using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Loinc
    {
        public long LoincNum { get; set; }
        public string LoincCode { get; set; }
        public string Component { get; set; }
        public string PropertyObserved { get; set; }
        public string TimeAspct { get; set; }
        public string SystemMeasured { get; set; }
        public string ScaleType { get; set; }
        public string MethodType { get; set; }
        public string StatusOfCode { get; set; }
        public string NameShort { get; set; }
        public string ClassType { get; set; }
        public sbyte UnitsRequired { get; set; }
        public string OrderObs { get; set; }
        public string Hl7fieldSubfieldId { get; set; }
        public string ExternalCopyrightNotice { get; set; }
        public string NameLongCommon { get; set; }
        public string UnitsUcum { get; set; }
        public int RankCommonTests { get; set; }
        public int RankCommonOrders { get; set; }
    }
}
