using System.Collections.Generic;
using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Selection
{
    public class FilteredElementCollector
    {
        private FilteredElementCollector() { }

        [NodeCategory("Create")]
        public static ADDB.FilteredElementCollector CreateByDoc(ADDB.Document doc)
        {
            ADDB.FilteredElementCollector filteredElementCollector = new ADDB.FilteredElementCollector(doc);
            return filteredElementCollector;
        }

        [NodeCategory("Create")]
        public static ADDB.FilteredElementCollector CreateByView(ADDB.Document doc, ADDB.ElementId viewId)
        {
            ADDB.FilteredElementCollector filteredElementCollector = new ADDB.FilteredElementCollector(doc, viewId);
            return filteredElementCollector;
        }

        [NodeCategory("Create")]
        public static ADDB.FilteredElementCollector CreateByElementIds(ADDB.Document doc, ICollection<ADDB.ElementId> elementIds)
        {
            ADDB.FilteredElementCollector filteredElementCollector = new ADDB.FilteredElementCollector(doc, elementIds);
            return filteredElementCollector;
        }

        [NodeCategory("Query")]
        public static ICollection<ADDB.ElementId> QueryElementIdByCategory(ADDB.Document doc, ADDB.BuiltInCategory category, bool typeFilter = false)
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
        public static ICollection<ADDB.ElementId> QueryElementIdByClass(ADDB.Document doc, System.Type classType, bool typeFilter = false)
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
        public static ADDB.FilteredElementCollector LogicAnd(ADDB.FilteredElementCollector filteredElementCollector_1, ADDB.FilteredElementCollector filteredElementCollector_2)
        {
            return filteredElementCollector_1.IntersectWith(filteredElementCollector_2);
        }
        
        [NodeCategory("Actions")]
        public static ADDB.FilteredElementCollector LogicOr(ADDB.FilteredElementCollector filteredElementCollector_1, ADDB.FilteredElementCollector filteredElementCollector_2)
        {
            return filteredElementCollector_1.UnionWith(filteredElementCollector_2);
        }

        [NodeCategory("Actions")]
        public static ADDB.FilteredElementCollector OfClass(ADDB.FilteredElementCollector filteredElementCollector, System.Type type)
        {
            return filteredElementCollector.OfClass(type);
        }

        [NodeCategory("Actions")]
        public static ADDB.FilteredElementCollector OfCategory(ADDB.FilteredElementCollector filteredElementCollector, ADDB.BuiltInCategory category)
        {
            return filteredElementCollector.OfCategory(category);
        }
    }
}