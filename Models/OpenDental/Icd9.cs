using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Icd9
    {
        public long Icd9num { get; set; }
        public string Icd9code { get; set; }
        public string Description { get; set; }
        public DateTime DateTstamp { get; set; }
    }
}
