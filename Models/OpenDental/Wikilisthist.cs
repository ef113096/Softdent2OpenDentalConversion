using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Wikilisthist
    {
        public long WikiListHistNum { get; set; }
        public long UserNum { get; set; }
        public string ListName { get; set; }
        public string ListHeaders { get; set; }
        public string ListContent { get; set; }
        public DateTime DateTimeSaved { get; set; }
    }
}
