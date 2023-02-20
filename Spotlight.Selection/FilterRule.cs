using System.Collections.Generic;
using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Selection
{
    public class FilterRule
    {
        private FilterRule() { }

        [NodeCategory("Create")]
        public static ADDB.FilterCategoryRule FilterCategoryRule(ICollection<ADDB.ElementId> elementIds)
        {
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

    }
}