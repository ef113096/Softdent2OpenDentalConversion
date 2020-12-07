using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Emailmessage
    {
        public long EmailMessageNum { get; set; }
        public long PatNum { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }
        public string BodyText { get; set; }
        public DateTime MsgDateTime { get; set; }
        public byte SentOrReceived { get; set; }
        public string RecipientAddress { get; set; }
        public string RawEmailIn { get; set; }
        public long ProvNumWebMail { get; set; }
        public long PatNumSubj { get; set; }
        public string CcAddress { get; set; }
        public string BccAddress { get; set; }
        public sbyte HideIn { get; set; }
        public long AptNum { get; set; }
        public long UserNum { get; set; }
        public sbyte HtmlType { get; set; }
        public DateTime SecDateTentry { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
