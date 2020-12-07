using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Hl7msg
    {
        public long Hl7msgNum { get; set; }
        public int Hl7status { get; set; }
        public string MsgText { get; set; }
        public long AptNum { get; set; }
        public DateTime DateTstamp { get; set; }
        public long PatNum { get; set; }
        public string Note { get; set; }
    }
}
