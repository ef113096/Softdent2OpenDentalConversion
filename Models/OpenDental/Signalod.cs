using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Signalod
    {
        public long SignalNum { get; set; }
        public DateTime DateViewing { get; set; }
        public DateTime SigDateTime { get; set; }
        public long Fkey { get; set; }
        public string FkeyType { get; set; }
        public sbyte Itype { get; set; }
        public sbyte RemoteRole { get; set; }
        public string MsgValue { get; set; }
    }
}
