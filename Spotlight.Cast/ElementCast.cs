
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;


namespace Spotlight.Cast
{
    public class ElementCast
    {
        private ElementCast() { }

        ///////////////////////////////
        #region GetElementId Overloads

        public static ADDB.ElementId GetElementId(ADDB.Wall element)
        {
            return element.Id;
        }

        public static ADDB.ElementId GetElementId(ADDB.Mullion element)
        {
            return element.Id;
        }
        
        #endregion
        ///////////////////////////////

        
    }
}