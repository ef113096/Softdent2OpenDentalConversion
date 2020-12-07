using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Procedurecode
    {
        public long CodeNum { get; set; }
        public string ProcCode { get; set; }
        public string Descript { get; set; }
        public string AbbrDesc { get; set; }
        public string ProcTime { get; set; }
        public long ProcCat { get; set; }
        public byte TreatArea { get; set; }
        public byte NoBillIns { get; set; }
        public byte IsProsth { get; set; }
        public string DefaultNote { get; set; }
        public byte IsHygiene { get; set; }
        public ushort GtypeNum { get; set; }
        public string AlternateCode1 { get; set; }
        public string MedicalCode { get; set; }
        public byte IsTaxed { get; set; }
        public sbyte PaintType { get; set; }
        public int GraphicColor { get; set; }
        public string LaymanTerm { get; set; }
        public byte IsCanadianLab { get; set; }
        public bool PreExisting { get; set; }
        public int BaseUnits { get; set; }
        public string SubstitutionCode { get; set; }
        public int SubstOnlyIf { get; set; }
        public DateTime DateTstamp { get; set; }
        public sbyte IsMultiVisit { get; set; }
        public string DrugNdc { get; set; }
        public string RevenueCodeDefault { get; set; }
        public long ProvNumDefault { get; set; }
        public double CanadaTimeUnits { get; set; }
        public sbyte IsRadiology { get; set; }
        public string DefaultClaimNote { get; set; }
        public string DefaultTpnote { get; set; }
        public sbyte BypassGlobalLock { get; set; }
        public string TaxCode { get; set; }
    }
}
