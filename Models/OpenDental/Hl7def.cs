using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Hl7def
    {
        public long Hl7defNum { get; set; }
        public string Description { get; set; }
        public sbyte ModeTx { get; set; }
        public string IncomingFolder { get; set; }
        public string OutgoingFolder { get; set; }
        public string IncomingPort { get; set; }
        public string OutgoingIpPort { get; set; }
        public string FieldSeparator { get; set; }
        public string ComponentSeparator { get; set; }
        public string SubcomponentSeparator { get; set; }
        public string RepetitionSeparator { get; set; }
        public string EscapeCharacter { get; set; }
        public sbyte IsInternal { get; set; }
        public string InternalType { get; set; }
        public string InternalTypeVersion { get; set; }
        public sbyte IsEnabled { get; set; }
        public string Note { get; set; }
        public string Hl7server { get; set; }
        public string Hl7serviceName { get; set; }
        public sbyte ShowDemographics { get; set; }
        public sbyte ShowAppts { get; set; }
        public sbyte ShowAccount { get; set; }
        public sbyte IsQuadAsToothNum { get; set; }
        public long LabResultImageCat { get; set; }
        public string SftpUsername { get; set; }
        public string SftpPassword { get; set; }
        public string SftpInSocket { get; set; }
        public sbyte HasLongDcodes { get; set; }
        public sbyte IsProcApptEnforced { get; set; }
    }
}
