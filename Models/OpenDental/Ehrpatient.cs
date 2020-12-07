using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrpatient
    {
        public long PatNum { get; set; }
        public string MotherMaidenFname { get; set; }
        public string MotherMaidenLname { get; set; }
        public sbyte VacShareOk { get; set; }
        public string MedicaidState { get; set; }
        public string SexualOrientation { get; set; }
        public string GenderIdentity { get; set; }
        public string SexualOrientationNote { get; set; }
        public string GenderIdentityNote { get; set; }
    }
}
