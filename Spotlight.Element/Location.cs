using Revit.GeometryConversion;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;
using ADSG = Autodesk.DesignScript.Geometry;

namespace Spotlight.Element
{
    public class Location
    {
        private Location() { }

        public static ADSG.Curve GetCurve(ADDB.LocationCurve locationCurve)
        {
            ADDB.Curve curve = locationCurve.Curve;
            return curve.ToProtoType(true);

        }

        public static void SetCurve(ADDB.LocationCurve locationCurve, ADDB.Curve curve)
        {
            locationCurve.Curve = curve;
        }
    }
}