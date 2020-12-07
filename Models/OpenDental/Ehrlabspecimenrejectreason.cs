using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrlabspecimenrejectreason
    {
        public long EhrLabSpecimenRejectReasonNum { get; set; }
        public long EhrLabSpecimenNum { get; set; }
        public string SpecimenRejectReasonId { get; set; }
        public string SpecimenRejectReasonText { get; set; }
        public string SpecimenRejectReasonCodeSystemName { get; set; }
        public string SpecimenRejectReasonIdalt { get; set; }
        public string SpecimenRejectReasonTextAlt { get; set; }
        public string SpecimenRejectReasonCodeSystemNameAlt { get; set; }
        public string SpecimenRejectReasonTextOriginal { get; set; }
    }
}
