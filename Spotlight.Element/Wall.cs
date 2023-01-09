using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class Wall
    {
        private Wall() { }
        
        public static ADDB.CurtainGrid CurtainGrid(ADDB.Wall wall)
        {
            return wall.CurtainGrid;
        }

        [NodeCategory("Actions")]
        public static ADDB.LocationCurve LocationCurve(ADDB.Wall wall)
        {
            ADDB.LocationCurve locationCurve = wall.Location as ADDB.LocationCurve;
            return locationCurve;
        }

        [NodeCategory("Query")]
        public static bool CanBeHidden(ADDB.Wall wall, ADDB.View view)
        {
            return wall.CanBeHidden(view);
        }

        [NodeCategory("Query")]
        public static bool CanBeLocked(ADDB.Wall wall)
        {
            return wall.CanBeLocked();
        }
        
    }
}