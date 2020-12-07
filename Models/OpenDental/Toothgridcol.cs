using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Toothgridcol
    {
        public long ToothGridColNum { get; set; }
        public long SheetFieldNum { get; set; }
        public string NameItem { get; set; }
        public sbyte CellType { get; set; }
        public short ItemOrder { get; set; }
        public short ColumnWidth { get; set; }
        public long CodeNum { get; set; }
        public sbyte ProcStatus { get; set; }
    }
}
