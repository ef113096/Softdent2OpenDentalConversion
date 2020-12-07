using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Codesystem
    {
        public long CodeSystemNum { get; set; }
        public string CodeSystemName { get; set; }
        public string VersionCur { get; set; }
        public string VersionAvail { get; set; }
        public string Hl7oid { get; set; }
        public string Note { get; set; }
    }
}
