using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Mountdef
    {
        public long MountDefNum { get; set; }
        public string Description { get; set; }
        public int ItemOrder { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int ColorBack { get; set; }
    }
}
