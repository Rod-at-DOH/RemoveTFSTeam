internal class Program
{
    // This application is meant to be used for removing the section of code:
    // "GlobalSection(TeamFoundationVersionControl)" to "EndGlobalSection"
    // from the Visual Studio .sln files, which are passed to it on the PowerShell command line.
    // This is a part of the process of migrating TFS/TFVC projects to Git repos.
    private static void Main(string[] args)
    {
        Console.WriteLine($"args.Length == {args.Length}");

        // reflect back the lists fed to this app
        foreach (var item in args)
        {
            // Need to use Console.Read, to process data fed via the "|" command line operator
            string s;
            while ((s = Console.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}