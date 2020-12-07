using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Updatehistory
    {
        public long UpdateHistoryNum { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public string ProgramVersion { get; set; }
    }
}
