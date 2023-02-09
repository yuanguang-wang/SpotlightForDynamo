using System;
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

        [NodeCategory("Actions")]
        public static ADDB.FilteredElementCollector OfClass(ADDB.FilteredElementCollector filteredElementCollector, Type systemType)
        {
            return filteredElementCollector.OfClass(systemType);
        }

        [NodeCategory("Query")]
        public static ICollection<ADDB.ElementId> ToElementIds(ADDB.FilteredElementCollector filteredElementCollector)
        {
            return filteredElementCollector.ToElementIds();
        }
    }
}