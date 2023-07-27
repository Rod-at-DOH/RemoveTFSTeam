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
                string[] lines = File.ReadAllLines(file);
                List<string> newLines = new List<string>();

                Console.Write($"Processing {file} ");

                foreach (string line in lines)
                {
                    bool beginTFSTeamSectionFound = false;

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

                Console.WriteLine();    // make sure that we've entered a new line character
            }
        }
    }
}
