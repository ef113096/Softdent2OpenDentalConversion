using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Ehrlab
    {
        public long EhrLabNum { get; set; }
        public long PatNum { get; set; }
        public string OrderControlCode { get; set; }
        public string PlacerOrderNum { get; set; }
        public string PlacerOrderNamespace { get; set; }
        public string PlacerOrderUniversalId { get; set; }
        public string PlacerOrderUniversalIdtype { get; set; }
        public string FillerOrderNum { get; set; }
        public string FillerOrderNamespace { get; set; }
        public string FillerOrderUniversalId { get; set; }
        public string FillerOrderUniversalIdtype { get; set; }
        public string PlacerGroupNum { get; set; }
        public string PlacerGroupNamespace { get; set; }
        public string PlacerGroupUniversalId { get; set; }
        public string PlacerGroupUniversalIdtype { get; set; }
        public string OrderingProviderId { get; set; }
        public string OrderingProviderLname { get; set; }
        public string OrderingProviderFname { get; set; }
        public string OrderingProviderMiddleNames { get; set; }
        public string OrderingProviderSuffix { get; set; }
        public string OrderingProviderPrefix { get; set; }
        public string OrderingProviderAssigningAuthorityNamespaceId { get; set; }
        public string OrderingProviderAssigningAuthorityUniversalId { get; set; }
        public string OrderingProviderAssigningAuthorityIdtype { get; set; }
        public string OrderingProviderNameTypeCode { get; set; }
        public string OrderingProviderIdentifierTypeCode { get; set; }
        public long SetIdObr { get; set; }
        public string UsiId { get; set; }
        public string UsiText { get; set; }
        public string UsiCodeSystemName { get; set; }
        public string UsiIdalt { get; set; }
        public string UsiTextAlt { get; set; }
        public string UsiCodeSystemNameAlt { get; set; }
        public string UsiTextOriginal { get; set; }
        public string ObservationDateTimeStart { get; set; }
        public string ObservationDateTimeEnd { get; set; }
        public string SpecimenActionCode { get; set; }
        public string ResultDateTime { get; set; }
        public string ResultStatus { get; set; }
        public string ParentObservationId { get; set; }
        public string ParentObservationText { get; set; }
        public string ParentObservationCodeSystemName { get; set; }
        public string ParentObservationIdalt { get; set; }
        public string ParentObservationTextAlt { get; set; }
        public string ParentObservationCodeSystemNameAlt { get; set; }
        public string ParentObservationTextOriginal { get; set; }
        public string ParentObservationSubId { get; set; }
        public string ParentPlacerOrderNum { get; set; }
        public string ParentPlacerOrderNamespace { get; set; }
        public string ParentPlacerOrderUniversalId { get; set; }
        public string ParentPlacerOrderUniversalIdtype { get; set; }
        public string ParentFillerOrderNum { get; set; }
        public string ParentFillerOrderNamespace { get; set; }
        public string ParentFillerOrderUniversalId { get; set; }
        public string ParentFillerOrderUniversalIdtype { get; set; }
        public sbyte ListEhrLabResultsHandlingF { get; set; }
        public sbyte ListEhrLabResultsHandlingN { get; set; }
        public long Tq1setId { get; set; }
        public string Tq1dateTimeStart { get; set; }
        public string Tq1dateTimeEnd { get; set; }
        public sbyte IsCpoe { get; set; }
        public string OriginalPidsegment { get; set; }
    }
}
