using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Rxalert
    {
        public long RxAlertNum { get; set; }
        public long RxDefNum { get; set; }
        public long DiseaseDefNum { get; set; }
        public long AllergyDefNum { get; set; }
        public long MedicationNum { get; set; }
        public string NotificationMsg { get; set; }
        public sbyte IsHighSignificance { get; set; }
    }
}
