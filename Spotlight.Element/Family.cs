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

        [NodeCategory("Query")]
        public static ADDB.FamilyManager GetFamilyManager(ADDB.Family family)
        {
            return family.Document.FamilyManager;
        }

        [NodeCategory("Query")]
        public static ADDB.Category GetFamilyCategory(ADDB.Family family)
        {
            return family.FamilyCategory;
        }

        [NodeCategory("Actions")]
        public static void SetFamilyCategory(ADDB.Family family, ADDB.Category category)
        {
            family.FamilyCategory = category;
        }
        
    }
}