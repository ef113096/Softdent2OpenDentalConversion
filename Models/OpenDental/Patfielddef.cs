using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Patfielddef
    {
        public long PatFieldDefNum { get; set; }
        public string FieldName { get; set; }
        public sbyte FieldType { get; set; }
        public string PickList { get; set; }
        public int ItemOrder { get; set; }
        public sbyte IsHidden { get; set; }
    }
}
