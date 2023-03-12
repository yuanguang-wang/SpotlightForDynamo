using System.Collections.Generic;
using Dynamo.Graph.Nodes;

using RevitServices.Transactions;
    
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Revit
{
    public class ElementTransformation
    {
        private ElementTransformation() {}

        [NodeCategory("Create")]
        public static ICollection<ADDB.ElementId> CopyElement(ADDB.Document doc, ADDB.ElementId elementId, ADDB.XYZ xyz)
        {
            TransactionManager.Instance.EnsureInTransaction(doc);
            
            ICollection<ADDB.ElementId> copiedId =  ADDB.ElementTransformUtils.CopyElement(doc, elementId, xyz);
            
            TransactionManager.Instance.TransactionTaskDone();

            return copiedId;
        }

        [NodeCategory("Create")]
        public static ICollection<ADDB.ElementId> CopyElementInPlace(ADDB.Document doc, ADDB.ElementId elementId)
        {
            TransactionManager.Instance.EnsureInTransaction(doc);
            
            ICollection<ADDB.ElementId> copiedId =  ADDB.ElementTransformUtils.CopyElement(doc, elementId, ADDB.XYZ.Zero);
            
            TransactionManager.Instance.TransactionTaskDone();

            return copiedId; 
        }

        [NodeCategory("Actions")]
        public static void MoveElement(ADDB.Document doc, ADDB.ElementId elementId, ADDB.XYZ xyz)
        {
            TransactionManager.Instance.EnsureInTransaction(doc);
            
            ADDB.ElementTransformUtils.MoveElement(doc, elementId, xyz);
            
            TransactionManager.Instance.TransactionTaskDone();
        }

        [NodeCategory("Actions")]
        public static void RotateElement(ADDB.Document doc, ADDB.ElementId elementId, ADDB.Line axis, double angle)
        {
            TransactionManager.Instance.EnsureInTransaction(doc);
            
            ADDB.ElementTransformUtils.RotateElement(doc, elementId, axis, angle);
            
            TransactionManager.Instance.TransactionTaskDone();
        }

    }
}