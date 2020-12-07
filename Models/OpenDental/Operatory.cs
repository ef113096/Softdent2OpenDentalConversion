using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Operatory
    {
        public long OperatoryNum { get; set; }
        public string OpName { get; set; }
        public string Abbrev { get; set; }
        public ushort ItemOrder { get; set; }
        public byte IsHidden { get; set; }
        public long ProvDentist { get; set; }
        public long ProvHygienist { get; set; }
        public byte IsHygiene { get; set; }
        public long ClinicNum { get; set; }
        public DateTime DateTstamp { get; set; }
        public sbyte SetProspective { get; set; }
        public sbyte IsWebSched { get; set; }
        public sbyte IsNewPatAppt { get; set; }
    }
}
