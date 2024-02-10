using System.Collections.Generic;
using System.Linq;
using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;


namespace Spotlight.Filter
{
    public class FilterRule
    {
        private FilterRule() { }

        [NodeCategory("Create")]
        public static ADDB.FilterRule FilterCategoryRule(IEnumerable<ADDB.BuiltInCategory> builtInCategories)
        {
            ICollection<ADDB.ElementId> elementIds = builtInCategories.Select(category => new ADDB.ElementId(category)).ToList();
            ADDB.FilterRule filterCategoryRule = new ADDB.FilterCategoryRule(elementIds);
            return filterCategoryRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule FilterDoubleRule(ADDB.BuiltInParameter builtInParameter, ADDB.FilterNumericRuleEvaluator numericRuleType, double value, double tolerance)
        {
            ADDB.FilterableValueProvider valueProvider = new ADDB.ParameterValueProvider( new ADDB.ElementId(builtInParameter));
            ADDB.FilterRule filterRule= new ADDB.FilterDoubleRule(valueProvider, numericRuleType, value, tolerance);
            return filterRule;
        }
       
        [NodeCategory("Create")]
        public static ADDB.FilterRule FilterIntegerRule(ADDB.BuiltInParameter builtInParameter, ADDB.FilterNumericRuleEvaluator numericRuleType, int value)
        {
            ADDB.FilterableValueProvider valueProvider = new ADDB.ParameterValueProvider( new ADDB.ElementId(builtInParameter));
            ADDB.FilterRule filterRule= new ADDB.FilterIntegerRule(valueProvider, numericRuleType, value);
            return filterRule;
        } 
              
        [NodeCategory("Create")]
        public static ADDB.FilterRule FilterElementIdRule(ADDB.BuiltInParameter builtInParameter, ADDB.FilterNumericRuleEvaluator numericRuleType, ADDB.ElementId value)
        {
            ADDB.FilterableValueProvider valueProvider = new ADDB.ParameterValueProvider( new ADDB.ElementId(builtInParameter));
            ADDB.FilterRule filterRule= new ADDB.FilterElementIdRule(valueProvider, numericRuleType, value);
            return filterRule;
        }  
                      
        [NodeCategory("Create")]
        public static ADDB.FilterRule FilterStringRule(ADDB.BuiltInParameter builtInParameter, ADDB.FilterStringRuleEvaluator stringRuleType, string value)
        {
            ADDB.FilterableValueProvider valueProvider = new ADDB.ParameterValueProvider( new ADDB.ElementId(builtInParameter));
            ADDB.FilterRule filterRule= new ADDB.FilterStringRule(valueProvider, stringRuleType, value);
            return filterRule;
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule FilterHasValueRule(ADDB.BuiltInParameter builtInParameter)
        {
            return new ADDB.HasValueFilterRule(new ADDB.ElementId(builtInParameter));
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule FilterHasNoValueRule(ADDB.BuiltInParameter builtInParameter)
        {
            return new ADDB.HasNoValueFilterRule(new ADDB.ElementId(builtInParameter));
        }

        [NodeCategory("Create")]
        public static ADDB.FilterRule FilterInvertRule(ADDB.FilterRule filterRule)
        {
            return new ADDB.FilterInverseRule(filterRule);
        }
    }

}