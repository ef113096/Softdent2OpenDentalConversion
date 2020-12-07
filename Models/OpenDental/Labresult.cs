using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Labresult
    {
        public long LabResultNum { get; set; }
        public long LabPanelNum { get; set; }
        public DateTime DateTimeTest { get; set; }
        public string TestName { get; set; }
        public DateTime DateTstamp { get; set; }
        public string TestId { get; set; }
        public string ObsValue { get; set; }
        public string ObsUnits { get; set; }
        public string ObsRange { get; set; }
        public sbyte AbnormalFlag { get; set; }
    }
}
