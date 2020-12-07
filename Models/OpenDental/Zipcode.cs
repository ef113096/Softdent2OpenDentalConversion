using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Zipcode
    {
        public long ZipCodeNum { get; set; }
        public string ZipCodeDigits { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public byte IsFrequent { get; set; }
    }
}
