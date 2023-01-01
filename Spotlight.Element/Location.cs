using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class Location
    {
        private Location() { }

        public static ADDB.Curve Curve(ADDB.LocationCurve LocationCurve)
        {
            return LocationCurve.Curve;
        }
    }
}