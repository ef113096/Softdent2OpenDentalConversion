using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Computer
    {
        public long ComputerNum { get; set; }
        public string CompName { get; set; }
        public DateTime LastHeartBeat { get; set; }
    }
}
