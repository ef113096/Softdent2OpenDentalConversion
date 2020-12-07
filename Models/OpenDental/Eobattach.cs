using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Eobattach
    {
        public long EobAttachNum { get; set; }
        public long ClaimPaymentNum { get; set; }
        public DateTime DateTcreated { get; set; }
        public string FileName { get; set; }
        public string RawBase64 { get; set; }
    }
}
