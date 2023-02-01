using System.Collections.Generic;
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

        /////////////////////////////////////
        // ChangePanelType has 4 Overloads //
        /////////////////////////////////////
        private static ADDB.Element ChangePanelTypeBase(ADDB.CurtainGrid curtainGrid, ADDB.Element oldPanel, ADDB.ElementType newPanelType)
        {
            ADDB.Document doc = DocumentManager.Instance.CurrentDBDocument;
            TransactionManager.Instance.EnsureInTransaction(doc);

            ADDB.Element newPanel = curtainGrid.ChangePanelType(oldPanel, newPanelType);
            
            TransactionManager.Instance.TransactionTaskDone();
            
            return newPanel;
        }

        public static ADDB.Element ChangePanelType(ADDB.CurtainGrid curtainGrid, ADDB.Panel oldPanel, ADDB.PanelType newPanelType)
        {
            return ChangePanelTypeBase(curtainGrid, oldPanel, newPanelType);
        }

        public static ADDB.Element ChangePanelType(ADDB.CurtainGrid curtainGrid, ADDB.Panel oldPanel, ADDB.WallType newPanelType)
        {
            return ChangePanelTypeBase(curtainGrid, oldPanel, newPanelType);
        }
        
        public static ADDB.Element ChangePanelType(ADDB.CurtainGrid curtainGrid, ADDB.Wall oldPanel, ADDB.PanelType newPanelType)
        {
            return ChangePanelTypeBase(curtainGrid, oldPanel, newPanelType);
        }

        public static ADDB.Element ChangePanelType(ADDB.CurtainGrid curtainGrid, ADDB.Wall oldPanel, ADDB.WallType newPanelType)
        {
            return ChangePanelTypeBase(curtainGrid, oldPanel, newPanelType);
        }

        public static ICollection<ADDB.ElementId> GetMullionId(ADDB.CurtainGrid curtainGrid)
        {
            return curtainGrid.GetMullionIds();
        }
        
        
    }
}