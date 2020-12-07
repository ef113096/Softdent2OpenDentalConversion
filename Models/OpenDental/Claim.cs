using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Claim
    {
        public long ClaimNum { get; set; }
        public long PatNum { get; set; }
        public DateTime DateService { get; set; }
        public DateTime DateSent { get; set; }
        public string ClaimStatus { get; set; }
        public DateTime DateReceived { get; set; }
        public long PlanNum { get; set; }
        public long ProvTreat { get; set; }
        public double ClaimFee { get; set; }
        public double InsPayEst { get; set; }
        public double InsPayAmt { get; set; }
        public double DedApplied { get; set; }
        public string PreAuthString { get; set; }
        public string IsProsthesis { get; set; }
        public DateTime PriorDate { get; set; }
        public string ReasonUnderPaid { get; set; }
        public string ClaimNote { get; set; }
        public string ClaimType { get; set; }
        public long ProvBill { get; set; }
        public long ReferringProv { get; set; }
        public string RefNumString { get; set; }
        public byte PlaceService { get; set; }
        public string AccidentRelated { get; set; }
        public DateTime AccidentDate { get; set; }
        public string AccidentSt { get; set; }
        public byte EmployRelated { get; set; }
        public byte IsOrtho { get; set; }
        public byte OrthoRemainM { get; set; }
        public DateTime OrthoDate { get; set; }
        public byte PatRelat { get; set; }
        public long PlanNum2 { get; set; }
        public byte PatRelat2 { get; set; }
        public double WriteOff { get; set; }
        public byte Radiographs { get; set; }
        public long ClinicNum { get; set; }
        public long ClaimForm { get; set; }
        public int AttachedImages { get; set; }
        public int AttachedModels { get; set; }
        public string AttachedFlags { get; set; }
        public string AttachmentId { get; set; }
        public string CanadianMaterialsForwarded { get; set; }
        public string CanadianReferralProviderNum { get; set; }
        public sbyte CanadianReferralReason { get; set; }
        public string CanadianIsInitialLower { get; set; }
        public DateTime CanadianDateInitialLower { get; set; }
        public sbyte CanadianMandProsthMaterial { get; set; }
        public string CanadianIsInitialUpper { get; set; }
        public DateTime CanadianDateInitialUpper { get; set; }
        public sbyte CanadianMaxProsthMaterial { get; set; }
        public long InsSubNum { get; set; }
        public long InsSubNum2 { get; set; }
        public string CanadaTransRefNum { get; set; }
        public DateTime CanadaEstTreatStartDate { get; set; }
        public double CanadaInitialPayment { get; set; }
        public byte CanadaPaymentMode { get; set; }
        public byte CanadaTreatDuration { get; set; }
        public byte CanadaNumAnticipatedPayments { get; set; }
        public double CanadaAnticipatedPayAmount { get; set; }
        public string PriorAuthorizationNumber { get; set; }
        public sbyte SpecialProgramCode { get; set; }
        public string UniformBillType { get; set; }
        public sbyte MedType { get; set; }
        public string AdmissionTypeCode { get; set; }
        public string AdmissionSourceCode { get; set; }
        public string PatientStatusCode { get; set; }
        public long CustomTracking { get; set; }
        public DateTime DateResent { get; set; }
        public sbyte CorrectionType { get; set; }
        public string ClaimIdentifier { get; set; }
        public string OrigRefNum { get; set; }
        public long ProvOrderOverride { get; set; }
        public byte OrthoTotalM { get; set; }
        public double ShareOfCost { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
        public long OrderingReferralNum { get; set; }
        public DateTime DateSentOrig { get; set; }
        public DateTime DateIllnessInjuryPreg { get; set; }
        public short DateIllnessInjuryPregQualifier { get; set; }
        public DateTime DateOther { get; set; }
        public short DateOtherQualifier { get; set; }
        public sbyte IsOutsideLab { get; set; }
    }
}
