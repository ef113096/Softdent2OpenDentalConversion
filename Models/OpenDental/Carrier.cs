using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Carrier
    {
        public long CarrierNum { get; set; }
        public string CarrierName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string ElectId { get; set; }
        public byte NoSendElect { get; set; }
        public byte IsCda { get; set; }
        public string CdanetVersion { get; set; }
        public long CanadianNetworkNum { get; set; }
        public sbyte IsHidden { get; set; }
        public sbyte CanadianEncryptionMethod { get; set; }
        public int CanadianSupportedTypes { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
        public string Tin { get; set; }
        public long CarrierGroupName { get; set; }
        public int ApptTextBackColor { get; set; }
        public sbyte IsCoinsuranceInverted { get; set; }
        public sbyte TrustedEtransFlags { get; set; }
    }
}
