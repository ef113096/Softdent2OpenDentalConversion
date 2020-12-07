using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Dashboardar
    {
        public long DashboardArnum { get; set; }
        public DateTime DateCalc { get; set; }
        public double BalTotal { get; set; }
        public double InsEst { get; set; }
    }
}
