﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapWinGIS;
using MWLite.Core;
using MWLite.Core.UI;
using MWLite.GUI.Classes;
using MWLite.ShapeEditor.Helpers;
using MWLite.ShapeEditor.Operations;

namespace MWLite.ShapeEditor
{
    internal class EditorDispatcher: CommandDispatcher<EditorCommand>
    {
        private void SetMapCursor(tkCursorMode mode)
        {
            App.Instance.Map.CursorMode = mode;
            App.Instance.RefreshUI();
        }
        
        public override void Run(EditorCommand command)
        {
            if (HandleGroupOperation(command)) return;

            if (HandleChangeTool(command)) return;

            if (HandleVertexEditor(command)) return;

            if (HandleSnappingAndHighlighting(command)) return;

            var map = App.Instance.Map;
            switch (command)
            {
                case EditorCommand.Undo:
                    map.Undo();
                    map.Redraw2(tkRedrawType.RedrawSkipDataLayers);
                    break;
                case EditorCommand.Redo:
                    map.UndoList.Redo();
                    map.Redraw2(tkRedrawType.RedrawSkipDataLayers);
                    break;
                case EditorCommand.EditLayer:
                    EditorHelper.ToggleEditLayer();
                    break;
                case EditorCommand.CreateLayer:
                    EditorHelper.CreateLayer();
                    break;
                case EditorCommand.ClearSelection:
                    App.Instance.RunCommand(AppCommand.ClearSelection);
                    break;
                case EditorCommand.Save:
                    if (!App.Map.ShapeEditor.SaveChanges())
                    {
                        MessageHelper.Info($"Failed to save.");
                    }
                    break;
            }
            
            App.Instance.RefreshUI();
        }

        public bool HandleSnappingAndHighlighting(EditorCommand command)
        {
            switch (command)
            {
                case EditorCommand.SnappingNone:
                    App.Map.ShapeEditor.SnapBehavior = tkLayerSelection.lsNoLayer;
                    break;
                case EditorCommand.SnappingCurrent:
                    App.Map.ShapeEditor.SnapBehavior = tkLayerSelection.lsActiveLayer;
                    break;
                case EditorCommand.SnappingAll:
                    App.Map.ShapeEditor.SnapBehavior = tkLayerSelection.lsAllLayers;
                    break;
                case EditorCommand.HighlightingNone:
                    App.Map.ShapeEditor.HighlightVertices = tkLayerSelection.lsNoLayer;
                    break;
                case EditorCommand.HighlightingCurrent:
                    App.Map.ShapeEditor.HighlightVertices = tkLayerSelection.lsActiveLayer;
                    break;
                case EditorCommand.HighlightingAll:
                    App.Map.ShapeEditor.HighlightVertices = tkLayerSelection.lsAllLayers;
                    break;
            }
            return false;
        }

        public bool HandleVertexEditor(EditorCommand command)
        {
            switch (command)
            {
                case EditorCommand.ClearEditor:
                    App.Map.ShapeEditor.Clear();
                    App.Map.Redraw2(tkRedrawType.RedrawSkipDataLayers);
                    return true;
                case EditorCommand.SaveShape:
                    App.Map.ShapeEditor.SaveChanges();
                    App.Map.Redraw2(tkRedrawType.RedrawSkipDataLayers);
                    return true;
                case EditorCommand.AddPart:
                    App.Map.ShapeEditor.StartOverlay(tkEditorOverlay.eoAddPart);
                    return true;
                case EditorCommand.RemovePart:
                    App.Map.ShapeEditor.StartOverlay(tkEditorOverlay.eoRemovePart);
                    return true;
                case EditorCommand.VertexEditor:
                    App.Map.ShapeEditor.EditorBehavior = tkEditorBehavior.ebVertexEditor;
                    App.Map.Redraw2(tkRedrawType.RedrawSkipDataLayers);
                    return true;
                case EditorCommand.PartEditor:
                    App.Map.ShapeEditor.EditorBehavior = tkEditorBehavior.ebPartEditor;
                    App.Map.Redraw2(tkRedrawType.RedrawSkipDataLayers);
                    return true;
            }
            return false;
        }

        public bool HandleChangeTool(EditorCommand command)
        {
            switch (command)
            {
                case EditorCommand.SelectByRectangle:
                    SetMapCursor(tkCursorMode.cmSelection);
                    return true;
                case EditorCommand.SplitByPolygon:
                    SetMapCursor(tkCursorMode.cmSplitByPolygon);
                    return true;
                case EditorCommand.EraseByPolygon:
                    SetMapCursor(tkCursorMode.cmEraseByPolygon);
                    return true;
                case EditorCommand.ClipByPolygon:
                    SetMapCursor(tkCursorMode.cmClipByPolygon);
                    return true;
                case EditorCommand.SplitByPolyline:
                    SetMapCursor(tkCursorMode.cmSplitByPolyline);
                    return true;
                case EditorCommand.RotateShapes:
                    SetMapCursor(tkCursorMode.cmRotateShapes);
                    return true;
                case EditorCommand.MoveShapes:
                    SetMapCursor(tkCursorMode.cmMoveShapes);
                    return true;
                
                case EditorCommand.AddShape:
                    SetMapCursor(tkCursorMode.cmAddShape);
                    return true;
                case EditorCommand.EditShape:
                    SetMapCursor(tkCursorMode.cmEditShape);
                    return true;
            }
            return false;
        }

        public bool HandleGroupOperation(EditorCommand command)
        {
            switch (command)
            {
                case EditorCommand.Copy:
                    OperationHelper.CopyShapes();
                    return true;
                case EditorCommand.Paste:
                    OperationHelper.PasteShapes();
                    return true;
                case EditorCommand.Cut:
                    OperationHelper.CutShapes();
                    return true;
                case EditorCommand.SplitShapes:
                    OperationHelper.ExplodeShapes();
                    return true;
                case EditorCommand.MergeShapes:
                    OperationHelper.MergeShapes();
                    return true;
                case EditorCommand.RemoveShapes:
                    OperationHelper.RemoveShapes();
                    return true;
            }
            return false;
        }

        protected override void CommandNotFound(ToolStripItem item)
        {
            MessageHelper.Info("No handle is found: " + item.Name);
        }
    }
}
