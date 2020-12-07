using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Orthochart
    {
        public long OrthoChartNum { get; set; }
        public long PatNum { get; set; }
        public DateTime DateService { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public long UserNum { get; set; }
    }
}
