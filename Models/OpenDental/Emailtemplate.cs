using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Emailtemplate
    {
        public long EmailTemplateNum { get; set; }
        public string Subject { get; set; }
        public string BodyText { get; set; }
        public string Description { get; set; }
        public sbyte TemplateType { get; set; }
    }
}
