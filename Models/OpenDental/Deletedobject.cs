using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Deletedobject
    {
        public long DeletedObjectNum { get; set; }
        public long ObjectNum { get; set; }
        public int ObjectType { get; set; }
        public DateTime DateTstamp { get; set; }
    }
}
