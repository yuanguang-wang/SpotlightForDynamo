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
        public static ICollection<ADDB.ElementId> QueryByCategory(ADDB.Document doc, ADDB.BuiltInCategory category, bool typeFilter = false)
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
        public static ICollection<ADDB.ElementId> QueryByClass(ADDB.Document doc, System.Type classType, bool typeFilter = false)
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
    }
}