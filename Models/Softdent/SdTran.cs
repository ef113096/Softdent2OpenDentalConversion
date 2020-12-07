using System;
using System.Collections.Generic;

using FileHelpers;
using FileHelpers.Events;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.Softdent
{
    [DelimitedRecord(",")]
    [IgnoreFirst]
    [IgnoreLast]
    [IgnoreEmptyLines]
    public partial class SdTran : INotifyRead
    {
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string TransDate { get; set; }
        public int? TransPatId { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string TransPatName { get; set; }
        public int? TransD { get; set; }
        public int? TransDr { get; set; }
        public decimal? TransCode { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string TransCodeType { get; set; }
        public decimal? TransProd { get; set; }
        public decimal? TransCharges { get; set; }
        public decimal? TransTax { get; set; }
        public decimal? TransProdAdj { get; set; }
        public decimal? TransCash { get; set; }
        public decimal? TransChecks { get; set; }
        public decimal? TransCredit { get; set; }
        public decimal? TransPayAdj { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string TransTooth { get; set; }
        [FieldQuoted('~', QuoteMode.AlwaysQuoted, MultilineMode.AllowForBoth)]
        public string TransSurface { get; set; }

        void INotifyRead.AfterRead(AfterReadEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void INotifyRead.BeforeRead(BeforeReadEventArgs e)
        {
            if (e.RecordLine.Substring(1, 1) == "~")
            {
                e.RecordLine = e.RecordLine.Substring(1);
            }
        }
    }
}
