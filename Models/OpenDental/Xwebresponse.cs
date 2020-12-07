using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Xwebresponse
    {
        public long XwebResponseNum { get; set; }
        public long PatNum { get; set; }
        public long ProvNum { get; set; }
        public long ClinicNum { get; set; }
        public long PaymentNum { get; set; }
        public DateTime DateTentry { get; set; }
        public DateTime DateTupdate { get; set; }
        public sbyte TransactionStatus { get; set; }
        public int ResponseCode { get; set; }
        public string XwebResponseCode { get; set; }
        public string ResponseDescription { get; set; }
        public string Otk { get; set; }
        public string HpfUrl { get; set; }
        public DateTime HpfExpiration { get; set; }
        public string TransactionId { get; set; }
        public string TransactionType { get; set; }
        public string Alias { get; set; }
        public string CardType { get; set; }
        public string CardBrand { get; set; }
        public string CardBrandShort { get; set; }
        public string MaskedAcctNum { get; set; }
        public double Amount { get; set; }
        public string ApprovalCode { get; set; }
        public string CardCodeResponse { get; set; }
        public int ReceiptId { get; set; }
        public string ExpDate { get; set; }
        public string EntryMethod { get; set; }
        public string ProcessorResponse { get; set; }
        public int BatchNum { get; set; }
        public double BatchAmount { get; set; }
        public DateTime AccountExpirationDate { get; set; }
        public string DebugError { get; set; }
        public string PayNote { get; set; }
        public sbyte Ccsource { get; set; }
        public string OrderId { get; set; }
    }
}
