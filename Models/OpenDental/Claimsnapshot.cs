using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Claimsnapshot
    {
        public long ClaimSnapshotNum { get; set; }
        public long ProcNum { get; set; }
        public string ClaimType { get; set; }
        public double Writeoff { get; set; }
        public double InsPayEst { get; set; }
        public double Fee { get; set; }
        public DateTime DateTentry { get; set; }
        public long ClaimProcNum { get; set; }
        public sbyte SnapshotTrigger { get; set; }
    }
}
