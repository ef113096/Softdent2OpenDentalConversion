using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Replicationserver
    {
        public long ReplicationServerNum { get; set; }
        public string Descript { get; set; }
        public uint ServerId { get; set; }
        public long RangeStart { get; set; }
        public long RangeEnd { get; set; }
        public string AtoZpath { get; set; }
        public sbyte UpdateBlocked { get; set; }
        public string SlaveMonitor { get; set; }
    }
}
