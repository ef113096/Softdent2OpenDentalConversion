using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Procedurelog
    {
        public long ProcNum { get; set; }
        public long PatNum { get; set; }
        public long AptNum { get; set; }
        public string OldCode { get; set; }
        public DateTime ProcDate { get; set; }
        public double ProcFee { get; set; }
        public string Surf { get; set; }
        public string ToothNum { get; set; }
        public string ToothRange { get; set; }
        public long Priority { get; set; }
        public byte ProcStatus { get; set; }
        public long ProvNum { get; set; }
        public long Dx { get; set; }
        public long PlannedAptNum { get; set; }
        public byte PlaceService { get; set; }
        public string Prosthesis { get; set; }
        public DateTime DateOriginalProsth { get; set; }
        public string ClaimNote { get; set; }
        public DateTime DateEntryC { get; set; }
        public long ClinicNum { get; set; }
        public string MedicalCode { get; set; }
        public string DiagnosticCode { get; set; }
        public byte IsPrincDiag { get; set; }
        public long ProcNumLab { get; set; }
        public long BillingTypeOne { get; set; }
        public long BillingTypeTwo { get; set; }
        public long CodeNum { get; set; }
        public string CodeMod1 { get; set; }
        public string CodeMod2 { get; set; }
        public string CodeMod3 { get; set; }
        public string CodeMod4 { get; set; }
        public string RevCode { get; set; }
        public int UnitQty { get; set; }
        public int BaseUnits { get; set; }
        public int StartTime { get; set; }
        public int StopTime { get; set; }
        public DateTime DateTp { get; set; }
        public long SiteNum { get; set; }
        public sbyte HideGraphics { get; set; }
        public string CanadianTypeCodes { get; set; }
        public TimeSpan ProcTime { get; set; }
        public TimeSpan ProcTimeEnd { get; set; }
        public DateTime DateTstamp { get; set; }
        public long Prognosis { get; set; }
        public sbyte DrugUnit { get; set; }
        public float DrugQty { get; set; }
        public sbyte UnitQtyType { get; set; }
        public long StatementNum { get; set; }
        public sbyte IsLocked { get; set; }
        public string BillingNote { get; set; }
        public long RepeatChargeNum { get; set; }
        public string SnomedBodySite { get; set; }
        public string DiagnosticCode2 { get; set; }
        public string DiagnosticCode3 { get; set; }
        public string DiagnosticCode4 { get; set; }
        public long ProvOrderOverride { get; set; }
        public double Discount { get; set; }
        public sbyte IsDateProsthEst { get; set; }
        public byte IcdVersion { get; set; }
        public sbyte IsCpoe { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateEntry { get; set; }
        public DateTime DateComplete { get; set; }
        public long OrderingReferralNum { get; set; }
        public double TaxAmt { get; set; }
        public sbyte Urgency { get; set; }
    }
}
