using System.Collections.Generic;
using Dynamo.Graph.Nodes;
using RevitServices.Persistence;
using RevitServices.Transactions;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class ElementId
    {
        private ElementId() { }

        private static ADDB.Document CurrentDoc => DocumentManager.Instance.CurrentDBDocument;

        [NodeCategory("Create")]
        public static ADDB.ElementId CreateByBuiltInCategory(ADDB.BuiltInCategory builtInCategory)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInCategory);
            return elementId;
        }

        [NodeCategory("Create")]
        public static ADDB.ElementId CreateByInteger(int integer)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(integer);
            return elementId;
        }

        [NodeCategory("Create")]
        public static ADDB.ElementId CreateByBuiltInParameter(ADDB.BuiltInParameter builtInParameter)
        {
            ADDB.ElementId elementId = new ADDB.ElementId(builtInParameter);
            return elementId;
        }

        [NodeCategory("Query")]
        public static ADDB.Parameter LookupParameter(ADDB.ElementId elementId, string parameterName)
        {
            ADDB.Element element = CurrentDoc.GetElement(elementId);
            return element.LookupParameter(parameterName);
        }

        [NodeCategory("Query")]
        public static System.Type GetClassType(ADDB.ElementId elementId)
        {
            return elementId.GetType();
        }
        
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