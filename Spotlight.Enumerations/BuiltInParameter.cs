using System;
using System.Collections.Generic;
using System.Linq;
using Autodesk.DesignScript.Runtime;
using Dynamo.Graph.Nodes;
using Spotlight.Revit;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Enumerations
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
        [MultiReturn(new [] {"parameter", "description"})]
        public static Dictionary<string, object> GetParameterByKeyword(string keyword)
        {
            Dictionary<string, object> output = new Dictionary<string, object>();

            List<ADDB.BuiltInParameter> enumTypeList = Enum.GetValues(typeof(ADDB.BuiltInParameter)).Cast<ADDB.BuiltInParameter>().ToList();
            List<string> enumNameList = Enum.GetNames(typeof(ADDB.BuiltInParameter)).ToList();
            IEnumerable<string> enumDesIEnum = from enumType in enumTypeList select enumType.ToDescription();
            List<string> enumDesList = enumDesIEnum.ToList();

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
            List<ADDB.BuiltInParameter> targetParam = targetIndex.Select(index => enumTypeList[index]).ToList();
            List<string> targetDes = targetIndex.Select(index => enumDesList[index]).ToList();
            
            output.Add("parameter", targetParam);
            output.Add("description", targetDes);

            return output;

        }
    }
}