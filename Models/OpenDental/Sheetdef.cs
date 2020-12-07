using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Sheetdef
    {
        public long SheetDefNum { get; set; }
        public string Description { get; set; }
        public int SheetType { get; set; }
        public float FontSize { get; set; }
        public string FontName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public sbyte IsLandscape { get; set; }
        public int PageCount { get; set; }
        public sbyte IsMultiPage { get; set; }
        public sbyte BypassGlobalLock { get; set; }
        public sbyte HasMobileLayout { get; set; }
        public DateTime DateTcreated { get; set; }
    }
}
