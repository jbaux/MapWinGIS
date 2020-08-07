using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapWinGIS;
using MWLite.Core.UI;

namespace MWLite.ShapeEditor.Operations
{
    public static class RemoveOperation
    {
        public static void Remove(AxMapWinGIS.AxMap map, Shapefile sf, int layerHandle)
        {
            var list = map.UndoList;
            bool beginSuccess = list.BeginBatch();
            Debug.Assert(beginSuccess);
            if (beginSuccess)
            {
                for (int i = sf.NumShapes - 1; i >= 0; i--)
                {
                    if (sf.ShapeSelected[i])
                    {
                        bool undoSuccess = list.Add(tkUndoOperation.uoRemoveShape, layerHandle, i);
                        Debug.Assert(undoSuccess);
                        bool editSuccess = sf.EditDeleteShape(i);
                        Debug.Assert(editSuccess);
                    }
                }
                list.EndBatch();
            }
        }
    }
}
