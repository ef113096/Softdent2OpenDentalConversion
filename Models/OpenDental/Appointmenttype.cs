using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Appointmenttype
    {
        public long AppointmentTypeNum { get; set; }
        public string AppointmentTypeName { get; set; }
        public int AppointmentTypeColor { get; set; }
        public int ItemOrder { get; set; }
        public sbyte IsHidden { get; set; }
        public string Pattern { get; set; }
        public string CodeStr { get; set; }
    }
}
