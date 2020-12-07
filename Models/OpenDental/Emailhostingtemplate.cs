using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Emailhostingtemplate
    {
        public long EmailHostingTemplateNum { get; set; }
        public string TemplateName { get; set; }
        public string Subject { get; set; }
        public string BodyPlainText { get; set; }
        public string BodyHtml { get; set; }
        public long TemplateId { get; set; }
        public long ClinicNum { get; set; }
        public string EmailTemplateType { get; set; }
    }
}
