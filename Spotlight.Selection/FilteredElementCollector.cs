using System.Collections.Generic;
using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;
using SP = Spotlight.Revit;

// ReSharper disable InconsistentNaming

namespace Spotlight.Selection
{
    public class FilteredElementCollector
    {
        private FilteredElementCollector() { }

        [NodeCategory("Create")]
        public static SP.FilteredElementCollector CreateByDoc(ADDB.Document doc)
        {
            ADDB.FilteredElementCollector filteredElementCollector = new ADDB.FilteredElementCollector(doc);
            SP.FilteredElementCollector spCollector = new SP.FilteredElementCollector(filteredElementCollector);
            return spCollector;
        }

        [NodeCategory("Create")]
        public static SP.FilteredElementCollector CreateByView(ADDB.Document doc, ADDB.ElementId viewId)
        {
            ADDB.FilteredElementCollector filteredElementCollector = new ADDB.FilteredElementCollector(doc, viewId);
            SP.FilteredElementCollector spCollector = new SP.FilteredElementCollector(filteredElementCollector);
            return spCollector;
        }

        [NodeCategory("Create")]
        public static SP.FilteredElementCollector CreateByElementIds(ADDB.Document doc, ICollection<ADDB.ElementId> elementIds)
        {
            ADDB.FilteredElementCollector filteredElementCollector = new ADDB.FilteredElementCollector(doc, elementIds);
            SP.FilteredElementCollector spCollector = new SP.FilteredElementCollector(filteredElementCollector);
            return spCollector;
        }

        [NodeCategory("Query")]
        public static ICollection<ADDB.ElementId> GetElementIdByCategory(ADDB.Document doc, ADDB.BuiltInCategory category, bool typeFilter = false)
        {
            ADDB.FilteredElementCollector filteredElementCollector = new ADDB.FilteredElementCollector(doc).OfCategory(category);
            
            if (typeFilter)
            {
                filteredElementCollector.WhereElementIsElementType();
            }
            else
            {
                filteredElementCollector.WhereElementIsNotElementType();
            }
            
            return filteredElementCollector.ToElementIds();
        }

        [NodeCategory("Query")]
        public static ICollection<ADDB.ElementId> GetElementIdByClass(ADDB.Document doc, System.Type classType, bool typeFilter = false)
        {
            ADDB.FilteredElementCollector filteredElementCollector = new ADDB.FilteredElementCollector(doc).OfClass(classType);
            
            if (typeFilter)
            {
                filteredElementCollector.WhereElementIsElementType();
            }
            else
            {
                filteredElementCollector.WhereElementIsNotElementType();
            }
            
            return filteredElementCollector.ToElementIds(); 
        }

        [NodeCategory("Actions")]
        public static SP.FilteredElementCollector LogicAnd(SP.FilteredElementCollector filteredElementCollector_1, SP.FilteredElementCollector filteredElementCollector_2)
        {
            ADDB.FilteredElementCollector newCollector = filteredElementCollector_1.DbCollector.IntersectWith(filteredElementCollector_2.DbCollector);
            SP.FilteredElementCollector newSpCollector = new SP.FilteredElementCollector(newCollector);
            return newSpCollector;
        }
        
        [NodeCategory("Actions")]
        public static SP.FilteredElementCollector LogicOr(SP.FilteredElementCollector filteredElementCollector_1, SP.FilteredElementCollector filteredElementCollector_2)
        {
            ADDB.FilteredElementCollector newCollector = filteredElementCollector_1.DbCollector.UnionWith(filteredElementCollector_2.DbCollector);
            SP.FilteredElementCollector newSpCollector = new SP.FilteredElementCollector(newCollector);
            return newSpCollector;
        }

        [NodeCategory("Actions")]
        public static SP.FilteredElementCollector OfClass(SP.FilteredElementCollector filteredElementCollector, System.Type type)
        {
            ADDB.FilteredElementCollector newCollector = filteredElementCollector.DbCollector.OfClass(type);
            SP.FilteredElementCollector newSpCollector = new SP.FilteredElementCollector(newCollector);
            return newSpCollector;
        }

        [NodeCategory("Actions")]
        public static SP.FilteredElementCollector OfCategory(SP.FilteredElementCollector filteredElementCollector, ADDB.BuiltInCategory category)
        {
            ADDB.FilteredElementCollector newCollector = filteredElementCollector.DbCollector.OfCategory(category);
            SP.FilteredElementCollector newSpCollector = new SP.FilteredElementCollector(newCollector);
            return newSpCollector;
        }

        [NodeCategory("Query")]
        public static ICollection<ADDB.ElementId> GetElementIds(SP.FilteredElementCollector filteredElementCollector)
        {
            return filteredElementCollector.DbCollector.ToElementIds();
        }

        [NodeCategory("Query")]
        public static ICollection<ADDB.Element> GetElements(SP.FilteredElementCollector filteredElementCollector)
        {
            return filteredElementCollector.DbCollector.ToElements();
        }

        [NodeCategory("Query")]
        public static int Count(SP.FilteredElementCollector filteredElementCollector)
        {
            return filteredElementCollector.DbCollector.GetElementCount();
        }

        [NodeCategory("Actions")]
        public static SP.FilteredElementCollector RemoveElement(SP.FilteredElementCollector filteredElementCollector, ICollection<ADDB.ElementId> elementIds)
        {
            ADDB.FilteredElementCollector newCollector = filteredElementCollector.DbCollector.Excluding(elementIds);
            SP.FilteredElementCollector newSpCollector = new SP.FilteredElementCollector(newCollector);
            return newSpCollector;
        }

        [NodeCategory("Actions")]
        public static SP.FilteredElementCollector WherePasses(SP.FilteredElementCollector filteredElementCollector, SP.ElementFilter elementFilter)
        {
            ADDB.FilteredElementCollector newFilter = filteredElementCollector.DbCollector.WherePasses(elementFilter.DbElementFilter);
            SP.FilteredElementCollector newSpFilter = new SP.FilteredElementCollector(newFilter);
            return newSpFilter;
        }
    }
    

}