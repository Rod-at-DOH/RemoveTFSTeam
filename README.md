# RemoveTFSTeam
This console app is used to remove the TFS "Team" related data from the .sln files, which are passed to it on the command line. This expects to be run within a PowerShell command line.

## Addendum 7/27/2023
I will discontinue work on this project, because I've learned that it is no longer needed.

This project was meant to remove the TFS related code in Visual Studio's solution files, per Herbi's blog [Migrate From TFVC to Git - 5 Simple Streps](https://www.scrum-tips.com/agile/migrate-from-tfvc-to-git/).

The TFVC repo I've been working through, with 145 VS solution files, don't have any of that TFS code in them. Therefore, there's no point continuing work on this project.
