using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Hl7defmessage
    {
        public long Hl7defMessageNum { get; set; }
        public long Hl7defNum { get; set; }
        public string MessageType { get; set; }
        public string EventType { get; set; }
        public sbyte InOrOut { get; set; }
        public int ItemOrder { get; set; }
        public string Note { get; set; }
        public string MessageStructure { get; set; }
    }
}
