using Revit.GeometryConversion;
using DYDG = Autodesk.DesignScript.Geometry;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Switch
{
    public class GeometrySwitch
    {
        private GeometrySwitch() { }

        public static ADDB.XYZ DynamoPointToRevitXyz(DYDG.Point dynamoPoint)
        {
            return dynamoPoint.ToRevitType();
        }

        public static DYDG.Point RevitXyzToDynamoPoint(ADDB.XYZ revitXyz)
        {
            return revitXyz.ToPoint();
        }

        public static DYDG.Curve RevitCurveToDynamoCurve(ADDB.Curve revitCurve)
        {
            return revitCurve.ToProtoType();
        }

        public static ADDB.Curve DynamoCurveToRevitCurve(DYDG.Curve dynamoCurve)
        {
            return dynamoCurve.ToRevitType();
        }

    }
}