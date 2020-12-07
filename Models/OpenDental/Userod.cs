using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Userod
    {
        public long UserNum { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long UserGroupNum { get; set; }
        public long EmployeeNum { get; set; }
        public long ClinicNum { get; set; }
        public long ProvNum { get; set; }
        public bool IsHidden { get; set; }
        public long TaskListInBox { get; set; }
        public int AnesthProvType { get; set; }
        public sbyte DefaultHidePopups { get; set; }
        public sbyte PasswordIsStrong { get; set; }
        public sbyte ClinicIsRestricted { get; set; }
        public sbyte InboxHidePopups { get; set; }
        public long UserNumCemt { get; set; }
        public DateTime DateTfail { get; set; }
        public byte FailedAttempts { get; set; }
        public string DomainUser { get; set; }
        public sbyte IsPasswordResetRequired { get; set; }
        public string MobileWebPin { get; set; }
        public byte MobileWebPinFailedAttempts { get; set; }
        public DateTime DateTlastLogin { get; set; }
    }
}
