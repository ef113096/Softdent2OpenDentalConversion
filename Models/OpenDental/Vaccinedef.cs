using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Vaccinedef
    {
        public long VaccineDefNum { get; set; }
        public string Cvxcode { get; set; }
        public string VaccineName { get; set; }
        public long DrugManufacturerNum { get; set; }
    }
}
