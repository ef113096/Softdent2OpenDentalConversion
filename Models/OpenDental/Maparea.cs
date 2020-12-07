using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Maparea
    {
        public long MapAreaNum { get; set; }
        public int Extension { get; set; }
        public double Xpos { get; set; }
        public double Ypos { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string Description { get; set; }
        public sbyte ItemType { get; set; }
        public long MapAreaContainerNum { get; set; }
    }
}
