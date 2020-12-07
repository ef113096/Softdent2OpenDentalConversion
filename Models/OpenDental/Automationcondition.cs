using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Automationcondition
    {
        public long AutomationConditionNum { get; set; }
        public long AutomationNum { get; set; }
        public sbyte CompareField { get; set; }
        public sbyte Comparison { get; set; }
        public string CompareString { get; set; }
    }
}
