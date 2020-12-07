using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Apptfielddef
    {
        public long ApptFieldDefNum { get; set; }
        public string FieldName { get; set; }
        public sbyte FieldType { get; set; }
        public string PickList { get; set; }
    }
}
