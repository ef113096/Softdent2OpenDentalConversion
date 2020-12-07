using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Screengroup
    {
        public long ScreenGroupNum { get; set; }
        public string Description { get; set; }
        public DateTime Sgdate { get; set; }
        public string ProvName { get; set; }
        public long ProvNum { get; set; }
        public sbyte PlaceService { get; set; }
        public string County { get; set; }
        public string GradeSchool { get; set; }
        public long SheetDefNum { get; set; }
    }
}
