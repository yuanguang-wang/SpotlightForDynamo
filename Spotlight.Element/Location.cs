using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Element
{
    public class Location
    {
        private Location() { }
        /// <summary>
        /// test3
        /// </summary>
        /// <param name="LocationCurve"></param>
        /// <returns></returns>
        public static ADDB.Curve Curve(ADDB.LocationCurve LocationCurve)
        {
            return LocationCurve.Curve;
        }
    }
}