using System.Collections.Generic;
using Autodesk.DesignScript.Runtime;
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

        [NodeCategory("Query")]
        [MultiReturn(new []{"levelId", "offset"})]
        public static Dictionary<string, object> GetNearestLevelId(ADDB.Document doc, double elevation)
        {
            Dictionary<string, object> output = new Dictionary<string, object>();

            ADDB.ElementId elementId = ADDB.Level.GetNearestLevelId(doc, elevation, out double offset);
            
            output.Add("levelId", elementId);
            output.Add("offset", offset);

            return output;
        }

        [NodeCategory("Query")]
        public static double GetProjectionElevation(ADDB.Level level)
        {
            return level.ProjectElevation;
        }

    }
}