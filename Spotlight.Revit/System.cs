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
}