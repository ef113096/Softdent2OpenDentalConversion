using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Evaluation
    {
        public long EvaluationNum { get; set; }
        public long InstructNum { get; set; }
        public long StudentNum { get; set; }
        public long SchoolCourseNum { get; set; }
        public string EvalTitle { get; set; }
        public DateTime DateEval { get; set; }
        public long GradingScaleNum { get; set; }
        public string OverallGradeShowing { get; set; }
        public float OverallGradeNumber { get; set; }
        public string Notes { get; set; }
    }
}
