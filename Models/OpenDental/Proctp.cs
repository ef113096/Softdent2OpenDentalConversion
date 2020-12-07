using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Proctp
    {
        public long ProcTpnum { get; set; }
        public long TreatPlanNum { get; set; }
        public long PatNum { get; set; }
        public long ProcNumOrig { get; set; }
        public ushort ItemOrder { get; set; }
        public long Priority { get; set; }
        public string ToothNumTp { get; set; }
        public string Surf { get; set; }
        public string ProcCode { get; set; }
        public string Descript { get; set; }
        public double FeeAmt { get; set; }
        public double PriInsAmt { get; set; }
        public double SecInsAmt { get; set; }
        public double PatAmt { get; set; }
        public double Discount { get; set; }
        public string Prognosis { get; set; }
        public string Dx { get; set; }
        public string ProcAbbr { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
        public double FeeAllowed { get; set; }
        public double TaxAmt { get; set; }
        public long ProvNum { get; set; }
        public DateTime DateTp { get; set; }
        public long ClinicNum { get; set; }
        public double CatPercUcr { get; set; }
    }
}
