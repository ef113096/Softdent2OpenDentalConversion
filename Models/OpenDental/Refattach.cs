using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Refattach
    {
        public long RefAttachNum { get; set; }
        public long ReferralNum { get; set; }
        public long PatNum { get; set; }
        public ushort ItemOrder { get; set; }
        public DateTime RefDate { get; set; }
        public sbyte RefType { get; set; }
        public byte RefToStatus { get; set; }
        public string Note { get; set; }
        public sbyte IsTransitionOfCare { get; set; }
        public long ProcNum { get; set; }
        public DateTime DateProcComplete { get; set; }
        public long ProvNum { get; set; }
        public DateTime DateTstamp { get; set; }
    }
}
