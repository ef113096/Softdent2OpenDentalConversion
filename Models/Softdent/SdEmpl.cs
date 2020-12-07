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
    public partial class SdEmpl
    {
        public int EmpId { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string EmpName { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string EmpAddr1 { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string EmpAddr2 { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string EmpCity { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string EmpState { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string EmpZipCode { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string EmpContact { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string EmpPhone { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string EmpFax { get; set; }
    }
}
