using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Documentmisc
    {
        public long DocMiscNum { get; set; }
        public DateTime DateCreated { get; set; }
        public string FileName { get; set; }
        public sbyte DocMiscType { get; set; }
        public string RawBase64 { get; set; }
    }
}
