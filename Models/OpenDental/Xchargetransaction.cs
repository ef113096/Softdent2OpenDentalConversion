using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Xchargetransaction
    {
        public long XchargeTransactionNum { get; set; }
        public string TransType { get; set; }
        public double Amount { get; set; }
        public string Ccentry { get; set; }
        public long PatNum { get; set; }
        public string Result { get; set; }
        public string ClerkId { get; set; }
        public string ResultCode { get; set; }
        public string Expiration { get; set; }
        public string Cctype { get; set; }
        public string CreditCardNum { get; set; }
        public string BatchNum { get; set; }
        public string ItemNum { get; set; }
        public string ApprCode { get; set; }
        public DateTime TransactionDateTime { get; set; }
    }
}
