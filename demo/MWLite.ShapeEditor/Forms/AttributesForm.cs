﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MapWinGIS;
using MWLite.Core;
using MWLite.Core.UI;
using System.IO;

namespace MWLite.ShapeEditor.Forms
{
    public partial class AttributesForm : Form
    {
        private readonly Shapefile _sf;
        private readonly int _shapeIndex;
        private readonly int _layerHandle;

        public AttributesForm(Shapefile sf, int shapeIndex, int layerHandle)
        {
            _sf = sf;
            _shapeIndex = shapeIndex;
            _layerHandle = layerHandle;
            InitializeComponent();
            Populate();

            this.Shown += AttributesForm_Shown;
        }

        void AttributesForm_Shown(object sender, EventArgs e)
        {
            if (!_sf.InteractiveEditing)
            {
                btnOk.Focus();
            }
            else
            {
                var box = WinApi.GetFocusedControl() as TextBox;
                if (box != null)
                {
                    box.SelectAll();
                }
            }
        }

        private string OgrFidName
        {
            get
            {
                var layer = App.Map.get_OgrLayer(_layerHandle);
                if (layer == null) return "";
                return layer.FIDColumnName;
            }
        }

        private void Populate()
        {
            tableLayoutPanel1.SuspendLayout();

            bool editing = _sf.InteractiveEditing;

            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.AutoSize = true;
            
            tableLayoutPanel1.RowCount = _sf.NumFields;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            double maxRows = 15.0;
            int columCount = (int)Math.Ceiling(_sf.NumFields / maxRows);
            tableLayoutPanel1.ColumnCount = columCount*3;
            for (int n = 0; n < columCount; n++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            }
            
            int padding = editing ? 5 : 0;
            for (int i = 0; i < _sf.NumFields; i++)
            {
                int cmnIndex = (int)(Math.Floor(i / maxRows) * 3);
                int rowIndex = i % (int)maxRows;

                string name = _sf.Field[i].Name.ToUpper();
                var fieldType = _sf.Field[i].Type;

                var lbl = new System.Windows.Forms.Label() {Text = name};
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.AutoSize = true;
                lbl.Padding = new Padding(padding);
                lbl.BackColor = Color.White;
                tableLayoutPanel1.Controls.Add(lbl, cmnIndex, rowIndex);

                lbl = new System.Windows.Forms.Label() { Text = editing ? GetFieldTypeName(fieldType) : "" };
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.AutoSize = true;
                lbl.Padding = new Padding(0, padding, 0, padding);
                tableLayoutPanel1.Controls.Add(lbl, cmnIndex + 2, rowIndex);

                var value = _sf.CellValue[i, _shapeIndex] ?? GetDefaultValue(fieldType);
                var control = new TextBox() { ReadOnly = !editing,  Text = value.ToString() };
                control.Dock = DockStyle.Fill;
                control.Padding = new Padding(padding);
                control.Tag = i;
                tableLayoutPanel1.Controls.Add(control, cmnIndex + 1, rowIndex);

                control.Enabled = name.ToLower() != "mwshapeid" && name.ToLower() != OgrFidName.ToLower();
            }
            tableLayoutPanel1.ResumeLayout();
        }

        private object GetDefaultValue(FieldType type)
        {
            switch (type)
            {
                case FieldType.INTEGER_FIELD:
                    return 0;
                case FieldType.DOUBLE_FIELD:
                    return 0.0;
                case FieldType.STRING_FIELD:
                    return "";
                case FieldType.DATE_FIELD:
                    return "";
                case FieldType.BOOLEAN_FIELD:
                    return false;
                default:
                    Debug.Fail($"AttributesForm.GetDefaultValue: unknown field type: {type.ToString()}");
                    return "";
            }
        }

        private string GetFieldTypeName(FieldType type)
        {
            switch (type)
            {
                case FieldType.INTEGER_FIELD:
                    return "integer";
                case FieldType.DOUBLE_FIELD:
                    return "double (floating-point)";
                case FieldType.STRING_FIELD:
                    return "string";
                case FieldType.BOOLEAN_FIELD:
                    return "Boolean";
                case FieldType.DATE_FIELD:
                    return "date";
                default:
                    Debug.Fail($"AttributesForm.GetFieldTypeName: unknown field type: {type.ToString()}");
                    return "?";
            }
        }

        private bool Save()
        {
            var list = tableLayoutPanel1.Controls.OfType<TextBox>();
            foreach (var txt in list)
            {
                if (!txt.Enabled) continue;

                int fieldIndex = (int)txt.Tag;
                var fld = _sf.Field[fieldIndex];

                switch (fld.Type)
                {
                    case FieldType.STRING_FIELD:
                        {
                            _sf.EditCellValue(fieldIndex, _shapeIndex, txt.Text);
                            break;
                        }
                    case FieldType.INTEGER_FIELD:
                        {
                            int val;
                            if (!Int32.TryParse(txt.Text, out val))
                            {
                                txt.Focus();
                                MessageHelper.Info("Failed to parse integer value: " + txt.Text);
                                return false;
                            }
                            _sf.EditCellValue(fieldIndex, _shapeIndex, val);
                            break;
                        }
                    case FieldType.DOUBLE_FIELD:
                        {
                            double val;
                            if (!Double.TryParse(txt.Text, out val))
                            {
                                txt.Focus();
                                MessageHelper.Info("Failed to parse double value: " + txt.Text);
                                return false;
                            }
                            _sf.EditCellValue(fieldIndex, _shapeIndex, val);
                            break;
                        }
                    case FieldType.BOOLEAN_FIELD:
                        {
                            if (!Boolean.TryParse(txt.Text, out bool val))
                            {
                                txt.Focus();
                                MessageHelper.Info("Failed to parse Boolean value: " + txt.Text);
                                return false;
                            }
                            _sf.EditCellValue(fieldIndex, _shapeIndex, val);
                            break;
                        }
                    default:
                        Debug.Fail($"AttributesForm.Save: unknown field type: {fld.Type.ToString()}");
                        break;
                }
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Save())
                DialogResult = DialogResult.OK;
        }
    }
}
