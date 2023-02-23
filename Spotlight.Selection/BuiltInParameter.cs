using System;
using System.Collections.Generic;
using System.Linq;
using Dynamo.Graph.Nodes;
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

            Dictionary<string, ADDB.BuiltInParameter> paramDic = new Dictionary<string, ADDB.BuiltInParameter>();

            int i = 0;
            foreach (string name in enumNameList)
            {
                paramDic.Add(name, enumTypeList[i]);
                i++;
            }

            return (from pair in paramDic where pair.Key.Contains(keyword) select pair.Value).ToList();
        }
    }
}