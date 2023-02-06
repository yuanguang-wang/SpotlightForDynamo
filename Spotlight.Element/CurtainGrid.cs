using System.Collections.Generic;

using Autodesk.DesignScript.Runtime;

using Dynamo.Graph.Nodes;

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

        [NodeCategory("Query")]
        public static ICollection<ADDB.ElementId> GetMullionIds(ADDB.CurtainGrid curtainGrid)
        {
            return curtainGrid.GetMullionIds();
        }

        [NodeCategory("Query")]
        [MultiReturn(new[] { "grid1Angle", "grid2Angle" })]
        public static Dictionary<string, object> GetGridAngles(ADDB.CurtainGrid curtainGrid)
        {
            Dictionary<string, object> output = new Dictionary<string, object>();
            double angle1 = curtainGrid.Grid1Angle;
            double angle2 = curtainGrid.Grid2Angle;
            output.Add("grid1Angle", angle1);
            output.Add("grid2Angle", angle2);

            return output;
        }
        
        [NodeCategory("Query")]
        [MultiReturn(new[] { "grid1Offset", "grid2Offset" })]
        public static Dictionary<string, object> GetGridOffsets(ADDB.CurtainGrid curtainGrid)
        {
            Dictionary<string, object> output = new Dictionary<string, object>();
            double offset1 = curtainGrid.Grid1Offset;
            double offset2 = curtainGrid.Grid2Offset;
            output.Add("grid1Offset", offset1);
            output.Add("grid2Offset", offset2);

            return output;
        }

        [NodeCategory("Query")]
        [MultiReturn(new[] { "gridULineNumber", "gridVLineNumber" })]
        public static Dictionary<string, object> GetGridLineNumbers(ADDB.CurtainGrid curtainGrid)
        {
            Dictionary<string, object> output = new Dictionary<string, object>();
            int uNum = curtainGrid.NumULines;
            int vNum = curtainGrid.NumVLines;
            output.Add("gridULineNumber", uNum);
            output.Add("gridVLineNumber", vNum);

            return output;
        }

        [NodeCategory("Query")]
        public static ICollection<ADDB.ElementId> GetPanelIds(ADDB.CurtainGrid curtainGrid)
        {
            return curtainGrid.GetPanelIds();
        }

        [NodeCategory("Query")]
        [MultiReturn(new[] { "gridULineIds", "gridVLineIds" })]
        public static Dictionary<string, object> GetGridLineIds(ADDB.CurtainGrid curtainGrid)
        {
            Dictionary<string, object> output = new Dictionary<string, object>();
            ICollection<ADDB.ElementId> uIds = curtainGrid.GetUGridLineIds();
            ICollection<ADDB.ElementId> vIds = curtainGrid.GetVGridLineIds();
            
            output.Add("gridULineIds", uIds);
            output.Add("gridVLineIds", vIds);

            return output;
        }
    }
}