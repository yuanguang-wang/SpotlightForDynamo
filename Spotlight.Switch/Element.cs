using DYDG = Autodesk.DesignScript.Geometry;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Switch
{
    public class Element
    {
        private Element() { }

        public static ADDB.Wall DynamoWallToRevitWall(DYDB.Wall Wall)
        {
            return Wall.InternalElement as ADDB.Wall;
        }
    }
}