using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Question
    {
        public long QuestionNum { get; set; }
        public long PatNum { get; set; }
        public ushort ItemOrder { get; set; }
        public string Description { get; set; }
        public string Answer { get; set; }
        public long FormPatNum { get; set; }
    }
}
