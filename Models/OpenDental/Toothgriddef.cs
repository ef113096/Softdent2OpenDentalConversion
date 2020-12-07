using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Toothgriddef
    {
        public long ToothGridDefNum { get; set; }
        public string NameInternal { get; set; }
        public string NameShowing { get; set; }
        public sbyte CellType { get; set; }
        public short ItemOrder { get; set; }
        public short ColumnWidth { get; set; }
        public long CodeNum { get; set; }
        public sbyte ProcStatus { get; set; }
        public long SheetFieldDefNum { get; set; }
    }
}
