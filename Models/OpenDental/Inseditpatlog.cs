using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Inseditpatlog
    {
        public long InsEditPatLogNum { get; set; }
        public long Fkey { get; set; }
        public sbyte LogType { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public long UserNum { get; set; }
        public DateTime DateTstamp { get; set; }
        public long ParentKey { get; set; }
        public string Description { get; set; }
    }
}
