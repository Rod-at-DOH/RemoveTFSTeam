using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTFSTeam
{
    internal static class ProcessSolutionFiles
    {
        const string TFS_BEGIN_TEAM_SECTION = "GlobalSection(TeamFoundationVersionControl)";
        const string TFS_END_TEAM_SECTION = "EndGlobalSection";

        internal static void ProcessFiles(List<string> files)
        {
            foreach (string file in files) 
            {
                Console.Write($"Processing {file} ");
                string[] lines = File.ReadAllLines(file);
                List<string> newLines = new List<string>();
                foreach (string line in lines)
                {
                    bool beginTFSTeamSectionFound = false;

                    // Have we encountered TFS_BEGIN_TEAM_SECTION
                        // ... and this is not TFS_END_TEAM_SECTION?
                            // then don't append this to newLines
                        // ... and this is TFS_END_TEAM_SECTION?
                            // then still don't append to newLines, but signal that we can resume appending to newLines with next read

                    // Is this TFS_BEGIN_TEAM_SECTION?
                    // then don't append to newLines and assign beginTFSTeamSectionFound to true

                    // Append to newLines

                    if (beginTFSTeamSectionFound)
                    {
                        if (!line.Contains(TFS_END_TEAM_SECTION))
                        {
                            // don't append to newLines
                        }
                        else
                        {
                            // This contains TFS_END_TEAM_SECTION and don't append to newLines
                            beginTFSTeamSectionFound = false;   //resume appending to newLines on the next read
                            Console.WriteLine("TFS Team Section found");
                        }
                    }
                    else if (line.Contains(TFS_BEGIN_TEAM_SECTION))
                    {
                        // stop appending to newLines
                        beginTFSTeamSectionFound = true;
                    }
                    else
                    {
                        // append to newLines
                        newLines.Add(line);
                    }
                }
            }
        }
    }
}
