using Revit.GeometryConversion;
using ADSG = Autodesk.DesignScript.Geometry;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Switch
{
    public class GeometrySwitch
    {
        private GeometrySwitch() { }

        public static ADDB.XYZ Point_DSGtoRVT(ADSG.Point pointDSG)
        {
            return pointDSG.ToRevitType();
        }

        public static ADSG.Point Point_RVTtoDSG(ADDB.XYZ pointRVT)
        {
            return pointRVT.ToPoint();
        }

        public static ADSG.Curve Curve_RVTtoDSG(ADDB.Curve curveRVT)
        {
            return curveRVT.ToProtoType();
        }

        public static ADDB.Curve Curve_DSGtoRVT(ADSG.Curve curveDSG)
        {
            return curveDSG.ToRevitType();
        }

    }
}