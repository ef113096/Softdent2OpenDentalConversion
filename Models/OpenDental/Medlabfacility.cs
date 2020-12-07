using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Medlabfacility
    {
        public long MedLabFacilityNum { get; set; }
        public string FacilityName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string DirectorTitle { get; set; }
        public string DirectorLname { get; set; }
        public string DirectorFname { get; set; }
    }
}
