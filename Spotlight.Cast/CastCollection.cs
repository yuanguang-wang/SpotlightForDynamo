using Revit.Elements;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;
using SP = Spotlight.Revit;


namespace Spotlight.Cast
{
    public class SubElements
    {
        private SubElements() { }

        #region GetElementId Overloads

        public static ADDB.ElementId GetElementId(ADDB.Wall element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.Wall element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.Mullion element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.Mullion element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.Analysis.PathOfTravel element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.Analysis.PathOfTravel element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.Architecture.Railing element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.Architecture.Railing element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.Architecture.Stairs element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.Architecture.Stairs element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.Architecture.StairsLanding element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.Architecture.StairsLanding element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.Architecture.StairsPath element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.Architecture.StairsPath element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.Architecture.StairsRun element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.Architecture.StairsRun element)
        {
            return element.ToDSType(true);
        }

        // CurveElement
        //      --CurveByPoints
        //      --DetailCurve
        //      --ModelCurve
        //      --SymbolicCurve
        public static ADDB.ElementId GetElementId(ADDB.CurveByPoints element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.CurveByPoints element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.DetailCurve element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.DetailCurve element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.ModelCurve element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.ModelCurve element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.SymbolicCurve element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.SymbolicCurve element)
        {
            return element.ToDSType(true);
        }

        // DetailCurve
        //      --DetailArc
        //      --DetailEllipse
        //      --DetailLine
        //      --DetailNurbSpline

        public static ADDB.ElementId GetElementId(ADDB.DetailArc element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.DetailArc element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.DetailEllipse element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.DetailEllipse element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.DetailLine element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.DetailLine element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.DetailNurbSpline element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.DetailNurbSpline element)
        {
            return element.ToDSType(true);
        }

        // ModelCurve
        //      --ModelArc
        //      --ModelEllipse
        //      --ModelHermiteSpline
        //      --ModelLine
        //      --ModelNurbSpline

        public static ADDB.ElementId GetElementId(ADDB.ModelArc element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.ModelArc element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.ModelEllipse element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.ModelEllipse element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.ModelHermiteSpline element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.ModelHermiteSpline element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.ModelLine element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.ModelLine element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.ModelNurbSpline element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.ModelNurbSpline element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.Family element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.Family element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.FilledRegion element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.FilledRegion element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.FilterElement element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.FilterElement element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.Group element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.Group element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.HostObject element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.HostObject element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.Instance element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.Instance element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.LinePatternElement element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.LinePatternElement element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.Material element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.Material element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.ModelText element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.ModelText element)
        {
            return element.ToDSType(true);
        }

        public static ADDB.ElementId GetElementId(ADDB.Opening element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.Opening element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.ParameterElement element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.ParameterElement element)
        {
            return element.ToDSType(true);
        } 
        
        public static ADDB.ElementId GetElementId(ADDB.TextElement element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.TextElement element)
        {
            return element.ToDSType(true);
        } 

        public static ADDB.ElementId GetElementId(ADDB.View element)
        {
            return element.Id;
        }

        public static DYDB.Element GetDynamoElement(ADDB.View element)
        {
            return element.ToDSType(true);
        } 
        
        public static ADDB.ElementId GetElementId(ADDB.Viewport element)
        {
            return element.Id;
        }
        
        public static DYDB.Element GetDynamoElement(ADDB.Viewport element)
        {
            return element.ToDSType(true);
        } 

        #endregion
    }

    public class SubElementFilters
    {
        private SubElementFilters() { }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementLevelFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.Architecture.RoomFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.Architecture.RoomTagFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.AreaFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.AreaTagFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.CurveElementFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementIntersectsFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementParameterFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementPhaseStatusFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.FamilyInstanceFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.BoundingBoxContainsPointFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.BoundingBoxIntersectsFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.BoundingBoxIsInsideFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementCategoryFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementClassFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementDesignOptionFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementIdSetFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementIsCurveDrivenFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementIsElementTypeFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementMulticategoryFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementMulticlassFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementOwnerViewFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementStructuralTypeFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ElementWorksetFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.ExclusionFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.FamilySymbolFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.VisibleInViewFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.LogicalAndFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }

        public static SP.ElementFilter GetElementFilter(ADDB.LogicalOrFilter subElementFilter)
        {
            ADDB.ElementFilter dbfilter = subElementFilter;
            SP.ElementFilter spFilter = new SP.ElementFilter(dbfilter);
            return spFilter;
        }
    }
}