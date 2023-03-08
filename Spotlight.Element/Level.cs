using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;
using ADSG = Autodesk.DesignScript.Geometry;

// ReSharper disable MemberCanBePrivate.Global

namespace Spotlight.Element
{
    public class Level
    {
        private Level() { }

        [NodeCategory("Create")]
        public static ADDB.Level CreateLevel(ADDB.Document doc, double elevation)
        {
            ADDB.Level level = ADDB.Level.Create(doc, elevation);
            return level;
        }

        [NodeCategory("Actions")]
        public static ADDB.Leader AddLeader(ADDB.Level level, ADDB.DatumEnds datumEnds, ADDB.View view)
        {
            return level.AddLeader(datumEnds, view);
        }
        
        [NodeCategory("Query")]
        public static ADDB.Leader GetLeader(ADDB.Level level, ADDB.DatumEnds datumEnds, ADDB.View view)
        {
            return level.GetLeader(datumEnds, view);
        }
    }
}