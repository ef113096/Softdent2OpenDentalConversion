using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.Softdent
{
    public partial class SdContact
    {
        public int Id { get; set; }
        public string DateMade { get; set; }
        public string MadeBy { get; set; }
        public string Type { get; set; }
        public string Regarding { get; set; }
        public string Notes { get; set; }
        public bool Converted { get; set; }
    }
}
