using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Mount
    {
        public long MountNum { get; set; }
        public long PatNum { get; set; }
        public long DocCategory { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int ColorBack { get; set; }
    }
}
