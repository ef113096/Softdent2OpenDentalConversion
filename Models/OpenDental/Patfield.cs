using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Patfield
    {
        public long PatFieldNum { get; set; }
        public long PatNum { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateEntry { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
