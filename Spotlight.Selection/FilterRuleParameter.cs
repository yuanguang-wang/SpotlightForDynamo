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

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateEqualsRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateEqualsRule(elementId, value, caseSensitive);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateEqualsRule(ADDB.BuiltInParameter builtInParameter, int value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateEqualsRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateEqualsRule(ADDB.BuiltInParameter builtInParameter, double value, double tolerance = 0.001)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateEqualsRule(elementId, value, tolerance);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateEqualsRule(ADDB.BuiltInParameter builtInParameter, ADDB.ElementId value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateEqualsRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateGreaterRule(ADDB.BuiltInParameter builtInParameter, int value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateGreaterRule(ADDB.BuiltInParameter builtInParameter, double value, double tolerance = 0.001)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterRule(elementId, value, tolerance);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateLessRule(ADDB.BuiltInParameter builtInParameter, int value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessRule(elementId, value);
            return filterRule;
        }

    }
}