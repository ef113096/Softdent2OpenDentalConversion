using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Automation
    {
        public long AutomationNum { get; set; }
        public string Description { get; set; }
        public sbyte Autotrigger { get; set; }
        public string ProcCodes { get; set; }
        public sbyte AutoAction { get; set; }
        public long SheetDefNum { get; set; }
        public long CommType { get; set; }
        public string MessageContent { get; set; }
        public sbyte AptStatus { get; set; }
        public long AppointmentTypeNum { get; set; }
        public sbyte PatStatus { get; set; }
    }
}
