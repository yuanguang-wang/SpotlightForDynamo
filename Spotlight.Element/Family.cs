using System.Collections.Generic;
using Dynamo.Graph.Nodes;

using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Element
{
    public class Family
    {
        private Family() { }

        [NodeCategory("Query")]
        public static ISet<ADDB.ElementId> GetFamilySymbolIds(ADDB.Family family)
        {
            return family.GetFamilySymbolIds();
        }
    }
}