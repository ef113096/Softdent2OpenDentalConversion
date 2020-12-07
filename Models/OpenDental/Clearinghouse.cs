using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Clearinghouse
    {
        public long ClearinghouseNum { get; set; }
        public string Description { get; set; }
        public string ExportPath { get; set; }
        public string Payors { get; set; }
        public byte Eformat { get; set; }
        public string Isa05 { get; set; }
        public string SenderTin { get; set; }
        public string Isa07 { get; set; }
        public string Isa08 { get; set; }
        public string Isa15 { get; set; }
        public string Password { get; set; }
        public string ResponsePath { get; set; }
        public byte CommBridge { get; set; }
        public string ClientProgram { get; set; }
        public ushort LastBatchNumber { get; set; }
        public byte ModemPort { get; set; }
        public string LoginId { get; set; }
        public string SenderName { get; set; }
        public string SenderTelephone { get; set; }
        public string Gs03 { get; set; }
        public string Isa02 { get; set; }
        public string Isa04 { get; set; }
        public string Isa16 { get; set; }
        public string SeparatorData { get; set; }
        public string SeparatorSegment { get; set; }
        public long ClinicNum { get; set; }
        public long HqClearinghouseNum { get; set; }
        public sbyte IsEraDownloadAllowed { get; set; }
        public sbyte IsClaimExportAllowed { get; set; }
        public sbyte IsAttachmentSendAllowed { get; set; }
    }
}
