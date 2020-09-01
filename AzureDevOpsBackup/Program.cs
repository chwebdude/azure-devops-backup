using System;
using AzureDevOpsBackup.Backuper;
using AzureDevOpsBackup.Models;
using CommandLine;
using Type = AzureDevOpsBackup.Models.Type;

namespace AzureDevOpsBackup
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o =>
                {
                    switch (o.Mode)
                    {
                        case Mode.Backup:
                            switch (o.Type)
                            {
                                case Type.Repository:
                                    ZipBackuper.ZipDownload(o.Token, o.Organization, o.OutDir, o.Unzip);
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException();
                            }
                            break;
                        case Mode.Recover:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                });
            
        }
    }
}