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
    public partial class SdAdum
    {
        public decimal AdaCode { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string AdaDescription { get; set; }
        public decimal AdaFee01 { get; set; }
        public decimal AdaFee02 { get; set; }
        public decimal AdaFee03 { get; set; }
        public decimal AdaFee04 { get; set; }
        public decimal AdaFee05 { get; set; }
        public decimal AdaFee06 { get; set; }
        public decimal AdaFee07 { get; set; }
        public decimal AdaFee08 { get; set; }
        public decimal AdaFee09 { get; set; }
        public decimal AdaFee10 { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string AdaShortDesc { get; set; }
        public int? AdaTimeUnits { get; set; }
    }
}
