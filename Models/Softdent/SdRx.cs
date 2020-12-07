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
    public partial class SdRx
    {
        public int RxPatId { get; set; }
        public int RxDrugId { get; set; }
        public int? RxDrId { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string RxDrugName { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string RxDate { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string RxDrugQty { get; set; }
        public string RxDrugRefills { get; set; }
    }
}
