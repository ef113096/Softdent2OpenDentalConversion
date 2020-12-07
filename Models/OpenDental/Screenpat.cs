using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Screenpat
    {
        public long ScreenPatNum { get; set; }
        public long PatNum { get; set; }
        public long ScreenGroupNum { get; set; }
        public long SheetNum { get; set; }
        public sbyte PatScreenPerm { get; set; }
    }
}
