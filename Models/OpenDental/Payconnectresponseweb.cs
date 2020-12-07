using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Payconnectresponseweb
    {
        public long PayConnectResponseWebNum { get; set; }
        public long PatNum { get; set; }
        public long PayNum { get; set; }
        public string AccountToken { get; set; }
        public string PaymentToken { get; set; }
        public string ProcessingStatus { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public DateTime DateTimePending { get; set; }
        public DateTime DateTimeCompleted { get; set; }
        public DateTime DateTimeExpired { get; set; }
        public DateTime DateTimeLastError { get; set; }
        public string LastResponseStr { get; set; }
        public sbyte Ccsource { get; set; }
        public double Amount { get; set; }
        public string PayNote { get; set; }
        public sbyte IsTokenSaved { get; set; }
        public string PayToken { get; set; }
        public string ExpDateToken { get; set; }
        public string RefNumber { get; set; }
        public string TransType { get; set; }
    }
}
