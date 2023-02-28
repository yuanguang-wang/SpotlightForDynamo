using System;
using System.Collections.Generic;
using System.Linq;
using Dynamo.Graph.Nodes;
using Spotlight.Revit;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Selection
{
    public class BuiltInParameter
    {
        private BuiltInParameter() { }

        [NodeCategory("Query")]
        public static List<ADDB.BuiltInParameter> GetAllParameters()
        {
            return Enum.GetValues(typeof(ADDB.BuiltInParameter)).Cast<ADDB.BuiltInParameter>().ToList();
        }

        [NodeCategory("Query")]
        public static List<ADDB.BuiltInParameter> GetParameterByKeyword(string keyword)
        {
            List<ADDB.BuiltInParameter> enumTypeList = Enum.GetValues(typeof(ADDB.BuiltInParameter)).Cast<ADDB.BuiltInParameter>().ToList();
            List<string> enumNameList = Enum.GetNames(typeof(ADDB.BuiltInParameter)).ToList();
            IEnumerable<string> enumDesList = from enumType in enumTypeList select enumType.ToDescription();

            List<int> targetNameIndex = new List<int>();
            List<int> targetDesIndex = new List<int>();

            string upperKeyword = keyword.ToUpper();

            int i = 0;
            foreach (string name in enumNameList)
            {
                if (name.Contains(keyword))
                {
                   targetNameIndex.Add(i); 
                }

                i++;
            }

            int j = 0;
            foreach (string name in enumDesList)
            {
                if (name.Contains(keyword))
                {
                    targetDesIndex.Add(j);
                }

                j++;
            }

            List<int> targetIndex = targetNameIndex.Union(targetDesIndex).ToList();

            return targetIndex.Select(index => enumTypeList[index]).ToList();
            
        }
    }
}