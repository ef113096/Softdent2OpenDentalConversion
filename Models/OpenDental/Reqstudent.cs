using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Reqstudent
    {
        public long ReqStudentNum { get; set; }
        public long ReqNeededNum { get; set; }
        public string Descript { get; set; }
        public long SchoolCourseNum { get; set; }
        public long ProvNum { get; set; }
        public long AptNum { get; set; }
        public long PatNum { get; set; }
        public long InstructorNum { get; set; }
        public DateTime DateCompleted { get; set; }
    }
}
