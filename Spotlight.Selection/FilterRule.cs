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
        public static ADDB.FilterCategoryRule CreateFilterCategoryRule(ICollection<ADDB.ElementId> elementIds)
        {
            ADDB.FilterCategoryRule filterCategoryRule = new ADDB.FilterCategoryRule(elementIds);
            return filterCategoryRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterCategoryRule CreateFilterCategoryRule(IEnumerable<ADDB.BuiltInCategory> builtInCategories)
        {
            ICollection<ADDB.ElementId> elementIds = builtInCategories.Select(category => new ADDB.ElementId(category)).ToList();
            ADDB.FilterCategoryRule filterCategoryRule = new ADDB.FilterCategoryRule(elementIds);
            return filterCategoryRule;
        }

        [NodeCategory("Query")]
        public static ICollection<ADDB.ElementId> GetCategories(ADDB.FilterCategoryRule filterCategoryRule)
        {
            return filterCategoryRule.GetCategories();
        }

        [NodeCategory("Actions")]
        public static bool SetCategories(ADDB.FilterCategoryRule filterCategoryRule, ICollection<ADDB.ElementId> elementIds)
        {
            return filterCategoryRule.SetCategories(elementIds);
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateFilterDoubleRule(ADDB.FilterableValueProvider valueProvider,
            ADDB.FilterNumericRuleEvaluator filterNumericRuleEvaluator, double ruleValue, double tolerance)
        {
            ADDB.FilterRule filterRule= new ADDB.FilterDoubleRule(valueProvider, filterNumericRuleEvaluator, ruleValue, tolerance);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateFilterDoubleRule(ADDB.ParameterValueProvider valueProvider,
            ADDB.FilterNumericRuleEvaluator filterNumericRuleEvaluator, double ruleValue, double tolerance)
        {
            ADDB.FilterRule filterRule= new ADDB.FilterDoubleRule(valueProvider, filterNumericRuleEvaluator, ruleValue, tolerance);
            return filterRule;
        }
    }
}