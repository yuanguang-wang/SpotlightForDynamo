using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class Location
    {
        private Location() { }

        public static ADDB.Curve GetCurve(ADDB.LocationCurve locationCurve)
        {
            return locationCurve.Curve;
        }

        public static void SetCurve(ADDB.LocationCurve locationCurve, ADDB.Curve curve)
        {
            locationCurve.Curve = curve;
        }
    }
}