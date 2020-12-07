using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Grouppermission
    {
        public long GroupPermNum { get; set; }
        public DateTime NewerDate { get; set; }
        public int NewerDays { get; set; }
        public long UserGroupNum { get; set; }
        public byte PermType { get; set; }
        public long Fkey { get; set; }
    }
}
