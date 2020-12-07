using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Labcase
    {
        public long LabCaseNum { get; set; }
        public long PatNum { get; set; }
        public long LaboratoryNum { get; set; }
        public long AptNum { get; set; }
        public long PlannedAptNum { get; set; }
        public DateTime DateTimeDue { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeSent { get; set; }
        public DateTime DateTimeRecd { get; set; }
        public DateTime DateTimeChecked { get; set; }
        public long ProvNum { get; set; }
        public string Instructions { get; set; }
        public double LabFee { get; set; }
        public DateTime DateTstamp { get; set; }
        public string InvoiceNum { get; set; }
    }
}
