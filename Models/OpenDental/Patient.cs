using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Patient
    {
        public long PatNum { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string MiddleI { get; set; }
        public string Preferred { get; set; }
        public byte PatStatus { get; set; }
        public byte Gender { get; set; }
        public byte Position { get; set; }
        public DateTime Birthdate { get; set; }
        public string Ssn { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string HmPhone { get; set; }
        public string WkPhone { get; set; }
        public string WirelessPhone { get; set; }
        public long Guarantor { get; set; }
        public string CreditType { get; set; }
        public string Email { get; set; }
        public string Salutation { get; set; }
        public double EstBalance { get; set; }
        public long PriProv { get; set; }
        public long SecProv { get; set; }
        public long FeeSched { get; set; }
        public long BillingType { get; set; }
        public string ImageFolder { get; set; }
        public string AddrNote { get; set; }
        public string FamFinUrgNote { get; set; }
        public string MedUrgNote { get; set; }
        public string ApptModNote { get; set; }
        public string StudentStatus { get; set; }
        public string SchoolName { get; set; }
        public string ChartNumber { get; set; }
        public string MedicaidId { get; set; }
        public double Bal030 { get; set; }
        public double Bal3160 { get; set; }
        public double Bal6190 { get; set; }
        public double BalOver90 { get; set; }
        public double InsEst { get; set; }
        public double BalTotal { get; set; }
        public long EmployerNum { get; set; }
        public string EmploymentNote { get; set; }
        public string County { get; set; }
        public sbyte GradeLevel { get; set; }
        public sbyte Urgency { get; set; }
        public DateTime DateFirstVisit { get; set; }
        public long ClinicNum { get; set; }
        public string HasIns { get; set; }
        public string TrophyFolder { get; set; }
        public byte PlannedIsDone { get; set; }
        public byte Premed { get; set; }
        public string Ward { get; set; }
        public byte PreferConfirmMethod { get; set; }
        public byte PreferContactMethod { get; set; }
        public byte PreferRecallMethod { get; set; }
        public TimeSpan? SchedBeforeTime { get; set; }
        public TimeSpan? SchedAfterTime { get; set; }
        public byte SchedDayOfWeek { get; set; }
        public string Language { get; set; }
        public DateTime AdmitDate { get; set; }
        public string Title { get; set; }
        public double PayPlanDue { get; set; }
        public long SiteNum { get; set; }
        public DateTime DateTstamp { get; set; }
        public long ResponsParty { get; set; }
        public sbyte CanadianEligibilityCode { get; set; }
        public int AskToArriveEarly { get; set; }
        public sbyte PreferContactConfidential { get; set; }
        public long SuperFamily { get; set; }
        public sbyte TxtMsgOk { get; set; }
        public string SmokingSnoMed { get; set; }
        public string Country { get; set; }
        public DateTime DateTimeDeceased { get; set; }
        public int BillingCycleDay { get; set; }
        public long SecUserNumEntry { get; set; }
        public DateTime SecDateEntry { get; set; }
        public sbyte HasSuperBilling { get; set; }
        public long PatNumCloneFrom { get; set; }
        public long DiscountPlanNum { get; set; }
        public sbyte HasSignedTil { get; set; }
        public sbyte ShortCodeOptIn { get; set; }
    }
}
