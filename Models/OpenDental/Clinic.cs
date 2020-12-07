using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Clinic
    {
        public long ClinicNum { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string BankNumber { get; set; }
        public byte DefaultPlaceService { get; set; }
        public long InsBillingProv { get; set; }
        public string Fax { get; set; }
        public long EmailAddressNum { get; set; }
        public long DefaultProv { get; set; }
        public DateTime SmsContractDate { get; set; }
        public double SmsMonthlyLimit { get; set; }
        public sbyte IsMedicalOnly { get; set; }
        public string BillingAddress { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZip { get; set; }
        public string PayToAddress { get; set; }
        public string PayToAddress2 { get; set; }
        public string PayToCity { get; set; }
        public string PayToState { get; set; }
        public string PayToZip { get; set; }
        public sbyte UseBillAddrOnClaims { get; set; }
        public long Region { get; set; }
        public int ItemOrder { get; set; }
        public sbyte IsInsVerifyExcluded { get; set; }
        public string Abbr { get; set; }
        public string MedLabAccountNum { get; set; }
        public sbyte IsConfirmEnabled { get; set; }
        public sbyte IsConfirmDefault { get; set; }
        public sbyte IsNewPatApptExcluded { get; set; }
        public sbyte IsHidden { get; set; }
        public long ExternalId { get; set; }
        public string SchedNote { get; set; }
        public sbyte HasProcOnRx { get; set; }
    }
}
