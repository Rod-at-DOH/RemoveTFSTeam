internal class Program
{
    // This application is meant to be used for removing the section of code:
    // "GlobalSection(TeamFoundationVersionControl)" to "EndGlobalSection"
    // from the Visual Studio .sln files, which are passed to it on the PowerShell command line.
    // This is a part of the process of migrating TFS/TFVC projects to Git repos.
    private static void Main(string[] args)
    {
        Console.WriteLine($"args.Length == {args.Length}");

        string s;

        // Is this app being fed data on the PowerShell command line, or is it being redirected data using a PowerShell pipe operator (|)?
        if (args.Length == 0)
        {
            // Data is being redirected using PowerShell pipe operator
            while ((s = Console.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
        else
        {
            // Data is coming from the command line as arguments on the command line
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
        }
    }
}