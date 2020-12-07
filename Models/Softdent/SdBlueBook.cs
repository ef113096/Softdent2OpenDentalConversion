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
    public partial class SdBlueBook
    {
        public int BlueBookPlanId { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string BlueBookPlanName { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string BlueBookGroupNum { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string BlueBookInscoName { get; set; }
        public decimal BlueBookMaxCov { get; set; }
        public decimal BlueBookFamDed { get; set; }
        public decimal BlueBookIndDed { get; set; }
        public decimal BlueBookOrthoMax { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string BlueBookPriorAuth { get; set; }
        public int BlueBookEffectiveMonth { get; set; }
        public int BlueBookFormNum { get; set; }
        public decimal BlueBookDiagnostic { get; set; }
        public decimal BlueBookXray { get; set; }
        public decimal BlueBookPreventative { get; set; }
        public decimal BlueBookRestorative { get; set; }
        public decimal BlueBookEndo { get; set; }
        public decimal BlueBookPerio { get; set; }
        public decimal BlueBookProstR { get; set; }
        public decimal BlueBookProstF { get; set; }
        public decimal BlueBookCrown { get; set; }
        public decimal BlueBookOralSurg { get; set; }
        public decimal BlueBookOrtho { get; set; }
        public decimal BlueBookAdjSvc { get; set; }
    }
}
