using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Custrefentry
    {
        public long CustRefEntryNum { get; set; }
        public long PatNumCust { get; set; }
        public long PatNumRef { get; set; }
        public DateTime DateEntry { get; set; }
        public string Note { get; set; }
    }
}
