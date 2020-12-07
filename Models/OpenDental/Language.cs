using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Language
    {
        public long LanguageNum { get; set; }
        public string EnglishComments { get; set; }
        public string ClassType { get; set; }
        public string English { get; set; }
        public byte IsObsolete { get; set; }
    }
}
