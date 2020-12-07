using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Apptviewitem
    {
        public long ApptViewItemNum { get; set; }
        public long ApptViewNum { get; set; }
        public long OpNum { get; set; }
        public long ProvNum { get; set; }
        public string ElementDesc { get; set; }
        public byte ElementOrder { get; set; }
        public int ElementColor { get; set; }
        public sbyte ElementAlignment { get; set; }
        public long ApptFieldDefNum { get; set; }
        public long PatFieldDefNum { get; set; }
    }
}
