using DYDG = Autodesk.DesignScript.Geometry;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Switch
{
    public class ElementSwitch
    {
        private ElementSwitch() { }
        
        /// <summary>
        /// Switch Dynamo wall (Revit.Elements.Wall to Autodesk.Revit.DB.Wall)
        /// </summary>
        /// <param name="dynamoWall">Dynamo Wall</param>
        /// <returns name="revitWall">Revit Wall</returns>
        /// <search>dynamo wall to revit wall</search>
        public static ADDB.Wall DynamoWallToRevitWall(DYDB.Wall dynamoWall)
        {
            ADDB.Wall revitWall = dynamoWall.InternalElement as ADDB.Wall;
            return revitWall;
        }
    }
}