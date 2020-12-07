using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Insplan
    {
        public long PlanNum { get; set; }
        public string GroupName { get; set; }
        public string GroupNum { get; set; }
        public string PlanNote { get; set; }
        public long FeeSched { get; set; }
        public string PlanType { get; set; }
        public long ClaimFormNum { get; set; }
        public byte UseAltCode { get; set; }
        public byte ClaimsUseUcr { get; set; }
        public long CopayFeeSched { get; set; }
        public long EmployerNum { get; set; }
        public long CarrierNum { get; set; }
        public long AllowedFeeSched { get; set; }
        public string TrojanId { get; set; }
        public string DivisionNo { get; set; }
        public byte IsMedical { get; set; }
        public long FilingCode { get; set; }
        public byte DentaideCardSequence { get; set; }
        public bool ShowBaseUnits { get; set; }
        public bool CodeSubstNone { get; set; }
        public sbyte IsHidden { get; set; }
        public sbyte MonthRenew { get; set; }
        public long FilingCodeSubtype { get; set; }
        public string CanadianPlanFlag { get; set; }
        public string CanadianDiagnosticCode { get; set; }
        public string CanadianInstitutionCode { get; set; }
        public string RxBin { get; set; }
        public sbyte CobRule { get; set; }
        public string SopCode { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
        public sbyte HideFromVerifyList { get; set; }
        public sbyte OrthoType { get; set; }
        public sbyte OrthoAutoProcFreq { get; set; }
        public long OrthoAutoProcCodeNumOverride { get; set; }
        public double OrthoAutoFeeBilled { get; set; }
        public int OrthoAutoClaimDaysWait { get; set; }
        public long BillingType { get; set; }
        public sbyte HasPpoSubstWriteoffs { get; set; }
        public sbyte ExclusionFeeRule { get; set; }
    }
}
