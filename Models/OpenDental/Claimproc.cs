using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Claimproc
    {
        public long ClaimProcNum { get; set; }
        public long ProcNum { get; set; }
        public long ClaimNum { get; set; }
        public long PatNum { get; set; }
        public long ProvNum { get; set; }
        public double FeeBilled { get; set; }
        public double InsPayEst { get; set; }
        public double DedApplied { get; set; }
        public byte Status { get; set; }
        public double InsPayAmt { get; set; }
        public string Remarks { get; set; }
        public long ClaimPaymentNum { get; set; }
        public long PlanNum { get; set; }
        public DateTime DateCp { get; set; }
        public double WriteOff { get; set; }
        public string CodeSent { get; set; }
        public double AllowedOverride { get; set; }
        public sbyte Percentage { get; set; }
        public sbyte PercentOverride { get; set; }
        public double CopayAmt { get; set; }
        public byte NoBillIns { get; set; }
        public double PaidOtherIns { get; set; }
        public double BaseEst { get; set; }
        public double CopayOverride { get; set; }
        public DateTime ProcDate { get; set; }
        public DateTime DateEntry { get; set; }
        public byte LineNumber { get; set; }
        public double DedEst { get; set; }
        public double DedEstOverride { get; set; }
        public double InsEstTotal { get; set; }
        public double InsEstTotalOverride { get; set; }
        public double PaidOtherInsOverride { get; set; }
        public string EstimateNote { get; set; }
        public double WriteOffEst { get; set; }
        public double WriteOffEstOverride { get; set; }
        public long ClinicNum { get; set; }
        public long InsSubNum { get; set; }
        public int PaymentRow { get; set; }
        public long PayPlanNum { get; set; }
        public long ClaimPaymentTracking { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
        public DateTime DateSuppReceived { get; set; }
        public DateTime DateInsFinalized { get; set; }
        public sbyte IsTransfer { get; set; }
    }
}
