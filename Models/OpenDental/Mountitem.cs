using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Mountitem
    {
        public long MountItemNum { get; set; }
        public long MountNum { get; set; }
        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public int ItemOrder { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
