﻿using AxMapWinGIS;
using MapWinGIS;
using MWLite.ShapeEditor.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MWLite.ShapeEditor
{
    static class MapEventHandlers
    {
        static AxMap _map = null;

        public static void Init(AxMap map)
        {
            _map = map;

            _map.ChooseLayer += _map_ChooseLayer;
            _map.MouseUpEvent += _map_MouseUpEvent;
            _map.UndoListChanged += _map_UndoListChanged;
            _map.AfterShapeEdit += _map_AfterShapeEdit;
            _map.BeforeDeleteShape += _map_BeforeDeleteShape;
            _map.BeforeShapeEdit += _map_BeforeShapeEdit;
            _map.ShapeValidationFailed += _map_ShapeValidationFailed;
            _map.ValidateShape += _map_ValidateShape;
            _map.DblClick += _map_DblClick;
        }

        private static void _map_DblClick(object sender, EventArgs e)
        {
            tkCursorMode cm = _map.CursorMode;
            if (cm == tkCursorMode.cmAddShape)
            {
                _map.ShapeEditor.SaveChanges();
            }
        }

        static void _map_ChooseLayer(object sender, _DMapEvents_ChooseLayerEvent e)
        {
            e.layerHandle = App.Instance.Legend.SelectedLayer;
        }

        static void _map_BeforeDeleteShape(object sender, _DMapEvents_BeforeDeleteShapeEvent e)
        {
            string s = string.Empty;
            switch (e.target)
            {
                case tkDeleteTarget.dtShape: s = "shape";
                    break;
                case tkDeleteTarget.dtPart: s = "part";
                    break;
                case tkDeleteTarget.dtVertex: s = "vertex";
                    break;
            }

            s = string.Format("Do you want to delete {0}?", s);
            var result = MessageBox.Show(s, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.cancel = result == DialogResult.No ? tkMwBoolean.blnTrue : tkMwBoolean.blnFalse;
        }

        static void _map_AfterShapeEdit(object sender, _DMapEvents_AfterShapeEditEvent e)
        {
            if (e.operation == tkUndoOperation.uoAddShape)
            {
                var sf = _map.get_Shapefile(e.layerHandle);
                if (sf != null)
                {
                    using (var form = new AttributesForm(sf, e.shapeIndex, e.layerHandle))
                    {
                        form.ShowDialog(App.MainForm);
                    }
                }
            }
            else
            {
                Debug.WriteLine("After shape edit: " + e.operation);
            }
        }

        static void _map_BeforeShapeEdit(object sender, _DMapEvents_BeforeShapeEditEvent e)
        {
            // to prevent editing of particular shapes
            //var sf = App.Map.get_Shapefile(e.layerHandle);
            //if (sf != null)
            //{
            //    if (sf.ShapefileType2D == ShpfileType.SHP_POLYLINE)
            //    {
            //        MessageHelper.Info("Editing of polylines isn't allowed");
            //        e.cancel = tkMwBoolean.blnTrue;
            //    }
            //}
        }

        static void _map_ValidateShape(object sender, _DMapEvents_ValidateShapeEvent e)
        {
            Debug.Print("Custom validation");
        }

        static void _map_ShapeValidationFailed(object sender, _DMapEvents_ShapeValidationFailedEvent e)
        {
            MessageBox.Show("Validation failed: " + e.errorMessage);
        }

        static void _map_MouseUpEvent(object sender, _DMapEvents_MouseUpEvent e)
        {
            if (e.button == 2)
            {
                switch (_map.CursorMode)
                {
                    case tkCursorMode.cmRotateShapes:
                    case tkCursorMode.cmMoveShapes:
                    case tkCursorMode.cmSelection:
                    {
                        var menu = App.SelectionContextMenu;
                        menu.Show(_map, e.x, e.y);
                        break;
                    }
                    case tkCursorMode.cmEditShape:
                    case tkCursorMode.cmAddShape:
                    case tkCursorMode.cmClipByPolygon:
                    case tkCursorMode.cmEraseByPolygon:
                    case tkCursorMode.cmSplitByPolygon:
                    case tkCursorMode.cmSplitByPolyline:
                    case tkCursorMode.cmSelectByPolygon:
                    {
                        var menu = App.VertexContextMenu;
                        menu.Show(_map, e.x, e.y);
                        break;
                    }
                    //{
                    //    var menu = App.DigitizingContextMenu;
                    //    menu.Show(_map, e.x, e.y);
                    //    break;
                    //}
                }
            }
        }

        private static void _map_UndoListChanged(object sender, EventArgs e)
        {
            App.Instance.RefreshUI();
        }
    }
}
