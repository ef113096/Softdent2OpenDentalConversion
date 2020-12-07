using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Payortype
    {
        public long PayorTypeNum { get; set; }
        public long PatNum { get; set; }
        public DateTime DateStart { get; set; }
        public string SopCode { get; set; }
        public string Note { get; set; }
    }
}
