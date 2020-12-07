using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Tasksubscription
    {
        public long TaskSubscriptionNum { get; set; }
        public long UserNum { get; set; }
        public long TaskListNum { get; set; }
        public long TaskNum { get; set; }
    }
}
