using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Screen
    {
        public long ScreenNum { get; set; }
        public byte Gender { get; set; }
        public sbyte RaceOld { get; set; }
        public sbyte GradeLevel { get; set; }
        public byte Age { get; set; }
        public sbyte Urgency { get; set; }
        public byte HasCaries { get; set; }
        public byte NeedsSealants { get; set; }
        public byte CariesExperience { get; set; }
        public byte EarlyChildCaries { get; set; }
        public byte ExistingSealants { get; set; }
        public byte MissingAllTeeth { get; set; }
        public DateTime Birthdate { get; set; }
        public long ScreenGroupNum { get; set; }
        public ushort ScreenGroupOrder { get; set; }
        public string Comments { get; set; }
        public long ScreenPatNum { get; set; }
        public long SheetNum { get; set; }
    }
}
