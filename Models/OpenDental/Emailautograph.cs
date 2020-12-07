using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Emailautograph
    {
        public long EmailAutographNum { get; set; }
        public string Description { get; set; }
        public string EmailAddress { get; set; }
        public string AutographText { get; set; }
    }
}
