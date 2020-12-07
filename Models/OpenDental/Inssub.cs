using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Inssub
    {
        public long InsSubNum { get; set; }
        public long PlanNum { get; set; }
        public long Subscriber { get; set; }
        public DateTime DateEffective { get; set; }
        public DateTime DateTerm { get; set; }
        public sbyte ReleaseInfo { get; set; }
        public sbyte AssignBen { get; set; }
        public string SubscriberId { get; set; }
        public string BenefitNotes { get; set; }
        public string SubscNote { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
