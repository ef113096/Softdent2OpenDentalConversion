using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Wikipage
    {
        public long WikiPageNum { get; set; }
        public long UserNum { get; set; }
        public string PageTitle { get; set; }
        public string KeyWords { get; set; }
        public string PageContent { get; set; }
        public DateTime DateTimeSaved { get; set; }
        public sbyte IsDraft { get; set; }
        public sbyte IsLocked { get; set; }
        public sbyte IsDeleted { get; set; }
        public string PageContentPlainText { get; set; }
    }
}
