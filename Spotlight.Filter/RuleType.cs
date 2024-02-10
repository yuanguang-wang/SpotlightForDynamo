using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Filter

{
    public class RuleType
    {
        private RuleType() { }

        [NodeCategory("Create")]
        public static ADDB.FilterNumericRuleEvaluator NumericEqualsRule()
        {
            return new ADDB.FilterNumericEquals();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterNumericRuleEvaluator NumericGreaterRule()
        {
            return new ADDB.FilterNumericGreater();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterNumericRuleEvaluator NumericLessRule()
        {
            return new ADDB.FilterNumericLess();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterNumericRuleEvaluator NumericGreaterOrEqualRule()
        {
            return new ADDB.FilterNumericGreaterOrEqual();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterNumericRuleEvaluator NumericLessOrEqualRule()
        {
            return new ADDB.FilterNumericLessOrEqual();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterStringRuleEvaluator StringBeginsWithRule()
        {
            return new ADDB.FilterStringBeginsWith();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterStringRuleEvaluator StringEndsWithRule()
        {
            return new ADDB.FilterStringEndsWith();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterStringRuleEvaluator StringContainsRule()
        {
            return new ADDB.FilterStringContains();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterStringRuleEvaluator StringEqualsRule()
        {
            return new ADDB.FilterStringEquals();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterStringRuleEvaluator StringGreaterRule()
        {
            return new ADDB.FilterStringGreater();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterStringRuleEvaluator StringGreaterOrEqualRule()
        {
            return new ADDB.FilterStringGreaterOrEqual();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterStringRuleEvaluator StringLessRule()
        {
            return new ADDB.FilterStringLess();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterStringRuleEvaluator StringLessOrEqualRule()
        {
            return new ADDB.FilterStringLessOrEqual();
        }

        
    }
}