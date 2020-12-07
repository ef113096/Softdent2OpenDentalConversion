using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class File
    {
        public long DocNum { get; set; }
        public byte[] Data { get; set; }
        public byte[] Thumbnail { get; set; }
    }
}
