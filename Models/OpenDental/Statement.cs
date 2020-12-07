using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Statement
    {
        public long StatementNum { get; set; }
        public long PatNum { get; set; }
        public DateTime DateSent { get; set; }
        public DateTime DateRangeFrom { get; set; }
        public DateTime DateRangeTo { get; set; }
        public string Note { get; set; }
        public string NoteBold { get; set; }
        public byte Mode { get; set; }
        public bool HidePayment { get; set; }
        public bool SinglePatient { get; set; }
        public bool Intermingled { get; set; }
        public bool IsSent { get; set; }
        public long DocNum { get; set; }
        public DateTime DateTstamp { get; set; }
        public sbyte IsReceipt { get; set; }
        public sbyte IsInvoice { get; set; }
        public sbyte IsInvoiceCopy { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public long SuperFamily { get; set; }
        public sbyte IsBalValid { get; set; }
        public double InsEst { get; set; }
        public double BalTotal { get; set; }
        public string StatementType { get; set; }
        public string ShortGuid { get; set; }
        public string StatementShortUrl { get; set; }
        public string StatementUrl { get; set; }
        public sbyte SmsSendStatus { get; set; }
    }
}
