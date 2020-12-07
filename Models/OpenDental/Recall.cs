using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Recall
    {
        public long RecallNum { get; set; }
        public long PatNum { get; set; }
        public DateTime DateDueCalc { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DatePrevious { get; set; }
        public int RecallInterval { get; set; }
        public long RecallStatus { get; set; }
        public string Note { get; set; }
        public byte IsDisabled { get; set; }
        public DateTime DateTstamp { get; set; }
        public long RecallTypeNum { get; set; }
        public double DisableUntilBalance { get; set; }
        public DateTime DisableUntilDate { get; set; }
        public DateTime DateScheduled { get; set; }
        public sbyte Priority { get; set; }
    }
}
