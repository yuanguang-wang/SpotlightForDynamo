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

        /// <summary>
        /// Get the Location Class as Location Curve for DB.Wall
        /// </summary>
        /// <param name="wall">DB.Wall</param>
        /// <returns name="locationCurve">Location Curve of the wall</returns>
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
    }
}