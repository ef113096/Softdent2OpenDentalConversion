using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Securitylog
    {
        public long SecurityLogNum { get; set; }
        public byte PermType { get; set; }
        public long UserNum { get; set; }
        public DateTime LogDateTime { get; set; }
        public string LogText { get; set; }
        public long PatNum { get; set; }
        public string CompName { get; set; }
        public long Fkey { get; set; }
        public sbyte LogSource { get; set; }
        public long DefNum { get; set; }
        public long DefNumError { get; set; }
        public DateTime DateTprevious { get; set; }
    }
}
