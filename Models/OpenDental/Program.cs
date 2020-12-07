using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Program
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
    }
}
