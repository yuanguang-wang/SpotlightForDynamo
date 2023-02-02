using Revit.Elements;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;


namespace Spotlight.Cast
{
    public class ElementCast
    {
        private ElementCast() { }

        public static ADDB.ElementId Wall__to__Element(ADDB.Wall wall)
        {
            ADDB.ElementId element = wall.Id;
            return element;
        }
    }
}