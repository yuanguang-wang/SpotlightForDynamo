using Dynamo.Graph.Nodes;
using RevitServices.Persistence;

using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class ElementId
    {
        private ElementId() { }

        private static ADDB.Document CurrentDoc => DocumentManager.Instance.CurrentDBDocument;

        [NodeCategory("Create")]
        public static ADDB.ElementId CreateByBuiltInCategory(ADDB.BuiltInCategory builtInCategory)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInCategory);
            return elementId;
        }

        [NodeCategory("Create")]
        public static ADDB.ElementId CreateByInteger(int integer)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(integer);
            return elementId;
        }

        [NodeCategory("Create")]
        public static ADDB.ElementId CreateByBuiltInParameter(ADDB.BuiltInParameter builtInParameter)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            return elementId;
        }

        [NodeCategory("Query")]
        public static ADDB.Parameter LookupParameter(ADDB.ElementId elementId, string parameterName)
        {
            ADDB.Element element = CurrentDoc.GetElement(elementId);
            return element.LookupParameter(parameterName);
        }

        [NodeCategory("Query")]
        public static System.Type GetClassType(ADDB.ElementId elementId)
        {
            return elementId.GetType();
        }


    }
}