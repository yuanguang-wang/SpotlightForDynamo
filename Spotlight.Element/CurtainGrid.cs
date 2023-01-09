using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class CurtainGrid
    {
        private CurtainGrid() { }

        public static void AddGridLine(ADDB.CurtainGrid curtainGrid, bool isUGridLine, ADDB.XYZ xyz, bool oneSegmentOnly)
        {
            curtainGrid.AddGridLine(isUGridLine, xyz, oneSegmentOnly);
        }
    }
}