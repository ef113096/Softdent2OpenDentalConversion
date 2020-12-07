using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Reqneeded
    {
        public long ReqNeededNum { get; set; }
        public string Descript { get; set; }
        public long SchoolCourseNum { get; set; }
        public long SchoolClassNum { get; set; }
    }
}
