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
        public static List<ADDB.BuiltInCategory> GetByKeyword(string keyword)
        {
            List<ADDB.BuiltInCategory> enumTypeList = Enum.GetValues(typeof(ADDB.BuiltInCategory)).Cast<ADDB.BuiltInCategory>().ToList();
            List<string> enumNameList = Enum.GetNames(typeof(ADDB.BuiltInCategory)).ToList();

            Dictionary<string, ADDB.BuiltInCategory> categoryDic = new Dictionary<string, ADDB.BuiltInCategory>();

            int i = 0;
            foreach (string name in enumNameList)
            {
                categoryDic.Add(name, enumTypeList[i]);
                i++;
            }

            List<ADDB.BuiltInCategory> filteredList = new List<ADDB.BuiltInCategory>();
            foreach (KeyValuePair<string, ADDB.BuiltInCategory> pair in categoryDic)
            {
                if (pair.Key.Contains(keyword))
                {
                    filteredList.Add(pair.Value);
                }
            }

            return filteredList;
        }

        public static List<T> GetWithKeyword<T>(string keyword)
        {
            return new List<T>();
        }
    }
}