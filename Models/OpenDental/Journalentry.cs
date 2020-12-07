using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Journalentry
    {
        public long JournalEntryNum { get; set; }
        public long TransactionNum { get; set; }
        public long AccountNum { get; set; }
        public DateTime DateDisplayed { get; set; }
        public double DebitAmt { get; set; }
        public double CreditAmt { get; set; }
        public string Memo { get; set; }
        public string Splits { get; set; }
        public string CheckNumber { get; set; }
        public long ReconcileNum { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateTentry { get; set; }
        public long SecUserNumEdit { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
