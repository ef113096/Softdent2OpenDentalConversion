using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Labpanel
    {
        public long LabPanelNum { get; set; }
        public long PatNum { get; set; }
        public string RawMessage { get; set; }
        public string LabNameAddress { get; set; }
        public DateTime DateTstamp { get; set; }
        public string SpecimenCondition { get; set; }
        public string SpecimenSource { get; set; }
        public string ServiceId { get; set; }
        public string ServiceName { get; set; }
        public long MedicalOrderNum { get; set; }
    }
}
