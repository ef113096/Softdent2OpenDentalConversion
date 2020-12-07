using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Databasemaintenance
    {
        public long DatabaseMaintenanceNum { get; set; }
        public string MethodName { get; set; }
        public sbyte IsHidden { get; set; }
        public sbyte IsOld { get; set; }
        public DateTime DateLastRun { get; set; }
    }
}
