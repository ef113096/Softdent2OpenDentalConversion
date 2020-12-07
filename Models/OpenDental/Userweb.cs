using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Userweb
    {
        public long UserWebNum { get; set; }
        public long Fkey { get; set; }
        public sbyte FkeyType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordResetCode { get; set; }
        public sbyte RequireUserNameChange { get; set; }
        public DateTime DateTimeLastLogin { get; set; }
        public sbyte RequirePasswordChange { get; set; }
    }
}
