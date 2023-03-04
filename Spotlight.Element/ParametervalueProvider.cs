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
        public static Dictionary<string, object> GetParameterValue(ADDB.BuiltInParameter builtInParameter, DYDB.Element dynamoElement)
        {
            Dictionary<string, object> output = new Dictionary<string, object>();

            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.ParameterValueProvider parameterValueProvider = new ADDB.ParameterValueProvider(elementId);
            ADDB.Element revitElement= dynamoElement.InternalElement;
            
            output.Add("double", parameterValueProvider.GetDoubleValue(revitElement));
            output.Add("elementId", parameterValueProvider.GetElementIdValue(revitElement));
            output.Add("integer", parameterValueProvider.GetIntegerValue(revitElement));
            output.Add("string", parameterValueProvider.GetStringValue(revitElement));
            
            parameterValueProvider.Dispose();

            return output;
        }
        
        [MultiReturn(new[]{"double","elementId","integer","string" })]
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