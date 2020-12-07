using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Dbmlog
    {
        public long DbmLogNum { get; set; }
        public long UserNum { get; set; }
        public long Fkey { get; set; }
        public sbyte FkeyType { get; set; }
        public sbyte ActionType { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public string MethodName { get; set; }
        public string LogText { get; set; }
    }
}
