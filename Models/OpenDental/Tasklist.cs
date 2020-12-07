using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Tasklist
    {
        public long TaskListNum { get; set; }
        public string Descript { get; set; }
        public long Parent { get; set; }
        public DateTime DateTl { get; set; }
        public byte IsRepeating { get; set; }
        public byte DateType { get; set; }
        public long FromNum { get; set; }
        public byte ObjectType { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public sbyte GlobalTaskFilterType { get; set; }
        public sbyte TaskListStatus { get; set; }
    }
}
