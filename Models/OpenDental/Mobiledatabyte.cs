using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Mobiledatabyte
    {
        public long MobileDataByteNum { get; set; }
        public string RawBase64Data { get; set; }
        public string RawBase64Code { get; set; }
        public string RawBase64Tag { get; set; }
        public long PatNum { get; set; }
        public sbyte ActionType { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public DateTime DateTimeExpires { get; set; }
    }
}
