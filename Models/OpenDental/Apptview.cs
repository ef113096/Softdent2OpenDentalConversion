using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Apptview
    {
        public long ApptViewNum { get; set; }
        public string Description { get; set; }
        public ushort ItemOrder { get; set; }
        public byte RowsPerIncr { get; set; }
        public byte OnlyScheduledProvs { get; set; }
        public TimeSpan OnlySchedBeforeTime { get; set; }
        public TimeSpan OnlySchedAfterTime { get; set; }
        public sbyte StackBehavUr { get; set; }
        public sbyte StackBehavLr { get; set; }
        public long ClinicNum { get; set; }
        public TimeSpan ApptTimeScrollStart { get; set; }
        public sbyte IsScrollStartDynamic { get; set; }
        public sbyte IsApptBubblesDisabled { get; set; }
        public ushort WidthOpMinimum { get; set; }
    }
}
