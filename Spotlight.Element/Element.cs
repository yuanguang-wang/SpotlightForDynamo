using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class Element
    {
        private Element()
        {
        }

        [NodeCategory("Query")]
        public static ADDB.Parameter LookupParameter(DYDB.Element dynamoElement, string parameterName)
        {
            ADDB.Element element = dynamoElement.InternalElement;
            return element.LookupParameter(parameterName);
        }

        [NodeCategory("Query")]
        public static bool CanBeHidden(DYDB.Element dynamoElement, ADDB.View view)
        {
            ADDB.Element element = dynamoElement.InternalElement;
            return element.CanBeHidden(view);
        }

        [NodeCategory("Query")]
        public static bool CanBeLocked(DYDB.Element dynamoElement)
        {
            ADDB.Element element = dynamoElement.InternalElement;
            return element.CanBeLocked();
        }

        [NodeCategory("Query")]
        public static bool CanDeleteSubelement(DYDB.Element dynamoElement, ADDB.Subelement subElement)
        {
            ADDB.Element element = dynamoElement.InternalElement;
            return element.CanDeleteSubelement(subElement);
        }
    }
}