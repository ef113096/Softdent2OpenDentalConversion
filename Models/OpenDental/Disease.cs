using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Disease
    {
        public long DiseaseNum { get; set; }
        public long PatNum { get; set; }
        public long DiseaseDefNum { get; set; }
        public string PatNote { get; set; }
        public DateTime DateTstamp { get; set; }
        public sbyte ProbStatus { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateStop { get; set; }
        public string SnomedProblemType { get; set; }
        public sbyte FunctionStatus { get; set; }
    }
}
