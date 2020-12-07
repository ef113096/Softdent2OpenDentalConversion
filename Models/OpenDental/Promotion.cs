using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Promotion
    {
        public long PromotionNum { get; set; }
        public string PromotionName { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public long ClinicNum { get; set; }
        public sbyte TypePromotion { get; set; }
    }
}
