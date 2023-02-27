using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Selection
{
    public class ParameterFilterRule
    {
        private ParameterFilterRule() { }

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
        public static ADDB.FilterRule CreateGreaterRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterRule(elementId, value, caseSensitive);
            return filterRule;
        }
        
        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateGreaterRule(ADDB.BuiltInParameter builtInParameter, ADDB.ElementId value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateGreaterOrEqualRule(ADDB.BuiltInParameter builtInParameter, int value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterOrEqualRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateGreaterOrEqualRule(ADDB.BuiltInParameter builtInParameter, double value, double tolerance = 0.001)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterOrEqualRule(elementId, value, tolerance);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateGreaterOrEqualRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterOrEqualRule(elementId, value, caseSensitive);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateGreaterOrEqualRule(ADDB.BuiltInParameter builtInParameter, ADDB.ElementId value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterOrEqualRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateLessRule(ADDB.BuiltInParameter builtInParameter, int value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessRule(elementId, value);
            return filterRule;
        }
        
        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateLessRule(ADDB.BuiltInParameter builtInParameter, double value, double tolerance = 0.001)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessRule(elementId, value, tolerance);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateLessRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessRule(elementId, value, caseSensitive);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateLessRule(ADDB.BuiltInParameter builtInParameter, ADDB.ElementId value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateLessOrEqualRule(ADDB.BuiltInParameter builtInParameter, int value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessOrEqualRule(elementId, value);
            return filterRule;
        }
        
        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateLessOrEqualRule(ADDB.BuiltInParameter builtInParameter, double value, double tolerance = 0.001)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessOrEqualRule(elementId, value, tolerance);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateLessOrEqualRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessOrEqualRule(elementId, value, caseSensitive);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateLessOrEqualRule(ADDB.BuiltInParameter builtInParameter, ADDB.ElementId value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessOrEqualRule(elementId, value);
            return filterRule;
        }
       
        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateNotEqualsRule(ADDB.BuiltInParameter builtInParameter, int value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateNotEqualsRule(elementId, value);
            return filterRule;
        }
        
        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateNotEqualsRule(ADDB.BuiltInParameter builtInParameter, double value, double tolerance = 0.001)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateNotEqualsRule(elementId, value, tolerance);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateNotEqualsRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateNotEqualsRule(elementId, value, caseSensitive);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateNotEqualsRule(ADDB.BuiltInParameter builtInParameter, ADDB.ElementId value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateNotEqualsRule(elementId, value);
            return filterRule;
        } 
    }
}