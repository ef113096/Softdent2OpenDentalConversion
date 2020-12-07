using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Contact
    {
        public long ContactNum { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string WkPhone { get; set; }
        public string Fax { get; set; }
        public long Category { get; set; }
        public string Notes { get; set; }
    }
}
