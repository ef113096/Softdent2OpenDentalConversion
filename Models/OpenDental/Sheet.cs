using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Sheet
    {
        public long SheetNum { get; set; }
        public int SheetType { get; set; }
        public long PatNum { get; set; }
        public DateTime DateTimeSheet { get; set; }
        public float FontSize { get; set; }
        public string FontName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public sbyte IsLandscape { get; set; }
        public string InternalNote { get; set; }
        public string Description { get; set; }
        public sbyte ShowInTerminal { get; set; }
        public sbyte IsWebForm { get; set; }
        public sbyte IsMultiPage { get; set; }
        public sbyte IsDeleted { get; set; }
        public long SheetDefNum { get; set; }
        public long DocNum { get; set; }
        public long ClinicNum { get; set; }
        public DateTime DateTsheetEdited { get; set; }
        public sbyte HasMobileLayout { get; set; }
    }
}
