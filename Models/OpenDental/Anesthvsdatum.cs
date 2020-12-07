using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Anesthvsdatum
    {
        public int AnesthVsdataNum { get; set; }
        public int AnestheticRecordNum { get; set; }
        public int? PatNum { get; set; }
        public string Vsmname { get; set; }
        public string VsmserNum { get; set; }
        public short? Bpsys { get; set; }
        public short? Bpdias { get; set; }
        public short? Bpmap { get; set; }
        public short? Hr { get; set; }
        public short? SpO2 { get; set; }
        public short? EtCo2 { get; set; }
        public short? Temp { get; set; }
        public string VstimeStamp { get; set; }
        public string MessageId { get; set; }
        public string Hl7message { get; set; }
    }
}
