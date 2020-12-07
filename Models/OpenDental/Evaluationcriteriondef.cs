using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Evaluationcriteriondef
    {
        public long EvaluationCriterionDefNum { get; set; }
        public long EvaluationDefNum { get; set; }
        public string CriterionDescript { get; set; }
        public sbyte IsCategoryName { get; set; }
        public long GradingScaleNum { get; set; }
        public int ItemOrder { get; set; }
        public float MaxPointsPoss { get; set; }
    }
}
