using System.Collections.Generic;
using System.Linq;
using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;
using SP = Spotlight.Revit;
using DYDB = Revit.Elements;
using MS = System;

// ReSharper disable MemberCanBePrivate.Global

namespace Spotlight.Filter
{
    public class ElementFilter
    {
        private ElementFilter() { }

        // Element Slow Filter //
        /////////////////////////
        
        [NodeCategory("Create")]
        public static SP.ElementFilter ElementParameterFilter(ADDB.FilterRule filterRule, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementParameterFilter(filterRule, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementParameterFilter(IList<ADDB.FilterRule> filterRules, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementParameterFilter(filterRules, invert));
        } 

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementLevelFilter(DYDB.Level level, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementLevelFilter(level.InternalElement.LevelId, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementLevelFilter(ADDB.Level level, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementLevelFilter(level.LevelId, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementLevelFilter(ADDB.ElementId level, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementLevelFilter(level, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementIntersectElementFilter(DYDB.Element element, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementIntersectsElementFilter(element.InternalElement, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementIntersectSolidFilter(ADDB.Solid solid, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementIntersectsSolidFilter(solid, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter AreaFilter()
        {
            return new SP.ElementFilter(new ADDB.AreaFilter());
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter AreaTagFilter()
        {
            return new SP.ElementFilter(new ADDB.AreaTagFilter());
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter RoomFilter()
        {
            return new SP.ElementFilter(new ADDB.Architecture.RoomFilter());
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter RoomTagFilter()
        {
            return new SP.ElementFilter(new ADDB.Architecture.RoomTagFilter());
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter CurveElementFilter(ADDB.CurveElementType curveElementType, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.CurveElementFilter(curveElementType, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter FamilyInstanceFilter(ADDB.Document doc, ADDB.ElementId familySymbol)
        {
            return new SP.ElementFilter(new ADDB.FamilyInstanceFilter(doc, familySymbol));
        }
        
        // Element Quick Filter //
        /////////////////////////

        [NodeCategory("Create")]
        public static SP.ElementFilter BoundingBoxContainsPointFilter(ADDB.XYZ xyz, double tolerance = 0.00, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.BoundingBoxContainsPointFilter(xyz, tolerance, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter BoundingBoxIntersectsFilter(ADDB.Outline outline, double tolerance = 0.00, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.BoundingBoxIntersectsFilter(outline, tolerance, invert));
        }
        
        [NodeCategory("Create")]
        public static SP.ElementFilter BoundingBoxIsInsideFilter(ADDB.Outline outline, double tolerance = 0.00, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.BoundingBoxIsInsideFilter(outline, tolerance, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementCategoryFilter(ADDB.BuiltInCategory builtInCategory, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementCategoryFilter(builtInCategory, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementClassFilter(MS.Type classType, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementClassFilter(classType, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementIdSetFilter(ICollection<ADDB.ElementId> elementIds)
        {
            return new SP.ElementFilter(new ADDB.ElementIdSetFilter(elementIds));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementIsCurveDrivenFilter(bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementIsCurveDrivenFilter(invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementIsElementTypeFilter(bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementIsElementTypeFilter(invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementMultiCategoryFilter(ICollection<ADDB.BuiltInCategory> builtInCategories, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementMulticategoryFilter(builtInCategories, invert));
        }
        
        [NodeCategory("Create")]
        public static SP.ElementFilter ElementMultiCategoryFilter(ICollection<ADDB.ElementId> builtInCategories, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementMulticategoryFilter(builtInCategories, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementMultiClassFilter(IList<MS.Type> classTypes, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementMulticlassFilter(classTypes, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementWorksetFilter(ADDB.WorksetId worksetId, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.ElementWorksetFilter(worksetId, invert));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter ElementExclusionFilter(ICollection<ADDB.ElementId> elementIds)
        {
            return new SP.ElementFilter(new ADDB.ExclusionFilter(elementIds));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter FamilySymbolFilter(ADDB.ElementId familyId)
        {
            return new SP.ElementFilter(new ADDB.FamilySymbolFilter(familyId));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter VisibleInViewFilter(ADDB.Document doc, ADDB.ElementId viewId, bool invert = false)
        {
            return new SP.ElementFilter(new ADDB.VisibleInViewFilter(doc, viewId, invert));
        }
               
        // Element Logical Filter //
        ////////////////////////////

        [NodeCategory("Create")]
        public static SP.ElementFilter LogicalAndFilter(IEnumerable<SP.ElementFilter> elementFilters)
        {
            IList<ADDB.ElementFilter> dbElementFilters = (from filters in elementFilters select filters.DbElementFilter).ToList();
            return new SP.ElementFilter(new ADDB.LogicalAndFilter(dbElementFilters));
        }

        [NodeCategory("Create")]
        public static SP.ElementFilter LogicalOrFilter(IEnumerable<SP.ElementFilter> elementFilters)
        {
            IList<ADDB.ElementFilter> dbElementFilters = (from filters in elementFilters select filters.DbElementFilter).ToList();
            return new SP.ElementFilter(new ADDB.LogicalOrFilter(dbElementFilters)); 
        }

    }
}