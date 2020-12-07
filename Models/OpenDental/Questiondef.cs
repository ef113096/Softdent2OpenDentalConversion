using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Questiondef
    {
        public long QuestionDefNum { get; set; }
        public string Description { get; set; }
        public ushort ItemOrder { get; set; }
        public byte QuestType { get; set; }
    }
}
