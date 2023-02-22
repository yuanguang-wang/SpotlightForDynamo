using System.Collections.Generic;
using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Selection
{
    public class FilterRuleParameter
    {
        private FilterRuleParameter() { }

        [NodeCategory("Create")]
        public static ADDB.FilterRule CreateContainsRule(ADDB.ElementId elementId, string value, bool caseSensitive)
        {
            ADDB.FilterRule filterRule = ADDB.ParameterFilterRuleFactory.CreateContainsRule(elementId, value, caseSensitive);
            return filterRule;
        }

    }
}