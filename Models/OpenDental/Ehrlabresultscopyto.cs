using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrlabresultscopyto
    {
        public long EhrLabResultsCopyToNum { get; set; }
        public long EhrLabNum { get; set; }
        public string CopyToId { get; set; }
        public string CopyToLname { get; set; }
        public string CopyToFname { get; set; }
        public string CopyToMiddleNames { get; set; }
        public string CopyToSuffix { get; set; }
        public string CopyToPrefix { get; set; }
        public string CopyToAssigningAuthorityNamespaceId { get; set; }
        public string CopyToAssigningAuthorityUniversalId { get; set; }
        public string CopyToAssigningAuthorityIdtype { get; set; }
        public string CopyToNameTypeCode { get; set; }
        public string CopyToIdentifierTypeCode { get; set; }
    }
}
