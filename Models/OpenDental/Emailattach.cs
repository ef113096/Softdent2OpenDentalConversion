using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Emailattach
    {
        public long EmailAttachNum { get; set; }
        public long EmailMessageNum { get; set; }
        public string DisplayedFileName { get; set; }
        public string ActualFileName { get; set; }
        public long EmailTemplateNum { get; set; }
    }
}
