using CommandLine;

namespace AzureDevOpsBackup.Models
{
    class Options
    {
        [Option('t', "token", Required = true, HelpText = "The access token")]
        public string Token { get; set; }

        [Option('o', "organization", Required = true, HelpText = "Organization name, ex: fabrikam if your URI is https://dev.azure.com/fabrikam")]
        public string Organization { get; set; }

        [Option('d', "outdir", Required = true, HelpText = "Location where to save the downloaded data")]
        public string OutDir { get; set; }

        [Option('u', "unzip", Required = false, HelpText = "Extract downloaded data")]
        public bool Unzip { get; set; }

        [Option('m', "mode", Required = false, Default = Mode.Backup, HelpText = "Backup or recovery mode")]
        public Mode Mode { get; set; }

        [Option('t', "type", Required = false, Default = Type.Repository, HelpText = "What should be backuped or recovered")]
        public Type Type { get; set; }
    }
}
