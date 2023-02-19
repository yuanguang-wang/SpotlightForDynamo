using Dynamo.Graph.Nodes;
using RevitServices.Persistence;

using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class DynamoElement
    {
        private DynamoElement() { }

        private static ADDB.Document CurrentDoc => DocumentManager.Instance.CurrentDBDocument;

        [NodeCategory("Query")]
        public static ADDB.Parameter LookupParameter(DYDB.Element dynamoElement, string parameterName)
        {
            return dynamoElement.InternalElement.LookupParameter(parameterName);
        }

        [NodeCategory("Query")]
        public static bool CanBeHidden(ADDB.ElementId elementId, ADDB.View view)
        {
            ADDB.Element element = CurrentDoc.GetElement(elementId);
            return element.CanBeHidden(view);
        }

        [NodeCategory("Query")]
        public static bool CanBeLocked(ADDB.ElementId elementId)
        {
            ADDB.Element element = CurrentDoc.GetElement(elementId);
            return element.CanBeLocked();
        }

        [NodeCategory("Query")]
        public static bool CanDeleteSubelement(ADDB.ElementId elementId, ADDB.Subelement subElement)
        {
            ADDB.Element element = CurrentDoc.GetElement(elementId);
            return element.CanDeleteSubelement(subElement);
        }

        [NodeCategory("Query")]
        public static System.Type GetClassType(ADDB.ElementId elementId)
        {
            return elementId.GetType();
        }


    }
}