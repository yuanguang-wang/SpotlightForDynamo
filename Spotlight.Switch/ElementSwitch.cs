using Revit.GeometryConversion;
using DYDG = Autodesk.DesignScript.Geometry;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;

namespace Spotlight.Switch
{
    public class ElementSwitch
    {
        private ElementSwitch() { }
        
        public static ADDB.Wall DYN__Wall__RVT(DYDB.Wall wall_DYN)
        {
            ADDB.Wall revitWall = wall_DYN.InternalElement as ADDB.Wall;
            return revitWall;
        }

        public static DYDB.Wall RVT__Wall__DYN(ADDB.Wall wall_RVT)
        {
            return DYDB.ElementWrapper.Wrap(wall_RVT,true);
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public static ADDB.ModelCurve DYN__ModelCurve__RVT(DYDB.ModelCurve modelCurve_DYN)
        {
            ADDB.ModelCurve revitModelCurve = modelCurve_DYN.InternalElement as ADDB.ModelCurve;
            return revitModelCurve;
        }

        public static DYDG.Curve DYN__ModelCurve__DSG(DYDB.ModelCurve modelCurve_DYN)
        {
            DYDG.Curve designScriptCurve = DYN__ModelCurve__RVT(modelCurve_DYN).GeometryCurve.ToProtoType();
            return designScriptCurve;
        }
        
    }
}