using System.Collections.Generic;
using System.Linq;
using Dynamo.Graph.Nodes;

using RevitServices.Persistence;
using RevitServices.Transactions;

using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

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
        public static ICollection<ADDB.ElementId> Delete(ADDB.ElementId elementId, bool run)
        {
            if (run)
            {
                TransactionManager.Instance.EnsureInTransaction(CurrentDoc);

                ICollection<ADDB.ElementId> deletedIdList = CurrentDoc.Delete(elementId);
            
                TransactionManager.Instance.TransactionTaskDone();

                return deletedIdList; 
            }
            return null;
        }
               
        [NodeCategory("Actions")]
        public static ICollection<ADDB.ElementId> Delete(ICollection<ADDB.ElementId> elementIds, bool run)
        {
            if (run)
            {
                TransactionManager.Instance.EnsureInTransaction(CurrentDoc);

                ICollection<ADDB.ElementId> deletedIdList = CurrentDoc.Delete(elementIds);
            
                TransactionManager.Instance.TransactionTaskDone();

                return deletedIdList; 
            }
            return null;
        }
        
        [NodeCategory("Actions")]
        public static ICollection<ADDB.ElementId> Delete(DYDB.Element dynamoElement, bool run)
        {
            if (run)
            {
                TransactionManager.Instance.EnsureInTransaction(CurrentDoc);

                ADDB.ElementId elementId = dynamoElement.InternalElement.Id;
                ICollection<ADDB.ElementId> deletedIdList = CurrentDoc.Delete(elementId);
            
                TransactionManager.Instance.TransactionTaskDone();

                return deletedIdList; 
            }
            return null;
        } 
        
                       
        [NodeCategory("Actions")]
        public static ICollection<ADDB.ElementId> Delete(ICollection<DYDB.Element> dynamoElements, bool run)
        {
            if (run)
            {
                TransactionManager.Instance.EnsureInTransaction(CurrentDoc);

                ICollection<ADDB.ElementId> elementIds = dynamoElements.Select(t => t.InternalElement.Id).ToList();
                ICollection<ADDB.ElementId> deletedIdList = CurrentDoc.Delete(elementIds);
            
                TransactionManager.Instance.TransactionTaskDone();

                return deletedIdList; 
            }
            return null;
        }

        [NodeCategory("Actions")]
        public static void Regenerate(bool run)
        {
            if (run)
            {
                TransactionManager.Instance.EnsureInTransaction(CurrentDoc);

                CurrentDoc.Regenerate();
            
                TransactionManager.Instance.TransactionTaskDone(); 
            }
        }





    }
}