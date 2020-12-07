using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Pharmacy
    {
        public long PharmacyNum { get; set; }
        public string PharmId { get; set; }
        public string StoreName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Note { get; set; }
        public DateTime DateTstamp { get; set; }
    }
}
