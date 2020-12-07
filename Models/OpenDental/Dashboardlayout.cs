using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Dashboardlayout
    {
        public long DashboardLayoutNum { get; set; }
        public long UserNum { get; set; }
        public long UserGroupNum { get; set; }
        public string DashboardTabName { get; set; }
        public int DashboardTabOrder { get; set; }
        public int DashboardRows { get; set; }
        public int DashboardColumns { get; set; }
        public string DashboardGroupName { get; set; }
    }
}
