using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class Wall
    {
        private Wall() { }
        
        public static ADDB.CurtainGrid CurtainGrid(ADDB.Wall Wall)
        {
            return Wall.CurtainGrid;
        }

        public static ADDB.LocationCurve LocationCurve(ADDB.Wall Wall)
        {
            ADDB.LocationCurve locationCurve = Wall.Location as ADDB.LocationCurve;
            return locationCurve;
        }
    }
}