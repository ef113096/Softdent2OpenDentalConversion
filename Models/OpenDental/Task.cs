using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Task
    {
        public long TaskNum { get; set; }
        public long TaskListNum { get; set; }
        public DateTime DateTask { get; set; }
        public long KeyNum { get; set; }
        public string Descript { get; set; }
        public byte TaskStatus { get; set; }
        public byte IsRepeating { get; set; }
        public byte DateType { get; set; }
        public long FromNum { get; set; }
        public byte ObjectType { get; set; }
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
