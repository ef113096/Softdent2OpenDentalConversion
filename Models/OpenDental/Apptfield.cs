using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Apptfield
    {
        public long ApptFieldNum { get; set; }
        public long AptNum { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
    }
}
