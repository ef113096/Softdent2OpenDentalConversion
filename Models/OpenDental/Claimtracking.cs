using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Claimtracking
    {
        public long ClaimTrackingNum { get; set; }
        public long ClaimNum { get; set; }
        public string TrackingType { get; set; }
        public long UserNum { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public string Note { get; set; }
        public long TrackingDefNum { get; set; }
        public long TrackingErrorDefNum { get; set; }
    }
}
