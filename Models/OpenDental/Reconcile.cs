using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Reconcile
    {
        public long ReconcileNum { get; set; }
        public long AccountNum { get; set; }
        public double StartingBal { get; set; }
        public double EndingBal { get; set; }
        public DateTime DateReconcile { get; set; }
        public byte IsLocked { get; set; }
    }
}
