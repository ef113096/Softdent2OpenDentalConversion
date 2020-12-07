using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Emailaddress
    {
        public long EmailAddressNum { get; set; }
        public string Smtpserver { get; set; }
        public string EmailUsername { get; set; }
        public string EmailPassword { get; set; }
        public int ServerPort { get; set; }
        public sbyte UseSsl { get; set; }
        public string SenderAddress { get; set; }
        public string Pop3ServerIncoming { get; set; }
        public int ServerPortIncoming { get; set; }
        public long UserNum { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
