using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Autodesk.DesignScript.Runtime;
using Dynamo.Graph.Nodes;
    
using MS = System;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Revit
{
    // ReSharper disable once InconsistentNaming
    public class dotnetSystem
    {
        private dotnetSystem() { }

        
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

    [IsVisibleInDynamoLibrary(false)]
    public static class EnumDescriptionExtension
    {
        public static string ToDescription(this MS.Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] desAttribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (desAttribute != null && desAttribute.Any())
            {
                return desAttribute.First().Description;
            }
            return string.Empty;
        }
    }

    [IsVisibleInDynamoLibrary(false)]
    public static class GeneralUtility
    {
        public static List<TResult> RevitIteratorConvertor<TSource, TResult>(TSource revitIterator)
        {
            return null;
        }
    }

}