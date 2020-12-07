using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Employee
    {
        public long EmployeeNum { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string MiddleI { get; set; }
        public byte IsHidden { get; set; }
        public string ClockStatus { get; set; }
        public int PhoneExt { get; set; }
        public string PayrollId { get; set; }
        public string WirelessPhone { get; set; }
        public string EmailWork { get; set; }
        public string EmailPersonal { get; set; }
        public sbyte IsFurloughed { get; set; }
        public sbyte IsWorkingHome { get; set; }
    }
}
