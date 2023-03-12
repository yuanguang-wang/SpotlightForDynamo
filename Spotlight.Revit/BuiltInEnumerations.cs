using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            return (api.GetTypes().Where(t => t.IsEnum)).ToList();
        }
        
    }
}