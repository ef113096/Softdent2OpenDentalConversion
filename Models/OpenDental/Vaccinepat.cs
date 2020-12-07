using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Vaccinepat
    {
        public long VaccinePatNum { get; set; }
        public long VaccineDefNum { get; set; }
        public DateTime? DateTimeStart { get; set; }
        public DateTime? DateTimeEnd { get; set; }
        public float AdministeredAmt { get; set; }
        public long DrugUnitNum { get; set; }
        public string LotNumber { get; set; }
        public long PatNum { get; set; }
        public string Note { get; set; }
        public string FilledCity { get; set; }
        public string FilledSt { get; set; }
        public sbyte CompletionStatus { get; set; }
        public sbyte AdministrationNoteCode { get; set; }
        public long UserNum { get; set; }
        public long ProvNumOrdering { get; set; }
        public long ProvNumAdminister { get; set; }
        public DateTime DateExpire { get; set; }
        public sbyte RefusalReason { get; set; }
        public sbyte ActionCode { get; set; }
        public sbyte AdministrationRoute { get; set; }
        public sbyte AdministrationSite { get; set; }
    }
}
