using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Requiredfieldcondition
    {
        public long RequiredFieldConditionNum { get; set; }
        public long RequiredFieldNum { get; set; }
        public string ConditionType { get; set; }
        public sbyte Operator { get; set; }
        public string ConditionValue { get; set; }
        public sbyte ConditionRelationship { get; set; }
    }
}
