using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Terminalactive
    {
        public long TerminalActiveNum { get; set; }
        public string ComputerName { get; set; }
        public byte TerminalStatus { get; set; }
        public long PatNum { get; set; }
        public int SessionId { get; set; }
        public int ProcessId { get; set; }
        public string SessionName { get; set; }
    }
}
