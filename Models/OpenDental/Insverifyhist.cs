using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Insverifyhist
    {
        public long InsVerifyHistNum { get; set; }
        public long InsVerifyNum { get; set; }
        public DateTime DateLastVerified { get; set; }
        public long UserNum { get; set; }
        public sbyte VerifyType { get; set; }
        public long Fkey { get; set; }
        public long DefNum { get; set; }
        public string Note { get; set; }
        public DateTime DateLastAssigned { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public double HoursAvailableForVerification { get; set; }
        public long VerifyUserNum { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
