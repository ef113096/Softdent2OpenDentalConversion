using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Autocode
    {
        public long AutoCodeNum { get; set; }
        public string Description { get; set; }
        public byte IsHidden { get; set; }
        public byte LessIntrusive { get; set; }
    }
}
