using System.Collections.Generic;
using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Selection
{
    public class FilterRuleParameter
    {
        private FilterRuleParameter() { }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateContainsRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateContainsRule(elementId, value, caseSensitive);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateBeginsWithRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateBeginsWithRule(elementId, value, caseSensitive);
            return filterRule;
        }
        
        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateEndsWithRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateEndsWithRule(elementId, value, caseSensitive);
            return filterRule;
        } 
        
        
    }
}