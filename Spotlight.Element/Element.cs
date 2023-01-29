using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class Element
    {
        private Element() { }


        public static ADDB.Parameter LookupParameter(ADDB.Element element, string parameterName)
        {
            return element.LookupParameter(parameterName);
        }
        
        [NodeCategory("Query")]
        public static bool CanBeHidden(ADDB.Element element, ADDB.View view)
        {
            return element.CanBeHidden(view);
        }

        [NodeCategory("Query")]
        public static bool CanBeLocked(ADDB.Element element)
        {
            return element.CanBeLocked();
        }

        [NodeCategory("Query")]
        public static bool CanDeleteSubelement(ADDB.Element element, ADDB.Subelement subElement)
        {
            return element.CanDeleteSubelement(subElement);
        }
        
        
    }
}