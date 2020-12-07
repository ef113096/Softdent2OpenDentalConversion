using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Mountitemdef
    {
        public long MountItemDefNum { get; set; }
        public long MountDefNum { get; set; }
        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int ItemOrder { get; set; }
    }
}
