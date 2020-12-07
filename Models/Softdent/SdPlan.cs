using System;
using System.Collections.Generic;

using FileHelpers;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.Softdent
{
    [DelimitedRecord(",")]
    [IgnoreFirst]
    [IgnoreLast]
    [IgnoreEmptyLines]
    public partial class SdPlan
    {
        public int PlanId { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PlanName { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PlanGroupNo { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PlanPhone { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PlanElPhone { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PlanFax { get; set; }
        public int PlanInscoId { get; set; }

        public int PlanType { get; set; }
    }
}
