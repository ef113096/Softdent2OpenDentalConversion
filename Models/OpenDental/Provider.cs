using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Provider
    {
        public long ProvNum { get; set; }
        public string Abbr { get; set; }
        public ushort ItemOrder { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Mi { get; set; }
        public string Suffix { get; set; }
        public long FeeSched { get; set; }
        public long Specialty { get; set; }
        public string Ssn { get; set; }
        public string StateLicense { get; set; }
        public string Deanum { get; set; }
        public byte IsSecondary { get; set; }
        public int ProvColor { get; set; }
        public byte IsHidden { get; set; }
        public byte UsingTin { get; set; }
        public string BlueCrossId { get; set; }
        public byte SigOnFile { get; set; }
        public string MedicaidId { get; set; }
        public int OutlineColor { get; set; }
        public long SchoolClassNum { get; set; }
        public string NationalProvId { get; set; }
        public string CanadianOfficeNum { get; set; }
        public DateTime DateTstamp { get; set; }
        public long AnesthProvType { get; set; }
        public string TaxonomyCodeOverride { get; set; }
        public sbyte IsCdanet { get; set; }
        public string EcwId { get; set; }
        public string StateRxId { get; set; }
        public sbyte IsNotPerson { get; set; }
        public string StateWhereLicensed { get; set; }
        public long EmailAddressNum { get; set; }
        public sbyte IsInstructor { get; set; }
        public int EhrMuStage { get; set; }
        public long ProvNumBillingOverride { get; set; }
        public string CustomId { get; set; }
        public sbyte ProvStatus { get; set; }
        public sbyte IsHiddenReport { get; set; }
        public sbyte IsErxEnabled { get; set; }
        public DateTime Birthdate { get; set; }
        public string SchedNote { get; set; }
        public string WebSchedDescript { get; set; }
        public string WebSchedImageLocation { get; set; }
        public double HourlyProdGoalAmt { get; set; }
        public DateTime DateTerm { get; set; }
    }
}
