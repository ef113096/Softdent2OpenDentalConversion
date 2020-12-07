using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Vitalsign
    {
        public long VitalsignNum { get; set; }
        public long PatNum { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public short BpSystolic { get; set; }
        public short BpDiastolic { get; set; }
        public DateTime DateTaken { get; set; }
        public sbyte HasFollowupPlan { get; set; }
        public sbyte IsIneligible { get; set; }
        public string Documentation { get; set; }
        public sbyte ChildGotNutrition { get; set; }
        public sbyte ChildGotPhysCouns { get; set; }
        public string WeightCode { get; set; }
        public string HeightExamCode { get; set; }
        public string WeightExamCode { get; set; }
        public string BmiexamCode { get; set; }
        public long EhrNotPerformedNum { get; set; }
        public long PregDiseaseNum { get; set; }
        public int Bmipercentile { get; set; }
        public int Pulse { get; set; }
    }
}
