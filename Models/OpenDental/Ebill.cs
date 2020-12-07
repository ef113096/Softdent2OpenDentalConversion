using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ebill
    {
        public long EbillNum { get; set; }
        public long ClinicNum { get; set; }
        public string ClientAcctNumber { get; set; }
        public string ElectUserName { get; set; }
        public string ElectPassword { get; set; }
        public sbyte PracticeAddress { get; set; }
        public sbyte RemitAddress { get; set; }
    }
}
