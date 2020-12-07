using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Phonenumber
    {
        public long PhoneNumberNum { get; set; }
        public long PatNum { get; set; }
        public string PhoneNumberVal { get; set; }
        public string PhoneNumberDigits { get; set; }
        public sbyte PhoneType { get; set; }
    }
}
