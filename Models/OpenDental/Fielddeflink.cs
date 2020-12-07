using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Fielddeflink
    {
        public long FieldDefLinkNum { get; set; }
        public long FieldDefNum { get; set; }
        public sbyte FieldDefType { get; set; }
        public sbyte FieldLocation { get; set; }
    }
}
