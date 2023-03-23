using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Selection

{
    public class RuleType
    {
        private RuleType() { }

        [NodeCategory("Create")]
        public static ADDB.FilterNumericEquals NumericEqualsRule()
        {
            return new ADDB.FilterNumericEquals();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterNumericGreater NumericGreaterRule()
        {
            return new ADDB.FilterNumericGreater();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterNumericLess NumericLessRule()
        {
            return new ADDB.FilterNumericLess();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterNumericGreaterOrEqual NumericGreaterOrEqualRule()
        {
            return new ADDB.FilterNumericGreaterOrEqual();
        }

        [NodeCategory("Create")]
        public static ADDB.FilterNumericLessOrEqual NumericLessOrEqualRule()
        {
            return new ADDB.FilterNumericLessOrEqual();
        }

    }
}