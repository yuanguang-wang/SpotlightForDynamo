using System.Collections.Generic;
using System.Linq;
using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;


namespace Spotlight.Selection
{
    public class FilterRule
    {
        private FilterRule() { }

        [NodeCategory("Create")]
        public static ADDB.FilterCategoryRule FilterCategoryRule(IEnumerable<ADDB.BuiltInCategory> builtInCategories)
        {
            ICollection<ADDB.ElementId> elementIds = builtInCategories.Select(category => new ADDB.ElementId(category)).ToList();
            ADDB.FilterCategoryRule filterCategoryRule = new ADDB.FilterCategoryRule(elementIds);
            return filterCategoryRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule FilterDoubleRule(ADDB.FilterableValueProvider valueProvider,
            ADDB.FilterNumericRuleEvaluator filterNumericRuleEvaluator, double ruleValue, double tolerance)
        {
            ADDB.FilterRule filterRule= new ADDB.FilterDoubleRule(valueProvider, filterNumericRuleEvaluator, ruleValue, tolerance);
            return filterRule;
        }
        
        
    }

}