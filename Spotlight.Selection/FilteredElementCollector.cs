using System.Collections.Generic;
using Autodesk.DesignScript.Runtime;
using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Selection
{
    public class FilteredElementCollector
    {
        private FilteredElementCollector() { }

        [NodeCategory("Create")]
        public static SpotlightElementCollector CreateByDoc(ADDB.Document doc)
        {
            ADDB.FilteredElementCollector filteredElementCollector = new ADDB.FilteredElementCollector(doc);
            SpotlightElementCollector spCollector = new SpotlightElementCollector(filteredElementCollector);
            return spCollector;
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
        public static SpotlightElementCollector OfClass(SpotlightElementCollector filteredElementCollector, System.Type type)
        {
            ADDB.FilteredElementCollector newCollector = filteredElementCollector.DbCollector.OfClass(type);
            SpotlightElementCollector newSpCollector = new SpotlightElementCollector(newCollector);
            return newSpCollector;
        }

        [NodeCategory("Actions")]
        public static ADDB.FilteredElementCollector OfCategory(ADDB.FilteredElementCollector filteredElementCollector, ADDB.BuiltInCategory category)
        {
            return filteredElementCollector.OfCategory(category);
        }

        [NodeCategory("Query")]
        public static ICollection<ADDB.ElementId> GetElementIds(SpotlightElementCollector spElementCollector)
        {
            return spElementCollector.DbCollector.ToElementIds();
        }
    }
    
    [IsVisibleInDynamoLibrary(false)]
    public class SpotlightElementCollector
    {
        public SpotlightElementCollector(ADDB.FilteredElementCollector filteredElementCollector)
        {
            DbCollector = filteredElementCollector;
        }
        public ADDB.FilteredElementCollector DbCollector { get; }
    }
}