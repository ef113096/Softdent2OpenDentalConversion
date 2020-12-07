using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Supplier
    {
        public long SupplierNum { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string CustomerId { get; set; }
        public string Website { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Note { get; set; }
    }
}
