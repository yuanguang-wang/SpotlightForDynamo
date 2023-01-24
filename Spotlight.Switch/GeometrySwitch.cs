using Revit.GeometryConversion;
using ADSG = Autodesk.DesignScript.Geometry;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Switch
{
    public class GeometrySwitch
    {
        private GeometrySwitch() { }

        public static ADDB.XYZ DSG__Point__RVT(ADSG.Point point_DSG)
        {
            return point_DSG.ToRevitType();
        }

        public static ADSG.Point RVT__Point__DSG(ADDB.XYZ xyz_RVT)
        {
            return xyz_RVT.ToPoint();
        }

        public static ADSG.Curve RVT__Curve__DSG(ADDB.Curve curve_RVT)
        {
            return curve_RVT.ToProtoType();
        }

        public static ADDB.Curve DSG__Curve__RVT(ADSG.Curve curve_DSG)
        {
            return curve_DSG.ToRevitType();
        }

    }
}