using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Letter
    {
        public long LetterNum { get; set; }
        public string Description { get; set; }
        public string BodyText { get; set; }
    }
}
