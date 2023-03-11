using System;
using System.Collections.Generic;
using System.Linq;
using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Enumerations
{
    public class CurveElementType
    {
        private CurveElementType() { }
        
        [NodeCategory("Query")]
        public static List<ADDB.CurveElementType> GetAllCurveElementTypes()
        {
            return Enum.GetValues(typeof(ADDB.CurveElementType)).Cast<ADDB.CurveElementType>().ToList();
        }
        
        [NodeCategory("Query")]
        public static List<ADDB.CurveElementType> GetByKeyword(string keyword)
        {
            return GetWithKeyword<ADDB.CurveElementType>(keyword);
        }

        private static List<T> GetWithKeyword<T>(string keyword)
        {
            List<T> enumTypeList = Enum.GetValues(typeof(T)).Cast<T>().ToList();
            List<string> enumNameList = Enum.GetNames(typeof(T)).ToList();

            Dictionary<string, T> enumDic = new Dictionary<string, T>();

            int i = 0;
            foreach (string name in enumNameList)
            {
                enumDic.Add(name,enumTypeList[i]);
                i++;
            }

            return (from pair in enumDic where pair.Key.Contains(keyword) select pair.Value).ToList();
        }
    }
}