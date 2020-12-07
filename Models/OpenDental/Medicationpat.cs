using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Medicationpat
    {
        public long MedicationPatNum { get; set; }
        public long PatNum { get; set; }
        public long MedicationNum { get; set; }
        public string PatNote { get; set; }
        public DateTime DateTstamp { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateStop { get; set; }
        public long ProvNum { get; set; }
        public string MedDescript { get; set; }
        public long RxCui { get; set; }
        public string ErxGuid { get; set; }
        public sbyte IsCpoe { get; set; }
    }
}
