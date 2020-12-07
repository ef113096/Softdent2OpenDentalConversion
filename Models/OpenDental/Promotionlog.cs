using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Promotionlog
    {
        public long PromotionLogNum { get; set; }
        public long PromotionNum { get; set; }
        public long PatNum { get; set; }
        public long EmailMessageNum { get; set; }
        public long EmailHostingFk { get; set; }
        public DateTime DateTimeSent { get; set; }
        public sbyte PromotionStatus { get; set; }
    }
}
