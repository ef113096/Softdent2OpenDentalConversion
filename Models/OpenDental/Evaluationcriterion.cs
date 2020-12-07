using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Evaluationcriterion
    {
        public long EvaluationCriterionNum { get; set; }
        public long EvaluationNum { get; set; }
        public string CriterionDescript { get; set; }
        public sbyte IsCategoryName { get; set; }
        public long GradingScaleNum { get; set; }
        public string GradeShowing { get; set; }
        public float GradeNumber { get; set; }
        public string Notes { get; set; }
        public int ItemOrder { get; set; }
        public float MaxPointsPoss { get; set; }
    }
}
