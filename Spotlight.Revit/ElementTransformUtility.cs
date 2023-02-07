using System.Collections.Generic;
using Dynamo.Graph.Nodes;

using RevitServices.Transactions;
    
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Revit
{
    public class ElementTransformUtility
    {
        private ElementTransformUtility() {}

        [NodeCategory("Create")]
        public static ICollection<ADDB.ElementId> CopyElement(ADDB.Document doc, ADDB.ElementId elementId, ADDB.XYZ xyz)
        {
            TransactionManager.Instance.EnsureInTransaction(doc);
            
            ICollection<ADDB.ElementId> copiedId =  ADDB.ElementTransformUtils.CopyElement(doc, elementId, xyz);
            
            TransactionManager.Instance.TransactionTaskDone();

            return copiedId;
        }
    }
}