using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class Parameter
    {
        private Parameter() { }
        

        [NodeCategory("Actions")]
        public static ADDB.Element GetElement(ADDB.Parameter parameter)
        {
            return parameter.Element;
        }

        [NodeCategory("Query")]
        public static double AsDouble(ADDB.Parameter parameter)
        {
            return parameter.AsDouble();
        }

        [NodeCategory("Query")]
        public static int AsInteger(ADDB.Parameter parameter)
        {
            return parameter.AsInteger();
        }

        [NodeCategory("Query")]
        public static string AsString(ADDB.Parameter parameter)
        {
            return parameter.AsString();
        }

        [NodeCategory("Query")]
        public static string AsValueString(ADDB.Parameter parameter)
        {
            return parameter.AsValueString();
        }

        [NodeCategory("Actions")]
        public static void SetNewValue(ADDB.Parameter parameter, double newValue)
        {
            parameter.Set(newValue);
        }
        
        [NodeCategory("Actions")]
        public static void SetNewValue(ADDB.Parameter parameter, int newValue)
        {
            parameter.Set(newValue);
        }
        
        [NodeCategory("Actions")]
        public static void SetNewValue(ADDB.Parameter parameter, string newValue)
        {
            parameter.Set(newValue);
        }        
        
        [NodeCategory("Actions")]
        public static void SetValueString(ADDB.Parameter parameter, string newValueString)
        {
            parameter.SetValueString(newValueString);
        }    
    }
}