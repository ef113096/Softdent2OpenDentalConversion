using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Commlog
    {
        public long CommlogNum { get; set; }
        public long PatNum { get; set; }
        public DateTime CommDateTime { get; set; }
        public long CommType { get; set; }
        public string Note { get; set; }
        public byte Mode { get; set; }
        public byte SentOrReceived { get; set; }
        public long UserNum { get; set; }
        public string Signature { get; set; }
        public sbyte SigIsTopaz { get; set; }
        public DateTime DateTstamp { get; set; }
        public DateTime DateTimeEnd { get; set; }
        public sbyte? CommSource { get; set; }
        public long ProgramNum { get; set; }
    }
}
