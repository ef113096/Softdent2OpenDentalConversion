using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Userquery
    {
        public long QueryNum { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string QueryText { get; set; }
        public sbyte? IsReleased { get; set; }
        public sbyte IsPromptSetup { get; set; }
    }
}
