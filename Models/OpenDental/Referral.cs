using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Referral
    {
        public long ReferralNum { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Ssn { get; set; }
        public byte UsingTin { get; set; }
        public long Specialty { get; set; }
        public string St { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Note { get; set; }
        public string Phone2 { get; set; }
        public byte IsHidden { get; set; }
        public byte NotPerson { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public long PatNum { get; set; }
        public string NationalProvId { get; set; }
        public long Slip { get; set; }
        public sbyte IsDoctor { get; set; }
        public sbyte IsTrustedDirect { get; set; }
        public DateTime DateTstamp { get; set; }
        public sbyte IsPreferred { get; set; }
    }
}
