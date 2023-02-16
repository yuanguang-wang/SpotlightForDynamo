using Autodesk.DesignScript.Runtime;
using Dynamo.Graph.Nodes;
    
using MS = System;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Revit
{
    public class System
    {
        private System() { }

        [NodeCategory("Query")]
        // ReSharper disable once InconsistentNaming
        public static MS.Type GetDBClassType(string className)
        {
            string concatName = "Autodesk.Revit.DB." + className + ", " + "RevitApi";
            return MS.Type.GetType(concatName);
        }

        [NodeCategory("Query")]
        public static MS.Type GetOtherClassType(string nameSpace, string className, string assemblyName)
        {
            string concatName = nameSpace + "." + className + ", " + assemblyName;
            return MS.Type.GetType(concatName);
        }
    }
    
    [IsVisibleInDynamoLibrary(false)]
    public class FilteredElementCollector
    {
        public FilteredElementCollector(ADDB.FilteredElementCollector filteredElementCollector)
        {
            DbCollector = filteredElementCollector;
        }

        public ADDB.FilteredElementCollector DbCollector { get; }
    }

    [IsVisibleInDynamoLibrary(false)]
    public class ElementFilter
    {
        public ADDB.ElementFilter DbElementFilter { get; }

        public ElementFilter(ADDB.ElementFilter elementFilter)
        {
            DbElementFilter = elementFilter;
        }
    }
}