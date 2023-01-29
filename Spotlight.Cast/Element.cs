using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;


namespace Spotlight.Cast
{
    public class Element
    {
        private Element() { }

        public static ADDB.Element Wall__to__Element(ADDB.Wall wall)
        {
            ADDB.Element element = wall;
            return element;
        }
    }
}