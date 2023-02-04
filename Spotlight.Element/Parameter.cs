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

        [NodeCategory("Query")]
        public static int? AsValueInteger(ADDB.Parameter parameter)
        {
            string valueString = parameter.AsValueString();
            bool result = int.TryParse(valueString, out int valueInt);
            if (result)
            {
                return valueInt;
            }
            return null;
        }

        [NodeCategory("Query")]
        public static double? AsValueDouble(ADDB.Parameter parameter)
        {
            string valueString = parameter.AsValueString();
            bool result = double.TryParse(valueString, out double valueDouble);
            if (result)
            {
                return valueDouble;
            }
            return null;
        }

        public static void SetNewValue(double newValue, ADDB.Parameter parameter)
        {
            parameter.Set(newValue);
        }
        
        public static void SetNewValue(int newValue, ADDB.Parameter parameter)
        {
            parameter.Set(newValue);
        }
        
        public static void SetNewValue(string newValue, ADDB.Parameter parameter)
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