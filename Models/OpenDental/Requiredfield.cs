using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Requiredfield
    {
        public long RequiredFieldNum { get; set; }
        public sbyte FieldType { get; set; }
        public string FieldName { get; set; }
    }
}
