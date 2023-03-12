using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Element
{
    public class Xyz
    {
        private Xyz() { }

        [NodeCategory("Create")]
        public static ADDB.XYZ CreateByDouble (double x = 0, double y = 0, double z = 0)
        {
            ADDB.XYZ xyzObj = new ADDB.XYZ(x, y, z);
            return xyzObj;
        }

        [NodeCategory("Create")]
        public static ADDB.XYZ CreateByZero()
        {
            ADDB.XYZ xyzObj = new ADDB.XYZ();
            return xyzObj;
        }
        
        
    }
}