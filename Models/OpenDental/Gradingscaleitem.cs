using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Gradingscaleitem
    {
        public long GradingScaleItemNum { get; set; }
        public long GradingScaleNum { get; set; }
        public string GradeShowing { get; set; }
        public float GradeNumber { get; set; }
        public string Description { get; set; }
    }
}
