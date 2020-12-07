using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Anesthscore
    {
        public int AnesthScoreNum { get; set; }
        public int? AnestheticRecordNum { get; set; }
        public short? Qactivity { get; set; }
        public short? Qresp { get; set; }
        public short? Qcirc { get; set; }
        public short? Qconc { get; set; }
        public short? Qcolor { get; set; }
        public short? AnesthesiaScore { get; set; }
        public bool? DischAmb { get; set; }
        public bool? DischWheelChr { get; set; }
        public bool? DischAmbulance { get; set; }
        public bool? DischCondStable { get; set; }
        public bool? DischCondUnStable { get; set; }
    }
}
