using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Canadiannetwork
    {
        public long CanadianNetworkNum { get; set; }
        public string Abbrev { get; set; }
        public string Descript { get; set; }
        public string CanadianTransactionPrefix { get; set; }
        public sbyte CanadianIsRprHandler { get; set; }
    }
}
