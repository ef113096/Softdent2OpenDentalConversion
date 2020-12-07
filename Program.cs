using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Softdent2OpenDentalConversion
{
    public class Program
    {
        public long ProgramNum { get; set; }
        public string ProgName { get; set; }
        public string ProgDesc { get; set; }
        public byte Enabled { get; set; }
        public string Path { get; set; }
        public string CommandLine { get; set; }
        public string Note { get; set; }
        public string PluginDllName { get; set; }
        public string ButtonImage { get; set; }
        public string FileTemplate { get; set; }
        public string FilePath { get; set; }


        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
