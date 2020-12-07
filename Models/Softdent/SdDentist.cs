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
    public partial class SdDentist
    {
        public int ProvId { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvType { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvFirst { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvMiddle { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvLast { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvDegree { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvTitle { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvHomeAddr { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvHomeCity { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvHomeState { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvHomeZipCode { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvHomePhone { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvBirthday { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvSsn { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvTin { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvLicNo { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvNotes { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvDeaid { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvDeltaId { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvBcbsid { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvAddress { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvCity { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvState { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvZipCode { get; set; }
        [FieldQuoted('"', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string ProvPhone { get; set; }
    }
}
