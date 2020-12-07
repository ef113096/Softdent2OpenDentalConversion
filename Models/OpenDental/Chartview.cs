using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Chartview
    {
        public long ChartViewNum { get; set; }
        public string Description { get; set; }
        public int ItemOrder { get; set; }
        public sbyte ProcStatuses { get; set; }
        public short ObjectTypes { get; set; }
        public sbyte ShowProcNotes { get; set; }
        public sbyte IsAudit { get; set; }
        public sbyte SelectedTeethOnly { get; set; }
        public int OrionStatusFlags { get; set; }
        public sbyte DatesShowing { get; set; }
        public sbyte IsTpCharting { get; set; }
    }
}
