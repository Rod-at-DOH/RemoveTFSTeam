using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTFSTeam
{
    internal static class ProcessSolutionFiles
    {
        const string TFS_BEING_TEAM_SECTION = "GlobalSection(TeamFoundationVersionControl)";
        const string TFS_END_TEAM_SECTION = "EndGlobalSection";

        internal static void ProcessFiles(List<string> files)
        {
            bool beginTFSTeamSectionFound = false;

            foreach (string file in files) { }
        }
    }
}
