using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Creditcard
    {
        public long CreditCardNum { get; set; }
        public long PatNum { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string XchargeToken { get; set; }
        public string CcnumberMasked { get; set; }
        public DateTime Ccexpiration { get; set; }
        public int ItemOrder { get; set; }
        public double ChargeAmt { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateStop { get; set; }
        public string Note { get; set; }
        public long PayPlanNum { get; set; }
        public string PayConnectToken { get; set; }
        public DateTime PayConnectTokenExp { get; set; }
        public string Procedures { get; set; }
        public sbyte Ccsource { get; set; }
        public long ClinicNum { get; set; }
        public sbyte ExcludeProcSync { get; set; }
        public string PaySimpleToken { get; set; }
        public string ChargeFrequency { get; set; }
        public sbyte CanChargeWhenNoBal { get; set; }
        public long PaymentType { get; set; }
    }
}
