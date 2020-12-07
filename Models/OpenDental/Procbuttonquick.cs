using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Procbuttonquick
    {
        public long ProcButtonQuickNum { get; set; }
        public string Description { get; set; }
        public string CodeValue { get; set; }
        public string Surf { get; set; }
        public int Ypos { get; set; }
        public int ItemOrder { get; set; }
        public sbyte IsLabel { get; set; }
    }
}
