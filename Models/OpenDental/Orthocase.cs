using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Orthocase
    {
        public long OrthoCaseNum { get; set; }
        public long PatNum { get; set; }
        public long ProvNum { get; set; }
        public long ClinicNum { get; set; }
        public double Fee { get; set; }
        public double FeeInsPrimary { get; set; }
        public double FeePat { get; set; }
        public DateTime BandingDate { get; set; }
        public DateTime DebondDate { get; set; }
        public DateTime DebondDateExpected { get; set; }
        public sbyte IsTransfer { get; set; }
        public long OrthoType { get; set; }
        public DateTime SecDateTentry { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
        public sbyte IsActive { get; set; }
        public double FeeInsSecondary { get; set; }
    }
}
