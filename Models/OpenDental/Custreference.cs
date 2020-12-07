using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Custreference
    {
        public long CustReferenceNum { get; set; }
        public long PatNum { get; set; }
        public DateTime DateMostRecent { get; set; }
        public string Note { get; set; }
        public sbyte IsBadRef { get; set; }
    }
}
