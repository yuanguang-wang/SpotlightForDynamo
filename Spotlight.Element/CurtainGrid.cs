using RevitServices.Persistence;
using RevitServices.Transactions;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class CurtainGrid
    {
        private CurtainGrid() { }

        public static ADDB.CurtainGridLine AddGridLine(ADDB.CurtainGrid curtainGrid, bool isUGridLine, ADDB.XYZ xyz, bool oneSegmentOnly)
        {
            ADDB.Document doc = DocumentManager.Instance.CurrentDBDocument;
            TransactionManager.Instance.EnsureInTransaction(doc);
            
            ADDB.CurtainGridLine curtainGridLine = curtainGrid.AddGridLine(isUGridLine, xyz, oneSegmentOnly);
            
            TransactionManager.Instance.TransactionTaskDone();
            
            return curtainGridLine;
        }
    }
}