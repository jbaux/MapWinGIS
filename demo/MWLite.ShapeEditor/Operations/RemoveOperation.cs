using System;
using System.Collections.Generic;
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
            list.BeginBatch();
            for (int i = sf.NumShapes - 1; i >= 0; i--)
            {
                if (sf.ShapeSelected[i])
                {
                    list.Add(tkUndoOperation.uoRemoveShape, layerHandle , i);
                    sf.EditDeleteShape(i);
                }
            }
            list.EndBatch();
        }
    }
}
