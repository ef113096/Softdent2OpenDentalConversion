using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Lettermerge
    {
        public long LetterMergeNum { get; set; }
        public string Description { get; set; }
        public string TemplateName { get; set; }
        public string DataFileName { get; set; }
        public long Category { get; set; }
        public long ImageFolder { get; set; }
    }
}
