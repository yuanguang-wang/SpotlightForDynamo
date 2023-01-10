using Revit.GeometryConversion;
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

        // ReSharper disable once MemberCanBePrivate.Global
        public static ADDB.ModelCurve DynamoModelCurveToRevitModelCurve(DYDB.ModelCurve dynamoModelCurve)
        {
            ADDB.ModelCurve revitModelCurve = dynamoModelCurve.InternalElement as ADDB.ModelCurve;
            return revitModelCurve;
        }

        public static DYDG.Curve DynamoModelCurveToDesignScriptCurve(DYDB.ModelCurve dynamoModelCurve)
        {
            DYDG.Curve designScriptCurve = DynamoModelCurveToRevitModelCurve(dynamoModelCurve).GeometryCurve.ToProtoType();
            return designScriptCurve;
        }
        
    }
}