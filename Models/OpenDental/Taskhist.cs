using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Taskhist
    {
        public long TaskHistNum { get; set; }
        public long UserNumHist { get; set; }
        public DateTime DateTstamp { get; set; }
        public sbyte IsNoteChange { get; set; }
        public long TaskNum { get; set; }
        public long TaskListNum { get; set; }
        public DateTime DateTask { get; set; }
        public long KeyNum { get; set; }
        public string Descript { get; set; }
        public sbyte TaskStatus { get; set; }
        public sbyte IsRepeating { get; set; }
        public sbyte DateType { get; set; }
        public long FromNum { get; set; }
        public sbyte ObjectType { get; set; }
        public DateTime DateTimeEntry { get; set; }
        public long UserNum { get; set; }
        public DateTime DateTimeFinished { get; set; }
        public long PriorityDefNum { get; set; }
        public string ReminderGroupId { get; set; }
        public short ReminderType { get; set; }
        public int ReminderFrequency { get; set; }
        public DateTime DateTimeOriginal { get; set; }
        public DateTime SecDateTedit { get; set; }
    }
}
