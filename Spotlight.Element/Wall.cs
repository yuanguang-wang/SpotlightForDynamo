using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class Wall
    {
        private Wall() { }
        
        [NodeCategory("Actions")] 
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

        [NodeCategory("Actions")]
        public static void Flip(ADDB.Wall wall)
        {
            wall.Flip();
        }
        
    }
}