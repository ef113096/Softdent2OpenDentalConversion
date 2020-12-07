using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Medication
    {
        public long MedicationNum { get; set; }
        public string MedName { get; set; }
        public long GenericNum { get; set; }
        public string Notes { get; set; }
        public DateTime DateTstamp { get; set; }
        public long RxCui { get; set; }
    }
}
