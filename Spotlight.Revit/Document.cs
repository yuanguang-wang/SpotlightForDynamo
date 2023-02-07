using System.Collections.Generic;
using Dynamo.Graph.Nodes;

using RevitServices.Persistence;
using RevitServices.Transactions;

using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Revit
{
    public class Document
    {
        private Document() { }
        private static ADDB.Document CurrentDoc => DocumentManager.Instance.CurrentDBDocument;
        
        [NodeCategory("Query")]
        public static ADDB.Document GetDocument()
        {
            return CurrentDoc;
        }
        
        [NodeCategory("Actions")]
        public static ICollection<ADDB.ElementId> Delete(ADDB.ElementId elementId) 
        {
            TransactionManager.Instance.EnsureInTransaction(CurrentDoc);

            ICollection<ADDB.ElementId> deletedIdList = CurrentDoc.Delete(elementId);
            
            TransactionManager.Instance.TransactionTaskDone();

            return deletedIdList;
        }





    }
}