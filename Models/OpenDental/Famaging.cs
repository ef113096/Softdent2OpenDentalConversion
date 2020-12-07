using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Famaging
    {
        public long PatNum { get; set; }
        public double Bal030 { get; set; }
        public double Bal3160 { get; set; }
        public double Bal6190 { get; set; }
        public double BalOver90 { get; set; }
        public double InsEst { get; set; }
        public double BalTotal { get; set; }
        public double PayPlanDue { get; set; }
    }
}
