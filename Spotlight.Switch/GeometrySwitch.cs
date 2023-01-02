using Revit.GeometryConversion;
using DYDG = Autodesk.DesignScript.Geometry;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Switch
{
    public class GeometrySwitch
    {
        private GeometrySwitch() { }

        public static ADDB.XYZ DynamoPointToRevitXyz(DYDG.Point DynamoPoint)
        {
            return DynamoPoint.ToRevitType();
        }

        public static DYDG.Point RevitXyzToDynamoPoint(ADDB.XYZ RevitXyz)
        {
            return RevitXyz.ToPoint();
        }

        public static DYDG.Curve RevitCurveToDynamoCurve(ADDB.Curve RevitCurve)
        {
            return RevitCurve.ToProtoType();
        }

        public static ADDB.Curve DynamoCurveToRevitCurve(DYDG.Curve DynamoCurve)
        {
            return DynamoCurve.ToRevitType();
        }

    }
}