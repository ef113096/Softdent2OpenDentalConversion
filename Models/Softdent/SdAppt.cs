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
    public partial class SdAppt
    {
        public int ApptPatId { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ApptDate { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ApptTime { get; set; }
        public decimal ApptAdacode { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ApptAdadesc { get; set; }
        public int ApptOperatory { get; set; }
        public int ApptTimeUnits { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ApptName { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ApptChartId { get; set; }
        public int ApptDentist { get; set; }
        public decimal ApptAdacode2 { get; set; }
        public decimal ApptAdacode3 { get; set; }
        public decimal ApptAdacode4 { get; set; }
        public decimal ApptAdacode5 { get; set; }
        public decimal ApptAdacode6 { get; set; }
        public string ApptTooth1 { get; set; }
        public string ApptSurface1 { get; set; }
        public string ApptTooth2 { get; set; }
        public string ApptSurface2 { get; set; }
        public string ApptTooth3 { get; set; }
        public string ApptSurface3 { get; set; }
        public string ApptTooth4 { get; set; }
        public string ApptSurface4 { get; set; }
        public string ApptTooth5 { get; set; }
        public string ApptSurface5 { get; set; }
        public string ApptTooth6 { get; set; }
        public string ApptSurface6 { get; set; }
    }
}
