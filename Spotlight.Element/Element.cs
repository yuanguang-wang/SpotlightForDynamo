using System.Collections.Generic;
using Dynamo.Graph.Nodes;
using RevitServices.Transactions;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;
using Spotlight.Support;

namespace Spotlight.Element
{
    public class Element
    {
        private Element() { }

        [NodeCategory("Query")]
        public static ADDB.Parameter LookupParameter(DYDB.Element dynamoElement, string parameterName)
        {
            ADDB.Element element = dynamoElement.InternalElement;
            return element.LookupParameter(parameterName);
        }
       
        [NodeCategory("Create")]
        public static ICollection<ADDB.ElementId> CopyElement(ADDB.Document doc, DYDB.Element dynamoElement, ADDB.XYZ xyz)
        {
            TransactionManager.Instance.EnsureInTransaction(doc);

            ADDB.ElementId elementId = dynamoElement.InternalElement.Id;
            ICollection<ADDB.ElementId> copiedId =  ADDB.ElementTransformUtils.CopyElement(doc, elementId, xyz);
            
            TransactionManager.Instance.TransactionTaskDone();

            return copiedId;
        }

        [NodeCategory("Create")]
        public static ICollection<ADDB.ElementId> CopyElementInPlace(ADDB.Document doc, DYDB.Element dynamoElement)
        {
            TransactionManager.Instance.EnsureInTransaction(doc);
            
            ADDB.ElementId elementId = dynamoElement.InternalElement.Id;
            ICollection<ADDB.ElementId> copiedId =  ADDB.ElementTransformUtils.CopyElement(doc, elementId, ADDB.XYZ.Zero);
            
            TransactionManager.Instance.TransactionTaskDone();

            return copiedId; 
        }


        [NodeCategory("Actions")]
        public static void MoveElement(ADDB.Document doc, DYDB.Element dynamoElement, ADDB.XYZ xyz)
        {
            TransactionManager.Instance.EnsureInTransaction(doc);

            ADDB.ElementId elementId = dynamoElement.InternalElement.Id; 
            ADDB.ElementTransformUtils.MoveElement(doc, elementId, xyz);

            TransactionManager.Instance.TransactionTaskDone();
        }


        [NodeCategory("Actions")]
        public static void RotateElement(ADDB.Document doc, DYDB.Element dynamoElement, ADDB.Line axis, double angle)
        {
            TransactionManager.Instance.EnsureInTransaction(doc);
            
            ADDB.ElementId elementId = dynamoElement.InternalElement.Id; 
            ADDB.ElementTransformUtils.RotateElement(doc, elementId, axis, angle);
            
            TransactionManager.Instance.TransactionTaskDone();
        }

        void WriteXml()
        {
            DynamoCustomization.Write(typeof(Element).Namespace);
        }
        
    }
}