using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Adjustment
    {
        public long AdjNum { get; set; }
        public DateTime AdjDate { get; set; }
        public double AdjAmt { get; set; }
        public long PatNum { get; set; }
        public long AdjType { get; set; }
        public long ProvNum { get; set; }
        public string AdjNote { get; set; }
        public DateTime ProcDate { get; set; }
        public long ProcNum { get; set; }
        public DateTime DateEntry { get; set; }
        public long ClinicNum { get; set; }
        public long StatementNum { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
        public long TaxTransId { get; set; }
    }
}
