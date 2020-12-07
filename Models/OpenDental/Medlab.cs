using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Medlab
    {
        public long MedLabNum { get; set; }
        public string SendingApp { get; set; }
        public string SendingFacility { get; set; }
        public long PatNum { get; set; }
        public long ProvNum { get; set; }
        public string PatIdlab { get; set; }
        public string PatIdalt { get; set; }
        public string PatAge { get; set; }
        public string PatAccountNum { get; set; }
        public sbyte PatFasting { get; set; }
        public string SpecimenId { get; set; }
        public string SpecimenIdfiller { get; set; }
        public string ObsTestId { get; set; }
        public string ObsTestDescript { get; set; }
        public string ObsTestLoinc { get; set; }
        public string ObsTestLoincText { get; set; }
        public DateTime DateTimeCollected { get; set; }
        public string TotalVolume { get; set; }
        public string ActionCode { get; set; }
        public string ClinicalInfo { get; set; }
        public DateTime DateTimeEntered { get; set; }
        public string OrderingProvNpi { get; set; }
        public string OrderingProvLocalId { get; set; }
        public string OrderingProvLname { get; set; }
        public string OrderingProvFname { get; set; }
        public string SpecimenIdalt { get; set; }
        public DateTime DateTimeReported { get; set; }
        public string ResultStatus { get; set; }
        public string ParentObsId { get; set; }
        public string ParentObsTestId { get; set; }
        public string NotePat { get; set; }
        public string NoteLab { get; set; }
        public string FileName { get; set; }
        public string OriginalPidsegment { get; set; }
    }
}
