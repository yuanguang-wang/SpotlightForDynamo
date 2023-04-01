using System.Collections.Generic;
using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;
using SP = Spotlight.Revit;
using DYDB = Revit.Elements;

// ReSharper disable MemberCanBePrivate.Global

namespace Spotlight.Selection
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
    }
}