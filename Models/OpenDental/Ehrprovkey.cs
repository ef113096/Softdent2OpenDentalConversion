using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrprovkey
    {
        public long EhrProvKeyNum { get; set; }
        public long PatNum { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string ProvKey { get; set; }
        public float FullTimeEquiv { get; set; }
        public string Notes { get; set; }
        public int YearValue { get; set; }
    }
}
