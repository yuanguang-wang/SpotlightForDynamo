using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.ElementType
{
    public class WallType
    {
        private WallType() { }

        [NodeCategory("Query")]
        public static double Width(ADDB.WallType wallType)
        {
            return wallType.Width;
        }

        [NodeCategory("Query")]
        public static ADDB.WallKind Kind(ADDB.WallType wallType)
        {
            return wallType.Kind;
        }

        [NodeCategory("Query")]
        public static ADDB.ThermalProperties ThermalProperty(ADDB.WallType wallType)
        {
            return wallType.ThermalProperties;
        }

        [NodeCategory("Query")]
        public static ADDB.WallFunction Function(ADDB.WallType wallType)
        {
            return wallType.Function;
        }
    }
}