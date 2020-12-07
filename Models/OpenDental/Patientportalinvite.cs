using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Patientportalinvite
    {
        public long PatientPortalInviteNum { get; set; }
        public long PatNum { get; set; }
        public long AptNum { get; set; }
        public long ClinicNum { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public long Tsprior { get; set; }
        public sbyte EmailSendStatus { get; set; }
        public long EmailMessageNum { get; set; }
        public string TemplateEmail { get; set; }
        public string TemplateEmailSubj { get; set; }
        public string Note { get; set; }
    }
}
