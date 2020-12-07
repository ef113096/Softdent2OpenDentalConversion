using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Stmtlink
    {
        public long StmtLinkNum { get; set; }
        public long StatementNum { get; set; }
        public sbyte StmtLinkType { get; set; }
        public long Fkey { get; set; }
    }
}
