using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Definition
    {
        public long DefNum { get; set; }
        public byte Category { get; set; }
        public ushort ItemOrder { get; set; }
        public string ItemName { get; set; }
        public string ItemValue { get; set; }
        public int ItemColor { get; set; }
        public byte IsHidden { get; set; }
    }
}
