using System.Collections.Generic;
using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;
using SP = Spotlight.Revit;

// ReSharper disable MemberCanBePrivate.Global

namespace Spotlight.Selection
{
    public class ElementFilter
    {
        private ElementFilter() { }

        [NodeCategory("Create")]
        public static ADDB.ElementClassFilter ElementClassFilter(System.Type classType, bool invert = false)
        {
            ADDB.ElementClassFilter filter = new ADDB.ElementClassFilter(classType, invert);
            return filter;
        }

        [NodeCategory("Create")]
        public static ADDB.ElementLevelFilter ElementLevelFilter(ADDB.ElementId levelId, bool invert = false)
        {
            ADDB.ElementLevelFilter filter = new ADDB.ElementLevelFilter(levelId, invert);
            return filter;
        }

        [NodeCategory("Create")]
        public static ADDB.ElementParameterFilter ElementParameterFilter(ADDB.FilterRule filterRule)
        {
            ADDB.ElementParameterFilter elementParameterFilter = new ADDB.ElementParameterFilter(filterRule);
            return elementParameterFilter;
        }

        [NodeCategory("Create")]
        public static ADDB.ElementParameterFilter ElementParameterFilter(IList<ADDB.FilterRule> filterRules)
        {
            ADDB.ElementParameterFilter elementParameterFilter = new ADDB.ElementParameterFilter(filterRules);
            return elementParameterFilter;
        }

        [NodeCategory("Create")]
        public static ADDB.ElementParameterFilter ElementParameterFilter(ADDB.FilterRule filterRule, bool inverted)
        {
            ADDB.ElementParameterFilter elementParameterFilter = new ADDB.ElementParameterFilter(filterRule, inverted);
            return elementParameterFilter; 
        }
    }
}