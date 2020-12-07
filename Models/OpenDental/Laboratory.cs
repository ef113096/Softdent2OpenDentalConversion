using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Laboratory
    {
        public long LaboratoryNum { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }
        public long Slip { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string WirelessPhone { get; set; }
        public sbyte IsHidden { get; set; }
    }
}
