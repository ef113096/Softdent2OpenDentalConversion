using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Site
    {
        public long SiteNum { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public long ProvNum { get; set; }
        public sbyte PlaceService { get; set; }
    }
}
