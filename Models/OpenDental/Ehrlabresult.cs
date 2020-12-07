using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrlabresult
    {
        public long EhrLabResultNum { get; set; }
        public long EhrLabNum { get; set; }
        public long SetIdObx { get; set; }
        public string ValueType { get; set; }
        public string ObservationIdentifierId { get; set; }
        public string ObservationIdentifierText { get; set; }
        public string ObservationIdentifierCodeSystemName { get; set; }
        public string ObservationIdentifierIdalt { get; set; }
        public string ObservationIdentifierTextAlt { get; set; }
        public string ObservationIdentifierCodeSystemNameAlt { get; set; }
        public string ObservationIdentifierTextOriginal { get; set; }
        public string ObservationIdentifierSub { get; set; }
        public string ObservationValueCodedElementId { get; set; }
        public string ObservationValueCodedElementText { get; set; }
        public string ObservationValueCodedElementCodeSystemName { get; set; }
        public string ObservationValueCodedElementIdalt { get; set; }
        public string ObservationValueCodedElementTextAlt { get; set; }
        public string ObservationValueCodedElementCodeSystemNameAlt { get; set; }
        public string ObservationValueCodedElementTextOriginal { get; set; }
        public string ObservationValueDateTime { get; set; }
        public TimeSpan ObservationValueTime { get; set; }
        public string ObservationValueComparator { get; set; }
        public double ObservationValueNumber1 { get; set; }
        public string ObservationValueSeparatorOrSuffix { get; set; }
        public double ObservationValueNumber2 { get; set; }
        public double ObservationValueNumeric { get; set; }
        public string ObservationValueText { get; set; }
        public string UnitsId { get; set; }
        public string UnitsText { get; set; }
        public string UnitsCodeSystemName { get; set; }
        public string UnitsIdalt { get; set; }
        public string UnitsTextAlt { get; set; }
        public string UnitsCodeSystemNameAlt { get; set; }
        public string UnitsTextOriginal { get; set; }
        public string ReferenceRange { get; set; }
        public string AbnormalFlags { get; set; }
        public string ObservationResultStatus { get; set; }
        public string ObservationDateTime { get; set; }
        public string AnalysisDateTime { get; set; }
        public string PerformingOrganizationName { get; set; }
        public string PerformingOrganizationNameAssigningAuthorityNamespaceId { get; set; }
        public string PerformingOrganizationNameAssigningAuthorityUniversalId { get; set; }
        public string PerformingOrganizationNameAssigningAuthorityUniversalIdType { get; set; }
        public string PerformingOrganizationIdentifierTypeCode { get; set; }
        public string PerformingOrganizationIdentifier { get; set; }
        public string PerformingOrganizationAddressStreet { get; set; }
        public string PerformingOrganizationAddressOtherDesignation { get; set; }
        public string PerformingOrganizationAddressCity { get; set; }
        public string PerformingOrganizationAddressStateOrProvince { get; set; }
        public string PerformingOrganizationAddressZipOrPostalCode { get; set; }
        public string PerformingOrganizationAddressCountryCode { get; set; }
        public string PerformingOrganizationAddressAddressType { get; set; }
        public string PerformingOrganizationAddressCountyOrParishCode { get; set; }
        public string MedicalDirectorId { get; set; }
        public string MedicalDirectorLname { get; set; }
        public string MedicalDirectorFname { get; set; }
        public string MedicalDirectorMiddleNames { get; set; }
        public string MedicalDirectorSuffix { get; set; }
        public string MedicalDirectorPrefix { get; set; }
        public string MedicalDirectorAssigningAuthorityNamespaceId { get; set; }
        public string MedicalDirectorAssigningAuthorityUniversalId { get; set; }
        public string MedicalDirectorAssigningAuthorityIdtype { get; set; }
        public string MedicalDirectorNameTypeCode { get; set; }
        public string MedicalDirectorIdentifierTypeCode { get; set; }
    }
}
