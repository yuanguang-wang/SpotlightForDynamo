using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class Wall
    {
        private Wall() { }
        public static ADDB.CurtainGrid CurtainGrid(DYDB.Wall wall)
        {
            ADDB.Wall addbWall = wall.InternalElement as ADDB.Wall;
            return addbWall.CurtainGrid;
        }
    }
}