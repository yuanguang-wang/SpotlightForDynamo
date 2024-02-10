using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Filter
{
    public class ParameterFilterRule
    {
        private ParameterFilterRule() { }

        [NodeCategory("Create")]
        public static ADDB.FilterRule StringContainsFilterRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateContainsRule(elementId, value, caseSensitive);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule StringBeginsWithFilterRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateBeginsWithRule(elementId, value, caseSensitive);
            return filterRule;
        }
        
        [NodeCategory("Create")]
        public static ADDB.FilterRule StringEndsWithFilterRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateEndsWithRule(elementId, value, caseSensitive);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule StringEqualsFilterRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateEqualsRule(elementId, value, caseSensitive);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule IntegerEqualsFilterRule(ADDB.BuiltInParameter builtInParameter, int value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateEqualsRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule DoubleEqualsFilterRule(ADDB.BuiltInParameter builtInParameter, double value, double tolerance = 0.001)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateEqualsRule(elementId, value, tolerance);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule ElementIdEqualsFilterRule(ADDB.BuiltInParameter builtInParameter, ADDB.ElementId value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateEqualsRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule IntegerGreaterFilterRule(ADDB.BuiltInParameter builtInParameter, int value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule DoubleGreaterFilterRule(ADDB.BuiltInParameter builtInParameter, double value, double tolerance = 0.001)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterRule(elementId, value, tolerance);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule StringGreaterFilterRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterRule(elementId, value, caseSensitive);
            return filterRule;
        }
        
        [NodeCategory("Create")]
        public static ADDB.FilterRule ElementIdGreaterFilterRule(ADDB.BuiltInParameter builtInParameter, ADDB.ElementId value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule IntegerGreaterOrEqualFilterRule(ADDB.BuiltInParameter builtInParameter, int value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterOrEqualRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule IntegerGreaterOrEqualFilterRule(ADDB.BuiltInParameter builtInParameter, double value, double tolerance = 0.001)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterOrEqualRule(elementId, value, tolerance);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule StringGreaterOrEqualFilterRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterOrEqualRule(elementId, value, caseSensitive);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule ElementIdGreaterOrEqualFilterRule(ADDB.BuiltInParameter builtInParameter, ADDB.ElementId value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateGreaterOrEqualRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule IntegerLessFilterRule(ADDB.BuiltInParameter builtInParameter, int value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessRule(elementId, value);
            return filterRule;
        }
        
        [NodeCategory("Create")]
        public static ADDB.FilterRule DoubleLessFilterRule(ADDB.BuiltInParameter builtInParameter, double value, double tolerance = 0.001)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessRule(elementId, value, tolerance);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule StringLessFilterRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessRule(elementId, value, caseSensitive);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule ElementIdLessFilterRule(ADDB.BuiltInParameter builtInParameter, ADDB.ElementId value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessRule(elementId, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule IntegerLessOrEqualFilterRule(ADDB.BuiltInParameter builtInParameter, int value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessOrEqualRule(elementId, value);
            return filterRule;
        }
        
        [NodeCategory("Create")]
        public static ADDB.FilterRule DoubleLessOrEqualFilterRule(ADDB.BuiltInParameter builtInParameter, double value, double tolerance = 0.001)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessOrEqualRule(elementId, value, tolerance);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule StringLessOrEqualFilterRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessOrEqualRule(elementId, value, caseSensitive);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule ElementIdLessOrEqualFilterRule(ADDB.BuiltInParameter builtInParameter, ADDB.ElementId value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateLessOrEqualRule(elementId, value);
            return filterRule;
        }
       
        [NodeCategory("Create")]
        public static ADDB.FilterRule IntegerNotEqualsFilterRule(ADDB.BuiltInParameter builtInParameter, int value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateNotEqualsRule(elementId, value);
            return filterRule;
        }
        
        [NodeCategory("Create")]
        public static ADDB.FilterRule DoubleNotEqualsFilterRule(ADDB.BuiltInParameter builtInParameter, double value, double tolerance = 0.001)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateNotEqualsRule(elementId, value, tolerance);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule StringNotEqualsFilterRule(ADDB.BuiltInParameter builtInParameter, string value, bool caseSensitive)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateNotEqualsRule(elementId, value, caseSensitive);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule ElementIdNotEqualsFilterRule(ADDB.BuiltInParameter builtInParameter, ADDB.ElementId value)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateNotEqualsRule(elementId, value);
            return filterRule;
        } 
    }
}