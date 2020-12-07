using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Etran
    {
        public long EtransNum { get; set; }
        public DateTime DateTimeTrans { get; set; }
        public long ClearingHouseNum { get; set; }
        public byte Etype { get; set; }
        public long ClaimNum { get; set; }
        public int OfficeSequenceNumber { get; set; }
        public int CarrierTransCounter { get; set; }
        public int CarrierTransCounter2 { get; set; }
        public long CarrierNum { get; set; }
        public long CarrierNum2 { get; set; }
        public long PatNum { get; set; }
        public int BatchNumber { get; set; }
        public string AckCode { get; set; }
        public int TransSetNum { get; set; }
        public string Note { get; set; }
        public long EtransMessageTextNum { get; set; }
        public long AckEtransNum { get; set; }
        public long PlanNum { get; set; }
        public long InsSubNum { get; set; }
        public string TranSetId835 { get; set; }
        public string CarrierNameRaw { get; set; }
        public string PatientNameRaw { get; set; }
        public long UserNum { get; set; }
    }
}
