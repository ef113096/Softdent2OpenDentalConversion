using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Evaluationdef
    {
        public long EvaluationDefNum { get; set; }
        public long SchoolCourseNum { get; set; }
        public string EvalTitle { get; set; }
        public long GradingScaleNum { get; set; }
    }
}
