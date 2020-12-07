using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Perioexam
    {
        public long PerioExamNum { get; set; }
        public long PatNum { get; set; }
        public DateTime ExamDate { get; set; }
        public long ProvNum { get; set; }
        public DateTime DateTmeasureEdit { get; set; }
    }
}
