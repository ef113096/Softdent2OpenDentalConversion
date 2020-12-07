using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Rxpat
    {
        public long RxNum { get; set; }
        public long PatNum { get; set; }
        public DateTime RxDate { get; set; }
        public string Drug { get; set; }
        public string Sig { get; set; }
        public string Disp { get; set; }
        public string Refills { get; set; }
        public long ProvNum { get; set; }
        public string Notes { get; set; }
        public long PharmacyNum { get; set; }
        public sbyte IsControlled { get; set; }
        public DateTime DateTstamp { get; set; }
        public sbyte SendStatus { get; set; }
        public long RxCui { get; set; }
        public string DosageCode { get; set; }
        public string ErxGuid { get; set; }
        public sbyte IsErxOld { get; set; }
        public string ErxPharmacyInfo { get; set; }
        public sbyte IsProcRequired { get; set; }
        public long ProcNum { get; set; }
        public double? DaysOfSupply { get; set; }
        public string PatientInstruction { get; set; }
        public long ClinicNum { get; set; }
    }
}
