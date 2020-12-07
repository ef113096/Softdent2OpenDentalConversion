using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Loginattempt
    {
        public long LoginAttemptNum { get; set; }
        public string UserName { get; set; }
        public sbyte LoginType { get; set; }
        public DateTime DateTfail { get; set; }
    }
}
