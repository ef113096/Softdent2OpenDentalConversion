using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Centralconnection
    {
        public long CentralConnectionNum { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string MySqlUser { get; set; }
        public string MySqlPassword { get; set; }
        public string ServiceUri { get; set; }
        public string OdUser { get; set; }
        public string OdPassword { get; set; }
        public string Note { get; set; }
        public int ItemOrder { get; set; }
        public sbyte WebServiceIsEcw { get; set; }
        public string ConnectionStatus { get; set; }
        public sbyte HasClinicBreakdownReports { get; set; }
    }
}
