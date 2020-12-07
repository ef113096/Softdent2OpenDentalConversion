using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Stateabbr
    {
        public long StateAbbrNum { get; set; }
        public string Description { get; set; }
        public string Abbr { get; set; }
        public int MedicaidIdlength { get; set; }
    }
}
