using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Toolbutitem
    {
        public long ToolButItemNum { get; set; }
        public long ProgramNum { get; set; }
        public ushort ToolBar { get; set; }
        public string ButtonText { get; set; }
    }
}
