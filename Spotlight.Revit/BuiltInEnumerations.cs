using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autodesk.DesignScript.Runtime;
using MS = System;
using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Revit
{
    public class BuiltInEnumerations
    {
        private BuiltInEnumerations() { }

        [NodeCategory("Query")]
        public static List<MS.Type> GetAllEnumsTypes()
        {
            Assembly api = MS.AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(x => x.GetName().Name.Contains("RevitAPI"));
            
            // ReSharper disable once PossibleNullReferenceException
            return (api.GetTypes().Where(t => t.IsEnum)).ToList();
        }
        
        [IsVisibleInDynamoLibrary(false)]
        private static List<T> GetByKeyword<T>(string keyword)
        {
            List<T> enumTypeList = MS.Enum.GetValues(typeof(T)).Cast<T>().ToList();
            List<string> enumNameList = MS.Enum.GetNames(typeof(T)).ToList();

            Dictionary<string, T> enumDic = new Dictionary<string, T>();

            int i = 0;
            foreach (string name in enumNameList)
            {
                enumDic.Add(name,enumTypeList[i]);
                i++;
            }

            return keyword == "" ? enumTypeList : (from pair in enumDic where pair.Key.Contains(keyword) select pair.Value).ToList();
            
        }

        ////////////////////////////////////////////////////////////////////////////
        /// BuiltInEnumeration Implementations /////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////
         
        [NodeCategory("Query")]
        public static List<ADDB.CurveElementType> CurveElementType(string keyword = "")
        {
            return GetByKeyword<ADDB.CurveElementType>(keyword);
        }

        [NodeCategory("Query")]
        public static List<ADDB.BuiltInCategory> BuiltInCategory(string keyword = "")
        {
            return GetByKeyword<ADDB.BuiltInCategory>(keyword);
        }

        [NodeCategory("Query")]
        public static List<ADDB.BuiltInParameter> BuiltInParameter(string keyword = "")
        {
            return GetByKeyword<ADDB.BuiltInParameter>(keyword);
        }

        [NodeCategory("Query")]
        public static List<ADDB.WallFunction> WallFunctions(string keyword = "")
        {
            return GetByKeyword<ADDB.WallFunction>(keyword);
        }

        [NodeCategory("Query")]
        public static List<ADDB.WallKind> WallKinds(string keyword = "")
        {
            return GetByKeyword<ADDB.WallKind>(keyword);
        }

    }
}