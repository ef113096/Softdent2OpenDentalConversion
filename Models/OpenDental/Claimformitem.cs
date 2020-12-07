using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Claimformitem
    {
        public long ClaimFormItemNum { get; set; }
        public long ClaimFormNum { get; set; }
        public string ImageFileName { get; set; }
        public string FieldName { get; set; }
        public string FormatString { get; set; }
        public float Xpos { get; set; }
        public float Ypos { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
    }
}
