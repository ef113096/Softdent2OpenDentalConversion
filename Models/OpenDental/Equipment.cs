using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Equipment
    {
        public long EquipmentNum { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        public string ModelYear { get; set; }
        public DateTime DatePurchased { get; set; }
        public DateTime DateSold { get; set; }
        public double PurchaseCost { get; set; }
        public double MarketValue { get; set; }
        public string Location { get; set; }
        public DateTime DateEntry { get; set; }
        public long ProvNumCheckedOut { get; set; }
        public DateTime DateCheckedOut { get; set; }
        public DateTime DateExpectedBack { get; set; }
        public string DispenseNote { get; set; }
        public string Status { get; set; }
    }
}
