using System.Collections.Generic;
using Autodesk.DesignScript.Runtime;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;
using Dynamo.Graph.Nodes;

// ReSharper disable MemberCanBePrivate.Global

namespace Spotlight.Element
{
    public class ParameterValueProvider
    {
        private ParameterValueProvider() { }

        [NodeCategory("Create")]
        public static ADDB.ParameterValueProvider CreateParameterValueProvider(ADDB.BuiltInParameter builtInParameter)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.ParameterValueProvider parameterValueProvider = new ADDB.ParameterValueProvider(elementId);
            return parameterValueProvider;
        }

        [MultiReturn(new[]{"double","elementId","integer","string" })]
        [NodeCategory("Query")]
        public static Dictionary<string, object> GetAllParameterValues(ADDB.BuiltInParameter builtInParameter, DYDB.Element dynamoElement)
        {
            Dictionary<string, object> output = new Dictionary<string, object>();

            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.ParameterValueProvider parameterValueProvider = new ADDB.ParameterValueProvider(elementId);
            ADDB.Element revitElement= dynamoElement.InternalElement;

            double? doubleValue = parameterValueProvider.IsDoubleValueSupported(revitElement)
                ? (double?)parameterValueProvider.GetDoubleValue(revitElement)
                : null;

            int? intValue = parameterValueProvider.IsIntegerValueSupported(revitElement)
                ? (int?)parameterValueProvider.GetIntegerValue(revitElement)
                : null;

            ADDB.ElementId idValue = parameterValueProvider.IsElementIdValueSupported(revitElement)
                ? parameterValueProvider.GetElementIdValue(revitElement)
                : ADDB.ElementId.InvalidElementId;
            string strValue = parameterValueProvider.IsStringValueSupported(revitElement)
                ? parameterValueProvider.GetStringValue(revitElement)
                : string.Empty;

            output.Add("double", doubleValue);
            output.Add("elementId", idValue);
            output.Add("integer", intValue);
            output.Add("string", strValue);
            
            parameterValueProvider.Dispose();

            return output;
        }
        
        [MultiReturn(new[]{"double","elementId","integer","string" })]
        [NodeCategory("Query")]
        public static Dictionary<string, object> IsValueSupported(ADDB.BuiltInParameter builtInParameter, DYDB.Element dynamoElement)
        {
            Dictionary<string, object> output = new Dictionary<string, object>();

            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.ParameterValueProvider parameterValueProvider = new ADDB.ParameterValueProvider(elementId);
            ADDB.Element revitElement= dynamoElement.InternalElement;
            
            output.Add("double", parameterValueProvider.IsDoubleValueSupported(revitElement));
            output.Add("elementId", parameterValueProvider.IsElementIdValueSupported(revitElement));
            output.Add("integer", parameterValueProvider.IsIntegerValueSupported(revitElement));
            output.Add("string", parameterValueProvider.IsStringValueSupported(revitElement));
            
            parameterValueProvider.Dispose();

            return output;
        }

        
    }
        
}