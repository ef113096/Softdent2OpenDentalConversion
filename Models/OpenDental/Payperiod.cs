using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Payperiod
    {
        public long PayPeriodNum { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateStop { get; set; }
        public DateTime DatePaycheck { get; set; }
    }
}
