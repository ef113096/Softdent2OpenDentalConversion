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
    public partial class SdPat
    {
        public int PatId { get; set; }
        public int PatRpId { get; set; }
        public decimal PatArbalance { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatSsn { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatFname { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatMname { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatLname { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatAddress { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatCity { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatState { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatZip { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatHphone { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatWphone { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatGender { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatMarital { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatBirthday { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatFirstVisit { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatLastExam { get; set; }
        public decimal? PatRecallCode { get; set; }
        public int PatRecallTimeUnits { get; set; }
        public int PatHygId { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatChartId { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatNickname { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatDueBackDate { get; set; }
        public int PatDocId { get; set; }
        public int PatFeeSched { get; set; }
        public int PatRecallInt { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatUserCodes { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatMedAlert { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatNotes1 { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatNotes2 { get; set; }
        public int PatRefDrId { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatInsRel1 { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatInsRel2 { get; set; }
        public decimal PatInsDed1 { get; set; }
        public decimal PatInsDed2 { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatLastUpdate { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatTitle { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatLastVisit { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatLastPerioChart { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatLastMedHistory { get; set; }
        public int PatSdoffice { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatLastBiteWing { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatLastPanoral { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatLastFullSeries { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatIns1MedicaidId { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatIns1RelDesc { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatCellPhone { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string PatEmail { get; set; }
    }
}
