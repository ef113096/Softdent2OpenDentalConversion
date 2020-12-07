using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Dashboardcell
    {
        public long DashboardCellNum { get; set; }
        public long DashboardLayoutNum { get; set; }
        public int CellRow { get; set; }
        public int CellColumn { get; set; }
        public string CellType { get; set; }
        public string CellSettings { get; set; }
        public DateTime LastQueryTime { get; set; }
        public string LastQueryData { get; set; }
        public int RefreshRateSeconds { get; set; }
    }
}
