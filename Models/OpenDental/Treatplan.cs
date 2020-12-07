using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Treatplan
    {
        public long TreatPlanNum { get; set; }
        public long PatNum { get; set; }
        public DateTime DateTp { get; set; }
        public string Heading { get; set; }
        public string Note { get; set; }
        public string Signature { get; set; }
        public bool SigIsTopaz { get; set; }
        public long ResponsParty { get; set; }
        public long DocNum { get; set; }
        public sbyte Tpstatus { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
        public long UserNumPresenter { get; set; }
        public sbyte Tptype { get; set; }
        public string SignaturePractice { get; set; }
        public DateTime DateTsigned { get; set; }
        public DateTime DateTpracticeSigned { get; set; }
        public string SignatureText { get; set; }
        public string SignaturePracticeText { get; set; }
    }
}
