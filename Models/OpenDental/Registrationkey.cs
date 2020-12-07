using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Registrationkey
    {
        public long RegistrationKeyNum { get; set; }
        public long PatNum { get; set; }
        public string RegKey { get; set; }
        public string Note { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateDisabled { get; set; }
        public DateTime DateEnded { get; set; }
        public bool IsForeign { get; set; }
        public sbyte UsesServerVersion { get; set; }
        public sbyte IsFreeVersion { get; set; }
        public sbyte IsOnlyForTesting { get; set; }
        public int VotesAllotted { get; set; }
        public sbyte IsResellerCustomer { get; set; }
        public sbyte HasEarlyAccess { get; set; }
        public DateTime DateTbackupScheduled { get; set; }
        public string BackupPassCode { get; set; }
    }
}
