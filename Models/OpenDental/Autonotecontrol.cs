using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Autonotecontrol
    {
        public long AutoNoteControlNum { get; set; }
        public string Descript { get; set; }
        public string ControlType { get; set; }
        public string ControlLabel { get; set; }
        public string ControlOptions { get; set; }
    }
}
