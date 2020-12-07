using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Fhirsubscription
    {
        public long FhirsubscriptionNum { get; set; }
        public string Criteria { get; set; }
        public string Reason { get; set; }
        public sbyte SubStatus { get; set; }
        public string ErrorNote { get; set; }
        public sbyte ChannelType { get; set; }
        public string ChannelEndpoint { get; set; }
        public string ChannelPayLoad { get; set; }
        public string ChannelHeader { get; set; }
        public DateTime DateEnd { get; set; }
        public string ApikeyHash { get; set; }
    }
}
