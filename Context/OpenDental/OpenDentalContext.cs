using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Softdent2OpenDentalConversion.Models.OpenDental;

#nullable disable

namespace Softdent2OpenDentalConversion.Context.OpenDental
{
    public partial class OpenDentalContext : DbContext
    {
        public OpenDentalContext()
        {
        }

        public OpenDentalContext(DbContextOptions<OpenDentalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Accountingautopay> Accountingautopays { get; set; }
        public virtual DbSet<Adjustment> Adjustments { get; set; }
        public virtual DbSet<Alertcategory> Alertcategories { get; set; }
        public virtual DbSet<Alertcategorylink> Alertcategorylinks { get; set; }
        public virtual DbSet<Alertitem> Alertitems { get; set; }
        public virtual DbSet<Alertread> Alertreads { get; set; }
        public virtual DbSet<Alertsub> Alertsubs { get; set; }
        public virtual DbSet<Allergy> Allergies { get; set; }
        public virtual DbSet<Allergydef> Allergydefs { get; set; }
        public virtual DbSet<Anestheticdatum> Anestheticdata { get; set; }
        public virtual DbSet<Anestheticrecord> Anestheticrecords { get; set; }
        public virtual DbSet<Anesthmedsgiven> Anesthmedsgivens { get; set; }
        public virtual DbSet<Anesthmedsintake> Anesthmedsintakes { get; set; }
        public virtual DbSet<Anesthmedsinventory> Anesthmedsinventories { get; set; }
        public virtual DbSet<Anesthmedsinventoryadj> Anesthmedsinventoryadjs { get; set; }
        public virtual DbSet<Anesthmedsupplier> Anesthmedsuppliers { get; set; }
        public virtual DbSet<Anesthscore> Anesthscores { get; set; }
        public virtual DbSet<Anesthvsdatum> Anesthvsdata { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Appointmentrule> Appointmentrules { get; set; }
        public virtual DbSet<Appointmenttype> Appointmenttypes { get; set; }
        public virtual DbSet<Apptfield> Apptfields { get; set; }
        public virtual DbSet<Apptfielddef> Apptfielddefs { get; set; }
        public virtual DbSet<Apptreminderrule> Apptreminderrules { get; set; }
        public virtual DbSet<Apptremindersent> Apptremindersents { get; set; }
        public virtual DbSet<Apptthankyousent> Apptthankyousents { get; set; }
        public virtual DbSet<Apptview> Apptviews { get; set; }
        public virtual DbSet<Apptviewitem> Apptviewitems { get; set; }
        public virtual DbSet<Asapcomm> Asapcomms { get; set; }
        public virtual DbSet<Autocode> Autocodes { get; set; }
        public virtual DbSet<Autocodecond> Autocodeconds { get; set; }
        public virtual DbSet<Autocodeitem> Autocodeitems { get; set; }
        public virtual DbSet<Automation> Automations { get; set; }
        public virtual DbSet<Automationcondition> Automationconditions { get; set; }
        public virtual DbSet<Autonote> Autonotes { get; set; }
        public virtual DbSet<Autonotecontrol> Autonotecontrols { get; set; }
        public virtual DbSet<Benefit> Benefits { get; set; }
        public virtual DbSet<Canadiannetwork> Canadiannetworks { get; set; }
        public virtual DbSet<Carecreditwebresponse> Carecreditwebresponses { get; set; }
        public virtual DbSet<Carrier> Carriers { get; set; }
        public virtual DbSet<Cdcrec> Cdcrecs { get; set; }
        public virtual DbSet<Cdspermission> Cdspermissions { get; set; }
        public virtual DbSet<Centralconnection> Centralconnections { get; set; }
        public virtual DbSet<Chartview> Chartviews { get; set; }
        public virtual DbSet<Claim> Claims { get; set; }
        public virtual DbSet<Claimattach> Claimattaches { get; set; }
        public virtual DbSet<Claimcondcodelog> Claimcondcodelogs { get; set; }
        public virtual DbSet<Claimform> Claimforms { get; set; }
        public virtual DbSet<Claimformitem> Claimformitems { get; set; }
        public virtual DbSet<Claimpayment> Claimpayments { get; set; }
        public virtual DbSet<Claimproc> Claimprocs { get; set; }
        public virtual DbSet<Claimsnapshot> Claimsnapshots { get; set; }
        public virtual DbSet<Claimtracking> Claimtrackings { get; set; }
        public virtual DbSet<Claimvalcodelog> Claimvalcodelogs { get; set; }
        public virtual DbSet<Clearinghouse> Clearinghouses { get; set; }
        public virtual DbSet<Clinic> Clinics { get; set; }
        public virtual DbSet<Clinicerx> Clinicerxes { get; set; }
        public virtual DbSet<Clinicpref> Clinicprefs { get; set; }
        public virtual DbSet<Clockevent> Clockevents { get; set; }
        public virtual DbSet<Codesystem> Codesystems { get; set; }
        public virtual DbSet<Commlog> Commlogs { get; set; }
        public virtual DbSet<Commoptout> Commoptouts { get; set; }
        public virtual DbSet<Computer> Computers { get; set; }
        public virtual DbSet<Computerpref> Computerprefs { get; set; }
        public virtual DbSet<Confirmationrequest> Confirmationrequests { get; set; }
        public virtual DbSet<Connectiongroup> Connectiongroups { get; set; }
        public virtual DbSet<Conngroupattach> Conngroupattaches { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Covcat> Covcats { get; set; }
        public virtual DbSet<Covspan> Covspans { get; set; }
        public virtual DbSet<Cpt> Cpts { get; set; }
        public virtual DbSet<Creditcard> Creditcards { get; set; }
        public virtual DbSet<Custrefentry> Custrefentries { get; set; }
        public virtual DbSet<Custreference> Custreferences { get; set; }
        public virtual DbSet<Cvx> Cvxes { get; set; }
        public virtual DbSet<Dashboardar> Dashboardars { get; set; }
        public virtual DbSet<Dashboardcell> Dashboardcells { get; set; }
        public virtual DbSet<Dashboardlayout> Dashboardlayouts { get; set; }
        public virtual DbSet<Databasemaintenance> Databasemaintenances { get; set; }
        public virtual DbSet<Dbmlog> Dbmlogs { get; set; }
        public virtual DbSet<Definition> Definitions { get; set; }
        public virtual DbSet<Deflink> Deflinks { get; set; }
        public virtual DbSet<Deletedobject> Deletedobjects { get; set; }
        public virtual DbSet<Deposit> Deposits { get; set; }
        public virtual DbSet<Dictcustom> Dictcustoms { get; set; }
        public virtual DbSet<Discountplan> Discountplans { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Diseasedef> Diseasedefs { get; set; }
        public virtual DbSet<Displayfield> Displayfields { get; set; }
        public virtual DbSet<Displayreport> Displayreports { get; set; }
        public virtual DbSet<Dispsupply> Dispsupplies { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Documentmisc> Documentmiscs { get; set; }
        public virtual DbSet<Drugmanufacturer> Drugmanufacturers { get; set; }
        public virtual DbSet<Drugunit> Drugunits { get; set; }
        public virtual DbSet<Dunning> Dunnings { get; set; }
        public virtual DbSet<Ebill> Ebills { get; set; }
        public virtual DbSet<Eclipboardsheetdef> Eclipboardsheetdefs { get; set; }
        public virtual DbSet<Eduresource> Eduresources { get; set; }
        public virtual DbSet<Ehramendment> Ehramendments { get; set; }
        public virtual DbSet<Ehraptob> Ehraptobs { get; set; }
        public virtual DbSet<Ehrcareplan> Ehrcareplans { get; set; }
        public virtual DbSet<Ehrlab> Ehrlabs { get; set; }
        public virtual DbSet<Ehrlabclinicalinfo> Ehrlabclinicalinfos { get; set; }
        public virtual DbSet<Ehrlabimage> Ehrlabimages { get; set; }
        public virtual DbSet<Ehrlabnote> Ehrlabnotes { get; set; }
        public virtual DbSet<Ehrlabresult> Ehrlabresults { get; set; }
        public virtual DbSet<Ehrlabresultscopyto> Ehrlabresultscopytos { get; set; }
        public virtual DbSet<Ehrlabspeciman> Ehrlabspecimen { get; set; }
        public virtual DbSet<Ehrlabspecimencondition> Ehrlabspecimenconditions { get; set; }
        public virtual DbSet<Ehrlabspecimenrejectreason> Ehrlabspecimenrejectreasons { get; set; }
        public virtual DbSet<Ehrmeasure> Ehrmeasures { get; set; }
        public virtual DbSet<Ehrmeasureevent> Ehrmeasureevents { get; set; }
        public virtual DbSet<Ehrnotperformed> Ehrnotperformeds { get; set; }
        public virtual DbSet<Ehrpatient> Ehrpatients { get; set; }
        public virtual DbSet<Ehrprovkey> Ehrprovkeys { get; set; }
        public virtual DbSet<Ehrquarterlykey> Ehrquarterlykeys { get; set; }
        public virtual DbSet<Ehrsummaryccd> Ehrsummaryccds { get; set; }
        public virtual DbSet<Ehrtrigger> Ehrtriggers { get; set; }
        public virtual DbSet<Electid> Electids { get; set; }
        public virtual DbSet<Emailaddress> Emailaddresses { get; set; }
        public virtual DbSet<Emailattach> Emailattaches { get; set; }
        public virtual DbSet<Emailautograph> Emailautographs { get; set; }
        public virtual DbSet<Emailhostingtemplate> Emailhostingtemplates { get; set; }
        public virtual DbSet<Emailmessage> Emailmessages { get; set; }
        public virtual DbSet<Emailmessageuid> Emailmessageuids { get; set; }
        public virtual DbSet<Emailtemplate> Emailtemplates { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<Encounter> Encounters { get; set; }
        public virtual DbSet<Entrylog> Entrylogs { get; set; }
        public virtual DbSet<Eobattach> Eobattaches { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Erxlog> Erxlogs { get; set; }
        public virtual DbSet<Eservicesignal> Eservicesignals { get; set; }
        public virtual DbSet<Etran> Etrans { get; set; }
        public virtual DbSet<Etrans835attach> Etrans835attaches { get; set; }
        public virtual DbSet<Etransmessagetext> Etransmessagetexts { get; set; }
        public virtual DbSet<Evaluation> Evaluations { get; set; }
        public virtual DbSet<Evaluationcriterion> Evaluationcriteria { get; set; }
        public virtual DbSet<Evaluationcriteriondef> Evaluationcriteriondefs { get; set; }
        public virtual DbSet<Evaluationdef> Evaluationdefs { get; set; }
        public virtual DbSet<Famaging> Famagings { get; set; }
        public virtual DbSet<Familyhealth> Familyhealths { get; set; }
        public virtual DbSet<Fee> Fees { get; set; }
        public virtual DbSet<Feesched> Feescheds { get; set; }
        public virtual DbSet<Feeschedgroup> Feeschedgroups { get; set; }
        public virtual DbSet<Fhircontactpoint> Fhircontactpoints { get; set; }
        public virtual DbSet<Fhirsubscription> Fhirsubscriptions { get; set; }
        public virtual DbSet<Fielddeflink> Fielddeflinks { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Formpat> Formpats { get; set; }
        public virtual DbSet<Gradingscale> Gradingscales { get; set; }
        public virtual DbSet<Gradingscaleitem> Gradingscaleitems { get; set; }
        public virtual DbSet<Grouppermission> Grouppermissions { get; set; }
        public virtual DbSet<Guardian> Guardians { get; set; }
        public virtual DbSet<Hcpc> Hcpcs { get; set; }
        public virtual DbSet<Histappointment> Histappointments { get; set; }
        public virtual DbSet<Hl7def> Hl7defs { get; set; }
        public virtual DbSet<Hl7deffield> Hl7deffields { get; set; }
        public virtual DbSet<Hl7defmessage> Hl7defmessages { get; set; }
        public virtual DbSet<Hl7defsegment> Hl7defsegments { get; set; }
        public virtual DbSet<Hl7msg> Hl7msgs { get; set; }
        public virtual DbSet<Hl7procattach> Hl7procattaches { get; set; }
        public virtual DbSet<Icd10> Icd10s { get; set; }
        public virtual DbSet<Icd9> Icd9s { get; set; }
        public virtual DbSet<Inseditlog> Inseditlogs { get; set; }
        public virtual DbSet<Inseditpatlog> Inseditpatlogs { get; set; }
        public virtual DbSet<Insfilingcode> Insfilingcodes { get; set; }
        public virtual DbSet<Insfilingcodesubtype> Insfilingcodesubtypes { get; set; }
        public virtual DbSet<Insplan> Insplans { get; set; }
        public virtual DbSet<Inssub> Inssubs { get; set; }
        public virtual DbSet<Installmentplan> Installmentplans { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Insverify> Insverifies { get; set; }
        public virtual DbSet<Insverifyhist> Insverifyhists { get; set; }
        public virtual DbSet<Intervention> Interventions { get; set; }
        public virtual DbSet<Journalentry> Journalentries { get; set; }
        public virtual DbSet<Labcase> Labcases { get; set; }
        public virtual DbSet<Laboratory> Laboratories { get; set; }
        public virtual DbSet<Labpanel> Labpanels { get; set; }
        public virtual DbSet<Labresult> Labresults { get; set; }
        public virtual DbSet<Labturnaround> Labturnarounds { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Languageforeign> Languageforeigns { get; set; }
        public virtual DbSet<Letter> Letters { get; set; }
        public virtual DbSet<Lettermerge> Lettermerges { get; set; }
        public virtual DbSet<Lettermergefield> Lettermergefields { get; set; }
        public virtual DbSet<Loginattempt> Loginattempts { get; set; }
        public virtual DbSet<Loinc> Loincs { get; set; }
        public virtual DbSet<Maparea> Mapareas { get; set; }
        public virtual DbSet<Medicalorder> Medicalorders { get; set; }
        public virtual DbSet<Medication> Medications { get; set; }
        public virtual DbSet<Medicationpat> Medicationpats { get; set; }
        public virtual DbSet<Medlab> Medlabs { get; set; }
        public virtual DbSet<Medlabfacattach> Medlabfacattaches { get; set; }
        public virtual DbSet<Medlabfacility> Medlabfacilities { get; set; }
        public virtual DbSet<Medlabresult> Medlabresults { get; set; }
        public virtual DbSet<Medlabspeciman> Medlabspecimen { get; set; }
        public virtual DbSet<Mobileappdevice> Mobileappdevices { get; set; }
        public virtual DbSet<Mobiledatabyte> Mobiledatabytes { get; set; }
        public virtual DbSet<Mount> Mounts { get; set; }
        public virtual DbSet<Mountdef> Mountdefs { get; set; }
        public virtual DbSet<Mountitem> Mountitems { get; set; }
        public virtual DbSet<Mountitemdef> Mountitemdefs { get; set; }
        public virtual DbSet<Oidexternal> Oidexternals { get; set; }
        public virtual DbSet<Oidinternal> Oidinternals { get; set; }
        public virtual DbSet<Operatory> Operatories { get; set; }
        public virtual DbSet<Orionproc> Orionprocs { get; set; }
        public virtual DbSet<Orthocase> Orthocases { get; set; }
        public virtual DbSet<Orthochart> Orthocharts { get; set; }
        public virtual DbSet<Orthocharttab> Orthocharttabs { get; set; }
        public virtual DbSet<Orthocharttablink> Orthocharttablinks { get; set; }
        public virtual DbSet<Orthoplanlink> Orthoplanlinks { get; set; }
        public virtual DbSet<Orthoproclink> Orthoproclinks { get; set; }
        public virtual DbSet<Orthoschedule> Orthoschedules { get; set; }
        public virtual DbSet<Patfield> Patfields { get; set; }
        public virtual DbSet<Patfielddef> Patfielddefs { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Patientlink> Patientlinks { get; set; }
        public virtual DbSet<Patientnote> Patientnotes { get; set; }
        public virtual DbSet<Patientportalinvite> Patientportalinvites { get; set; }
        public virtual DbSet<Patientrace> Patientraces { get; set; }
        public virtual DbSet<Patplan> Patplans { get; set; }
        public virtual DbSet<Patrestriction> Patrestrictions { get; set; }
        public virtual DbSet<Payconnectresponseweb> Payconnectresponsewebs { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Payortype> Payortypes { get; set; }
        public virtual DbSet<Payperiod> Payperiods { get; set; }
        public virtual DbSet<Payplan> Payplans { get; set; }
        public virtual DbSet<Payplancharge> Payplancharges { get; set; }
        public virtual DbSet<Payplanlink> Payplanlinks { get; set; }
        public virtual DbSet<Paysplit> Paysplits { get; set; }
        public virtual DbSet<Perioexam> Perioexams { get; set; }
        public virtual DbSet<Periomeasure> Periomeasures { get; set; }
        public virtual DbSet<Pharmacy> Pharmacies { get; set; }
        public virtual DbSet<Pharmclinic> Pharmclinics { get; set; }
        public virtual DbSet<Phonenumber> Phonenumbers { get; set; }
        public virtual DbSet<Plannedappt> Plannedappts { get; set; }
        public virtual DbSet<Popup> Popups { get; set; }
        public virtual DbSet<Preference> Preferences { get; set; }
        public virtual DbSet<Printer> Printers { get; set; }
        public virtual DbSet<Procapptcolor> Procapptcolors { get; set; }
        public virtual DbSet<Procbutton> Procbuttons { get; set; }
        public virtual DbSet<Procbuttonitem> Procbuttonitems { get; set; }
        public virtual DbSet<Procbuttonquick> Procbuttonquicks { get; set; }
        public virtual DbSet<Proccodenote> Proccodenotes { get; set; }
        public virtual DbSet<Procedurecode> Procedurecodes { get; set; }
        public virtual DbSet<Procedurelog> Procedurelogs { get; set; }
        public virtual DbSet<Procgroupitem> Procgroupitems { get; set; }
        public virtual DbSet<Procmultivisit> Procmultivisits { get; set; }
        public virtual DbSet<Procnote> Procnotes { get; set; }
        public virtual DbSet<Proctp> Proctps { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<Programproperty> Programproperties { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Promotionlog> Promotionlogs { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Providerclinic> Providerclinics { get; set; }
        public virtual DbSet<Providercliniclink> Providercliniclinks { get; set; }
        public virtual DbSet<Providererx> Providererxes { get; set; }
        public virtual DbSet<Providerident> Provideridents { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Questiondef> Questiondefs { get; set; }
        public virtual DbSet<Quickpastecat> Quickpastecats { get; set; }
        public virtual DbSet<Quickpastenote> Quickpastenotes { get; set; }
        public virtual DbSet<Reactivation> Reactivations { get; set; }
        public virtual DbSet<Recall> Recalls { get; set; }
        public virtual DbSet<Recalltrigger> Recalltriggers { get; set; }
        public virtual DbSet<Recalltype> Recalltypes { get; set; }
        public virtual DbSet<Reconcile> Reconciles { get; set; }
        public virtual DbSet<Recurringcharge> Recurringcharges { get; set; }
        public virtual DbSet<Refattach> Refattaches { get; set; }
        public virtual DbSet<Referral> Referrals { get; set; }
        public virtual DbSet<Registrationkey> Registrationkeys { get; set; }
        public virtual DbSet<Reminderrule> Reminderrules { get; set; }
        public virtual DbSet<Repeatcharge> Repeatcharges { get; set; }
        public virtual DbSet<Replicationserver> Replicationservers { get; set; }
        public virtual DbSet<Reqneeded> Reqneededs { get; set; }
        public virtual DbSet<Reqstudent> Reqstudents { get; set; }
        public virtual DbSet<Requiredfield> Requiredfields { get; set; }
        public virtual DbSet<Requiredfieldcondition> Requiredfieldconditions { get; set; }
        public virtual DbSet<Reseller> Resellers { get; set; }
        public virtual DbSet<Resellerservice> Resellerservices { get; set; }
        public virtual DbSet<Rxalert> Rxalerts { get; set; }
        public virtual DbSet<Rxdef> Rxdefs { get; set; }
        public virtual DbSet<Rxnorm> Rxnorms { get; set; }
        public virtual DbSet<Rxpat> Rxpats { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Scheduledprocess> Scheduledprocesses { get; set; }
        public virtual DbSet<Scheduleop> Scheduleops { get; set; }
        public virtual DbSet<Schoolclass> Schoolclasses { get; set; }
        public virtual DbSet<Schoolcourse> Schoolcourses { get; set; }
        public virtual DbSet<Screen> Screens { get; set; }
        public virtual DbSet<Screengroup> Screengroups { get; set; }
        public virtual DbSet<Screenpat> Screenpats { get; set; }
        public virtual DbSet<Securitylog> Securitylogs { get; set; }
        public virtual DbSet<Securityloghash> Securityloghashes { get; set; }
        public virtual DbSet<Sheet> Sheets { get; set; }
        public virtual DbSet<Sheetdef> Sheetdefs { get; set; }
        public virtual DbSet<Sheetfield> Sheetfields { get; set; }
        public virtual DbSet<Sheetfielddef> Sheetfielddefs { get; set; }
        public virtual DbSet<Sigbutdef> Sigbutdefs { get; set; }
        public virtual DbSet<Sigelementdef> Sigelementdefs { get; set; }
        public virtual DbSet<Sigmessage> Sigmessages { get; set; }
        public virtual DbSet<Signalod> Signalods { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<Smsblockphone> Smsblockphones { get; set; }
        public virtual DbSet<Smsfrommobile> Smsfrommobiles { get; set; }
        public virtual DbSet<Smsphone> Smsphones { get; set; }
        public virtual DbSet<Smstomobile> Smstomobiles { get; set; }
        public virtual DbSet<Snomed> Snomeds { get; set; }
        public virtual DbSet<Sop> Sops { get; set; }
        public virtual DbSet<Stateabbr> Stateabbrs { get; set; }
        public virtual DbSet<Statement> Statements { get; set; }
        public virtual DbSet<Stmtlink> Stmtlinks { get; set; }
        public virtual DbSet<Substitutionlink> Substitutionlinks { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Supply> Supplies { get; set; }
        public virtual DbSet<Supplyneeded> Supplyneededs { get; set; }
        public virtual DbSet<Supplyorder> Supplyorders { get; set; }
        public virtual DbSet<Supplyorderitem> Supplyorderitems { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Taskancestor> Taskancestors { get; set; }
        public virtual DbSet<Taskhist> Taskhists { get; set; }
        public virtual DbSet<Tasklist> Tasklists { get; set; }
        public virtual DbSet<Tasknote> Tasknotes { get; set; }
        public virtual DbSet<Tasksubscription> Tasksubscriptions { get; set; }
        public virtual DbSet<Taskunread> Taskunreads { get; set; }
        public virtual DbSet<Terminalactive> Terminalactives { get; set; }
        public virtual DbSet<Timeadjust> Timeadjusts { get; set; }
        public virtual DbSet<Timecardrule> Timecardrules { get; set; }
        public virtual DbSet<Toolbutitem> Toolbutitems { get; set; }
        public virtual DbSet<Toothgridcell> Toothgridcells { get; set; }
        public virtual DbSet<Toothgridcol> Toothgridcols { get; set; }
        public virtual DbSet<Toothgriddef> Toothgriddefs { get; set; }
        public virtual DbSet<Toothinitial> Toothinitials { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Treatplan> Treatplans { get; set; }
        public virtual DbSet<Treatplanattach> Treatplanattaches { get; set; }
        public virtual DbSet<Tsitranslog> Tsitranslogs { get; set; }
        public virtual DbSet<Ucum> Ucums { get; set; }
        public virtual DbSet<Updatehistory> Updatehistories { get; set; }
        public virtual DbSet<Userclinic> Userclinics { get; set; }
        public virtual DbSet<Usergroup> Usergroups { get; set; }
        public virtual DbSet<Usergroupattach> Usergroupattaches { get; set; }
        public virtual DbSet<Userod> Userods { get; set; }
        public virtual DbSet<Userodapptview> Userodapptviews { get; set; }
        public virtual DbSet<Userodpref> Userodprefs { get; set; }
        public virtual DbSet<Userquery> Userqueries { get; set; }
        public virtual DbSet<Userweb> Userwebs { get; set; }
        public virtual DbSet<Vaccinedef> Vaccinedefs { get; set; }
        public virtual DbSet<Vaccineob> Vaccineobs { get; set; }
        public virtual DbSet<Vaccinepat> Vaccinepats { get; set; }
        public virtual DbSet<Vitalsign> Vitalsigns { get; set; }
        public virtual DbSet<Webschedrecall> Webschedrecalls { get; set; }
        public virtual DbSet<Wikilistheaderwidth> Wikilistheaderwidths { get; set; }
        public virtual DbSet<Wikilisthist> Wikilisthists { get; set; }
        public virtual DbSet<Wikipage> Wikipages { get; set; }
        public virtual DbSet<Wikipagehist> Wikipagehists { get; set; }
        public virtual DbSet<Xchargetransaction> Xchargetransactions { get; set; }
        public virtual DbSet<Xwebresponse> Xwebresponses { get; set; }
        public virtual DbSet<Zipcode> Zipcodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=opendental;user=root;password=Ef1956Baby45$;treattinyasboolean=true", Microsoft.EntityFrameworkCore.ServerVersion.FromString("5.5.14-mysql"));
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccountNum)
                    .HasName("PRIMARY");

                entity.ToTable("account");

                entity.Property(e => e.AccountNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AccountColor).HasColumnType("int(11)");

                entity.Property(e => e.AcctType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.BankNumber)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Inactive).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Accountingautopay>(entity =>
            {
                entity.HasKey(e => e.AccountingAutoPayNum)
                    .HasName("PRIMARY");

                entity.ToTable("accountingautopay");

                entity.Property(e => e.AccountingAutoPayNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayType).HasColumnType("bigint(20)");

                entity.Property(e => e.PickList)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Adjustment>(entity =>
            {
                entity.HasKey(e => e.AdjNum)
                    .HasName("PRIMARY");

                entity.ToTable("adjustment");

                entity.HasIndex(e => new { e.AdjDate, e.PatNum }, "AdjDatePN");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.ProcNum, "ProcNum");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => e.StatementNum, "StatementNum");

                entity.HasIndex(e => e.TaxTransId, "TaxTransID");

                entity.HasIndex(e => new { e.ProcNum, e.AdjAmt }, "indexPNAmt");

                entity.HasIndex(e => e.PatNum, "indexPatNum");

                entity.HasIndex(e => e.ProvNum, "indexProvNum");

                entity.Property(e => e.AdjNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AdjDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.AdjNote)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdjType).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.StatementNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TaxTransId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("TaxTransID");
            });

            modelBuilder.Entity<Alertcategory>(entity =>
            {
                entity.HasKey(e => e.AlertCategoryNum)
                    .HasName("PRIMARY");

                entity.ToTable("alertcategory");

                entity.Property(e => e.AlertCategoryNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InternalName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsHqcategory)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("IsHQCategory");
            });

            modelBuilder.Entity<Alertcategorylink>(entity =>
            {
                entity.HasKey(e => e.AlertCategoryLinkNum)
                    .HasName("PRIMARY");

                entity.ToTable("alertcategorylink");

                entity.HasIndex(e => e.AlertCategoryNum, "AlertCategoryNum");

                entity.Property(e => e.AlertCategoryLinkNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AlertCategoryNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AlertType).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Alertitem>(entity =>
            {
                entity.HasKey(e => e.AlertItemNum)
                    .HasName("PRIMARY");

                entity.ToTable("alertitem");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.AlertItemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Actions).HasColumnType("tinyint(4)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.FormToOpen).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemValue)
                    .IsRequired()
                    .HasColumnType("varchar(4000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Severity).HasColumnType("tinyint(4)");

                entity.Property(e => e.Type).HasColumnType("tinyint(4)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Alertread>(entity =>
            {
                entity.HasKey(e => e.AlertReadNum)
                    .HasName("PRIMARY");

                entity.ToTable("alertread");

                entity.HasIndex(e => e.AlertItemNum, "AlertItemNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.AlertReadNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AlertItemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Alertsub>(entity =>
            {
                entity.HasKey(e => e.AlertSubNum)
                    .HasName("PRIMARY");

                entity.ToTable("alertsub");

                entity.HasIndex(e => e.AlertCategoryNum, "AlertCategoryNum");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.AlertSubNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AlertCategoryNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Type).HasColumnType("tinyint(4)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Allergy>(entity =>
            {
                entity.HasKey(e => e.AllergyNum)
                    .HasName("PRIMARY");

                entity.ToTable("allergy");

                entity.HasIndex(e => e.AllergyDefNum, "AllergyDefNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.AllergyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AllergyDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateAdverseReaction)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Reaction)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SnomedReaction)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StatusIsActive).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Allergydef>(entity =>
            {
                entity.HasKey(e => e.AllergyDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("allergydef");

                entity.HasIndex(e => e.MedicationNum, "MedicationNum");

                entity.Property(e => e.AllergyDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(4)");

                entity.Property(e => e.MedicationNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SnomedType).HasColumnType("tinyint(4)");

                entity.Property(e => e.UniiCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Anestheticdatum>(entity =>
            {
                entity.HasKey(e => e.AnestheticDataNum)
                    .HasName("PRIMARY");

                entity.ToTable("anestheticdata");

                entity.HasIndex(e => e.AnestheticRecordNum, "AnestheticRecordNum");

                entity.Property(e => e.AnestheticDataNum).HasColumnType("int(11)");

                entity.Property(e => e.AnesthClose)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AnesthOpen)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AnestheticRecordNum).HasColumnType("int(11)");

                entity.Property(e => e.Anesthetist)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Asa)
                    .HasColumnType("char(3)")
                    .HasColumnName("ASA")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AsaEmodifier)
                    .HasColumnType("char(1)")
                    .HasColumnName("ASA_EModifier")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Asst)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Circulator)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EscortCellNum)
                    .HasColumnType("char(13)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EscortName)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EscortRel)
                    .HasColumnType("char(16)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ivatt)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("IVAtt");

                entity.Property(e => e.Ivf)
                    .HasColumnType("char(20)")
                    .HasColumnName("IVF")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ivfvol).HasColumnName("IVFVol");

                entity.Property(e => e.Ivgauge)
                    .HasColumnType("smallint(2)")
                    .HasColumnName("IVGauge");

                entity.Property(e => e.IvsideL)
                    .HasColumnType("smallint(2)")
                    .HasColumnName("IVSideL");

                entity.Property(e => e.IvsideR)
                    .HasColumnType("smallint(2)")
                    .HasColumnName("IVSideR");

                entity.Property(e => e.Ivsite)
                    .HasColumnType("char(20)")
                    .HasColumnName("IVSite")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedRouteIm).HasColumnName("MedRouteIM");

                entity.Property(e => e.MedRouteIvbuttFly).HasColumnName("MedRouteIVButtFly");

                entity.Property(e => e.MedRouteIvcath).HasColumnName("MedRouteIVCath");

                entity.Property(e => e.MedRoutePo).HasColumnName("MedRoutePO");

                entity.Property(e => e.MonBp).HasColumnName("MonBP");

                entity.Property(e => e.MonEkg).HasColumnName("MonEKG");

                entity.Property(e => e.MonEtCo2).HasColumnName("MonEtCO2");

                entity.Property(e => e.N2olmin)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("N2OLMin");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Npotime)
                    .HasColumnType("char(5)")
                    .HasColumnName("NPOTime")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.O2lmin)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("O2LMin");

                entity.Property(e => e.PatHgt).HasColumnType("smallint(3)");

                entity.Property(e => e.PatWgt).HasColumnType("smallint(3)");

                entity.Property(e => e.RteEtt).HasColumnName("RteETT");

                entity.Property(e => e.SigIsTopaz)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Signature)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SurgClose)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SurgOpen)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Surgeon)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Vsmname)
                    .HasColumnType("char(20)")
                    .HasColumnName("VSMName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VsmserNum)
                    .HasColumnType("char(20)")
                    .HasColumnName("VSMSerNum")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Anestheticrecord>(entity =>
            {
                entity.HasKey(e => e.AnestheticRecordNum)
                    .HasName("PRIMARY");

                entity.ToTable("anestheticrecord");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.Property(e => e.AnestheticRecordNum).HasColumnType("int(11)");

                entity.Property(e => e.PatNum).HasColumnType("int(11)");

                entity.Property(e => e.ProvNum).HasColumnType("smallint(5)");
            });

            modelBuilder.Entity<Anesthmedsgiven>(entity =>
            {
                entity.HasKey(e => e.AnestheticMedNum)
                    .HasName("PRIMARY");

                entity.ToTable("anesthmedsgiven");

                entity.Property(e => e.AnestheticMedNum).HasColumnType("int(3)");

                entity.Property(e => e.AnesthMedName)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AnesthMedNum).HasColumnType("int(11)");

                entity.Property(e => e.AnestheticRecordNum).HasColumnType("int(11)");

                entity.Property(e => e.DoseTimeStamp)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Anesthmedsintake>(entity =>
            {
                entity.HasKey(e => e.AnestheticMedNum)
                    .HasName("PRIMARY");

                entity.ToTable("anesthmedsintake");

                entity.Property(e => e.AnestheticMedNum).HasColumnType("int(3)");

                entity.Property(e => e.AnesthMedName)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InvoiceNum)
                    .IsRequired()
                    .HasColumnType("char(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Qty).HasColumnType("int(6)");

                entity.Property(e => e.SupplierIdnum)
                    .IsRequired()
                    .HasColumnType("char(11)")
                    .HasColumnName("SupplierIDNum")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Anesthmedsinventory>(entity =>
            {
                entity.HasKey(e => e.AnestheticMedNum)
                    .HasName("PRIMARY");

                entity.ToTable("anesthmedsinventory");

                entity.Property(e => e.AnestheticMedNum).HasColumnType("int(11)");

                entity.Property(e => e.AnesthHowSupplied)
                    .IsRequired()
                    .HasColumnType("char(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AnesthMedName)
                    .HasColumnType("char(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Deaschedule)
                    .HasColumnType("char(3)")
                    .HasColumnName("DEASchedule")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QtyOnHand).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Anesthmedsinventoryadj>(entity =>
            {
                entity.HasKey(e => e.AdjustNum)
                    .HasName("PRIMARY");

                entity.ToTable("anesthmedsinventoryadj");

                entity.HasIndex(e => e.AnestheticMedNum, "AnestheticMedNum");

                entity.Property(e => e.AdjustNum).HasColumnType("int(11)");

                entity.Property(e => e.AnestheticMedNum).HasColumnType("int(11)");

                entity.Property(e => e.Notes)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserNum).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Anesthmedsupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierIdnum)
                    .HasName("PRIMARY");

                entity.ToTable("anesthmedsuppliers");

                entity.Property(e => e.SupplierIdnum)
                    .HasColumnType("int(3)")
                    .HasColumnName("SupplierIDNum");

                entity.Property(e => e.Addr1)
                    .HasColumnType("varchar(48)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Addr2)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnType("varchar(48)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Contact)
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fax)
                    .HasColumnType("char(13)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .HasColumnType("char(13)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneExt)
                    .HasColumnType("char(6)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State)
                    .HasColumnType("char(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WebSite)
                    .HasColumnType("varchar(48)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zip)
                    .HasColumnType("char(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Anesthscore>(entity =>
            {
                entity.HasKey(e => e.AnesthScoreNum)
                    .HasName("PRIMARY");

                entity.ToTable("anesthscore");

                entity.HasIndex(e => e.AnestheticRecordNum, "AnestheticRecordNum");

                entity.Property(e => e.AnesthScoreNum).HasColumnType("int(11)");

                entity.Property(e => e.AnesthesiaScore).HasColumnType("smallint(2)");

                entity.Property(e => e.AnestheticRecordNum).HasColumnType("int(11)");

                entity.Property(e => e.Qactivity)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("QActivity");

                entity.Property(e => e.Qcirc)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("QCirc");

                entity.Property(e => e.Qcolor)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("QColor");

                entity.Property(e => e.Qconc)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("QConc");

                entity.Property(e => e.Qresp)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("QResp");
            });

            modelBuilder.Entity<Anesthvsdatum>(entity =>
            {
                entity.HasKey(e => e.AnesthVsdataNum)
                    .HasName("PRIMARY");

                entity.ToTable("anesthvsdata");

                entity.Property(e => e.AnesthVsdataNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("AnesthVSDataNum");

                entity.Property(e => e.AnestheticRecordNum).HasColumnType("int(11)");

                entity.Property(e => e.Bpdias)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("BPDias");

                entity.Property(e => e.Bpmap)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("BPMAP");

                entity.Property(e => e.Bpsys)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("BPSys");

                entity.Property(e => e.EtCo2).HasColumnType("smallint(3)");

                entity.Property(e => e.Hl7message)
                    .HasColumnType("longtext")
                    .HasColumnName("HL7Message")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hr)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("HR");

                entity.Property(e => e.MessageId)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("MessageID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("int(11)");

                entity.Property(e => e.SpO2).HasColumnType("smallint(3)");

                entity.Property(e => e.Temp).HasColumnType("smallint(3)");

                entity.Property(e => e.Vsmname)
                    .HasColumnType("char(20)")
                    .HasColumnName("VSMName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VsmserNum)
                    .HasColumnType("char(32)")
                    .HasColumnName("VSMSerNum")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VstimeStamp)
                    .HasColumnType("char(32)")
                    .HasColumnName("VSTimeStamp")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.AptNum)
                    .HasName("PRIMARY");

                entity.ToTable("appointment");

                entity.HasIndex(e => e.AppointmentTypeNum, "AppointmentTypeNum");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.DateTimeArrived, "DateTimeArrived");

                entity.HasIndex(e => e.InsPlan1, "InsPlan1");

                entity.HasIndex(e => e.InsPlan2, "InsPlan2");

                entity.HasIndex(e => e.Op, "Op");

                entity.HasIndex(e => e.Priority, "Priority");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => new { e.AptStatus, e.AptDateTime, e.ClinicNum }, "StatusDate");

                entity.HasIndex(e => e.UnschedStatus, "UnschedStatus");

                entity.HasIndex(e => e.AptDateTime, "indexAptDateTime");

                entity.HasIndex(e => e.NextAptNum, "indexNextAptNum");

                entity.HasIndex(e => e.PatNum, "indexPatNum");

                entity.HasIndex(e => e.ProvHyg, "indexProvHyg");

                entity.HasIndex(e => e.ProvNum, "indexProvNum");

                entity.Property(e => e.AptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AppointmentTypeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AptDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.AptStatus).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Assistant).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ColorOverride).HasColumnType("int(11)");

                entity.Property(e => e.Confirmed).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeAskedToArrive).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.InsPlan1).HasColumnType("bigint(20)");

                entity.Property(e => e.InsPlan2).HasColumnType("bigint(20)");

                entity.Property(e => e.IsHygiene).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.IsNewPatient).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.NextAptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Op).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Pattern)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatternSecondary)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Priority).HasColumnType("tinyint(4)");

                entity.Property(e => e.ProcDescript)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcsColored)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvBarText)
                    .IsRequired()
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvHyg).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.UnschedStatus).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Appointmentrule>(entity =>
            {
                entity.HasKey(e => e.AppointmentRuleNum)
                    .HasName("PRIMARY");

                entity.ToTable("appointmentrule");

                entity.Property(e => e.AppointmentRuleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeEnd)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeStart)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsEnabled).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RuleDesc)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Appointmenttype>(entity =>
            {
                entity.HasKey(e => e.AppointmentTypeNum)
                    .HasName("PRIMARY");

                entity.ToTable("appointmenttype");

                entity.Property(e => e.AppointmentTypeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AppointmentTypeColor).HasColumnType("int(11)");

                entity.Property(e => e.AppointmentTypeName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeStr)
                    .IsRequired()
                    .HasColumnType("varchar(4000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.Pattern)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Apptfield>(entity =>
            {
                entity.HasKey(e => e.ApptFieldNum)
                    .HasName("PRIMARY");

                entity.ToTable("apptfield");

                entity.HasIndex(e => e.AptNum, "AptNum");

                entity.Property(e => e.ApptFieldNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldValue)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Apptfielddef>(entity =>
            {
                entity.HasKey(e => e.ApptFieldDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("apptfielddef");

                entity.Property(e => e.ApptFieldDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldType).HasColumnType("tinyint(4)");

                entity.Property(e => e.PickList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Apptreminderrule>(entity =>
            {
                entity.HasKey(e => e.ApptReminderRuleNum)
                    .HasName("PRIMARY");

                entity.ToTable("apptreminderrule");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.Tsprior, "TSPrior");

                entity.Property(e => e.ApptReminderRuleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AggEmailTemplateType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DoNotSendWithin).HasColumnType("bigint(20)");

                entity.Property(e => e.EmailTemplateType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsAutoReplyEnabled).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsEnabled).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsSendAll).HasColumnType("tinyint(4)");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SendOrder)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateAutoReply)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateAutoReplyAgg)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateComeInMessage)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateEmail)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateEmailAggPerAppt)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateEmailAggShared)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateEmailSubjAggShared)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateEmailSubject)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateSms)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("TemplateSMS")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateSmsaggPerAppt)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("TemplateSMSAggPerAppt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateSmsaggShared)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("TemplateSMSAggShared")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tsprior)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("TSPrior");

                entity.Property(e => e.TypeCur).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Apptremindersent>(entity =>
            {
                entity.HasKey(e => e.ApptReminderSentNum)
                    .HasName("PRIMARY");

                entity.ToTable("apptremindersent");

                entity.HasIndex(e => e.ApptNum, "ApptNum");

                entity.HasIndex(e => e.ApptReminderRuleNum, "ApptReminderRuleNum");

                entity.HasIndex(e => e.Tsprior, "TSPrior");

                entity.Property(e => e.ApptReminderSentNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ApptDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ApptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ApptReminderRuleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeSent).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.IsEmailSent).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsSmsSent).HasColumnType("tinyint(4)");

                entity.Property(e => e.Tsprior)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("TSPrior");
            });

            modelBuilder.Entity<Apptthankyousent>(entity =>
            {
                entity.HasKey(e => e.ApptThankYouSentNum)
                    .HasName("PRIMARY");

                entity.ToTable("apptthankyousent");

                entity.HasIndex(e => e.ApptDateTime, "ApptDateTime");

                entity.HasIndex(e => e.ApptNum, "ApptNum");

                entity.HasIndex(e => e.ApptReminderRuleNum, "ApptReminderRuleNum");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.Tsprior, "TSPrior");

                entity.Property(e => e.ApptThankYouSentNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ApptDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ApptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ApptReminderRuleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ApptSecDateTentry)
                    .HasColumnName("ApptSecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeThankYouTransmit).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DoNotResend).HasColumnType("tinyint(4)");

                entity.Property(e => e.EmailSentStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.EmailSubj)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailSubjTemplate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailTextTemplate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GuidMessageToMobile)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsForEmail).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsForSms).HasColumnType("tinyint(4)");

                entity.Property(e => e.MsgTextToMobile)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MsgTextToMobileTemplate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PhonePat)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResponseDescript)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShortGuid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ShortGUID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShortGuidEmail)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SmsSentStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.Tsprior)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("TSPrior");
            });

            modelBuilder.Entity<Apptview>(entity =>
            {
                entity.HasKey(e => e.ApptViewNum)
                    .HasName("PRIMARY");

                entity.ToTable("apptview");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.Property(e => e.ApptViewNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsApptBubblesDisabled).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsScrollStartDynamic).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.OnlyScheduledProvs).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RowsPerIncr)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.StackBehavLr)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("StackBehavLR");

                entity.Property(e => e.StackBehavUr)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("StackBehavUR");

                entity.Property(e => e.WidthOpMinimum).HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<Apptviewitem>(entity =>
            {
                entity.HasKey(e => e.ApptViewItemNum)
                    .HasName("PRIMARY");

                entity.ToTable("apptviewitem");

                entity.HasIndex(e => e.OpNum, "OpNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.Property(e => e.ApptViewItemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ApptFieldDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ApptViewNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ElementAlignment).HasColumnType("tinyint(4)");

                entity.Property(e => e.ElementColor).HasColumnType("int(11)");

                entity.Property(e => e.ElementDesc)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ElementOrder).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.OpNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatFieldDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Asapcomm>(entity =>
            {
                entity.HasKey(e => e.AsapCommNum)
                    .HasName("PRIMARY");

                entity.ToTable("asapcomm");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.EmailMessageNum, "EmailMessageNum");

                entity.HasIndex(e => e.EmailSendStatus, "EmailSendStatus");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ScheduleNum, "ScheduleNum");

                entity.HasIndex(e => e.ShortGuid, "ShortGUID");

                entity.HasIndex(e => e.SmsSendStatus, "SmsSendStatus");

                entity.Property(e => e.AsapCommNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeEmailSent).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeExpire).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeOrig).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeSmsScheduled).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeSmsSent).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.EmailMessageNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EmailSendStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.EmailTemplateType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.FkeyType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("FKeyType");

                entity.Property(e => e.GuidMessageToMobile)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ResponseStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.ScheduleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ShortGuid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ShortGUID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SmsSendStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.TemplateEmail)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateEmailSubj)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Autocode>(entity =>
            {
                entity.HasKey(e => e.AutoCodeNum)
                    .HasName("PRIMARY");

                entity.ToTable("autocode");

                entity.Property(e => e.AutoCodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.LessIntrusive).HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<Autocodecond>(entity =>
            {
                entity.HasKey(e => e.AutoCodeCondNum)
                    .HasName("PRIMARY");

                entity.ToTable("autocodecond");

                entity.Property(e => e.AutoCodeCondNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AutoCodeItemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Cond).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Autocodeitem>(entity =>
            {
                entity.HasKey(e => e.AutoCodeItemNum)
                    .HasName("PRIMARY");

                entity.ToTable("autocodeitem");

                entity.Property(e => e.AutoCodeItemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AutoCodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.OldCode)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");
            });

            modelBuilder.Entity<Automation>(entity =>
            {
                entity.HasKey(e => e.AutomationNum)
                    .HasName("PRIMARY");

                entity.ToTable("automation");

                entity.HasIndex(e => e.AppointmentTypeNum, "AppointmentTypeNum");

                entity.Property(e => e.AutomationNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AppointmentTypeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AptStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.AutoAction).HasColumnType("tinyint(4)");

                entity.Property(e => e.Autotrigger).HasColumnType("tinyint(4)");

                entity.Property(e => e.CommType).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MessageContent)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.ProcCodes)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SheetDefNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Automationcondition>(entity =>
            {
                entity.HasKey(e => e.AutomationConditionNum)
                    .HasName("PRIMARY");

                entity.ToTable("automationcondition");

                entity.HasIndex(e => e.AutomationNum, "AutomationNum");

                entity.Property(e => e.AutomationConditionNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AutomationNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CompareField).HasColumnType("tinyint(4)");

                entity.Property(e => e.CompareString)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Comparison).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Autonote>(entity =>
            {
                entity.HasKey(e => e.AutoNoteNum)
                    .HasName("PRIMARY");

                entity.ToTable("autonote");

                entity.HasIndex(e => e.Category, "Category");

                entity.Property(e => e.AutoNoteNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AutoNoteName)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Category).HasColumnType("bigint(20)");

                entity.Property(e => e.MainText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Autonotecontrol>(entity =>
            {
                entity.HasKey(e => e.AutoNoteControlNum)
                    .HasName("PRIMARY");

                entity.ToTable("autonotecontrol");

                entity.Property(e => e.AutoNoteControlNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ControlLabel)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ControlOptions)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ControlType)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Descript)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Benefit>(entity =>
            {
                entity.HasKey(e => e.BenefitNum)
                    .HasName("PRIMARY");

                entity.ToTable("benefit");

                entity.HasIndex(e => e.BenefitType, "BenefitType");

                entity.HasIndex(e => e.CodeNum, "CodeNum");

                entity.HasIndex(e => e.CovCatNum, "CovCatNum");

                entity.HasIndex(e => e.CoverageLevel, "CoverageLevel");

                entity.HasIndex(e => e.MonetaryAmt, "MonetaryAmt");

                entity.HasIndex(e => e.Percent, "Percent");

                entity.HasIndex(e => e.Quantity, "Quantity");

                entity.HasIndex(e => e.QuantityQualifier, "QuantityQualifier");

                entity.HasIndex(e => e.SecDateTedit, "SecDateTEdit");

                entity.HasIndex(e => e.SecDateTentry, "SecDateTEntry");

                entity.HasIndex(e => e.TimePeriod, "TimePeriod");

                entity.HasIndex(e => e.PatPlanNum, "indexPatPlanNum");

                entity.HasIndex(e => e.PlanNum, "indexPlanNum");

                entity.Property(e => e.BenefitNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BenefitType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.CodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CovCatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CoverageLevel).HasColumnType("int(11)");

                entity.Property(e => e.PatPlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Percent).HasColumnType("tinyint(4)");

                entity.Property(e => e.PlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Quantity).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.QuantityQualifier).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.TimePeriod).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Canadiannetwork>(entity =>
            {
                entity.HasKey(e => e.CanadianNetworkNum)
                    .HasName("PRIMARY");

                entity.ToTable("canadiannetwork");

                entity.Property(e => e.CanadianNetworkNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Abbrev)
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CanadianIsRprHandler).HasColumnType("tinyint(4)");

                entity.Property(e => e.CanadianTransactionPrefix)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Descript)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Carecreditwebresponse>(entity =>
            {
                entity.HasKey(e => e.CareCreditWebResponseNum)
                    .HasName("PRIMARY");

                entity.ToTable("carecreditwebresponse");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.PayNum, "PayNum");

                entity.Property(e => e.CareCreditWebResponseNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeCompleted).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeExpired).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeLastError).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimePending).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.LastResponseStr)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcessingStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WebToken)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Carrier>(entity =>
            {
                entity.HasKey(e => e.CarrierNum)
                    .HasName("PRIMARY");

                entity.ToTable("carrier");

                entity.HasIndex(e => e.CanadianNetworkNum, "CanadianNetworkNum");

                entity.HasIndex(e => e.CarrierGroupName, "CarrierGroupName");

                entity.HasIndex(e => new { e.CarrierNum, e.CarrierName }, "CarrierNumName");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.Property(e => e.CarrierNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address2)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ApptTextBackColor).HasColumnType("int(11)");

                entity.Property(e => e.CanadianEncryptionMethod).HasColumnType("tinyint(4)");

                entity.Property(e => e.CanadianNetworkNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CanadianSupportedTypes).HasColumnType("int(11)");

                entity.Property(e => e.CarrierGroupName).HasColumnType("bigint(20)");

                entity.Property(e => e.CarrierName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CdanetVersion)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("CDAnetVersion")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ElectId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ElectID")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsCda)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("IsCDA");

                entity.Property(e => e.IsCoinsuranceInverted).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(4)");

                entity.Property(e => e.NoSendElect).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecDateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.State)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tin)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TIN")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TrustedEtransFlags).HasColumnType("tinyint(4)");

                entity.Property(e => e.Zip)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Cdcrec>(entity =>
            {
                entity.HasKey(e => e.CdcrecNum)
                    .HasName("PRIMARY");

                entity.ToTable("cdcrec");

                entity.HasIndex(e => e.CdcrecCode, "CdcrecCode");

                entity.Property(e => e.CdcrecNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CdcrecCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HeirarchicalCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Cdspermission>(entity =>
            {
                entity.HasKey(e => e.CdspermissionNum)
                    .HasName("PRIMARY");

                entity.ToTable("cdspermission");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.CdspermissionNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("CDSPermissionNum");

                entity.Property(e => e.AllergyCds)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("AllergyCDS");

                entity.Property(e => e.DemographicCds)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("DemographicCDS");

                entity.Property(e => e.EditBibliography).HasColumnType("tinyint(4)");

                entity.Property(e => e.LabTestCds)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("LabTestCDS");

                entity.Property(e => e.MedicationCds)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("MedicationCDS");

                entity.Property(e => e.ProblemCds)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("ProblemCDS");

                entity.Property(e => e.SetupCds)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("SetupCDS");

                entity.Property(e => e.ShowCds)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("ShowCDS");

                entity.Property(e => e.ShowInfobutton).HasColumnType("tinyint(4)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");

                entity.Property(e => e.VitalCds)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("VitalCDS");
            });

            modelBuilder.Entity<Centralconnection>(entity =>
            {
                entity.HasKey(e => e.CentralConnectionNum)
                    .HasName("PRIMARY");

                entity.ToTable("centralconnection");

                entity.Property(e => e.CentralConnectionNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ConnectionStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DatabaseName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HasClinicBreakdownReports).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.MySqlPassword)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MySqlUser)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OdPassword)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OdUser)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceUri)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ServiceURI")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WebServiceIsEcw).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Chartview>(entity =>
            {
                entity.HasKey(e => e.ChartViewNum)
                    .HasName("PRIMARY");

                entity.ToTable("chartview");

                entity.Property(e => e.ChartViewNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DatesShowing).HasColumnType("tinyint(4)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsAudit).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsTpCharting).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.ObjectTypes).HasColumnType("smallint(6)");

                entity.Property(e => e.OrionStatusFlags).HasColumnType("int(11)");

                entity.Property(e => e.ProcStatuses).HasColumnType("tinyint(4)");

                entity.Property(e => e.SelectedTeethOnly).HasColumnType("tinyint(4)");

                entity.Property(e => e.ShowProcNotes).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Claim>(entity =>
            {
                entity.HasKey(e => e.ClaimNum)
                    .HasName("PRIMARY");

                entity.ToTable("claim");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.CustomTracking, "CustomTracking");

                entity.HasIndex(e => e.InsSubNum, "InsSubNum");

                entity.HasIndex(e => e.InsSubNum2, "InsSubNum2");

                entity.HasIndex(e => e.OrderingReferralNum, "OrderingReferralNum");

                entity.HasIndex(e => e.ProvBill, "ProvBill");

                entity.HasIndex(e => e.ProvOrderOverride, "ProvOrderOverride");

                entity.HasIndex(e => e.ProvTreat, "ProvTreat");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => new { e.PlanNum, e.ClaimStatus, e.ClaimType, e.PatNum, e.ClaimNum, e.DateService, e.ProvTreat, e.ClaimFee, e.ClinicNum }, "indexOutClaimCovering");

                entity.HasIndex(e => e.PatNum, "indexPatNum");

                entity.HasIndex(e => e.PlanNum, "indexPlanNum");

                entity.Property(e => e.ClaimNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AccidentDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.AccidentRelated)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AccidentSt)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("AccidentST")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdmissionSourceCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdmissionTypeCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AttachedFlags)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AttachedImages).HasColumnType("int(11)");

                entity.Property(e => e.AttachedModels).HasColumnType("int(11)");

                entity.Property(e => e.AttachmentId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("AttachmentID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CanadaEstTreatStartDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.CanadaNumAnticipatedPayments).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.CanadaPaymentMode).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.CanadaTransRefNum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CanadaTreatDuration).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.CanadianDateInitialLower)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.CanadianDateInitialUpper)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.CanadianIsInitialLower)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CanadianIsInitialUpper)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CanadianMandProsthMaterial).HasColumnType("tinyint(4)");

                entity.Property(e => e.CanadianMaterialsForwarded)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CanadianMaxProsthMaterial).HasColumnType("tinyint(4)");

                entity.Property(e => e.CanadianReferralProviderNum)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CanadianReferralReason).HasColumnType("tinyint(4)");

                entity.Property(e => e.ClaimForm).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimIdentifier)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClaimNote)
                    .HasColumnType("varchar(400)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClaimStatus)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClaimType)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CorrectionType).HasColumnType("tinyint(4)");

                entity.Property(e => e.CustomTracking).HasColumnType("bigint(20)");

                entity.Property(e => e.DateIllnessInjuryPreg)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateIllnessInjuryPregQualifier).HasColumnType("smallint(6)");

                entity.Property(e => e.DateOther)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateOtherQualifier).HasColumnType("smallint(6)");

                entity.Property(e => e.DateReceived)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateResent)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateSent)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateSentOrig)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateService)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.EmployRelated).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.InsSubNum).HasColumnType("bigint(20)");

                entity.Property(e => e.InsSubNum2).HasColumnType("bigint(20)");

                entity.Property(e => e.IsOrtho).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsOutsideLab).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsProsthesis)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedType).HasColumnType("tinyint(4)");

                entity.Property(e => e.OrderingReferralNum).HasColumnType("bigint(20)");

                entity.Property(e => e.OrigRefNum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrthoDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.OrthoRemainM).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.OrthoTotalM).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatRelat).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PatRelat2).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PatientStatusCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlaceService).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PlanNum2).HasColumnType("bigint(20)");

                entity.Property(e => e.PreAuthString)
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PriorAuthorizationNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PriorDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.ProvBill).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvOrderOverride).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvTreat).HasColumnType("bigint(20)");

                entity.Property(e => e.Radiographs).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ReasonUnderPaid)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefNumString)
                    .HasColumnType("varchar(40)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReferringProv).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.SpecialProgramCode).HasColumnType("tinyint(4)");

                entity.Property(e => e.UniformBillType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Claimattach>(entity =>
            {
                entity.HasKey(e => e.ClaimAttachNum)
                    .HasName("PRIMARY");

                entity.ToTable("claimattach");

                entity.HasIndex(e => e.ClaimNum, "ClaimNum");

                entity.Property(e => e.ClaimAttachNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ActualFileName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClaimNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DisplayedFileName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Claimcondcodelog>(entity =>
            {
                entity.HasKey(e => e.ClaimCondCodeLogNum)
                    .HasName("PRIMARY");

                entity.ToTable("claimcondcodelog");

                entity.Property(e => e.ClaimCondCodeLogNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Code0)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code1)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code10)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code2)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code3)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code4)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code5)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code6)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code7)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code8)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Code9)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Claimform>(entity =>
            {
                entity.HasKey(e => e.ClaimFormNum)
                    .HasName("PRIMARY");

                entity.ToTable("claimform");

                entity.Property(e => e.ClaimFormNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FontName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FontSize).HasColumnType("float unsigned");

                entity.Property(e => e.Height).HasColumnType("int(11)");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.OffsetX).HasColumnType("smallint(5)");

                entity.Property(e => e.OffsetY).HasColumnType("smallint(5)");

                entity.Property(e => e.PrintImages).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.UniqueId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("UniqueID")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Width).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Claimformitem>(entity =>
            {
                entity.HasKey(e => e.ClaimFormItemNum)
                    .HasName("PRIMARY");

                entity.ToTable("claimformitem");

                entity.Property(e => e.ClaimFormItemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimFormNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FieldName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FormatString)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImageFileName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Xpos).HasColumnName("XPos");

                entity.Property(e => e.Ypos).HasColumnName("YPos");
            });

            modelBuilder.Entity<Claimpayment>(entity =>
            {
                entity.HasKey(e => e.ClaimPaymentNum)
                    .HasName("PRIMARY");

                entity.ToTable("claimpayment");

                entity.HasIndex(e => e.CheckDate, "CheckDate");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.DepositNum, "DepositNum");

                entity.HasIndex(e => e.PayGroup, "PayGroup");

                entity.HasIndex(e => e.PayType, "PayType");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.Property(e => e.ClaimPaymentNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BankBranch)
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarrierName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.CheckNum)
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateIssued)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DepositNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsPartial).HasColumnType("tinyint(4)");

                entity.Property(e => e.Note)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayGroup).HasColumnType("bigint(20)");

                entity.Property(e => e.PayType).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Claimproc>(entity =>
            {
                entity.HasKey(e => e.ClaimProcNum)
                    .HasName("PRIMARY");

                entity.ToTable("claimproc");

                entity.HasIndex(e => e.ClaimPaymentTracking, "ClaimPaymentTracking");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.DateCp, "DateCP");

                entity.HasIndex(e => e.DateSuppReceived, "DateSuppReceived");

                entity.HasIndex(e => e.InsSubNum, "InsSubNum");

                entity.HasIndex(e => e.PayPlanNum, "PayPlanNum");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => e.Status, "Status");

                entity.HasIndex(e => new { e.ProcNum, e.PlanNum, e.Status, e.InsPayAmt, e.InsPayEst, e.WriteOff, e.NoBillIns }, "indexAcctCov");

                entity.HasIndex(e => new { e.Status, e.PatNum, e.DateCp, e.PayPlanNum, e.InsPayAmt, e.WriteOff, e.InsPayEst, e.ProcDate, e.ProcNum }, "indexAgingCovering");

                entity.HasIndex(e => new { e.ClaimPaymentNum, e.Status, e.InsPayAmt }, "indexCPNSIPA");

                entity.HasIndex(e => e.ClaimNum, "indexClaimNum");

                entity.HasIndex(e => e.ClaimPaymentNum, "indexClaimPaymentNum");

                entity.HasIndex(e => new { e.ClaimNum, e.ClaimPaymentNum, e.InsPayAmt, e.DateCp }, "indexOutClaimCovering");

                entity.HasIndex(e => new { e.ProvNum, e.DateCp }, "indexPNDCP");

                entity.HasIndex(e => new { e.ProvNum, e.ProcDate }, "indexPNPD");

                entity.HasIndex(e => e.PatNum, "indexPatNum");

                entity.HasIndex(e => e.PlanNum, "indexPlanNum");

                entity.HasIndex(e => e.ProcNum, "indexProcNum");

                entity.HasIndex(e => e.ProvNum, "indexProvNum");

                entity.HasIndex(e => new { e.InsSubNum, e.ProcNum, e.Status, e.ProcDate, e.PatNum, e.InsPayAmt, e.InsPayEst }, "indexTxFinder");

                entity.Property(e => e.ClaimProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimPaymentNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimPaymentTracking).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeSent)
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CopayAmt).HasDefaultValueSql("'-1'");

                entity.Property(e => e.CopayOverride).HasDefaultValueSql("'-1'");

                entity.Property(e => e.DateCp)
                    .HasColumnType("date")
                    .HasColumnName("DateCP")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateInsFinalized)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateSuppReceived)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.EstimateNote)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InsSubNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsTransfer).HasColumnType("tinyint(4)");

                entity.Property(e => e.LineNumber).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.NoBillIns).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.PaidOtherIns).HasDefaultValueSql("'-1'");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayPlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PaymentRow).HasColumnType("int(11)");

                entity.Property(e => e.PercentOverride)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Percentage)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.PlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecDateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.Status).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Claimsnapshot>(entity =>
            {
                entity.HasKey(e => e.ClaimSnapshotNum)
                    .HasName("PRIMARY");

                entity.ToTable("claimsnapshot");

                entity.HasIndex(e => e.ClaimProcNum, "ClaimProcNum");

                entity.HasIndex(e => e.ProcNum, "ProcNum");

                entity.Property(e => e.ClaimSnapshotNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateTentry)
                    .HasColumnName("DateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SnapshotTrigger).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Claimtracking>(entity =>
            {
                entity.HasKey(e => e.ClaimTrackingNum)
                    .HasName("PRIMARY");

                entity.ToTable("claimtracking");

                entity.HasIndex(e => e.ClaimNum, "ClaimNum");

                entity.HasIndex(e => e.TrackingDefNum, "TrackingDefNum");

                entity.HasIndex(e => e.TrackingErrorDefNum, "TrackingErrorDefNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.ClaimTrackingNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeEntry)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TrackingDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TrackingErrorDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TrackingType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Claimvalcodelog>(entity =>
            {
                entity.HasKey(e => e.ClaimValCodeLogNum)
                    .HasName("PRIMARY");

                entity.ToTable("claimvalcodelog");

                entity.Property(e => e.ClaimValCodeLogNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimField)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClaimNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Ordinal).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ValCode)
                    .IsRequired()
                    .HasColumnType("char(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Clearinghouse>(entity =>
            {
                entity.HasKey(e => e.ClearinghouseNum)
                    .HasName("PRIMARY");

                entity.ToTable("clearinghouse");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.HqClearinghouseNum, "HqClearinghouseNum");

                entity.Property(e => e.ClearinghouseNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClientProgram)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CommBridge).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Eformat).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ExportPath)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gs03)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("GS03")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HqClearinghouseNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsAttachmentSendAllowed).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsClaimExportAllowed)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsEraDownloadAllowed)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Isa02)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("ISA02")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isa04)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("ISA04")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isa05)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ISA05")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isa07)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ISA07")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isa08)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ISA08")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isa15)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ISA15")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isa16)
                    .IsRequired()
                    .HasColumnType("varchar(2)")
                    .HasColumnName("ISA16")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastBatchNumber).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.LoginId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("LoginID")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModemPort).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Password)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Payors)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResponsePath)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SenderName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SenderTelephone)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SenderTin)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SenderTIN")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SeparatorData)
                    .IsRequired()
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SeparatorSegment)
                    .IsRequired()
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Clinic>(entity =>
            {
                entity.HasKey(e => e.ClinicNum)
                    .HasName("PRIMARY");

                entity.ToTable("clinic");

                entity.HasIndex(e => e.DefaultProv, "DefaultProv");

                entity.HasIndex(e => e.EmailAddressNum, "EmailAddressNum");

                entity.HasIndex(e => e.ExternalId, "ExternalID");

                entity.HasIndex(e => e.InsBillingProv, "InsBillingProv");

                entity.HasIndex(e => e.Region, "Region");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Abbr)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address2)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BankNumber)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BillingAddress)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BillingAddress2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BillingCity)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BillingState)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BillingZip)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DefaultPlaceService).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.DefaultProv).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailAddressNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ExternalId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ExternalID");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HasProcOnRx).HasColumnType("tinyint(4)");

                entity.Property(e => e.InsBillingProv).HasColumnType("bigint(20)");

                entity.Property(e => e.IsConfirmDefault).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsConfirmEnabled).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsInsVerifyExcluded).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsMedicalOnly).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsNewPatApptExcluded).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.MedLabAccountNum)
                    .IsRequired()
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayToAddress)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayToAddress2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayToCity)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayToState)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayToZip)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Region).HasColumnType("bigint(20)");

                entity.Property(e => e.SchedNote)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SmsContractDate).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.State)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UseBillAddrOnClaims).HasColumnType("tinyint(4)");

                entity.Property(e => e.Zip)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Clinicerx>(entity =>
            {
                entity.HasKey(e => e.ClinicErxNum)
                    .HasName("PRIMARY");

                entity.ToTable("clinicerx");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.RegistrationKeyNum, "RegistrationKeyNum");

                entity.Property(e => e.ClinicErxNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicDesc)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicKey)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EnabledStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.RegistrationKeyNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Clinicpref>(entity =>
            {
                entity.HasKey(e => e.ClinicPrefNum)
                    .HasName("PRIMARY");

                entity.ToTable("clinicpref");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.Property(e => e.ClinicPrefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PrefName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValueString)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Clockevent>(entity =>
            {
                entity.HasKey(e => e.ClockEventNum)
                    .HasName("PRIMARY");

                entity.ToTable("clockevent");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.EmployeeNum, "EmployeeNum");

                entity.HasIndex(e => e.TimeDisplayed1, "TimeDisplayed1");

                entity.Property(e => e.ClockEventNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AdjustIsOverridden).HasColumnType("tinyint(4)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClockStatus).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.EmployeeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OtimeAuto).HasColumnName("OTimeAuto");

                entity.Property(e => e.OtimeHours).HasColumnName("OTimeHours");

                entity.Property(e => e.TimeDisplayed1).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.TimeDisplayed2).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.TimeEntered1).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.TimeEntered2).HasDefaultValueSql("'0001-01-01 00:00:00'");
            });

            modelBuilder.Entity<Codesystem>(entity =>
            {
                entity.HasKey(e => e.CodeSystemNum)
                    .HasName("PRIMARY");

                entity.ToTable("codesystem");

                entity.HasIndex(e => e.CodeSystemName, "CodeSystemName");

                entity.Property(e => e.CodeSystemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeSystemName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hl7oid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("HL7OID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VersionAvail)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VersionCur)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Commlog>(entity =>
            {
                entity.HasKey(e => e.CommlogNum)
                    .HasName("PRIMARY");

                entity.ToTable("commlog");

                entity.HasIndex(e => e.CommDateTime, "CommDateTime");

                entity.HasIndex(e => e.CommType, "CommType");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProgramNum, "ProgramNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.HasIndex(e => new { e.PatNum, e.CommDateTime, e.CommType }, "indexPNCDateCType");

                entity.Property(e => e.CommlogNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CommDateTime).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CommSource).HasColumnType("tinyint(4)");

                entity.Property(e => e.CommType).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeEnd).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Mode)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Mode_");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProgramNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SentOrReceived).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SigIsTopaz).HasColumnType("tinyint(4)");

                entity.Property(e => e.Signature)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Commoptout>(entity =>
            {
                entity.HasKey(e => e.CommOptOutNum)
                    .HasName("PRIMARY");

                entity.ToTable("commoptout");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.CommOptOutNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CommMode).HasColumnType("tinyint(4)");

                entity.Property(e => e.CommType).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Computer>(entity =>
            {
                entity.HasKey(e => e.ComputerNum)
                    .HasName("PRIMARY");

                entity.ToTable("computer");

                entity.Property(e => e.ComputerNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CompName)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastHeartBeat).HasDefaultValueSql("'0001-01-01 00:00:00'");
            });

            modelBuilder.Entity<Computerpref>(entity =>
            {
                entity.HasKey(e => e.ComputerPrefNum)
                    .HasName("PRIMARY");

                entity.ToTable("computerpref");

                entity.HasIndex(e => e.ApptViewNum, "ApptViewNum");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.Property(e => e.ComputerPrefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ApptViewNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AtoZpath)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ComputerOs)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ComputerOS")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DirectXformat)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("DirectXFormat")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GraphicsDoubleBuffering).HasColumnType("tinyint(4)");

                entity.Property(e => e.GraphicsUseDirectX11).HasColumnType("tinyint(4)");

                entity.Property(e => e.HelpButtonXadjustment).HasColumnName("HelpButtonXAdjustment");

                entity.Property(e => e.NoShowDecimal).HasColumnType("tinyint(4)");

                entity.Property(e => e.NoShowLanguage).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatSelectSearchMode).HasColumnType("tinyint(4)");

                entity.Property(e => e.PreferredPixelFormatNum)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RecentApptView).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ScanDocDuplex).HasColumnType("tinyint(4)");

                entity.Property(e => e.ScanDocGrayscale).HasColumnType("tinyint(4)");

                entity.Property(e => e.ScanDocQuality).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ScanDocResolution).HasColumnType("int(11)");

                entity.Property(e => e.ScanDocSelectSource).HasColumnType("tinyint(4)");

                entity.Property(e => e.ScanDocShowOptions).HasColumnType("tinyint(4)");

                entity.Property(e => e.SensorBinned).HasColumnType("tinyint(4)");

                entity.Property(e => e.SensorExposure)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SensorPort)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SensorType)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'D'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaskDock).HasColumnType("int(11)");

                entity.Property(e => e.TaskX)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'900'");

                entity.Property(e => e.TaskY)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'625'");
            });

            modelBuilder.Entity<Confirmationrequest>(entity =>
            {
                entity.HasKey(e => e.ConfirmationRequestNum)
                    .HasName("PRIMARY");

                entity.ToTable("confirmationrequest");

                entity.HasIndex(e => e.ApptNum, "ApptNum");

                entity.HasIndex(e => e.ApptReminderRuleNum, "ApptReminderRuleNum");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.Tsprior, "TSPrior");

                entity.Property(e => e.ConfirmationRequestNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ApptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ApptReminderRuleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AptDateTimeOrig).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ConfirmCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateTimeConfirmExpire).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeConfirmTransmit).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeRsvp)
                    .HasColumnName("DateTimeRSVP")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DoNotResend).HasColumnType("tinyint(4)");

                entity.Property(e => e.EmailSentOk).HasColumnType("tinyint(4)");

                entity.Property(e => e.EmailSubj)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailSubjTemplate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailTextTemplate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GuidMessageFromMobile)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GuidMessageToMobile)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsForEmail).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsForSms).HasColumnType("tinyint(4)");

                entity.Property(e => e.MsgTextToMobile)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MsgTextToMobileTemplate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PhonePat)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResponseDescript)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rsvpstatus)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("RSVPStatus");

                entity.Property(e => e.SecondsFromEntryToExpire).HasColumnType("int(11)");

                entity.Property(e => e.ShortGuid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ShortGUID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShortGuidEmail)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SmsSentOk).HasColumnType("tinyint(4)");

                entity.Property(e => e.Tsprior)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("TSPrior");
            });

            modelBuilder.Entity<Connectiongroup>(entity =>
            {
                entity.HasKey(e => e.ConnectionGroupNum)
                    .HasName("PRIMARY");

                entity.ToTable("connectiongroup");

                entity.Property(e => e.ConnectionGroupNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Conngroupattach>(entity =>
            {
                entity.HasKey(e => e.ConnGroupAttachNum)
                    .HasName("PRIMARY");

                entity.ToTable("conngroupattach");

                entity.HasIndex(e => e.CentralConnectionNum, "CentralConnectionNum");

                entity.HasIndex(e => e.ConnectionGroupNum, "ConnectionGroupNum");

                entity.Property(e => e.ConnGroupAttachNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CentralConnectionNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ConnectionGroupNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.ContactNum)
                    .HasName("PRIMARY");

                entity.ToTable("contact");

                entity.Property(e => e.ContactNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Category).HasColumnType("bigint(20)");

                entity.Property(e => e.Fax)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fname)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("FName")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lname)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("LName")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WkPhone)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<County>(entity =>
            {
                entity.HasKey(e => e.CountyNum)
                    .HasName("PRIMARY");

                entity.ToTable("county");

                entity.Property(e => e.CountyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CountyCode)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountyName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Covcat>(entity =>
            {
                entity.HasKey(e => e.CovCatNum)
                    .HasName("PRIMARY");

                entity.ToTable("covcat");

                entity.Property(e => e.CovCatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CovOrder).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.DefaultPercent).HasColumnType("smallint(6)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EbenefitCat).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<Covspan>(entity =>
            {
                entity.HasKey(e => e.CovSpanNum)
                    .HasName("PRIMARY");

                entity.ToTable("covspan");

                entity.HasIndex(e => e.CovCatNum, "CovCatNum");

                entity.Property(e => e.CovSpanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CovCatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FromCode)
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.ToCode)
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");
            });

            modelBuilder.Entity<Cpt>(entity =>
            {
                entity.HasKey(e => e.CptNum)
                    .HasName("PRIMARY");

                entity.ToTable("cpt");

                entity.HasIndex(e => e.CptCode, "CptCode");

                entity.Property(e => e.CptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CptCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(4000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VersionIds)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("VersionIDs")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Creditcard>(entity =>
            {
                entity.HasKey(e => e.CreditCardNum)
                    .HasName("PRIMARY");

                entity.ToTable("creditcard");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.PayPlanNum, "PayPlanNum");

                entity.HasIndex(e => e.PaymentType, "PaymentType");

                entity.Property(e => e.CreditCardNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CanChargeWhenNoBal).HasColumnType("tinyint(4)");

                entity.Property(e => e.Ccexpiration)
                    .HasColumnType("date")
                    .HasColumnName("CCExpiration")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.CcnumberMasked)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CCNumberMasked")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ccsource)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("CCSource");

                entity.Property(e => e.ChargeFrequency)
                    .IsRequired()
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateStop)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.ExcludeProcSync).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayConnectToken)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayConnectTokenExp)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.PayPlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PaySimpleToken)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentType).HasColumnType("bigint(20)");

                entity.Property(e => e.Procedures)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.XchargeToken)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("XChargeToken")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zip)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Custrefentry>(entity =>
            {
                entity.HasKey(e => e.CustRefEntryNum)
                    .HasName("PRIMARY");

                entity.ToTable("custrefentry");

                entity.HasIndex(e => e.PatNumCust, "PatNumCust");

                entity.HasIndex(e => e.PatNumRef, "PatNumRef");

                entity.Property(e => e.CustRefEntryNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNumCust).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNumRef).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Custreference>(entity =>
            {
                entity.HasKey(e => e.CustReferenceNum)
                    .HasName("PRIMARY");

                entity.ToTable("custreference");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.CustReferenceNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateMostRecent)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.IsBadRef).HasColumnType("tinyint(4)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Cvx>(entity =>
            {
                entity.HasKey(e => e.CvxNum)
                    .HasName("PRIMARY");

                entity.ToTable("cvx");

                entity.HasIndex(e => e.CvxCode, "CvxCode");

                entity.Property(e => e.CvxNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CvxCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Dashboardar>(entity =>
            {
                entity.HasKey(e => e.DashboardArnum)
                    .HasName("PRIMARY");

                entity.ToTable("dashboardar");

                entity.Property(e => e.DashboardArnum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("DashboardARNum");

                entity.Property(e => e.DateCalc)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");
            });

            modelBuilder.Entity<Dashboardcell>(entity =>
            {
                entity.HasKey(e => e.DashboardCellNum)
                    .HasName("PRIMARY");

                entity.ToTable("dashboardcell");

                entity.HasIndex(e => e.DashboardLayoutNum, "DashboardLayoutNum");

                entity.Property(e => e.DashboardCellNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CellColumn).HasColumnType("int(11)");

                entity.Property(e => e.CellRow).HasColumnType("int(11)");

                entity.Property(e => e.CellSettings)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CellType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DashboardLayoutNum).HasColumnType("bigint(20)");

                entity.Property(e => e.LastQueryData)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastQueryTime).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.RefreshRateSeconds).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Dashboardlayout>(entity =>
            {
                entity.HasKey(e => e.DashboardLayoutNum)
                    .HasName("PRIMARY");

                entity.ToTable("dashboardlayout");

                entity.HasIndex(e => e.UserGroupNum, "UserGroupNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.DashboardLayoutNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DashboardColumns).HasColumnType("int(11)");

                entity.Property(e => e.DashboardGroupName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DashboardRows).HasColumnType("int(11)");

                entity.Property(e => e.DashboardTabName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DashboardTabOrder).HasColumnType("int(11)");

                entity.Property(e => e.UserGroupNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Databasemaintenance>(entity =>
            {
                entity.HasKey(e => e.DatabaseMaintenanceNum)
                    .HasName("PRIMARY");

                entity.ToTable("databasemaintenance");

                entity.Property(e => e.DatabaseMaintenanceNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateLastRun).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsOld).HasColumnType("tinyint(4)");

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Dbmlog>(entity =>
            {
                entity.HasKey(e => e.DbmLogNum)
                    .HasName("PRIMARY");

                entity.ToTable("dbmlog");

                entity.HasIndex(e => e.DateTimeEntry, "DateTimeEntry");

                entity.HasIndex(e => new { e.Fkey, e.FkeyType }, "FKeyAndType");

                entity.HasIndex(e => e.MethodName, "MethodName");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.DbmLogNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ActionType).HasColumnType("tinyint(4)");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.FkeyType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("FKeyType");

                entity.Property(e => e.LogText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Definition>(entity =>
            {
                entity.HasKey(e => e.DefNum)
                    .HasName("PRIMARY");

                entity.ToTable("definition");

                entity.Property(e => e.DefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Category).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ItemColor).HasColumnType("int(11)");

                entity.Property(e => e.ItemName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ItemValue)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Deflink>(entity =>
            {
                entity.HasKey(e => e.DefLinkNum)
                    .HasName("PRIMARY");

                entity.ToTable("deflink");

                entity.HasIndex(e => e.DefNum, "DefNum");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.Property(e => e.DefLinkNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.LinkType).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Deletedobject>(entity =>
            {
                entity.HasKey(e => e.DeletedObjectNum)
                    .HasName("PRIMARY");

                entity.ToTable("deletedobject");

                entity.Property(e => e.DeletedObjectNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ObjectNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ObjectType).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Deposit>(entity =>
            {
                entity.HasKey(e => e.DepositNum)
                    .HasName("PRIMARY");

                entity.ToTable("deposit");

                entity.HasIndex(e => e.DepositAccountNum, "DepositAccountNum");

                entity.Property(e => e.DepositNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BankAccountInfo)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Batch)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateDeposit)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DepositAccountNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Dictcustom>(entity =>
            {
                entity.HasKey(e => e.DictCustomNum)
                    .HasName("PRIMARY");

                entity.ToTable("dictcustom");

                entity.Property(e => e.DictCustomNum).HasColumnType("bigint(20)");

                entity.Property(e => e.WordText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Discountplan>(entity =>
            {
                entity.HasKey(e => e.DiscountPlanNum)
                    .HasName("PRIMARY");

                entity.ToTable("discountplan");

                entity.HasIndex(e => e.DefNum, "DefNum");

                entity.HasIndex(e => e.FeeSchedNum, "FeeSchedNum");

                entity.Property(e => e.DiscountPlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FeeSchedNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.HasKey(e => e.DiseaseNum)
                    .HasName("PRIMARY");

                entity.ToTable("disease");

                entity.HasIndex(e => e.PatNum, "indexPatNum");

                entity.Property(e => e.DiseaseNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateStop)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DiseaseDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FunctionStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatNote)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProbStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.SnomedProblemType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Diseasedef>(entity =>
            {
                entity.HasKey(e => e.DiseaseDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("diseasedef");

                entity.HasIndex(e => e.Icd9code, "ICD9Code");

                entity.HasIndex(e => e.Icd10Code, "Icd10Code");

                entity.HasIndex(e => e.SnomedCode, "SnomedCode");

                entity.Property(e => e.DiseaseDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DiseaseName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Icd10Code)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Icd9code)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ICD9Code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.SnomedCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Displayfield>(entity =>
            {
                entity.HasKey(e => e.DisplayFieldNum)
                    .HasName("PRIMARY");

                entity.ToTable("displayfield");

                entity.HasIndex(e => e.ChartViewNum, "ChartViewNum");

                entity.Property(e => e.DisplayFieldNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Category).HasColumnType("int(11)");

                entity.Property(e => e.ChartViewNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ColumnWidth).HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DescriptionOverride)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InternalName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.PickList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Displayreport>(entity =>
            {
                entity.HasKey(e => e.DisplayReportNum)
                    .HasName("PRIMARY");

                entity.ToTable("displayreport");

                entity.Property(e => e.DisplayReportNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Category).HasColumnType("tinyint(4)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InternalName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsVisibleInSubMenu).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Dispsupply>(entity =>
            {
                entity.HasKey(e => e.DispSupplyNum)
                    .HasName("PRIMARY");

                entity.ToTable("dispsupply");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.SupplyNum, "SupplyNum");

                entity.Property(e => e.DispSupplyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateDispensed)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SupplyNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.DocNum)
                    .HasName("PRIMARY");

                entity.ToTable("document");

                entity.HasIndex(e => new { e.PatNum, e.DocCategory }, "PNDC");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.DocNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CropH).HasColumnType("int(11)");

                entity.Property(e => e.CropW).HasColumnType("int(11)");

                entity.Property(e => e.CropX).HasColumnType("int(11)");

                entity.Property(e => e.CropY).HasColumnType("int(11)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DegreesRotated).HasColumnType("smallint(6)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DocCategory).HasColumnType("bigint(20)");

                entity.Property(e => e.ExternalGuid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ExternalGUID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExternalSource)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImgType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.IsFlipped).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.MountItemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.RawBase64)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SigIsTopaz).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Signature)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Thumbnail)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ToothNumbers)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WindowingMax).HasColumnType("int(11)");

                entity.Property(e => e.WindowingMin).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Documentmisc>(entity =>
            {
                entity.HasKey(e => e.DocMiscNum)
                    .HasName("PRIMARY");

                entity.ToTable("documentmisc");

                entity.Property(e => e.DocMiscNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DocMiscType).HasColumnType("tinyint(4)");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RawBase64)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Drugmanufacturer>(entity =>
            {
                entity.HasKey(e => e.DrugManufacturerNum)
                    .HasName("PRIMARY");

                entity.ToTable("drugmanufacturer");

                entity.Property(e => e.DrugManufacturerNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ManufacturerCode)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ManufacturerName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Drugunit>(entity =>
            {
                entity.HasKey(e => e.DrugUnitNum)
                    .HasName("PRIMARY");

                entity.ToTable("drugunit");

                entity.Property(e => e.DrugUnitNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UnitIdentifier)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnitText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Dunning>(entity =>
            {
                entity.HasKey(e => e.DunningNum)
                    .HasName("PRIMARY");

                entity.ToTable("dunning");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.Property(e => e.DunningNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AgeAccount).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.BillingType).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DaysInAdvance).HasColumnType("int(11)");

                entity.Property(e => e.DunMessage)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailBody)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailSubject)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InsIsPending).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.IsSuperFamily).HasColumnType("tinyint(4)");

                entity.Property(e => e.MessageBold)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ebill>(entity =>
            {
                entity.HasKey(e => e.EbillNum)
                    .HasName("PRIMARY");

                entity.ToTable("ebill");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.Property(e => e.EbillNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClientAcctNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ElectPassword)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ElectUserName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PracticeAddress).HasColumnType("tinyint(4)");

                entity.Property(e => e.RemitAddress).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Eclipboardsheetdef>(entity =>
            {
                entity.HasKey(e => e.EclipboardSheetDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("eclipboardsheetdef");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.ResubmitInterval, "ResubmitInterval");

                entity.HasIndex(e => e.SheetDefNum, "SheetDefNum");

                entity.Property(e => e.EclipboardSheetDefNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("EClipboardSheetDefNum");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.ResubmitInterval).HasColumnType("bigint(20)");

                entity.Property(e => e.SheetDefNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Eduresource>(entity =>
            {
                entity.HasKey(e => e.EduResourceNum)
                    .HasName("PRIMARY");

                entity.ToTable("eduresource");

                entity.HasIndex(e => e.DiseaseDefNum, "DiseaseDefNum");

                entity.HasIndex(e => e.LabResultId, "LabResultID");

                entity.HasIndex(e => e.MedicationNum, "MedicationNum");

                entity.Property(e => e.EduResourceNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DiseaseDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.LabResultCompare)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LabResultId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("LabResultID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LabResultName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicationNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ResourceUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SmokingSnoMed)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ehramendment>(entity =>
            {
                entity.HasKey(e => e.EhrAmendmentNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehramendment");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.EhrAmendmentNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTacceptDeny)
                    .HasColumnName("DateTAcceptDeny")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTappend)
                    .HasColumnName("DateTAppend")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTrequest)
                    .HasColumnName("DateTRequest")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsAccepted).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.RawBase64)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Source).HasColumnType("tinyint(4)");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ehraptob>(entity =>
            {
                entity.HasKey(e => e.EhrAptObsNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehraptobs");

                entity.HasIndex(e => e.AptNum, "AptNum");

                entity.Property(e => e.EhrAptObsNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IdentifyingCode).HasColumnType("tinyint(4)");

                entity.Property(e => e.UcumCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValCodeSystem)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValReported)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValType).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Ehrcareplan>(entity =>
            {
                entity.HasKey(e => e.EhrCarePlanNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrcareplan");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.EhrCarePlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DatePlanned)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Instructions)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SnomedEducation)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ehrlab>(entity =>
            {
                entity.HasKey(e => e.EhrLabNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrlab");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.SetIdObr, "SetIdOBR");

                entity.HasIndex(e => e.Tq1setId, "TQ1SetId");

                entity.Property(e => e.EhrLabNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FillerOrderNamespace)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FillerOrderNum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FillerOrderUniversalId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("FillerOrderUniversalID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FillerOrderUniversalIdtype)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("FillerOrderUniversalIDType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsCpoe).HasColumnType("tinyint(4)");

                entity.Property(e => e.ListEhrLabResultsHandlingF).HasColumnType("tinyint(4)");

                entity.Property(e => e.ListEhrLabResultsHandlingN).HasColumnType("tinyint(4)");

                entity.Property(e => e.ObservationDateTimeEnd)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationDateTimeStart)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderControlCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProviderAssigningAuthorityIdtype)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OrderingProviderAssigningAuthorityIDType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProviderAssigningAuthorityNamespaceId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OrderingProviderAssigningAuthorityNamespaceID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProviderAssigningAuthorityUniversalId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OrderingProviderAssigningAuthorityUniversalID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProviderFname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OrderingProviderFName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProviderId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OrderingProviderID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProviderIdentifierTypeCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProviderLname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OrderingProviderLName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProviderMiddleNames)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProviderNameTypeCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProviderPrefix)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProviderSuffix)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OriginalPidsegment)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("OriginalPIDSegment")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentFillerOrderNamespace)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentFillerOrderNum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentFillerOrderUniversalId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentFillerOrderUniversalID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentFillerOrderUniversalIdtype)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentFillerOrderUniversalIDType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentObservationCodeSystemName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentObservationCodeSystemNameAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentObservationId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentObservationID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentObservationIdalt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentObservationIDAlt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentObservationSubId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentObservationSubID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentObservationText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentObservationTextAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentObservationTextOriginal)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentPlacerOrderNamespace)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentPlacerOrderNum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentPlacerOrderUniversalId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentPlacerOrderUniversalID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentPlacerOrderUniversalIdtype)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentPlacerOrderUniversalIDType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PlacerGroupNamespace)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlacerGroupNum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlacerGroupUniversalId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PlacerGroupUniversalID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlacerGroupUniversalIdtype)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PlacerGroupUniversalIDType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlacerOrderNamespace)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlacerOrderNum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlacerOrderUniversalId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PlacerOrderUniversalID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlacerOrderUniversalIdtype)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PlacerOrderUniversalIDType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResultDateTime)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResultStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SetIdObr)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("SetIdOBR");

                entity.Property(e => e.SpecimenActionCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tq1dateTimeEnd)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TQ1DateTimeEnd")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tq1dateTimeStart)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TQ1DateTimeStart")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tq1setId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("TQ1SetId");

                entity.Property(e => e.UsiCodeSystemName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsiCodeSystemNameAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsiId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("UsiID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsiIdalt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("UsiIDAlt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsiText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsiTextAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsiTextOriginal)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ehrlabclinicalinfo>(entity =>
            {
                entity.HasKey(e => e.EhrLabClinicalInfoNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrlabclinicalinfo");

                entity.HasIndex(e => e.EhrLabNum, "EhrLabNum");

                entity.Property(e => e.EhrLabClinicalInfoNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicalInfoCodeSystemName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicalInfoCodeSystemNameAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicalInfoId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ClinicalInfoID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicalInfoIdalt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ClinicalInfoIDAlt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicalInfoText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicalInfoTextAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicalInfoTextOriginal)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EhrLabNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Ehrlabimage>(entity =>
            {
                entity.HasKey(e => e.EhrLabImageNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrlabimage");

                entity.HasIndex(e => e.DocNum, "DocNum");

                entity.HasIndex(e => e.EhrLabNum, "EhrLabNum");

                entity.Property(e => e.EhrLabImageNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DocNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EhrLabNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Ehrlabnote>(entity =>
            {
                entity.HasKey(e => e.EhrLabNoteNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrlabnote");

                entity.HasIndex(e => e.EhrLabNum, "EhrLabNum");

                entity.HasIndex(e => e.EhrLabResultNum, "EhrLabResultNum");

                entity.Property(e => e.EhrLabNoteNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EhrLabNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EhrLabResultNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Ehrlabresult>(entity =>
            {
                entity.HasKey(e => e.EhrLabResultNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrlabresult");

                entity.HasIndex(e => e.EhrLabNum, "EhrLabNum");

                entity.HasIndex(e => e.SetIdObx, "SetIdOBX");

                entity.Property(e => e.EhrLabResultNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AbnormalFlags)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AnalysisDateTime)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EhrLabNum).HasColumnType("bigint(20)");

                entity.Property(e => e.MedicalDirectorAssigningAuthorityIdtype)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("MedicalDirectorAssigningAuthorityIDType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicalDirectorAssigningAuthorityNamespaceId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("MedicalDirectorAssigningAuthorityNamespaceID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicalDirectorAssigningAuthorityUniversalId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("MedicalDirectorAssigningAuthorityUniversalID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicalDirectorFname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("MedicalDirectorFName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicalDirectorId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("MedicalDirectorID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicalDirectorIdentifierTypeCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicalDirectorLname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("MedicalDirectorLName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicalDirectorMiddleNames)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicalDirectorNameTypeCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicalDirectorPrefix)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicalDirectorSuffix)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationDateTime)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationIdentifierCodeSystemName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationIdentifierCodeSystemNameAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationIdentifierId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ObservationIdentifierID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationIdentifierIdalt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ObservationIdentifierIDAlt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationIdentifierSub)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationIdentifierText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationIdentifierTextAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationIdentifierTextOriginal)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationResultStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationValueCodedElementCodeSystemName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationValueCodedElementCodeSystemNameAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationValueCodedElementId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ObservationValueCodedElementID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationValueCodedElementIdalt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ObservationValueCodedElementIDAlt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationValueCodedElementText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationValueCodedElementTextAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationValueCodedElementTextOriginal)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationValueComparator)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationValueDateTime)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationValueSeparatorOrSuffix)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationValueText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObservationValueTime).HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.PerformingOrganizationAddressAddressType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PerformingOrganizationAddressCity)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PerformingOrganizationAddressCountryCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PerformingOrganizationAddressCountyOrParishCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PerformingOrganizationAddressOtherDesignation)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PerformingOrganizationAddressStateOrProvince)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PerformingOrganizationAddressStreet)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PerformingOrganizationAddressZipOrPostalCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PerformingOrganizationIdentifier)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PerformingOrganizationIdentifierTypeCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PerformingOrganizationName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PerformingOrganizationNameAssigningAuthorityNamespaceId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PerformingOrganizationNameAssigningAuthorityUniversalId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PerformingOrganizationNameAssigningAuthorityUniversalIdType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReferenceRange)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("referenceRange")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SetIdObx)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("SetIdOBX");

                entity.Property(e => e.UnitsCodeSystemName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnitsCodeSystemNameAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnitsId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("UnitsID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnitsIdalt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("UnitsIDAlt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnitsText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnitsTextAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnitsTextOriginal)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValueType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ehrlabresultscopyto>(entity =>
            {
                entity.HasKey(e => e.EhrLabResultsCopyToNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrlabresultscopyto");

                entity.HasIndex(e => e.EhrLabNum, "EhrLabNum");

                entity.Property(e => e.EhrLabResultsCopyToNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CopyToAssigningAuthorityIdtype)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CopyToAssigningAuthorityIDType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CopyToAssigningAuthorityNamespaceId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CopyToAssigningAuthorityNamespaceID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CopyToAssigningAuthorityUniversalId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CopyToAssigningAuthorityUniversalID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CopyToFname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CopyToFName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CopyToId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CopyToID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CopyToIdentifierTypeCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CopyToLname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CopyToLName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CopyToMiddleNames)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CopyToNameTypeCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CopyToPrefix)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CopyToSuffix)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EhrLabNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Ehrlabspeciman>(entity =>
            {
                entity.HasKey(e => e.EhrLabSpecimenNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrlabspecimen");

                entity.HasIndex(e => e.EhrLabNum, "EhrLabNum");

                entity.HasIndex(e => e.SetIdSpm, "SetIdSPM");

                entity.Property(e => e.EhrLabSpecimenNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CollectionDateTimeEnd)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CollectionDateTimeStart)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EhrLabNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SetIdSpm)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("SetIdSPM");

                entity.Property(e => e.SpecimenTypeCodeSystemName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenTypeCodeSystemNameAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenTypeId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SpecimenTypeID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenTypeIdalt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SpecimenTypeIDAlt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenTypeText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenTypeTextAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenTypeTextOriginal)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ehrlabspecimencondition>(entity =>
            {
                entity.HasKey(e => e.EhrLabSpecimenConditionNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrlabspecimencondition");

                entity.HasIndex(e => e.EhrLabSpecimenNum, "EhrLabSpecimenNum");

                entity.Property(e => e.EhrLabSpecimenConditionNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EhrLabSpecimenNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SpecimenConditionCodeSystemName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenConditionCodeSystemNameAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenConditionId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SpecimenConditionID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenConditionIdalt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SpecimenConditionIDAlt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenConditionText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenConditionTextAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenConditionTextOriginal)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ehrlabspecimenrejectreason>(entity =>
            {
                entity.HasKey(e => e.EhrLabSpecimenRejectReasonNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrlabspecimenrejectreason");

                entity.HasIndex(e => e.EhrLabSpecimenNum, "EhrLabSpecimenNum");

                entity.Property(e => e.EhrLabSpecimenRejectReasonNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EhrLabSpecimenNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SpecimenRejectReasonCodeSystemName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenRejectReasonCodeSystemNameAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenRejectReasonId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SpecimenRejectReasonID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenRejectReasonIdalt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SpecimenRejectReasonIDAlt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenRejectReasonText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenRejectReasonTextAlt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenRejectReasonTextOriginal)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ehrmeasure>(entity =>
            {
                entity.HasKey(e => e.EhrMeasureNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrmeasure");

                entity.Property(e => e.EhrMeasureNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Denominator).HasColumnType("smallint(6)");

                entity.Property(e => e.MeasureType).HasColumnType("tinyint(4)");

                entity.Property(e => e.Numerator).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<Ehrmeasureevent>(entity =>
            {
                entity.HasKey(e => e.EhrMeasureEventNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrmeasureevent");

                entity.HasIndex(e => e.CodeValueEvent, "CodeValueEvent");

                entity.HasIndex(e => e.CodeValueResult, "CodeValueResult");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.EhrMeasureEventNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeSystemEvent)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeSystemResult)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeValueEvent)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeValueResult)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateStartTobacco)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTevent)
                    .HasColumnName("DateTEvent")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.EventType).HasColumnType("tinyint(4)");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.MoreInfo)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TobaccoCessationDesire).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Ehrnotperformed>(entity =>
            {
                entity.HasKey(e => e.EhrNotPerformedNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrnotperformed");

                entity.HasIndex(e => e.CodeValue, "CodeValue");

                entity.HasIndex(e => e.CodeValueReason, "CodeValueReason");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.Property(e => e.EhrNotPerformedNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeSystem)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeSystemReason)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeValue)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeValueReason)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Ehrpatient>(entity =>
            {
                entity.HasKey(e => e.PatNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrpatient");

                entity.Property(e => e.PatNum)
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenderIdentity)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GenderIdentityNote)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicaidState)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MotherMaidenFname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MotherMaidenLname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SexualOrientation)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SexualOrientationNote)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VacShareOk).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Ehrprovkey>(entity =>
            {
                entity.HasKey(e => e.EhrProvKeyNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrprovkey");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.EhrProvKeyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("FName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("LName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvKey)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.YearValue).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Ehrquarterlykey>(entity =>
            {
                entity.HasKey(e => e.EhrQuarterlyKeyNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrquarterlykey");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.EhrQuarterlyKeyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PracticeName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QuarterValue).HasColumnType("int(11)");

                entity.Property(e => e.YearValue).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Ehrsummaryccd>(entity =>
            {
                entity.HasKey(e => e.EhrSummaryCcdNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrsummaryccd");

                entity.HasIndex(e => e.EmailAttachNum, "EmailAttachNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.EhrSummaryCcdNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ContentSummary)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateSummary)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.EmailAttachNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Ehrtrigger>(entity =>
            {
                entity.HasKey(e => e.EhrTriggerNum)
                    .HasName("PRIMARY");

                entity.ToTable("ehrtrigger");

                entity.Property(e => e.EhrTriggerNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AllergyDefNumList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bibliography)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cardinality).HasColumnType("tinyint(4)");

                entity.Property(e => e.CvxList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DemographicsList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Instructions)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LabLoincList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicationNumList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProblemDefNumList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProblemIcd10List)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProblemIcd9List)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProblemSnomedList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RxCuiList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VitalLoincList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Electid>(entity =>
            {
                entity.HasKey(e => e.ElectIdnum)
                    .HasName("PRIMARY");

                entity.ToTable("electid");

                entity.Property(e => e.ElectIdnum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ElectIDNum");

                entity.Property(e => e.CarrierName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Comments)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsMedicaid).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PayorId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PayorID")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProviderTypes)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Emailaddress>(entity =>
            {
                entity.HasKey(e => e.EmailAddressNum)
                    .HasName("PRIMARY");

                entity.ToTable("emailaddress");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.EmailAddressNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AccessToken)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailPassword)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailUsername)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pop3ServerIncoming)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefreshToken)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SenderAddress)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServerPort).HasColumnType("int(11)");

                entity.Property(e => e.ServerPortIncoming).HasColumnType("int(11)");

                entity.Property(e => e.Smtpserver)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SMTPserver")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UseSsl)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("UseSSL");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Emailattach>(entity =>
            {
                entity.HasKey(e => e.EmailAttachNum)
                    .HasName("PRIMARY");

                entity.ToTable("emailattach");

                entity.HasIndex(e => e.EmailMessageNum, "EmailMessageNum");

                entity.HasIndex(e => e.EmailTemplateNum, "EmailTemplateNum");

                entity.Property(e => e.EmailAttachNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ActualFileName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DisplayedFileName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailMessageNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EmailTemplateNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Emailautograph>(entity =>
            {
                entity.HasKey(e => e.EmailAutographNum)
                    .HasName("PRIMARY");

                entity.ToTable("emailautograph");

                entity.Property(e => e.EmailAutographNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AutographText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Emailhostingtemplate>(entity =>
            {
                entity.HasKey(e => e.EmailHostingTemplateNum)
                    .HasName("PRIMARY");

                entity.ToTable("emailhostingtemplate");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.TemplateId, "TemplateId");

                entity.Property(e => e.EmailHostingTemplateNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BodyHtml)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("BodyHTML")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BodyPlainText)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EmailTemplateType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateId).HasColumnType("bigint(20)");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Emailmessage>(entity =>
            {
                entity.HasKey(e => e.EmailMessageNum)
                    .HasName("PRIMARY");

                entity.ToTable("emailmessage");

                entity.HasIndex(e => e.AptNum, "AptNum");

                entity.HasIndex(e => new { e.MsgDateTime, e.SentOrReceived }, "MsgBoxCompound");

                entity.HasIndex(e => new { e.SentOrReceived, e.RecipientAddress, e.FromAddress }, "MsgHistoricAddresses")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 50, 50 });

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.PatNumSubj, "PatNumSubj");

                entity.HasIndex(e => e.ProvNumWebMail, "ProvNumWebMail");

                entity.HasIndex(e => e.SecDateTedit, "SecDateTEdit");

                entity.HasIndex(e => e.SecDateTentry, "SecDateTEntry");

                entity.HasIndex(e => e.SentOrReceived, "SentOrReceived");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.EmailMessageNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BccAddress)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BodyText)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CcAddress)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HideIn).HasColumnType("tinyint(4)");

                entity.Property(e => e.HtmlType).HasColumnType("tinyint(4)");

                entity.Property(e => e.MsgDateTime).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNumSubj).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNumWebMail).HasColumnType("bigint(20)");

                entity.Property(e => e.RawEmailIn)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RecipientAddress)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.SentOrReceived).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Subject)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ToAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Emailmessageuid>(entity =>
            {
                entity.HasKey(e => e.EmailMessageUidNum)
                    .HasName("PRIMARY");

                entity.ToTable("emailmessageuid");

                entity.Property(e => e.EmailMessageUidNum).HasColumnType("bigint(20)");

                entity.Property(e => e.MsgId)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RecipientAddress)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Emailtemplate>(entity =>
            {
                entity.HasKey(e => e.EmailTemplateNum)
                    .HasName("PRIMARY");

                entity.ToTable("emailtemplate");

                entity.Property(e => e.EmailTemplateNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BodyText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subject)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateType).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeNum)
                    .HasName("PRIMARY");

                entity.ToTable("employee");

                entity.Property(e => e.EmployeeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClockStatus)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailPersonal)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailWork)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fname)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("FName")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsFurloughed).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsWorkingHome).HasColumnType("tinyint(4)");

                entity.Property(e => e.Lname)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("LName")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MiddleI)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayrollId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PayrollID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneExt).HasColumnType("int(11)");

                entity.Property(e => e.WirelessPhone)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Employer>(entity =>
            {
                entity.HasKey(e => e.EmployerNum)
                    .HasName("PRIMARY");

                entity.ToTable("employer");

                entity.Property(e => e.EmployerNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address2)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmpName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zip)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Encounter>(entity =>
            {
                entity.HasKey(e => e.EncounterNum)
                    .HasName("PRIMARY");

                entity.ToTable("encounter");

                entity.HasIndex(e => e.CodeValue, "CodeValue");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.Property(e => e.EncounterNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeSystem)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeValue)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateEncounter)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Entrylog>(entity =>
            {
                entity.HasKey(e => e.EntryLogNum)
                    .HasName("PRIMARY");

                entity.ToTable("entrylog");

                entity.HasIndex(e => e.EntryDateTime, "EntryDateTime");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.EntryLogNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EntryDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.FkeyType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("FKeyType");

                entity.Property(e => e.LogSource).HasColumnType("tinyint(4)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Eobattach>(entity =>
            {
                entity.HasKey(e => e.EobAttachNum)
                    .HasName("PRIMARY");

                entity.ToTable("eobattach");

                entity.HasIndex(e => e.ClaimPaymentNum, "ClaimPaymentNum");

                entity.Property(e => e.EobAttachNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimPaymentNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTcreated).HasColumnName("DateTCreated");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RawBase64)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasKey(e => e.EquipmentNum)
                    .HasName("PRIMARY");

                entity.ToTable("equipment");

                entity.HasIndex(e => e.ProvNumCheckedOut, "ProvNumCheckedOut");

                entity.Property(e => e.EquipmentNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateCheckedOut)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateExpectedBack)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DatePurchased)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateSold)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DispenseNote)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModelYear)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvNumCheckedOut).HasColumnType("bigint(20)");

                entity.Property(e => e.SerialNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Erxlog>(entity =>
            {
                entity.HasKey(e => e.ErxLogNum)
                    .HasName("PRIMARY");

                entity.ToTable("erxlog");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.ErxLogNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MsgText)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Eservicesignal>(entity =>
            {
                entity.HasKey(e => e.EserviceSignalNum)
                    .HasName("PRIMARY");

                entity.ToTable("eservicesignal");

                entity.Property(e => e.EserviceSignalNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("EServiceSignalNum");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsProcessed).HasColumnType("tinyint(4)");

                entity.Property(e => e.ReasonCategory).HasColumnType("int(11)");

                entity.Property(e => e.ReasonCode).HasColumnType("int(11)");

                entity.Property(e => e.ServiceCode).HasColumnType("int(11)");

                entity.Property(e => e.Severity).HasColumnType("tinyint(4)");

                entity.Property(e => e.SigDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Etran>(entity =>
            {
                entity.HasKey(e => e.EtransNum)
                    .HasName("PRIMARY");

                entity.ToTable("etrans");

                entity.HasIndex(e => e.AckEtransNum, "AckEtransNum");

                entity.HasIndex(e => e.CarrierNum, "CarrierNum");

                entity.HasIndex(e => e.CarrierNum2, "CarrierNum2");

                entity.HasIndex(e => e.ClaimNum, "ClaimNum");

                entity.HasIndex(e => e.ClearingHouseNum, "ClearingHouseNum");

                entity.HasIndex(e => e.EtransMessageTextNum, "EtransMessageTextNum");

                entity.HasIndex(e => new { e.Etype, e.DateTimeTrans }, "EtransTypeAndDate");

                entity.HasIndex(e => e.InsSubNum, "InsSubNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.PlanNum, "PlanNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.EtransNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AckCode)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AckEtransNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BatchNumber).HasColumnType("int(11)");

                entity.Property(e => e.CarrierNameRaw)
                    .IsRequired()
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarrierNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CarrierNum2).HasColumnType("bigint(20)");

                entity.Property(e => e.CarrierTransCounter).HasColumnType("int(11)");

                entity.Property(e => e.CarrierTransCounter2).HasColumnType("int(11)");

                entity.Property(e => e.ClaimNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClearingHouseNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeTrans).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.EtransMessageTextNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Etype).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.InsSubNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OfficeSequenceNumber).HasColumnType("int(11)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatientNameRaw)
                    .IsRequired()
                    .HasColumnType("varchar(133)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TranSetId835)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TransSetNum).HasColumnType("int(11)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Etrans835attach>(entity =>
            {
                entity.HasKey(e => e.Etrans835AttachNum)
                    .HasName("PRIMARY");

                entity.ToTable("etrans835attach");

                entity.HasIndex(e => e.ClaimNum, "ClaimNum");

                entity.HasIndex(e => e.EtransNum, "EtransNum");

                entity.Property(e => e.Etrans835AttachNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClpSegmentIndex).HasColumnType("int(11)");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.EtransNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Etransmessagetext>(entity =>
            {
                entity.HasKey(e => e.EtransMessageTextNum)
                    .HasName("PRIMARY");

                entity.ToTable("etransmessagetext");

                entity.Property(e => e.EtransMessageTextNum).HasColumnType("bigint(20)");

                entity.Property(e => e.MessageText)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Evaluation>(entity =>
            {
                entity.HasKey(e => e.EvaluationNum)
                    .HasName("PRIMARY");

                entity.ToTable("evaluation");

                entity.HasIndex(e => e.GradingScaleNum, "GradingScaleNum");

                entity.HasIndex(e => e.InstructNum, "InstructNum");

                entity.HasIndex(e => e.SchoolCourseNum, "SchoolCourseNum");

                entity.HasIndex(e => e.StudentNum, "StudentNum");

                entity.Property(e => e.EvaluationNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateEval)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.EvalTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GradingScaleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.InstructNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OverallGradeShowing)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SchoolCourseNum).HasColumnType("bigint(20)");

                entity.Property(e => e.StudentNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Evaluationcriterion>(entity =>
            {
                entity.HasKey(e => e.EvaluationCriterionNum)
                    .HasName("PRIMARY");

                entity.ToTable("evaluationcriterion");

                entity.HasIndex(e => e.EvaluationNum, "EvaluationNum");

                entity.HasIndex(e => e.GradingScaleNum, "GradingScaleNum");

                entity.Property(e => e.EvaluationCriterionNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CriterionDescript)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EvaluationNum).HasColumnType("bigint(20)");

                entity.Property(e => e.GradeShowing)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GradingScaleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsCategoryName).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Evaluationcriteriondef>(entity =>
            {
                entity.HasKey(e => e.EvaluationCriterionDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("evaluationcriteriondef");

                entity.HasIndex(e => e.EvaluationDefNum, "EvaluationDefNum");

                entity.HasIndex(e => e.GradingScaleNum, "GradingScaleNum");

                entity.Property(e => e.EvaluationCriterionDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CriterionDescript)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EvaluationDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.GradingScaleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsCategoryName).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Evaluationdef>(entity =>
            {
                entity.HasKey(e => e.EvaluationDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("evaluationdef");

                entity.HasIndex(e => e.GradingScaleNum, "GradingScaleNum");

                entity.HasIndex(e => e.SchoolCourseNum, "SchoolCourseNum");

                entity.Property(e => e.EvaluationDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EvalTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GradingScaleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SchoolCourseNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Famaging>(entity =>
            {
                entity.HasKey(e => e.PatNum)
                    .HasName("PRIMARY");

                entity.ToTable("famaging");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Bal030).HasColumnName("Bal_0_30");

                entity.Property(e => e.Bal3160).HasColumnName("Bal_31_60");

                entity.Property(e => e.Bal6190).HasColumnName("Bal_61_90");
            });

            modelBuilder.Entity<Familyhealth>(entity =>
            {
                entity.HasKey(e => e.FamilyHealthNum)
                    .HasName("PRIMARY");

                entity.ToTable("familyhealth");

                entity.HasIndex(e => e.DiseaseDefNum, "DiseaseDefNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.FamilyHealthNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DiseaseDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Relationship).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Fee>(entity =>
            {
                entity.HasKey(e => e.FeeNum)
                    .HasName("PRIMARY");

                entity.ToTable("fee");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.CodeNum, "CodeNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => e.OldCode, "indexADACode");

                entity.HasIndex(e => e.FeeSched, "indexFeeSched");

                entity.Property(e => e.FeeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FeeSched).HasColumnType("bigint(20)");

                entity.Property(e => e.OldCode)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.UseDefaultCov).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.UseDefaultFee).HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<Feesched>(entity =>
            {
                entity.HasKey(e => e.FeeSchedNum)
                    .HasName("PRIMARY");

                entity.ToTable("feesched");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.Property(e => e.FeeSchedNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FeeSchedType).HasColumnType("int(11)");

                entity.Property(e => e.IsGlobal).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.SecDateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Feeschedgroup>(entity =>
            {
                entity.HasKey(e => e.FeeSchedGroupNum)
                    .HasName("PRIMARY");

                entity.ToTable("feeschedgroup");

                entity.HasIndex(e => e.FeeSchedNum, "FeeSchedNum");

                entity.Property(e => e.FeeSchedGroupNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNums)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FeeSchedNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Fhircontactpoint>(entity =>
            {
                entity.HasKey(e => e.FhircontactPointNum)
                    .HasName("PRIMARY");

                entity.ToTable("fhircontactpoint");

                entity.HasIndex(e => e.FhirsubscriptionNum, "FHIRSubscriptionNum");

                entity.Property(e => e.FhircontactPointNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FHIRContactPointNum");

                entity.Property(e => e.ContactSystem).HasColumnType("tinyint(4)");

                entity.Property(e => e.ContactUse).HasColumnType("tinyint(4)");

                entity.Property(e => e.ContactValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.FhirsubscriptionNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FHIRSubscriptionNum");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Fhirsubscription>(entity =>
            {
                entity.HasKey(e => e.FhirsubscriptionNum)
                    .HasName("PRIMARY");

                entity.ToTable("fhirsubscription");

                entity.Property(e => e.FhirsubscriptionNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FHIRSubscriptionNum");

                entity.Property(e => e.ApikeyHash)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("APIKeyHash")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChannelEndpoint)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChannelHeader)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChannelPayLoad)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChannelType).HasColumnType("tinyint(4)");

                entity.Property(e => e.Criteria)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateEnd).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ErrorNote)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubStatus).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Fielddeflink>(entity =>
            {
                entity.HasKey(e => e.FieldDefLinkNum)
                    .HasName("PRIMARY");

                entity.ToTable("fielddeflink");

                entity.HasIndex(e => e.FieldDefNum, "FieldDefNum");

                entity.Property(e => e.FieldDefLinkNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FieldDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FieldDefType).HasColumnType("tinyint(4)");

                entity.Property(e => e.FieldLocation).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.HasKey(e => e.DocNum)
                    .HasName("PRIMARY");

                entity.ToTable("files");

                entity.Property(e => e.DocNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Data).IsRequired();
            });

            modelBuilder.Entity<Formpat>(entity =>
            {
                entity.HasKey(e => e.FormPatNum)
                    .HasName("PRIMARY");

                entity.ToTable("formpat");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.FormPatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FormDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Gradingscale>(entity =>
            {
                entity.HasKey(e => e.GradingScaleNum)
                    .HasName("PRIMARY");

                entity.ToTable("gradingscale");

                entity.Property(e => e.GradingScaleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ScaleType).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Gradingscaleitem>(entity =>
            {
                entity.HasKey(e => e.GradingScaleItemNum)
                    .HasName("PRIMARY");

                entity.ToTable("gradingscaleitem");

                entity.HasIndex(e => e.GradingScaleNum, "GradingScaleNum");

                entity.Property(e => e.GradingScaleItemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GradeShowing)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GradingScaleNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Grouppermission>(entity =>
            {
                entity.HasKey(e => e.GroupPermNum)
                    .HasName("PRIMARY");

                entity.ToTable("grouppermission");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.HasIndex(e => e.UserGroupNum, "UserGroupNum");

                entity.Property(e => e.GroupPermNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.NewerDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.NewerDays).HasColumnType("int(11)");

                entity.Property(e => e.PermType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.UserGroupNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Guardian>(entity =>
            {
                entity.HasKey(e => e.GuardianNum)
                    .HasName("PRIMARY");

                entity.ToTable("guardian");

                entity.HasIndex(e => e.PatNumChild, "PatNumChild");

                entity.HasIndex(e => e.PatNumGuardian, "PatNumGuardian");

                entity.Property(e => e.GuardianNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsGuardian).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatNumChild).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNumGuardian).HasColumnType("bigint(20)");

                entity.Property(e => e.Relationship).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Hcpc>(entity =>
            {
                entity.HasKey(e => e.HcpcsNum)
                    .HasName("PRIMARY");

                entity.ToTable("hcpcs");

                entity.HasIndex(e => e.HcpcsCode, "HcpcsCode");

                entity.Property(e => e.HcpcsNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DescriptionShort)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HcpcsCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Histappointment>(entity =>
            {
                entity.HasKey(e => e.HistApptNum)
                    .HasName("PRIMARY");

                entity.ToTable("histappointment");

                entity.HasIndex(e => e.AppointmentTypeNum, "AppointmentTypeNum");

                entity.HasIndex(e => e.AptNum, "AptNum");

                entity.HasIndex(e => e.Assistant, "Assistant");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.Confirmed, "Confirmed");

                entity.HasIndex(e => e.HistUserNum, "HistUserNum");

                entity.HasIndex(e => e.InsPlan1, "InsPlan1");

                entity.HasIndex(e => e.InsPlan2, "InsPlan2");

                entity.HasIndex(e => e.NextAptNum, "NextAptNum");

                entity.HasIndex(e => e.Op, "Op");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProvHyg, "ProvHyg");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => e.UnschedStatus, "UnschedStatus");

                entity.Property(e => e.HistApptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AppointmentTypeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ApptSource).HasColumnType("tinyint(4)");

                entity.Property(e => e.AptDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.AptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AptStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.Assistant).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ColorOverride).HasColumnType("int(11)");

                entity.Property(e => e.Confirmed).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeArrived).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeAskedToArrive).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeDismissed).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeSeated).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HistApptAction).HasColumnType("tinyint(4)");

                entity.Property(e => e.HistDateTstamp)
                    .HasColumnName("HistDateTStamp")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.HistUserNum).HasColumnType("bigint(20)");

                entity.Property(e => e.InsPlan1).HasColumnType("bigint(20)");

                entity.Property(e => e.InsPlan2).HasColumnType("bigint(20)");

                entity.Property(e => e.IsHygiene).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsNewPatient).HasColumnType("tinyint(4)");

                entity.Property(e => e.NextAptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Op).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Pattern)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatternSecondary)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Priority).HasColumnType("tinyint(4)");

                entity.Property(e => e.ProcDescript)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcsColored)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvBarText)
                    .IsRequired()
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvHyg).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.TimeLocked).HasColumnType("tinyint(4)");

                entity.Property(e => e.UnschedStatus).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Hl7def>(entity =>
            {
                entity.HasKey(e => e.Hl7defNum)
                    .HasName("PRIMARY");

                entity.ToTable("hl7def");

                entity.HasIndex(e => e.LabResultImageCat, "LabResultImageCat");

                entity.Property(e => e.Hl7defNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("HL7DefNum");

                entity.Property(e => e.ComponentSeparator)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EscapeCharacter)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldSeparator)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HasLongDcodes)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("HasLongDCodes");

                entity.Property(e => e.Hl7server)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("HL7Server")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hl7serviceName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("HL7ServiceName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IncomingFolder)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IncomingPort)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InternalType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InternalTypeVersion)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsEnabled).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsInternal).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsProcApptEnforced).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsQuadAsToothNum).HasColumnType("tinyint(4)");

                entity.Property(e => e.LabResultImageCat).HasColumnType("bigint(20)");

                entity.Property(e => e.ModeTx).HasColumnType("tinyint(4)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutgoingFolder)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutgoingIpPort)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RepetitionSeparator)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SftpInSocket)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SftpPassword)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SftpUsername)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShowAccount).HasColumnType("tinyint(4)");

                entity.Property(e => e.ShowAppts).HasColumnType("tinyint(4)");

                entity.Property(e => e.ShowDemographics).HasColumnType("tinyint(4)");

                entity.Property(e => e.SubcomponentSeparator)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Hl7deffield>(entity =>
            {
                entity.HasKey(e => e.Hl7defFieldNum)
                    .HasName("PRIMARY");

                entity.ToTable("hl7deffield");

                entity.HasIndex(e => e.Hl7defSegmentNum, "HL7DefSegmentNum");

                entity.Property(e => e.Hl7defFieldNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("HL7DefFieldNum");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FixedText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hl7defSegmentNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("HL7DefSegmentNum");

                entity.Property(e => e.OrdinalPos).HasColumnType("int(11)");

                entity.Property(e => e.TableId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Hl7defmessage>(entity =>
            {
                entity.HasKey(e => e.Hl7defMessageNum)
                    .HasName("PRIMARY");

                entity.ToTable("hl7defmessage");

                entity.HasIndex(e => e.Hl7defNum, "HL7DefNum");

                entity.Property(e => e.Hl7defMessageNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("HL7DefMessageNum");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hl7defNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("HL7DefNum");

                entity.Property(e => e.InOrOut).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.MessageStructure)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Hl7defsegment>(entity =>
            {
                entity.HasKey(e => e.Hl7defSegmentNum)
                    .HasName("PRIMARY");

                entity.ToTable("hl7defsegment");

                entity.HasIndex(e => e.Hl7defMessageNum, "HL7DefMessageNum");

                entity.Property(e => e.Hl7defSegmentNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("HL7DefSegmentNum");

                entity.Property(e => e.CanRepeat).HasColumnType("tinyint(4)");

                entity.Property(e => e.Hl7defMessageNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("HL7DefMessageNum");

                entity.Property(e => e.IsOptional).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SegmentName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Hl7msg>(entity =>
            {
                entity.HasKey(e => e.Hl7msgNum)
                    .HasName("PRIMARY");

                entity.ToTable("hl7msg");

                entity.HasIndex(e => e.AptNum, "AptNum");

                entity.HasIndex(e => e.DateTstamp, "DateTStamp");

                entity.HasIndex(e => e.Hl7status, "HL7Status");

                entity.HasIndex(e => e.MsgText, "MsgText")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.Hl7msgNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("HL7MsgNum");

                entity.Property(e => e.AptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Hl7status)
                    .HasColumnType("int(11)")
                    .HasColumnName("HL7Status");

                entity.Property(e => e.MsgText)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Hl7procattach>(entity =>
            {
                entity.HasKey(e => e.Hl7procAttachNum)
                    .HasName("PRIMARY");

                entity.ToTable("hl7procattach");

                entity.HasIndex(e => e.Hl7msgNum, "HL7MsgNum");

                entity.HasIndex(e => e.ProcNum, "ProcNum");

                entity.Property(e => e.Hl7procAttachNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("HL7ProcAttachNum");

                entity.Property(e => e.Hl7msgNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("HL7MsgNum");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Icd10>(entity =>
            {
                entity.HasKey(e => e.Icd10Num)
                    .HasName("PRIMARY");

                entity.ToTable("icd10");

                entity.HasIndex(e => e.Icd10Code, "Icd10Code");

                entity.Property(e => e.Icd10Num).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Icd10Code)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Icd9>(entity =>
            {
                entity.HasKey(e => e.Icd9num)
                    .HasName("PRIMARY");

                entity.ToTable("icd9");

                entity.HasIndex(e => e.Icd9code, "ICD9Code");

                entity.Property(e => e.Icd9num)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ICD9Num");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Icd9code)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ICD9Code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Inseditlog>(entity =>
            {
                entity.HasKey(e => e.InsEditLogNum)
                    .HasName("PRIMARY");

                entity.ToTable("inseditlog");

                entity.HasIndex(e => new { e.LogType, e.Fkey }, "FKeyType");

                entity.HasIndex(e => e.ParentKey, "ParentKey");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.InsEditLogNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.LogType).HasColumnType("tinyint(4)");

                entity.Property(e => e.NewValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OldValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentKey).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Inseditpatlog>(entity =>
            {
                entity.HasKey(e => e.InsEditPatLogNum)
                    .HasName("PRIMARY");

                entity.ToTable("inseditpatlog");

                entity.HasIndex(e => new { e.Fkey, e.LogType }, "FkLogType");

                entity.HasIndex(e => e.ParentKey, "ParentKey");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.InsEditPatLogNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.LogType).HasColumnType("tinyint(4)");

                entity.Property(e => e.NewValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OldValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentKey).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Insfilingcode>(entity =>
            {
                entity.HasKey(e => e.InsFilingCodeNum)
                    .HasName("PRIMARY");

                entity.ToTable("insfilingcode");

                entity.HasIndex(e => e.GroupType, "GroupType");

                entity.HasIndex(e => e.ItemOrder, "ItemOrder");

                entity.Property(e => e.InsFilingCodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Descript)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EclaimCode)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupType).HasColumnType("bigint(20)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Insfilingcodesubtype>(entity =>
            {
                entity.HasKey(e => e.InsFilingCodeSubtypeNum)
                    .HasName("PRIMARY");

                entity.ToTable("insfilingcodesubtype");

                entity.HasIndex(e => e.InsFilingCodeNum, "InsFilingCodeNum");

                entity.Property(e => e.InsFilingCodeSubtypeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Descript)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InsFilingCodeNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Insplan>(entity =>
            {
                entity.HasKey(e => e.PlanNum)
                    .HasName("PRIMARY");

                entity.ToTable("insplan");

                entity.HasIndex(e => e.BillingType, "BillingType");

                entity.HasIndex(e => e.CarrierNum, "CarrierNum");

                entity.HasIndex(e => new { e.CarrierNum, e.PlanNum }, "CarrierNumPlanNum");

                entity.HasIndex(e => e.CopayFeeSched, "CopayFeeSched");

                entity.HasIndex(e => e.FeeSched, "FeeSched");

                entity.HasIndex(e => e.FilingCodeSubtype, "FilingCodeSubtype");

                entity.HasIndex(e => e.OrthoAutoProcCodeNumOverride, "OrthoAutoProcCodeNumOverride");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => e.TrojanId, "TrojanID");

                entity.Property(e => e.PlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AllowedFeeSched).HasColumnType("bigint(20)");

                entity.Property(e => e.BillingType).HasColumnType("bigint(20)");

                entity.Property(e => e.CanadianDiagnosticCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CanadianInstitutionCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CanadianPlanFlag)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarrierNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimFormNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimsUseUcr)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("ClaimsUseUCR");

                entity.Property(e => e.CobRule).HasColumnType("tinyint(4)");

                entity.Property(e => e.CopayFeeSched).HasColumnType("bigint(20)");

                entity.Property(e => e.DentaideCardSequence).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.DivisionNo)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmployerNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ExclusionFeeRule).HasColumnType("tinyint(4)");

                entity.Property(e => e.FeeSched).HasColumnType("bigint(20)");

                entity.Property(e => e.FilingCode).HasColumnType("bigint(20)");

                entity.Property(e => e.FilingCodeSubtype).HasColumnType("bigint(20)");

                entity.Property(e => e.GroupName)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupNum)
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HasPpoSubstWriteoffs).HasColumnType("tinyint(4)");

                entity.Property(e => e.HideFromVerifyList).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsMedical).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MonthRenew).HasColumnType("tinyint(4)");

                entity.Property(e => e.OrthoAutoClaimDaysWait).HasColumnType("int(11)");

                entity.Property(e => e.OrthoAutoProcCodeNumOverride).HasColumnType("bigint(20)");

                entity.Property(e => e.OrthoAutoProcFreq).HasColumnType("tinyint(4)");

                entity.Property(e => e.OrthoType).HasColumnType("tinyint(4)");

                entity.Property(e => e.PlanNote)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlanType)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RxBin)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("RxBIN")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecDateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.SopCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TrojanId)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("TrojanID")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UseAltCode).HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<Inssub>(entity =>
            {
                entity.HasKey(e => e.InsSubNum)
                    .HasName("PRIMARY");

                entity.ToTable("inssub");

                entity.HasIndex(e => e.PlanNum, "PlanNum");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => e.Subscriber, "Subscriber");

                entity.Property(e => e.InsSubNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AssignBen).HasColumnType("tinyint(4)");

                entity.Property(e => e.BenefitNotes)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateEffective)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTerm)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.PlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ReleaseInfo).HasColumnType("tinyint(4)");

                entity.Property(e => e.SecDateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.SubscNote)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subscriber).HasColumnType("bigint(20)");

                entity.Property(e => e.SubscriberId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SubscriberID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Installmentplan>(entity =>
            {
                entity.HasKey(e => e.InstallmentPlanNum)
                    .HasName("PRIMARY");

                entity.ToTable("installmentplan");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.InstallmentPlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Apr).HasColumnName("APR");

                entity.Property(e => e.DateAgreement)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateFirstPayment)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasKey(e => e.InstructorNum)
                    .HasName("PRIMARY");

                entity.ToTable("instructor");

                entity.Property(e => e.InstructorNum).HasColumnType("int(11)");

                entity.Property(e => e.Fname)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("FName")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lname)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("LName")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Suffix)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Insverify>(entity =>
            {
                entity.HasKey(e => e.InsVerifyNum)
                    .HasName("PRIMARY");

                entity.ToTable("insverify");

                entity.HasIndex(e => e.DateTimeEntry, "DateTimeEntry");

                entity.HasIndex(e => e.DefNum, "DefNum");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.HasIndex(e => e.SecDateTedit, "SecDateTEdit");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.HasIndex(e => e.VerifyType, "VerifyType");

                entity.Property(e => e.InsVerifyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateLastAssigned)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateLastVerified)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");

                entity.Property(e => e.VerifyType).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Insverifyhist>(entity =>
            {
                entity.HasKey(e => e.InsVerifyHistNum)
                    .HasName("PRIMARY");

                entity.ToTable("insverifyhist");

                entity.HasIndex(e => e.DefNum, "DefNum");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.HasIndex(e => e.InsVerifyNum, "InsVerifyNum");

                entity.HasIndex(e => e.SecDateTedit, "SecDateTEdit");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.HasIndex(e => e.VerifyUserNum, "VerifyUserNum");

                entity.Property(e => e.InsVerifyHistNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateLastAssigned)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateLastVerified)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.InsVerifyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");

                entity.Property(e => e.VerifyType).HasColumnType("tinyint(4)");

                entity.Property(e => e.VerifyUserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Intervention>(entity =>
            {
                entity.HasKey(e => e.InterventionNum)
                    .HasName("PRIMARY");

                entity.ToTable("intervention");

                entity.HasIndex(e => e.CodeValue, "CodeValue");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.Property(e => e.InterventionNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeSet).HasColumnType("tinyint(4)");

                entity.Property(e => e.CodeSystem)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeValue)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.IsPatDeclined).HasColumnType("tinyint(4)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Journalentry>(entity =>
            {
                entity.HasKey(e => e.JournalEntryNum)
                    .HasName("PRIMARY");

                entity.ToTable("journalentry");

                entity.HasIndex(e => e.SecUserNumEdit, "SecUserNumEdit");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => e.AccountNum, "indexAccountNum");

                entity.HasIndex(e => e.TransactionNum, "indexTransactionNum");

                entity.Property(e => e.JournalEntryNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AccountNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CheckNumber)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateDisplayed)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Memo)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReconcileNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.SecUserNumEdit).HasColumnType("bigint(20)");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.Splits)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TransactionNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Labcase>(entity =>
            {
                entity.HasKey(e => e.LabCaseNum)
                    .HasName("PRIMARY");

                entity.ToTable("labcase");

                entity.HasIndex(e => e.AptNum, "indexAptNum");

                entity.Property(e => e.LabCaseNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeChecked).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeCreated).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeDue).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeRecd).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeSent).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Instructions)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InvoiceNum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LaboratoryNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PlannedAptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Laboratory>(entity =>
            {
                entity.HasKey(e => e.LaboratoryNum)
                    .HasName("PRIMARY");

                entity.ToTable("laboratory");

                entity.Property(e => e.LaboratoryNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(4)");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slip).HasColumnType("bigint(20)");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WirelessPhone)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Labpanel>(entity =>
            {
                entity.HasKey(e => e.LabPanelNum)
                    .HasName("PRIMARY");

                entity.ToTable("labpanel");

                entity.HasIndex(e => e.MedicalOrderNum, "MedicalOrderNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.LabPanelNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LabNameAddress)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicalOrderNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.RawMessage)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenCondition)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenSource)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Labresult>(entity =>
            {
                entity.HasKey(e => e.LabResultNum)
                    .HasName("PRIMARY");

                entity.ToTable("labresult");

                entity.HasIndex(e => e.LabPanelNum, "LabPanelNum");

                entity.Property(e => e.LabResultNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AbnormalFlag).HasColumnType("tinyint(4)");

                entity.Property(e => e.DateTimeTest).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LabPanelNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ObsRange)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsUnits)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TestId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TestID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TestName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Labturnaround>(entity =>
            {
                entity.HasKey(e => e.LabTurnaroundNum)
                    .HasName("PRIMARY");

                entity.ToTable("labturnaround");

                entity.Property(e => e.LabTurnaroundNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DaysActual).HasColumnType("smallint(6)");

                entity.Property(e => e.DaysPublished).HasColumnType("smallint(6)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LaboratoryNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasKey(e => e.LanguageNum)
                    .HasName("PRIMARY");

                entity.ToTable("language");

                entity.Property(e => e.LanguageNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClassType)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.English)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EnglishComments)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsObsolete).HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<Languageforeign>(entity =>
            {
                entity.HasKey(e => e.LanguageForeignNum)
                    .HasName("PRIMARY");

                entity.ToTable("languageforeign");

                entity.Property(e => e.LanguageForeignNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClassType)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Comments)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Culture)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.English)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Translation)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Letter>(entity =>
            {
                entity.HasKey(e => e.LetterNum)
                    .HasName("PRIMARY");

                entity.ToTable("letter");

                entity.Property(e => e.LetterNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BodyText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Lettermerge>(entity =>
            {
                entity.HasKey(e => e.LetterMergeNum)
                    .HasName("PRIMARY");

                entity.ToTable("lettermerge");

                entity.Property(e => e.LetterMergeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Category).HasColumnType("bigint(20)");

                entity.Property(e => e.DataFileName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImageFolder).HasColumnType("bigint(20)");

                entity.Property(e => e.TemplateName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Lettermergefield>(entity =>
            {
                entity.HasKey(e => e.FieldNum)
                    .HasName("PRIMARY");

                entity.ToTable("lettermergefield");

                entity.Property(e => e.FieldNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FieldName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LetterMergeNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Loginattempt>(entity =>
            {
                entity.HasKey(e => e.LoginAttemptNum)
                    .HasName("PRIMARY");

                entity.ToTable("loginattempt");

                entity.HasIndex(e => e.UserName, "UserName")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

                entity.Property(e => e.LoginAttemptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTfail)
                    .HasColumnName("DateTFail")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.LoginType).HasColumnType("tinyint(4)");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Loinc>(entity =>
            {
                entity.HasKey(e => e.LoincNum)
                    .HasName("PRIMARY");

                entity.ToTable("loinc");

                entity.HasIndex(e => e.LoincCode, "LoincCode");

                entity.Property(e => e.LoincNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClassType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Component)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExternalCopyrightNotice)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hl7fieldSubfieldId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("HL7FieldSubfieldID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LoincCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MethodType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameLongCommon)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameShort)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderObs)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PropertyObserved)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RankCommonOrders).HasColumnType("int(11)");

                entity.Property(e => e.RankCommonTests).HasColumnType("int(11)");

                entity.Property(e => e.ScaleType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StatusOfCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SystemMeasured)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TimeAspct)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnitsRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.UnitsUcum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("UnitsUCUM")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Maparea>(entity =>
            {
                entity.HasKey(e => e.MapAreaNum)
                    .HasName("PRIMARY");

                entity.ToTable("maparea");

                entity.HasIndex(e => e.MapAreaContainerNum, "MapAreaContainerNum");

                entity.Property(e => e.MapAreaNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Extension).HasColumnType("int(11)");

                entity.Property(e => e.ItemType).HasColumnType("tinyint(4)");

                entity.Property(e => e.MapAreaContainerNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Xpos).HasColumnName("XPos");

                entity.Property(e => e.Ypos).HasColumnName("YPos");
            });

            modelBuilder.Entity<Medicalorder>(entity =>
            {
                entity.HasKey(e => e.MedicalOrderNum)
                    .HasName("PRIMARY");

                entity.ToTable("medicalorder");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.Property(e => e.MedicalOrderNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeOrder).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDiscontinued).HasColumnType("tinyint(4)");

                entity.Property(e => e.MedOrderType).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Medication>(entity =>
            {
                entity.HasKey(e => e.MedicationNum)
                    .HasName("PRIMARY");

                entity.ToTable("medication");

                entity.HasIndex(e => e.RxCui, "RxCui");

                entity.Property(e => e.MedicationNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.GenericNum).HasColumnType("bigint(20)");

                entity.Property(e => e.MedName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RxCui).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Medicationpat>(entity =>
            {
                entity.HasKey(e => e.MedicationPatNum)
                    .HasName("PRIMARY");

                entity.ToTable("medicationpat");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.RxCui, "RxCui");

                entity.Property(e => e.MedicationPatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateStop)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ErxGuid)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsCpoe).HasColumnType("tinyint(4)");

                entity.Property(e => e.MedDescript)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicationNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNote)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.RxCui).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Medlab>(entity =>
            {
                entity.HasKey(e => e.MedLabNum)
                    .HasName("PRIMARY");

                entity.ToTable("medlab");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.Property(e => e.MedLabNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ActionCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicalInfo)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateTimeCollected).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeEntered).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeReported).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NoteLab)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotePat)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsTestDescript)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsTestId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ObsTestID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsTestLoinc)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsTestLoincText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProvFname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OrderingProvFName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProvLname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OrderingProvLName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProvLocalId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OrderingProvLocalID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderingProvNpi)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OrderingProvNPI")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OriginalPidsegment)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("OriginalPIDSegment")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentObsId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentObsID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentObsTestId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentObsTestID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatAccountNum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatAge)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatFasting).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatIdalt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PatIDAlt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatIdlab)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PatIDLab")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ResultStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SendingApp)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SendingFacility)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SpecimenID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenIdalt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SpecimenIDAlt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenIdfiller)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SpecimenIDFiller")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TotalVolume)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Medlabfacattach>(entity =>
            {
                entity.HasKey(e => e.MedLabFacAttachNum)
                    .HasName("PRIMARY");

                entity.ToTable("medlabfacattach");

                entity.HasIndex(e => e.MedLabFacilityNum, "MedLabFacilityNum");

                entity.HasIndex(e => e.MedLabNum, "MedLabNum");

                entity.HasIndex(e => e.MedLabResultNum, "MedLabResultNum");

                entity.Property(e => e.MedLabFacAttachNum).HasColumnType("bigint(20)");

                entity.Property(e => e.MedLabFacilityNum).HasColumnType("bigint(20)");

                entity.Property(e => e.MedLabNum).HasColumnType("bigint(20)");

                entity.Property(e => e.MedLabResultNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Medlabfacility>(entity =>
            {
                entity.HasKey(e => e.MedLabFacilityNum)
                    .HasName("PRIMARY");

                entity.ToTable("medlabfacility");

                entity.Property(e => e.MedLabFacilityNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DirectorFname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("DirectorFName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DirectorLname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("DirectorLName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DirectorTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FacilityName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Medlabresult>(entity =>
            {
                entity.HasKey(e => e.MedLabResultNum)
                    .HasName("PRIMARY");

                entity.ToTable("medlabresult");

                entity.HasIndex(e => e.DocNum, "DocNum");

                entity.HasIndex(e => e.MedLabNum, "MedLabNum");

                entity.Property(e => e.MedLabResultNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AbnormalFlag)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateTimeObs).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DocNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FacilityId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("FacilityID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedLabNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ObsID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsIdsub)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ObsIDSub")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsLoinc)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsLoincText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsSubType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsUnits)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObsValue)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReferenceRange)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResultStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Medlabspeciman>(entity =>
            {
                entity.HasKey(e => e.MedLabSpecimenNum)
                    .HasName("PRIMARY");

                entity.ToTable("medlabspecimen");

                entity.HasIndex(e => e.MedLabNum, "MedLabNum");

                entity.Property(e => e.MedLabSpecimenNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeCollected).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.MedLabNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SpecimenDescript)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecimenId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SpecimenID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Mobileappdevice>(entity =>
            {
                entity.HasKey(e => e.MobileAppDeviceNum)
                    .HasName("PRIMARY");

                entity.ToTable("mobileappdevice");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.MobileAppDeviceNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DeviceName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsAllowed).HasColumnType("tinyint(4)");

                entity.Property(e => e.LastAttempt).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.LastCheckInActivity).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.LastLogin).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UniqueId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("UniqueID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Mobiledatabyte>(entity =>
            {
                entity.HasKey(e => e.MobileDataByteNum)
                    .HasName("PRIMARY");

                entity.ToTable("mobiledatabyte");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.RawBase64Code, "RawBase64Code")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 16 });

                entity.Property(e => e.MobileDataByteNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ActionType).HasColumnType("tinyint(4)");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeExpires).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.RawBase64Code)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RawBase64Data)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RawBase64Tag)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Mount>(entity =>
            {
                entity.HasKey(e => e.MountNum)
                    .HasName("PRIMARY");

                entity.ToTable("mount");

                entity.Property(e => e.MountNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ColorBack).HasColumnType("int(11)");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DocCategory).HasColumnType("bigint(20)");

                entity.Property(e => e.Height).HasColumnType("int(11)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Width).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Mountdef>(entity =>
            {
                entity.HasKey(e => e.MountDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("mountdef");

                entity.Property(e => e.MountDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ColorBack).HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Height).HasColumnType("int(11)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.Width).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Mountitem>(entity =>
            {
                entity.HasKey(e => e.MountItemNum)
                    .HasName("PRIMARY");

                entity.ToTable("mountitem");

                entity.Property(e => e.MountItemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Height).HasColumnType("int(11)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.MountNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Width).HasColumnType("int(11)");

                entity.Property(e => e.Xpos).HasColumnType("int(11)");

                entity.Property(e => e.Ypos).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Mountitemdef>(entity =>
            {
                entity.HasKey(e => e.MountItemDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("mountitemdef");

                entity.Property(e => e.MountItemDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Height).HasColumnType("int(11)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.MountDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Width).HasColumnType("int(11)");

                entity.Property(e => e.Xpos).HasColumnType("int(11)");

                entity.Property(e => e.Ypos).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Oidexternal>(entity =>
            {
                entity.HasKey(e => e.OidexternalNum)
                    .HasName("PRIMARY");

                entity.ToTable("oidexternal");

                entity.HasIndex(e => new { e.Idtype, e.Idinternal }, "IDType");

                entity.HasIndex(e => new { e.RootExternal, e.Idexternal }, "rootExternal")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 62, 62 });

                entity.Property(e => e.OidexternalNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("OIDExternalNum");

                entity.Property(e => e.Idexternal)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("IDExternal")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Idinternal)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("IDInternal");

                entity.Property(e => e.Idtype)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("IDType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RootExternal)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("rootExternal")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Oidinternal>(entity =>
            {
                entity.HasKey(e => e.OidinternalNum)
                    .HasName("PRIMARY");

                entity.ToTable("oidinternal");

                entity.Property(e => e.OidinternalNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("OIDInternalNum");

                entity.Property(e => e.Idroot)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("IDRoot")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Idtype)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("IDType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Operatory>(entity =>
            {
                entity.HasKey(e => e.OperatoryNum)
                    .HasName("PRIMARY");

                entity.ToTable("operatory");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.ProvDentist, "ProvDentist");

                entity.HasIndex(e => e.ProvHygienist, "ProvHygienist");

                entity.Property(e => e.OperatoryNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Abbrev)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.IsHygiene).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.IsNewPatAppt).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsWebSched).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.OpName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvDentist).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvHygienist).HasColumnType("bigint(20)");

                entity.Property(e => e.SetProspective).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Orionproc>(entity =>
            {
                entity.HasKey(e => e.OrionProcNum)
                    .HasName("PRIMARY");

                entity.ToTable("orionproc");

                entity.HasIndex(e => e.ProcNum, "ProcNum");

                entity.Property(e => e.OrionProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateScheduleBy)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateStopClock)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Dpc)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("DPC");

                entity.Property(e => e.Dpcpost)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("DPCpost");

                entity.Property(e => e.IsEffectiveComm).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsOnCall).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsRepair).HasColumnType("tinyint(4)");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Status2).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Orthocase>(entity =>
            {
                entity.HasKey(e => e.OrthoCaseNum)
                    .HasName("PRIMARY");

                entity.ToTable("orthocase");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.OrthoType, "OrthoType");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.Property(e => e.OrthoCaseNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BandingDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DebondDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DebondDateExpected)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.IsActive).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsTransfer).HasColumnType("tinyint(4)");

                entity.Property(e => e.OrthoType).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Orthochart>(entity =>
            {
                entity.HasKey(e => e.OrthoChartNum)
                    .HasName("PRIMARY");

                entity.ToTable("orthochart");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.OrthoChartNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateService)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldValue)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Orthocharttab>(entity =>
            {
                entity.HasKey(e => e.OrthoChartTabNum)
                    .HasName("PRIMARY");

                entity.ToTable("orthocharttab");

                entity.Property(e => e.OrthoChartTabNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.TabName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Orthocharttablink>(entity =>
            {
                entity.HasKey(e => e.OrthoChartTabLinkNum)
                    .HasName("PRIMARY");

                entity.ToTable("orthocharttablink");

                entity.HasIndex(e => e.DisplayFieldNum, "DisplayFieldNum");

                entity.HasIndex(e => e.OrthoChartTabNum, "OrthoChartTabNum");

                entity.Property(e => e.OrthoChartTabLinkNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ColumnWidthOverride).HasColumnType("int(11)");

                entity.Property(e => e.DisplayFieldNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.OrthoChartTabNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Orthoplanlink>(entity =>
            {
                entity.HasKey(e => e.OrthoPlanLinkNum)
                    .HasName("PRIMARY");

                entity.ToTable("orthoplanlink");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.HasIndex(e => e.OrthoCaseNum, "OrthoCaseNum");

                entity.Property(e => e.OrthoPlanLinkNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.IsActive).HasColumnType("tinyint(4)");

                entity.Property(e => e.LinkType).HasColumnType("tinyint(4)");

                entity.Property(e => e.OrthoCaseNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Orthoproclink>(entity =>
            {
                entity.HasKey(e => e.OrthoProcLinkNum)
                    .HasName("PRIMARY");

                entity.ToTable("orthoproclink");

                entity.HasIndex(e => e.OrthoCaseNum, "OrthoCaseNum");

                entity.HasIndex(e => e.ProcNum, "ProcNum");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.Property(e => e.OrthoProcLinkNum).HasColumnType("bigint(20)");

                entity.Property(e => e.OrthoCaseNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcLinkType).HasColumnType("tinyint(4)");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Orthoschedule>(entity =>
            {
                entity.HasKey(e => e.OrthoScheduleNum)
                    .HasName("PRIMARY");

                entity.ToTable("orthoschedule");

                entity.Property(e => e.OrthoScheduleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BandingDateOverride)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DebondDateOverride)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.IsActive).HasColumnType("tinyint(4)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Patfield>(entity =>
            {
                entity.HasKey(e => e.PatFieldNum)
                    .HasName("PRIMARY");

                entity.ToTable("patfield");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.Property(e => e.PatFieldNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FieldName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldValue)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Patfielddef>(entity =>
            {
                entity.HasKey(e => e.PatFieldDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("patfielddef");

                entity.Property(e => e.PatFieldDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FieldName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldType).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.PickList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.PatNum)
                    .HasName("PRIMARY");

                entity.ToTable("patient");

                entity.HasIndex(e => e.ChartNumber, "ChartNumber");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.DiscountPlanNum, "DiscountPlanNum");

                entity.HasIndex(e => e.Email, "Email");

                entity.HasIndex(e => e.FeeSched, "FeeSched");

                entity.HasIndex(e => e.HmPhone, "HmPhone");

                entity.HasIndex(e => e.PatNumCloneFrom, "PatNumCloneFrom");

                entity.HasIndex(e => e.PatStatus, "PatStatus");

                entity.HasIndex(e => e.PriProv, "PriProv");

                entity.HasIndex(e => e.ResponsParty, "ResponsParty");

                entity.HasIndex(e => e.SecDateEntry, "SecDateEntry");

                entity.HasIndex(e => e.SecProv, "SecProv");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => e.SiteNum, "SiteNum");

                entity.HasIndex(e => e.SuperFamily, "SuperFamily");

                entity.HasIndex(e => e.WirelessPhone, "WirelessPhone");

                entity.HasIndex(e => e.WkPhone, "WkPhone");

                entity.HasIndex(e => e.Fname, "indexFName")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

                entity.HasIndex(e => e.Guarantor, "indexGuarantor");

                entity.HasIndex(e => new { e.Lname, e.Fname }, "indexLFName");

                entity.HasIndex(e => e.Lname, "indexLName")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AddrNote)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address2)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AdmitDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.ApptModNote)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AskToArriveEarly).HasColumnType("int(11)");

                entity.Property(e => e.Bal030).HasColumnName("Bal_0_30");

                entity.Property(e => e.Bal3160).HasColumnName("Bal_31_60");

                entity.Property(e => e.Bal6190).HasColumnName("Bal_61_90");

                entity.Property(e => e.BillingCycleDay)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.BillingType).HasColumnType("bigint(20)");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.CanadianEligibilityCode).HasColumnType("tinyint(4)");

                entity.Property(e => e.ChartNumber)
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.County)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreditType)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateFirstVisit)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTimeDeceased).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DiscountPlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmployerNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EmploymentNote)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FamFinUrgNote)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FeeSched).HasColumnType("bigint(20)");

                entity.Property(e => e.Fname)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("FName")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gender).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.GradeLevel).HasColumnType("tinyint(4)");

                entity.Property(e => e.Guarantor).HasColumnType("bigint(20)");

                entity.Property(e => e.HasIns)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HasSignedTil).HasColumnType("tinyint(4)");

                entity.Property(e => e.HasSuperBilling).HasColumnType("tinyint(4)");

                entity.Property(e => e.HmPhone)
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImageFolder)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Language)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lname)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("LName")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedUrgNote)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicaidId)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("MedicaidID")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MiddleI)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNumCloneFrom).HasColumnType("bigint(20)");

                entity.Property(e => e.PatStatus).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PlannedIsDone).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Position).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PreferConfirmMethod).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PreferContactConfidential).HasColumnType("tinyint(4)");

                entity.Property(e => e.PreferContactMethod).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PreferRecallMethod).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Preferred)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Premed).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PriProv).HasColumnType("bigint(20)");

                entity.Property(e => e.ResponsParty).HasColumnType("bigint(20)");

                entity.Property(e => e.Salutation)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SchedDayOfWeek).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SchoolName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecDateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecProv).HasColumnType("bigint(20)");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.ShortCodeOptIn).HasColumnType("tinyint(4)");

                entity.Property(e => e.SiteNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SmokingSnoMed)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ssn)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("SSN")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StudentStatus)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SuperFamily).HasColumnType("bigint(20)");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TrophyFolder)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TxtMsgOk).HasColumnType("tinyint(4)");

                entity.Property(e => e.Urgency).HasColumnType("tinyint(4)");

                entity.Property(e => e.Ward)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WirelessPhone)
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WkPhone)
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zip)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Patientlink>(entity =>
            {
                entity.HasKey(e => e.PatientLinkNum)
                    .HasName("PRIMARY");

                entity.ToTable("patientlink");

                entity.HasIndex(e => e.PatNumFrom, "PatNumFrom");

                entity.HasIndex(e => e.PatNumTo, "PatNumTo");

                entity.Property(e => e.PatientLinkNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeLink).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.LinkType).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatNumFrom).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNumTo).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Patientnote>(entity =>
            {
                entity.HasKey(e => e.PatNum)
                    .HasName("PRIMARY");

                entity.ToTable("patientnote");

                entity.HasIndex(e => e.SecDateTedit, "SecDateTEdit");

                entity.HasIndex(e => e.SecDateTentry, "SecDateTEntry");

                entity.Property(e => e.PatNum)
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApptPhone)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Consent).HasColumnType("tinyint(4)");

                entity.Property(e => e.DateOrthoPlacementOverride)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.FamFinancial)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Icename)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ICEName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Icephone)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("ICEPhone")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Medical)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicalComp)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrthoMonthsTreatOverride)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Service)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Treatment)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Patientportalinvite>(entity =>
            {
                entity.HasKey(e => e.PatientPortalInviteNum)
                    .HasName("PRIMARY");

                entity.ToTable("patientportalinvite");

                entity.HasIndex(e => e.AptNum, "AptNum");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.EmailMessageNum, "EmailMessageNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.PatientPortalInviteNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.EmailMessageNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EmailSendStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TemplateEmail)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateEmailSubj)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tsprior)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("TSPrior");
            });

            modelBuilder.Entity<Patientrace>(entity =>
            {
                entity.HasKey(e => e.PatientRaceNum)
                    .HasName("PRIMARY");

                entity.ToTable("patientrace");

                entity.HasIndex(e => e.CdcrecCode, "CdcrecCode");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.PatientRaceNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CdcrecCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Race).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Patplan>(entity =>
            {
                entity.HasKey(e => e.PatPlanNum)
                    .HasName("PRIMARY");

                entity.ToTable("patplan");

                entity.HasIndex(e => e.InsSubNum, "InsSubNum");

                entity.HasIndex(e => e.SecDateTedit, "SecDateTEdit");

                entity.HasIndex(e => e.SecDateTentry, "SecDateTEntry");

                entity.HasIndex(e => e.PatNum, "indexPatNum");

                entity.Property(e => e.PatPlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.InsSubNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsPending).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Ordinal).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.OrthoAutoFeeBilledOverride).HasDefaultValueSql("'-1'");

                entity.Property(e => e.OrthoAutoNextClaimDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.PatId)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("PatID")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Relationship).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");
            });

            modelBuilder.Entity<Patrestriction>(entity =>
            {
                entity.HasKey(e => e.PatRestrictionNum)
                    .HasName("PRIMARY");

                entity.ToTable("patrestriction");

                entity.HasIndex(e => new { e.PatNum, e.PatRestrictType }, "PatNumRestrictType");

                entity.Property(e => e.PatRestrictionNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatRestrictType).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Payconnectresponseweb>(entity =>
            {
                entity.HasKey(e => e.PayConnectResponseWebNum)
                    .HasName("PRIMARY");

                entity.ToTable("payconnectresponseweb");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.PayNum, "PayNum");

                entity.Property(e => e.PayConnectResponseWebNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AccountToken)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ccsource)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("CCSource");

                entity.Property(e => e.DateTimeCompleted).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeExpired).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeLastError).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimePending).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ExpDateToken)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsTokenSaved).HasColumnType("tinyint(4)");

                entity.Property(e => e.LastResponseStr)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayNote)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayToken)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentToken)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcessingStatus)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PayNum)
                    .HasName("PRIMARY");

                entity.ToTable("payment");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.DepositNum, "DepositNum");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => e.PatNum, "indexPatNum");

                entity.Property(e => e.PayNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BankBranch)
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CheckNum)
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DepositNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ExternalId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsRecurringCc)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("IsRecurringCC");

                entity.Property(e => e.IsSplit).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.PayNote)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayType).HasColumnType("bigint(20)");

                entity.Property(e => e.PaymentSource).HasColumnType("tinyint(4)");

                entity.Property(e => e.PaymentStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.ProcessStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.Receipt)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RecurringChargeDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Payortype>(entity =>
            {
                entity.HasKey(e => e.PayorTypeNum)
                    .HasName("PRIMARY");

                entity.ToTable("payortype");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.SopCode, "SopCode");

                entity.Property(e => e.PayorTypeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SopCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Payperiod>(entity =>
            {
                entity.HasKey(e => e.PayPeriodNum)
                    .HasName("PRIMARY");

                entity.ToTable("payperiod");

                entity.Property(e => e.PayPeriodNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DatePaycheck)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateStop)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");
            });

            modelBuilder.Entity<Payplan>(entity =>
            {
                entity.HasKey(e => e.PayPlanNum)
                    .HasName("PRIMARY");

                entity.ToTable("payplan");

                entity.HasIndex(e => e.Guarantor, "Guarantor");

                entity.HasIndex(e => e.InsSubNum, "InsSubNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.PlanCategory, "PlanCategory");

                entity.HasIndex(e => e.PlanNum, "PlanNum");

                entity.Property(e => e.PayPlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Apr).HasColumnName("APR");

                entity.Property(e => e.ChargeFrequency).HasColumnType("tinyint(4)");

                entity.Property(e => e.DateInterestStart)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DatePayPlanStart)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Guarantor).HasColumnType("bigint(20)");

                entity.Property(e => e.InsSubNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsClosed).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsDynamic).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsLocked).HasColumnType("tinyint(4)");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumberOfPayments).HasColumnType("int(11)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayPlanDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.PaySchedule).HasColumnType("tinyint(4)");

                entity.Property(e => e.PlanCategory).HasColumnType("bigint(20)");

                entity.Property(e => e.PlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SigIsTopaz).HasColumnType("tinyint(4)");

                entity.Property(e => e.Signature)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Payplancharge>(entity =>
            {
                entity.HasKey(e => e.PayPlanChargeNum)
                    .HasName("PRIMARY");

                entity.ToTable("payplancharge");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.HasIndex(e => e.ProcNum, "ProcNum");

                entity.HasIndex(e => e.StatementNum, "StatementNum");

                entity.HasIndex(e => e.Guarantor, "indexGuarantor");

                entity.HasIndex(e => e.PatNum, "indexPatNum");

                entity.HasIndex(e => e.PayPlanNum, "indexPayPlanNum");

                entity.Property(e => e.PayPlanChargeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ChargeDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.ChargeType).HasColumnType("tinyint(4)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.Guarantor).HasColumnType("bigint(20)");

                entity.Property(e => e.LinkType).HasColumnType("tinyint(4)");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayPlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.StatementNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Payplanlink>(entity =>
            {
                entity.HasKey(e => e.PayPlanLinkNum)
                    .HasName("PRIMARY");

                entity.ToTable("payplanlink");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.HasIndex(e => e.PayPlanNum, "PayPlanNum");

                entity.Property(e => e.PayPlanLinkNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.LinkType).HasColumnType("tinyint(4)");

                entity.Property(e => e.PayPlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");
            });

            modelBuilder.Entity<Paysplit>(entity =>
            {
                entity.HasKey(e => e.SplitNum)
                    .HasName("PRIMARY");

                entity.ToTable("paysplit");

                entity.HasIndex(e => e.AdjNum, "AdjNum");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.DatePay, "DatePay");

                entity.HasIndex(e => e.PayNum, "PayNum");

                entity.HasIndex(e => e.PayPlanChargeNum, "PayPlanChargeNum");

                entity.HasIndex(e => e.PayPlanNum, "PayPlanNum");

                entity.HasIndex(e => e.FsplitNum, "PrepaymentNum");

                entity.HasIndex(e => e.ProcNum, "ProcNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => new { e.ProcNum, e.SplitAmt }, "indexPNAmt");

                entity.HasIndex(e => e.PatNum, "indexPatNum");

                entity.Property(e => e.SplitNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AdjNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DatePay)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DiscountType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.FsplitNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FSplitNum");

                entity.Property(e => e.IsDiscount).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayPlanChargeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayPlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.UnearnedType).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Perioexam>(entity =>
            {
                entity.HasKey(e => e.PerioExamNum)
                    .HasName("PRIMARY");

                entity.ToTable("perioexam");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.PerioExamNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTmeasureEdit)
                    .HasColumnName("DateTMeasureEdit")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ExamDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Periomeasure>(entity =>
            {
                entity.HasKey(e => e.PerioMeasureNum)
                    .HasName("PRIMARY");

                entity.ToTable("periomeasure");

                entity.HasIndex(e => e.PerioExamNum, "PerioExamNum");

                entity.HasIndex(e => e.SecDateTedit, "SecDateTEdit");

                entity.HasIndex(e => e.SecDateTentry, "SecDateTEntry");

                entity.Property(e => e.PerioMeasureNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Bvalue).HasColumnType("smallint(6)");

                entity.Property(e => e.Dbvalue)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("DBvalue");

                entity.Property(e => e.Dlvalue)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("DLvalue");

                entity.Property(e => e.IntTooth).HasColumnType("smallint(6)");

                entity.Property(e => e.Lvalue).HasColumnType("smallint(6)");

                entity.Property(e => e.Mbvalue)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("MBvalue");

                entity.Property(e => e.Mlvalue)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("MLvalue");

                entity.Property(e => e.PerioExamNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.SequenceType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ToothValue).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<Pharmacy>(entity =>
            {
                entity.HasKey(e => e.PharmacyNum)
                    .HasName("PRIMARY");

                entity.ToTable("pharmacy");

                entity.Property(e => e.PharmacyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address2)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Fax)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PharmId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PharmID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StoreName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zip)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Pharmclinic>(entity =>
            {
                entity.HasKey(e => e.PharmClinicNum)
                    .HasName("PRIMARY");

                entity.ToTable("pharmclinic");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.PharmacyNum, "PharmacyNum");

                entity.Property(e => e.PharmClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PharmacyNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Phonenumber>(entity =>
            {
                entity.HasKey(e => e.PhoneNumberNum)
                    .HasName("PRIMARY");

                entity.ToTable("phonenumber");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => new { e.PatNum, e.PhoneNumberDigits }, "PatPhoneDigits");

                entity.HasIndex(e => e.PhoneNumberVal, "PhoneNumberVal");

                entity.Property(e => e.PhoneNumberNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PhoneNumberDigits)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneNumberVal)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneType).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Plannedappt>(entity =>
            {
                entity.HasKey(e => e.PlannedApptNum)
                    .HasName("PRIMARY");

                entity.ToTable("plannedappt");

                entity.HasIndex(e => e.AptNum, "AptNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.PlannedApptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Popup>(entity =>
            {
                entity.HasKey(e => e.PopupNum)
                    .HasName("PRIMARY");

                entity.ToTable("popup");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.PopupNumArchive, "PopupNumArchive");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.PopupNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsArchived).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PopupLevel).HasColumnType("tinyint(4)");

                entity.Property(e => e.PopupNumArchive).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Preference>(entity =>
            {
                entity.HasKey(e => e.PrefNum)
                    .HasName("PRIMARY");

                entity.ToTable("preference");

                entity.HasIndex(e => e.PrefName, "PrefName");

                entity.Property(e => e.PrefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Comments)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrefName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValueString)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Printer>(entity =>
            {
                entity.HasKey(e => e.PrinterNum)
                    .HasName("PRIMARY");

                entity.ToTable("printer");

                entity.Property(e => e.PrinterNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ComputerNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DisplayPrompt).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PrintSit).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PrinterName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Procapptcolor>(entity =>
            {
                entity.HasKey(e => e.ProcApptColorNum)
                    .HasName("PRIMARY");

                entity.ToTable("procapptcolor");

                entity.Property(e => e.ProcApptColorNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeRange)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ColorText).HasColumnType("int(11)");

                entity.Property(e => e.ShowPreviousDate).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Procbutton>(entity =>
            {
                entity.HasKey(e => e.ProcButtonNum)
                    .HasName("PRIMARY");

                entity.ToTable("procbutton");

                entity.Property(e => e.ProcButtonNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ButtonImage)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Category).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsMultiVisit).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<Procbuttonitem>(entity =>
            {
                entity.HasKey(e => e.ProcButtonItemNum)
                    .HasName("PRIMARY");

                entity.ToTable("procbuttonitem");

                entity.Property(e => e.ProcButtonItemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AutoCodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ItemOrder).HasColumnType("bigint(20)");

                entity.Property(e => e.OldCode)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.ProcButtonNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Procbuttonquick>(entity =>
            {
                entity.HasKey(e => e.ProcButtonQuickNum)
                    .HasName("PRIMARY");

                entity.ToTable("procbuttonquick");

                entity.Property(e => e.ProcButtonQuickNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsLabel).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.Surf)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ypos)
                    .HasColumnType("int(11)")
                    .HasColumnName("YPos");
            });

            modelBuilder.Entity<Proccodenote>(entity =>
            {
                entity.HasKey(e => e.ProcCodeNoteNum)
                    .HasName("PRIMARY");

                entity.ToTable("proccodenote");

                entity.Property(e => e.ProcCodeNoteNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.ProcTime)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Procedurecode>(entity =>
            {
                entity.HasKey(e => e.CodeNum)
                    .HasName("PRIMARY");

                entity.ToTable("procedurecode");

                entity.HasIndex(e => e.ProcCode, "ProcCode");

                entity.HasIndex(e => e.ProvNumDefault, "ProvNumDefault");

                entity.Property(e => e.CodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AbbrDesc)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AlternateCode1)
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BaseUnits).HasColumnType("int(11)");

                entity.Property(e => e.BypassGlobalLock).HasColumnType("tinyint(4)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DefaultClaimNote)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DefaultNote)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DefaultTpnote)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("DefaultTPNote")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Descript)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DrugNdc)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("DrugNDC")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GraphicColor).HasColumnType("int(11)");

                entity.Property(e => e.GtypeNum)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("GTypeNum");

                entity.Property(e => e.IsCanadianLab).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.IsHygiene).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsMultiVisit).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsProsth).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsRadiology).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsTaxed).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LaymanTerm)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicalCode)
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.NoBillIns).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.PaintType).HasColumnType("tinyint(4)");

                entity.Property(e => e.ProcCat).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcCode)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.ProcTime)
                    .HasColumnType("varchar(24)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvNumDefault).HasColumnType("bigint(20)");

                entity.Property(e => e.RevenueCodeDefault)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubstOnlyIf).HasColumnType("int(11)");

                entity.Property(e => e.SubstitutionCode)
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaxCode)
                    .IsRequired()
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TreatArea).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Procedurelog>(entity =>
            {
                entity.HasKey(e => e.ProcNum)
                    .HasName("PRIMARY");

                entity.ToTable("procedurelog");

                entity.HasIndex(e => e.BillingTypeOne, "BillingTypeOne");

                entity.HasIndex(e => e.BillingTypeTwo, "BillingTypeTwo");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.CodeNum, "CodeNum");

                entity.HasIndex(e => e.DateComplete, "DateComplete");

                entity.HasIndex(e => e.OrderingReferralNum, "OrderingReferralNum");

                entity.HasIndex(e => new { e.PatNum, e.ProcStatus, e.CodeNum, e.ProcDate }, "PatStatusCodeDate");

                entity.HasIndex(e => e.PlannedAptNum, "PlannedAptNum");

                entity.HasIndex(e => e.Priority, "Priority");

                entity.HasIndex(e => e.ProcDate, "ProcDate");

                entity.HasIndex(e => e.Prognosis, "Prognosis");

                entity.HasIndex(e => e.ProvOrderOverride, "ProvOrderOverride");

                entity.HasIndex(e => new { e.AptNum, e.CodeNum, e.ProcStatus, e.IsCpoe, e.ProvNum }, "RadiologyProcs");

                entity.HasIndex(e => e.RepeatChargeNum, "RepeatChargeNum");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => e.StatementNum, "StatementNum");

                entity.HasIndex(e => new { e.PatNum, e.ProcStatus, e.ProcFee, e.UnitQty, e.BaseUnits, e.ProcDate }, "indexAgingCovering");

                entity.HasIndex(e => new { e.ProvNum, e.ProcDate }, "indexPNPD");

                entity.HasIndex(e => new { e.PatNum, e.ProcStatus, e.ClinicNum }, "indexPNPSCN");

                entity.HasIndex(e => e.ProcNumLab, "procedurelog_ProcNumLab");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BaseUnits).HasColumnType("int(11)");

                entity.Property(e => e.BillingNote)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BillingTypeOne).HasColumnType("bigint(20)");

                entity.Property(e => e.BillingTypeTwo).HasColumnType("bigint(20)");

                entity.Property(e => e.CanadianTypeCodes)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClaimNote)
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeMod1)
                    .HasColumnType("char(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeMod2)
                    .HasColumnType("char(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeMod3)
                    .HasColumnType("char(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeMod4)
                    .HasColumnType("char(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateComplete)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateEntryC)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateOriginalProsth)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTp)
                    .HasColumnType("date")
                    .HasColumnName("DateTP");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DiagnosticCode)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DiagnosticCode2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DiagnosticCode3)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DiagnosticCode4)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DrugUnit).HasColumnType("tinyint(4)");

                entity.Property(e => e.Dx).HasColumnType("bigint(20)");

                entity.Property(e => e.HideGraphics).HasColumnType("tinyint(4)");

                entity.Property(e => e.IcdVersion).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.IsCpoe).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsDateProsthEst).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsLocked).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsPrincDiag).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MedicalCode)
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.OldCode)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.OrderingReferralNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PlaceService).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PlannedAptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Priority).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.ProcNumLab).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcStatus).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Prognosis).HasColumnType("bigint(20)");

                entity.Property(e => e.Prosthesis)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvOrderOverride).HasColumnType("bigint(20)");

                entity.Property(e => e.RepeatChargeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.RevCode)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecDateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.SiteNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SnomedBodySite)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StartTime).HasColumnType("int(11)");

                entity.Property(e => e.StatementNum).HasColumnType("bigint(20)");

                entity.Property(e => e.StopTime).HasColumnType("int(11)");

                entity.Property(e => e.Surf)
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ToothNum)
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ToothRange)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnitQty).HasColumnType("int(11)");

                entity.Property(e => e.UnitQtyType).HasColumnType("tinyint(4)");

                entity.Property(e => e.Urgency).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Procgroupitem>(entity =>
            {
                entity.HasKey(e => e.ProcGroupItemNum)
                    .HasName("PRIMARY");

                entity.ToTable("procgroupitem");

                entity.HasIndex(e => e.GroupNum, "GroupNum");

                entity.HasIndex(e => e.ProcNum, "ProcNum");

                entity.Property(e => e.ProcGroupItemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.GroupNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Procmultivisit>(entity =>
            {
                entity.HasKey(e => e.ProcMultiVisitNum)
                    .HasName("PRIMARY");

                entity.ToTable("procmultivisit");

                entity.HasIndex(e => e.GroupProcMultiVisitNum, "GroupProcMultiVisitNum");

                entity.HasIndex(e => e.IsInProcess, "IsInProcess");

                entity.HasIndex(e => e.ProcNum, "ProcNum");

                entity.HasIndex(e => e.SecDateTedit, "SecDateTEdit");

                entity.HasIndex(e => e.SecDateTentry, "SecDateTEntry");

                entity.Property(e => e.ProcMultiVisitNum).HasColumnType("bigint(20)");

                entity.Property(e => e.GroupProcMultiVisitNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsInProcess).HasColumnType("tinyint(4)");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");
            });

            modelBuilder.Entity<Procnote>(entity =>
            {
                entity.HasKey(e => e.ProcNoteNum)
                    .HasName("PRIMARY");

                entity.ToTable("procnote");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProcNum, "ProcNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.ProcNoteNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EntryDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SigIsTopaz).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Signature)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Proctp>(entity =>
            {
                entity.HasKey(e => e.ProcTpnum)
                    .HasName("PRIMARY");

                entity.ToTable("proctp");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.ProcNumOrig, "ProcNumOrig");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => e.PatNum, "indexPatNum");

                entity.HasIndex(e => e.TreatPlanNum, "indexTreatPlanNum");

                entity.Property(e => e.ProcTpnum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ProcTPNum");

                entity.Property(e => e.CatPercUcr).HasColumnName("CatPercUCR");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTp)
                    .HasColumnType("date")
                    .HasColumnName("DateTP")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Descript)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dx)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Priority).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcAbbr)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcCode)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcNumOrig).HasColumnType("bigint(20)");

                entity.Property(e => e.Prognosis)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.Surf)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ToothNumTp)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ToothNumTP")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TreatPlanNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Program>(entity =>
            {
                entity.HasKey(e => e.ProgramNum)
                    .HasName("PRIMARY");

                entity.ToTable("program");

                entity.Property(e => e.ProgramNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ButtonImage)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommandLine)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Enabled).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileTemplate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Path)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PluginDllName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProgDesc)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProgName)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Programproperty>(entity =>
            {
                entity.HasKey(e => e.ProgramPropertyNum)
                    .HasName("PRIMARY");

                entity.ToTable("programproperty");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.Property(e => e.ProgramPropertyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProgramNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PropertyDesc)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PropertyValue)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.HasKey(e => e.PromotionNum)
                    .HasName("PRIMARY");

                entity.ToTable("promotion");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.Property(e => e.PromotionNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeCreated)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.PromotionName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TypePromotion).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Promotionlog>(entity =>
            {
                entity.HasKey(e => e.PromotionLogNum)
                    .HasName("PRIMARY");

                entity.ToTable("promotionlog");

                entity.HasIndex(e => e.EmailHostingFk, "EmailHostingFK");

                entity.HasIndex(e => e.EmailMessageNum, "EmailMessageNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.PromotionNum, "PromotionNum");

                entity.Property(e => e.PromotionLogNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeSent).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.EmailHostingFk)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("EmailHostingFK");

                entity.Property(e => e.EmailMessageNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PromotionNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PromotionStatus).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasKey(e => e.ProvNum)
                    .HasName("PRIMARY");

                entity.ToTable("provider");

                entity.HasIndex(e => e.EmailAddressNum, "EmailAddressNum");

                entity.HasIndex(e => e.FeeSched, "FeeSched");

                entity.HasIndex(e => e.ProvNumBillingOverride, "ProvNumBillingOverride");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Abbr)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AnesthProvType).HasColumnType("bigint(20)");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.BlueCrossId)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("BlueCrossID")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CanadianOfficeNum)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CustomID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateTerm)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Deanum)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("DEANum")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EcwId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("EcwID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EhrMuStage).HasColumnType("int(11)");

                entity.Property(e => e.EmailAddressNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FeeSched).HasColumnType("bigint(20)");

                entity.Property(e => e.Fname)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("FName")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsCdanet)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("IsCDAnet");

                entity.Property(e => e.IsErxEnabled).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsHiddenReport).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsInstructor).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsNotPerson).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsSecondary).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Lname)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("LName")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicaidId)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("MedicaidID")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mi)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("MI")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NationalProvId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("NationalProvID")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutlineColor).HasColumnType("int(11)");

                entity.Property(e => e.ProvColor).HasColumnType("int(11)");

                entity.Property(e => e.ProvNumBillingOverride).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.SchedNote)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SchoolClassNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SigOnFile)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Specialty).HasColumnType("bigint(20)");

                entity.Property(e => e.Ssn)
                    .HasColumnType("varchar(12)")
                    .HasColumnName("SSN")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StateLicense)
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StateRxId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("StateRxID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StateWhereLicensed)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Suffix)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaxonomyCodeOverride)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsingTin)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("UsingTIN");

                entity.Property(e => e.WebSchedDescript)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WebSchedImageLocation)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Providerclinic>(entity =>
            {
                entity.HasKey(e => e.ProviderClinicNum)
                    .HasName("PRIMARY");

                entity.ToTable("providerclinic");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.Property(e => e.ProviderClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Deanum)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("DEANum")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.StateLicense)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StateRxId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("StateRxID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StateWhereLicensed)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Providercliniclink>(entity =>
            {
                entity.HasKey(e => e.ProviderClinicLinkNum)
                    .HasName("PRIMARY");

                entity.ToTable("providercliniclink");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.Property(e => e.ProviderClinicLinkNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Providererx>(entity =>
            {
                entity.HasKey(e => e.ProviderErxNum)
                    .HasName("PRIMARY");

                entity.ToTable("providererx");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.RegistrationKeyNum, "RegistrationKeyNum");

                entity.Property(e => e.ProviderErxNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AccountId)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ErxType).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsEnabled).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsEpcs).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsIdentifyProofed).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsSentToHq).HasColumnType("tinyint(4)");

                entity.Property(e => e.NationalProviderId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("NationalProviderID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.RegistrationKeyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Providerident>(entity =>
            {
                entity.HasKey(e => e.ProviderIdentNum)
                    .HasName("PRIMARY");

                entity.ToTable("providerident");

                entity.Property(e => e.ProviderIdentNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Idnumber)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("IDNumber")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayorId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PayorID")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SuppIdtype)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("SuppIDType");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.QuestionNum)
                    .HasName("PRIMARY");

                entity.ToTable("question");

                entity.HasIndex(e => e.PatNum, "indexPatNum");

                entity.Property(e => e.QuestionNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Answer)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FormPatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Questiondef>(entity =>
            {
                entity.HasKey(e => e.QuestionDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("questiondef");

                entity.Property(e => e.QuestionDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.QuestType).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Quickpastecat>(entity =>
            {
                entity.HasKey(e => e.QuickPasteCatNum)
                    .HasName("PRIMARY");

                entity.ToTable("quickpastecat");

                entity.Property(e => e.QuickPasteCatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DefaultForTypes)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<Quickpastenote>(entity =>
            {
                entity.HasKey(e => e.QuickPasteNoteNum)
                    .HasName("PRIMARY");

                entity.ToTable("quickpastenote");

                entity.Property(e => e.QuickPasteNoteNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Abbreviation)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QuickPasteCatNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Reactivation>(entity =>
            {
                entity.HasKey(e => e.ReactivationNum)
                    .HasName("PRIMARY");

                entity.ToTable("reactivation");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ReactivationStatus, "ReactivationStatus");

                entity.Property(e => e.ReactivationNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DoNotContact).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ReactivationNote)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReactivationStatus).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Recall>(entity =>
            {
                entity.HasKey(e => e.RecallNum)
                    .HasName("PRIMARY");

                entity.ToTable("recall");

                entity.HasIndex(e => e.DateDue, "DateDue");

                entity.HasIndex(e => e.DatePrevious, "DatePrevious");

                entity.HasIndex(e => e.DateScheduled, "DateScheduled");

                entity.HasIndex(e => e.IsDisabled, "IsDisabled");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.RecallTypeNum, "RecallTypeNum");

                entity.Property(e => e.RecallNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateDue)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateDueCalc)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DatePrevious)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateScheduled)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DisableUntilDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.IsDisabled).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Priority).HasColumnType("tinyint(4)");

                entity.Property(e => e.RecallInterval).HasColumnType("int(11)");

                entity.Property(e => e.RecallStatus).HasColumnType("bigint(20)");

                entity.Property(e => e.RecallTypeNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Recalltrigger>(entity =>
            {
                entity.HasKey(e => e.RecallTriggerNum)
                    .HasName("PRIMARY");

                entity.ToTable("recalltrigger");

                entity.HasIndex(e => e.CodeNum, "CodeNum");

                entity.HasIndex(e => e.RecallTypeNum, "RecallTypeNum");

                entity.Property(e => e.RecallTriggerNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.RecallTypeNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Recalltype>(entity =>
            {
                entity.HasKey(e => e.RecallTypeNum)
                    .HasName("PRIMARY");

                entity.ToTable("recalltype");

                entity.Property(e => e.RecallTypeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AppendToSpecial).HasColumnType("tinyint(4)");

                entity.Property(e => e.DefaultInterval).HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Procedures)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TimePattern)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Reconcile>(entity =>
            {
                entity.HasKey(e => e.ReconcileNum)
                    .HasName("PRIMARY");

                entity.ToTable("reconcile");

                entity.Property(e => e.ReconcileNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AccountNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateReconcile)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.IsLocked).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Recurringcharge>(entity =>
            {
                entity.HasKey(e => e.RecurringChargeNum)
                    .HasName("PRIMARY");

                entity.ToTable("recurringcharge");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.CreditCardNum, "CreditCardNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.PayNum, "PayNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.RecurringChargeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ChargeStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CreditCardNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeCharge).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ErrorMsg)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Refattach>(entity =>
            {
                entity.HasKey(e => e.RefAttachNum)
                    .HasName("PRIMARY");

                entity.ToTable("refattach");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProcNum, "ProcNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.ReferralNum, "ReferralNum");

                entity.Property(e => e.RefAttachNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateProcComplete)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsTransitionOfCare).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.RefDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.RefToStatus).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RefType).HasColumnType("tinyint(4)");

                entity.Property(e => e.ReferralNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Referral>(entity =>
            {
                entity.HasKey(e => e.ReferralNum)
                    .HasName("PRIMARY");

                entity.ToTable("referral");

                entity.Property(e => e.ReferralNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address2)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("EMail")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fname)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("FName")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDoctor).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.IsPreferred).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsTrustedDirect).HasColumnType("tinyint(4)");

                entity.Property(e => e.Lname)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("LName")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mname)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("MName")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NationalProvId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("NationalProvID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotPerson).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Phone2)
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slip).HasColumnType("bigint(20)");

                entity.Property(e => e.Specialty).HasColumnType("bigint(20)");

                entity.Property(e => e.Ssn)
                    .HasColumnType("varchar(9)")
                    .HasColumnName("SSN")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.St)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("ST")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telephone)
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsingTin)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("UsingTIN");

                entity.Property(e => e.Zip)
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Registrationkey>(entity =>
            {
                entity.HasKey(e => e.RegistrationKeyNum)
                    .HasName("PRIMARY");

                entity.ToTable("registrationkey");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.RegistrationKeyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BackupPassCode)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateDisabled).HasColumnType("date");

                entity.Property(e => e.DateEnded).HasColumnType("date");

                entity.Property(e => e.DateStarted).HasColumnType("date");

                entity.Property(e => e.DateTbackupScheduled)
                    .HasColumnName("DateTBackupScheduled")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.HasEarlyAccess).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsFreeVersion).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsOnlyForTesting).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsResellerCustomer).HasColumnType("tinyint(4)");

                entity.Property(e => e.Note)
                    .HasColumnType("varchar(4000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.RegKey)
                    .HasColumnType("varchar(4000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsesServerVersion).HasColumnType("tinyint(4)");

                entity.Property(e => e.VotesAllotted).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Reminderrule>(entity =>
            {
                entity.HasKey(e => e.ReminderRuleNum)
                    .HasName("PRIMARY");

                entity.ToTable("reminderrule");

                entity.HasIndex(e => e.CriterionFk, "CriterionFK");

                entity.Property(e => e.ReminderRuleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CriterionFk)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("CriterionFK");

                entity.Property(e => e.CriterionValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReminderCriterion).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Repeatcharge>(entity =>
            {
                entity.HasKey(e => e.RepeatChargeNum)
                    .HasName("PRIMARY");

                entity.ToTable("repeatcharge");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.RepeatChargeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CopyNoteToProc).HasColumnType("tinyint(4)");

                entity.Property(e => e.CreatesClaim).HasColumnType("tinyint(4)");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateStop)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.ErxAccountId)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsEnabled).HasColumnType("tinyint(4)");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Npi)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcCode)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UnearnedTypes)
                    .IsRequired()
                    .HasColumnType("varchar(4000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsePrepay).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Replicationserver>(entity =>
            {
                entity.HasKey(e => e.ReplicationServerNum)
                    .HasName("PRIMARY");

                entity.ToTable("replicationserver");

                entity.Property(e => e.ReplicationServerNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AtoZpath)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Descript)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RangeEnd).HasColumnType("bigint(20)");

                entity.Property(e => e.RangeStart).HasColumnType("bigint(20)");

                entity.Property(e => e.ServerId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SlaveMonitor)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateBlocked).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Reqneeded>(entity =>
            {
                entity.HasKey(e => e.ReqNeededNum)
                    .HasName("PRIMARY");

                entity.ToTable("reqneeded");

                entity.Property(e => e.ReqNeededNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Descript)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SchoolClassNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SchoolCourseNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Reqstudent>(entity =>
            {
                entity.HasKey(e => e.ReqStudentNum)
                    .HasName("PRIMARY");

                entity.ToTable("reqstudent");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.ReqNeededNum, "ReqNeededNum");

                entity.Property(e => e.ReqStudentNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AptNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateCompleted)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Descript)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InstructorNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ReqNeededNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SchoolCourseNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Requiredfield>(entity =>
            {
                entity.HasKey(e => e.RequiredFieldNum)
                    .HasName("PRIMARY");

                entity.ToTable("requiredfield");

                entity.Property(e => e.RequiredFieldNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldType).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Requiredfieldcondition>(entity =>
            {
                entity.HasKey(e => e.RequiredFieldConditionNum)
                    .HasName("PRIMARY");

                entity.ToTable("requiredfieldcondition");

                entity.HasIndex(e => e.RequiredFieldNum, "RequiredFieldNum");

                entity.Property(e => e.RequiredFieldConditionNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ConditionRelationship).HasColumnType("tinyint(4)");

                entity.Property(e => e.ConditionType)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConditionValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Operator).HasColumnType("tinyint(4)");

                entity.Property(e => e.RequiredFieldNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Reseller>(entity =>
            {
                entity.HasKey(e => e.ResellerNum)
                    .HasName("PRIMARY");

                entity.ToTable("reseller");

                entity.HasIndex(e => e.BillingType, "BillingType");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.Property(e => e.ResellerNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BillingType).HasColumnType("bigint(20)");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("varchar(4000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ResellerPassword)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VotesAllotted).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Resellerservice>(entity =>
            {
                entity.HasKey(e => e.ResellerServiceNum)
                    .HasName("PRIMARY");

                entity.ToTable("resellerservice");

                entity.HasIndex(e => e.CodeNum, "CodeNum");

                entity.HasIndex(e => e.ResellerNum, "ResellerNum");

                entity.Property(e => e.ResellerServiceNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ResellerNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Rxalert>(entity =>
            {
                entity.HasKey(e => e.RxAlertNum)
                    .HasName("PRIMARY");

                entity.ToTable("rxalert");

                entity.HasIndex(e => e.AllergyDefNum, "AllergyDefNum");

                entity.HasIndex(e => e.MedicationNum, "MedicationNum");

                entity.Property(e => e.RxAlertNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AllergyDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DiseaseDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsHighSignificance).HasColumnType("tinyint(4)");

                entity.Property(e => e.MedicationNum).HasColumnType("bigint(20)");

                entity.Property(e => e.NotificationMsg)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RxDefNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Rxdef>(entity =>
            {
                entity.HasKey(e => e.RxDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("rxdef");

                entity.HasIndex(e => e.RxCui, "RxCui");

                entity.Property(e => e.RxDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Disp)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Drug)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsControlled).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsProcRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Notes)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatientInstruction)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Refills)
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RxCui).HasColumnType("bigint(20)");

                entity.Property(e => e.Sig)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Rxnorm>(entity =>
            {
                entity.HasKey(e => e.RxNormNum)
                    .HasName("PRIMARY");

                entity.ToTable("rxnorm");

                entity.HasIndex(e => e.RxCui, "RxCui");

                entity.Property(e => e.RxNormNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MmslCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RxCui)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Rxpat>(entity =>
            {
                entity.HasKey(e => e.RxNum)
                    .HasName("PRIMARY");

                entity.ToTable("rxpat");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProcNum, "ProcNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.RxCui, "RxCui");

                entity.Property(e => e.RxNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Disp)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DosageCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Drug)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ErxGuid)
                    .IsRequired()
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ErxPharmacyInfo)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsControlled).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsErxOld).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsProcRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Notes)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatientInstruction)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PharmacyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Refills)
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RxCui).HasColumnType("bigint(20)");

                entity.Property(e => e.RxDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.SendStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.Sig)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => e.ScheduleNum)
                    .HasName("PRIMARY");

                entity.ToTable("schedule");

                entity.HasIndex(e => e.BlockoutType, "BlockoutType");

                entity.HasIndex(e => new { e.ClinicNum, e.SchedType }, "ClinicNumSchedType");

                entity.HasIndex(e => new { e.EmployeeNum, e.SchedDate, e.SchedType, e.StopTime }, "EmpDateTypeStopTime");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.SchedDate, "SchedDate");

                entity.Property(e => e.ScheduleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BlockoutType).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EmployeeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SchedDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.SchedType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.StartTime).HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.Status).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.StopTime).HasDefaultValueSql("'00:00:00'");
            });

            modelBuilder.Entity<Scheduledprocess>(entity =>
            {
                entity.HasKey(e => e.ScheduledProcessNum)
                    .HasName("PRIMARY");

                entity.ToTable("scheduledprocess");

                entity.Property(e => e.ScheduledProcessNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FrequencyToRun)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastRanDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ScheduledAction)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TimeToRun).HasDefaultValueSql("'0001-01-01 00:00:00'");
            });

            modelBuilder.Entity<Scheduleop>(entity =>
            {
                entity.HasKey(e => e.ScheduleOpNum)
                    .HasName("PRIMARY");

                entity.ToTable("scheduleop");

                entity.HasIndex(e => e.OperatoryNum, "OperatoryNum");

                entity.HasIndex(e => e.ScheduleNum, "ScheduleNum");

                entity.Property(e => e.ScheduleOpNum).HasColumnType("bigint(20)");

                entity.Property(e => e.OperatoryNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ScheduleNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Schoolclass>(entity =>
            {
                entity.HasKey(e => e.SchoolClassNum)
                    .HasName("PRIMARY");

                entity.ToTable("schoolclass");

                entity.Property(e => e.SchoolClassNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Descript)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GradYear).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Schoolcourse>(entity =>
            {
                entity.HasKey(e => e.SchoolCourseNum)
                    .HasName("PRIMARY");

                entity.ToTable("schoolcourse");

                entity.Property(e => e.SchoolCourseNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CourseId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CourseID")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Descript)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Screen>(entity =>
            {
                entity.HasKey(e => e.ScreenNum)
                    .HasName("PRIMARY");

                entity.ToTable("screen");

                entity.HasIndex(e => e.ScreenPatNum, "ScreenPatNum");

                entity.HasIndex(e => e.SheetNum, "SheetNum");

                entity.Property(e => e.ScreenNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Age).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.CariesExperience).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Comments)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EarlyChildCaries).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ExistingSealants).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Gender).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.GradeLevel).HasColumnType("tinyint(4)");

                entity.Property(e => e.HasCaries).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MissingAllTeeth).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.NeedsSealants).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RaceOld).HasColumnType("tinyint(4)");

                entity.Property(e => e.ScreenGroupNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ScreenGroupOrder).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ScreenPatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SheetNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Urgency).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Screengroup>(entity =>
            {
                entity.HasKey(e => e.ScreenGroupNum)
                    .HasName("PRIMARY");

                entity.ToTable("screengroup");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.SheetDefNum, "SheetDefNum");

                entity.Property(e => e.ScreenGroupNum).HasColumnType("bigint(20)");

                entity.Property(e => e.County)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GradeSchool)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlaceService).HasColumnType("tinyint(4)");

                entity.Property(e => e.ProvName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Sgdate)
                    .HasColumnType("date")
                    .HasColumnName("SGDate")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.SheetDefNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Screenpat>(entity =>
            {
                entity.HasKey(e => e.ScreenPatNum)
                    .HasName("PRIMARY");

                entity.ToTable("screenpat");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ScreenGroupNum, "ScreenGroupNum");

                entity.HasIndex(e => e.SheetNum, "SheetNum");

                entity.Property(e => e.ScreenPatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PatScreenPerm).HasColumnType("tinyint(4)");

                entity.Property(e => e.ScreenGroupNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SheetNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Securitylog>(entity =>
            {
                entity.HasKey(e => e.SecurityLogNum)
                    .HasName("PRIMARY");

                entity.ToTable("securitylog");

                entity.HasIndex(e => e.DefNum, "DefNum");

                entity.HasIndex(e => e.DefNumError, "DefNumError");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.HasIndex(e => e.LogDateTime, "LogDateTime");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.PermType, "PermType");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.SecurityLogNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CompName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateTprevious)
                    .HasColumnName("DateTPrevious")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DefNumError).HasColumnType("bigint(20)");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.LogDateTime).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LogSource).HasColumnType("tinyint(4)");

                entity.Property(e => e.LogText)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PermType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Securityloghash>(entity =>
            {
                entity.HasKey(e => e.SecurityLogHashNum)
                    .HasName("PRIMARY");

                entity.ToTable("securityloghash");

                entity.HasIndex(e => e.SecurityLogNum, "SecurityLogNum");

                entity.Property(e => e.SecurityLogHashNum).HasColumnType("bigint(20)");

                entity.Property(e => e.LogHash)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecurityLogNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Sheet>(entity =>
            {
                entity.HasKey(e => e.SheetNum)
                    .HasName("PRIMARY");

                entity.ToTable("sheet");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.DocNum, "DocNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.SheetDefNum, "SheetDefNum");

                entity.Property(e => e.SheetNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeSheet).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTsheetEdited)
                    .HasColumnName("DateTSheetEdited")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DocNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FontName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HasMobileLayout).HasColumnType("tinyint(4)");

                entity.Property(e => e.Height).HasColumnType("int(11)");

                entity.Property(e => e.InternalNote)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDeleted).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsLandscape).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsMultiPage).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsWebForm).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SheetDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SheetType).HasColumnType("int(11)");

                entity.Property(e => e.ShowInTerminal).HasColumnType("tinyint(4)");

                entity.Property(e => e.Width).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Sheetdef>(entity =>
            {
                entity.HasKey(e => e.SheetDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("sheetdef");

                entity.Property(e => e.SheetDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BypassGlobalLock).HasColumnType("tinyint(4)");

                entity.Property(e => e.DateTcreated)
                    .HasColumnName("DateTCreated")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FontName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HasMobileLayout).HasColumnType("tinyint(4)");

                entity.Property(e => e.Height).HasColumnType("int(11)");

                entity.Property(e => e.IsLandscape).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsMultiPage).HasColumnType("tinyint(4)");

                entity.Property(e => e.PageCount).HasColumnType("int(11)");

                entity.Property(e => e.SheetType).HasColumnType("int(11)");

                entity.Property(e => e.Width).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Sheetfield>(entity =>
            {
                entity.HasKey(e => e.SheetFieldNum)
                    .HasName("PRIMARY");

                entity.ToTable("sheetfield");

                entity.HasIndex(e => e.FieldType, "FieldType");

                entity.HasIndex(e => e.SheetNum, "SheetNum");

                entity.HasIndex(e => new { e.SheetNum, e.FieldType }, "SheetNumFieldType");

                entity.Property(e => e.SheetFieldNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeSig).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.FieldName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldType).HasColumnType("int(11)");

                entity.Property(e => e.FieldValue)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FontIsBold).HasColumnType("tinyint(4)");

                entity.Property(e => e.FontName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GrowthBehavior).HasColumnType("int(11)");

                entity.Property(e => e.Height).HasColumnType("int(11)");

                entity.Property(e => e.IsLocked).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemColor)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-16777216'");

                entity.Property(e => e.RadioButtonGroup)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RadioButtonValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReportableName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SheetNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TabOrder).HasColumnType("int(11)");

                entity.Property(e => e.TabOrderMobile).HasColumnType("int(11)");

                entity.Property(e => e.TextAlign).HasColumnType("tinyint(4)");

                entity.Property(e => e.UiLabelMobile)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UiLabelMobileRadioButton)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Width).HasColumnType("int(11)");

                entity.Property(e => e.Xpos)
                    .HasColumnType("int(11)")
                    .HasColumnName("XPos");

                entity.Property(e => e.Ypos)
                    .HasColumnType("int(11)")
                    .HasColumnName("YPos");
            });

            modelBuilder.Entity<Sheetfielddef>(entity =>
            {
                entity.HasKey(e => e.SheetFieldDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("sheetfielddef");

                entity.HasIndex(e => e.SheetDefNum, "SheetDefNum");

                entity.Property(e => e.SheetFieldDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FieldName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldType).HasColumnType("int(11)");

                entity.Property(e => e.FieldValue)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FontIsBold).HasColumnType("tinyint(4)");

                entity.Property(e => e.FontName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GrowthBehavior).HasColumnType("int(11)");

                entity.Property(e => e.Height).HasColumnType("int(11)");

                entity.Property(e => e.IsLocked).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsPaymentOption).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.ItemColor)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-16777216'");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LayoutMode).HasColumnType("tinyint(4)");

                entity.Property(e => e.RadioButtonGroup)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RadioButtonValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReportableName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SheetDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TabOrder).HasColumnType("int(11)");

                entity.Property(e => e.TabOrderMobile).HasColumnType("int(11)");

                entity.Property(e => e.TextAlign).HasColumnType("tinyint(4)");

                entity.Property(e => e.UiLabelMobile)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UiLabelMobileRadioButton)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Width).HasColumnType("int(11)");

                entity.Property(e => e.Xpos)
                    .HasColumnType("int(11)")
                    .HasColumnName("XPos");

                entity.Property(e => e.Ypos)
                    .HasColumnType("int(11)")
                    .HasColumnName("YPos");
            });

            modelBuilder.Entity<Sigbutdef>(entity =>
            {
                entity.HasKey(e => e.SigButDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("sigbutdef");

                entity.HasIndex(e => e.SigElementDefNumExtra, "SigElementDefNumExtra");

                entity.HasIndex(e => e.SigElementDefNumMsg, "SigElementDefNumMsg");

                entity.HasIndex(e => e.SigElementDefNumUser, "SigElementDefNumUser");

                entity.Property(e => e.SigButDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ButtonIndex).HasColumnType("smallint(6)");

                entity.Property(e => e.ButtonText)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ComputerName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SigElementDefNumExtra).HasColumnType("bigint(20)");

                entity.Property(e => e.SigElementDefNumMsg).HasColumnType("bigint(20)");

                entity.Property(e => e.SigElementDefNumUser).HasColumnType("bigint(20)");

                entity.Property(e => e.SynchIcon).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Sigelementdef>(entity =>
            {
                entity.HasKey(e => e.SigElementDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("sigelementdef");

                entity.Property(e => e.SigElementDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(6)");

                entity.Property(e => e.LightColor).HasColumnType("int(11)");

                entity.Property(e => e.LightRow).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SigElementType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SigText)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sound)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Sigmessage>(entity =>
            {
                entity.HasKey(e => e.SigMessageNum)
                    .HasName("PRIMARY");

                entity.ToTable("sigmessage");

                entity.HasIndex(e => e.SigElementDefNumExtra, "SigElementDefNumExtra");

                entity.HasIndex(e => e.SigElementDefNumMsg, "SigElementDefNumMsg");

                entity.HasIndex(e => e.SigElementDefNumUser, "SigElementDefNumUser");

                entity.Property(e => e.SigMessageNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AckDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ButtonIndex).HasColumnType("int(11)");

                entity.Property(e => e.ButtonText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromUser)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MessageDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.SigElementDefNumExtra).HasColumnType("bigint(20)");

                entity.Property(e => e.SigElementDefNumMsg).HasColumnType("bigint(20)");

                entity.Property(e => e.SigElementDefNumUser).HasColumnType("bigint(20)");

                entity.Property(e => e.SigText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SynchIcon).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ToUser)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Signalod>(entity =>
            {
                entity.HasKey(e => e.SignalNum)
                    .HasName("PRIMARY");

                entity.ToTable("signalod");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.HasIndex(e => e.Itype, "IType");

                entity.HasIndex(e => e.SigDateTime, "indexSigDateTime");

                entity.Property(e => e.SignalNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateViewing)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.FkeyType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("FKeyType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Itype)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("IType");

                entity.Property(e => e.MsgValue)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RemoteRole).HasColumnType("tinyint(4)");

                entity.Property(e => e.SigDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.HasKey(e => e.SiteNum)
                    .HasName("PRIMARY");

                entity.ToTable("site");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.Property(e => e.SiteNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlaceService).HasColumnType("tinyint(4)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Smsblockphone>(entity =>
            {
                entity.HasKey(e => e.SmsBlockPhoneNum)
                    .HasName("PRIMARY");

                entity.ToTable("smsblockphone");

                entity.Property(e => e.SmsBlockPhoneNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BlockWirelessNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Smsfrommobile>(entity =>
            {
                entity.HasKey(e => e.SmsFromMobileNum)
                    .HasName("PRIMARY");

                entity.ToTable("smsfrommobile");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.CommlogNum, "CommlogNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.SecDateTedit, "SecDateTEdit");

                entity.Property(e => e.SmsFromMobileNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CommlogNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeReceived).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Flags)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GuidMessage)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(4)");

                entity.Property(e => e.MatchCount).HasColumnType("int(11)");

                entity.Property(e => e.MobilePhoneNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MsgPart).HasColumnType("int(11)");

                entity.Property(e => e.MsgRefId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("MsgRefID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MsgText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MsgTotal).HasColumnType("int(11)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SmsPhoneNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SmsStatus).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Smsphone>(entity =>
            {
                entity.HasKey(e => e.SmsPhoneNum)
                    .HasName("PRIMARY");

                entity.ToTable("smsphone");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.Property(e => e.SmsPhoneNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateTimeActive).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeInactive).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.InactiveCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Smstomobile>(entity =>
            {
                entity.HasKey(e => e.SmsToMobileNum)
                    .HasName("PRIMARY");

                entity.ToTable("smstomobile");

                entity.HasIndex(e => new { e.ClinicNum, e.DateTimeSent }, "ClinicDTSent");

                entity.HasIndex(e => e.GuidMessage, "GuidMessage");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.SecDateTedit, "SecDateTEdit");

                entity.Property(e => e.SmsToMobileNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CustErrorText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateTimeSent).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeTerminated).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.GuidBatch)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GuidMessage)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsHidden).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsTimeSensitive).HasColumnType("tinyint(4)");

                entity.Property(e => e.MobilePhoneNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MsgChargeUsd).HasColumnName("MsgChargeUSD");

                entity.Property(e => e.MsgDiscountUsd).HasColumnName("MsgDiscountUSD");

                entity.Property(e => e.MsgParts).HasColumnType("int(11)");

                entity.Property(e => e.MsgText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MsgType).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SmsPhoneNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SmsStatus).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Snomed>(entity =>
            {
                entity.HasKey(e => e.SnomedNum)
                    .HasName("PRIMARY");

                entity.ToTable("snomed");

                entity.HasIndex(e => e.SnomedCode, "SnomedCode");

                entity.Property(e => e.SnomedNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SnomedCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Sop>(entity =>
            {
                entity.HasKey(e => e.SopNum)
                    .HasName("PRIMARY");

                entity.ToTable("sop");

                entity.HasIndex(e => e.SopCode, "SopCode");

                entity.Property(e => e.SopNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SopCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Stateabbr>(entity =>
            {
                entity.HasKey(e => e.StateAbbrNum)
                    .HasName("PRIMARY");

                entity.ToTable("stateabbr");

                entity.Property(e => e.StateAbbrNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Abbr)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MedicaidIdlength)
                    .HasColumnType("int(11)")
                    .HasColumnName("MedicaidIDLength");
            });

            modelBuilder.Entity<Statement>(entity =>
            {
                entity.HasKey(e => e.StatementNum)
                    .HasName("PRIMARY");

                entity.ToTable("statement");

                entity.HasIndex(e => e.DocNum, "DocNum");

                entity.HasIndex(e => e.IsSent, "IsSent");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ShortGuid, "ShortGUID");

                entity.HasIndex(e => new { e.SuperFamily, e.Mode, e.DateSent }, "SuperFamModeDateSent");

                entity.Property(e => e.StatementNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateRangeFrom).HasColumnType("date");

                entity.Property(e => e.DateRangeTo).HasColumnType("date");

                entity.Property(e => e.DateSent).HasColumnType("date");

                entity.Property(e => e.DateTstamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DocNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EmailBody)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailSubject)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsBalValid).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsInvoice).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsInvoiceCopy).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsReceipt).HasColumnType("tinyint(4)");

                entity.Property(e => e.Mode)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Mode_");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NoteBold)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ShortGuid)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("ShortGUID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SmsSendStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.StatementShortUrl)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("StatementShortURL")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StatementType)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StatementUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("StatementURL")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SuperFamily).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Stmtlink>(entity =>
            {
                entity.HasKey(e => e.StmtLinkNum)
                    .HasName("PRIMARY");

                entity.ToTable("stmtlink");

                entity.HasIndex(e => new { e.StmtLinkType, e.Fkey }, "FKeyAndType");

                entity.HasIndex(e => e.StatementNum, "StatementNum");

                entity.Property(e => e.StmtLinkNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.StatementNum).HasColumnType("bigint(20)");

                entity.Property(e => e.StmtLinkType).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Substitutionlink>(entity =>
            {
                entity.HasKey(e => e.SubstitutionLinkNum)
                    .HasName("PRIMARY");

                entity.ToTable("substitutionlink");

                entity.HasIndex(e => e.CodeNum, "CodeNum");

                entity.HasIndex(e => e.PlanNum, "PlanNum");

                entity.Property(e => e.SubstitutionLinkNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SubstOnlyIf).HasColumnType("int(11)");

                entity.Property(e => e.SubstitutionCode)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.SupplierNum)
                    .HasName("PRIMARY");

                entity.ToTable("supplier");

                entity.Property(e => e.SupplierNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Website)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Supply>(entity =>
            {
                entity.HasKey(e => e.SupplyNum)
                    .HasName("PRIMARY");

                entity.ToTable("supply");

                entity.HasIndex(e => e.SupplierNum, "SupplierNum");

                entity.Property(e => e.SupplyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BarCodeOrId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("BarCodeOrID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CatalogNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Category).HasColumnType("bigint(20)");

                entity.Property(e => e.Descript)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DispUnitDesc)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DispUnitsCount).HasColumnType("int(11)");

                entity.Property(e => e.ItemOrder).HasColumnType("int(11)");

                entity.Property(e => e.OrderQty).HasColumnType("int(11)");

                entity.Property(e => e.SupplierNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Supplyneeded>(entity =>
            {
                entity.HasKey(e => e.SupplyNeededNum)
                    .HasName("PRIMARY");

                entity.ToTable("supplyneeded");

                entity.Property(e => e.SupplyNeededNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateAdded).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Supplyorder>(entity =>
            {
                entity.HasKey(e => e.SupplyOrderNum)
                    .HasName("PRIMARY");

                entity.ToTable("supplyorder");

                entity.HasIndex(e => e.SupplierNum, "SupplierNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.SupplyOrderNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DatePlaced).HasColumnType("date");

                entity.Property(e => e.DateReceived)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SupplierNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Supplyorderitem>(entity =>
            {
                entity.HasKey(e => e.SupplyOrderItemNum)
                    .HasName("PRIMARY");

                entity.ToTable("supplyorderitem");

                entity.HasIndex(e => e.SupplyNum, "SupplyNum");

                entity.HasIndex(e => e.SupplyOrderNum, "SupplyOrderNum");

                entity.Property(e => e.SupplyOrderItemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Qty).HasColumnType("int(11)");

                entity.Property(e => e.SupplyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SupplyOrderNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.TaskNum)
                    .HasName("PRIMARY");

                entity.ToTable("task");

                entity.HasIndex(e => e.DateTimeOriginal, "DateTimeOriginal");

                entity.HasIndex(e => e.KeyNum, "KeyNum");

                entity.HasIndex(e => e.PriorityDefNum, "PriorityDefNum");

                entity.HasIndex(e => e.SecDateTedit, "SecDateTEdit");

                entity.HasIndex(e => e.TaskStatus, "TaskStatus");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.HasIndex(e => e.TaskListNum, "indexTaskListNum");

                entity.Property(e => e.TaskNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTask)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeOriginal).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Descript)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsRepeating).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.KeyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ObjectType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PriorityDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ReminderFrequency).HasColumnType("int(11)");

                entity.Property(e => e.ReminderGroupId)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReminderType).HasColumnType("smallint(6)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TaskListNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TaskStatus).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Taskancestor>(entity =>
            {
                entity.HasKey(e => e.TaskAncestorNum)
                    .HasName("PRIMARY");

                entity.ToTable("taskancestor");

                entity.HasIndex(e => e.TaskListNum, "TaskListNum");

                entity.HasIndex(e => e.TaskNum, "TaskNum");

                entity.Property(e => e.TaskAncestorNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TaskListNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TaskNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Taskhist>(entity =>
            {
                entity.HasKey(e => e.TaskHistNum)
                    .HasName("PRIMARY");

                entity.ToTable("taskhist");

                entity.HasIndex(e => e.DateTstamp, "DateTStamp");

                entity.HasIndex(e => e.SecDateTedit, "SecDateTEdit");

                entity.HasIndex(e => e.TaskNum, "TaskNum");

                entity.Property(e => e.TaskHistNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTask)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeFinished).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeOriginal).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTstamp)
                    .HasColumnName("DateTStamp")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateType).HasColumnType("tinyint(4)");

                entity.Property(e => e.Descript)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsNoteChange).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsRepeating).HasColumnType("tinyint(4)");

                entity.Property(e => e.KeyNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ObjectType).HasColumnType("tinyint(4)");

                entity.Property(e => e.PriorityDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ReminderFrequency).HasColumnType("int(11)");

                entity.Property(e => e.ReminderGroupId)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReminderType).HasColumnType("smallint(6)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.TaskListNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TaskNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TaskStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNumHist).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Tasklist>(entity =>
            {
                entity.HasKey(e => e.TaskListNum)
                    .HasName("PRIMARY");

                entity.ToTable("tasklist");

                entity.HasIndex(e => e.Parent, "indexParent");

                entity.Property(e => e.TaskListNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTl)
                    .HasColumnType("date")
                    .HasColumnName("DateTL")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Descript)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FromNum).HasColumnType("bigint(20)");

                entity.Property(e => e.GlobalTaskFilterType).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsRepeating).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ObjectType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Parent).HasColumnType("bigint(20)");

                entity.Property(e => e.TaskListStatus).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Tasknote>(entity =>
            {
                entity.HasKey(e => e.TaskNoteNum)
                    .HasName("PRIMARY");

                entity.ToTable("tasknote");

                entity.HasIndex(e => e.TaskNum, "TaskNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.TaskNoteNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeNote).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaskNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Tasksubscription>(entity =>
            {
                entity.HasKey(e => e.TaskSubscriptionNum)
                    .HasName("PRIMARY");

                entity.ToTable("tasksubscription");

                entity.HasIndex(e => e.TaskListNum, "TaskListNum");

                entity.HasIndex(e => e.TaskNum, "TaskNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.TaskSubscriptionNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TaskListNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TaskNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Taskunread>(entity =>
            {
                entity.HasKey(e => e.TaskUnreadNum)
                    .HasName("PRIMARY");

                entity.ToTable("taskunread");

                entity.HasIndex(e => e.TaskNum, "TaskNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.TaskUnreadNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TaskNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Terminalactive>(entity =>
            {
                entity.HasKey(e => e.TerminalActiveNum)
                    .HasName("PRIMARY");

                entity.ToTable("terminalactive");

                entity.Property(e => e.TerminalActiveNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ComputerName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcessId).HasColumnType("int(11)");

                entity.Property(e => e.SessionId).HasColumnType("int(11)");

                entity.Property(e => e.SessionName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TerminalStatus).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Timeadjust>(entity =>
            {
                entity.HasKey(e => e.TimeAdjustNum)
                    .HasName("PRIMARY");

                entity.ToTable("timeadjust");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.PtoDefNum, "PtoDefNum");

                entity.HasIndex(e => e.EmployeeNum, "indexEmployeeNum");

                entity.Property(e => e.TimeAdjustNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EmployeeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsAuto).HasColumnType("tinyint(4)");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OtimeHours)
                    .HasColumnName("OTimeHours")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.PtoDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PtoHours).HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.RegHours).HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.TimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");
            });

            modelBuilder.Entity<Timecardrule>(entity =>
            {
                entity.HasKey(e => e.TimeCardRuleNum)
                    .HasName("PRIMARY");

                entity.ToTable("timecardrule");

                entity.HasIndex(e => e.EmployeeNum, "EmployeeNum");

                entity.Property(e => e.TimeCardRuleNum).HasColumnType("bigint(20)");

                entity.Property(e => e.EmployeeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.IsOvertimeExempt).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Toolbutitem>(entity =>
            {
                entity.HasKey(e => e.ToolButItemNum)
                    .HasName("PRIMARY");

                entity.ToTable("toolbutitem");

                entity.Property(e => e.ToolButItemNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ButtonText)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProgramNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ToolBar).HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<Toothgridcell>(entity =>
            {
                entity.HasKey(e => e.ToothGridCellNum)
                    .HasName("PRIMARY");

                entity.ToTable("toothgridcell");

                entity.HasIndex(e => e.SheetFieldNum, "SheetFieldNum");

                entity.HasIndex(e => e.ToothGridColNum, "ToothGridColNum");

                entity.Property(e => e.ToothGridCellNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SheetFieldNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ToothGridColNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ToothNum)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValueEntered)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Toothgridcol>(entity =>
            {
                entity.HasKey(e => e.ToothGridColNum)
                    .HasName("PRIMARY");

                entity.ToTable("toothgridcol");

                entity.HasIndex(e => e.CodeNum, "CodeNum");

                entity.HasIndex(e => e.SheetFieldNum, "SheetFieldNum");

                entity.Property(e => e.ToothGridColNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CellType).HasColumnType("tinyint(4)");

                entity.Property(e => e.CodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ColumnWidth).HasColumnType("smallint(6)");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(6)");

                entity.Property(e => e.NameItem)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.SheetFieldNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Toothgriddef>(entity =>
            {
                entity.HasKey(e => e.ToothGridDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("toothgriddef");

                entity.HasIndex(e => e.CodeNum, "CodeNum");

                entity.HasIndex(e => e.SheetFieldDefNum, "SheetFieldDefNum");

                entity.Property(e => e.ToothGridDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.CellType).HasColumnType("tinyint(4)");

                entity.Property(e => e.CodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ColumnWidth).HasColumnType("smallint(6)");

                entity.Property(e => e.ItemOrder).HasColumnType("smallint(6)");

                entity.Property(e => e.NameInternal)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NameShowing)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.SheetFieldDefNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Toothinitial>(entity =>
            {
                entity.HasKey(e => e.ToothInitialNum)
                    .HasName("PRIMARY");

                entity.ToTable("toothinitial");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.SecDateTedit, "SecDateTEdit");

                entity.HasIndex(e => e.SecDateTentry, "SecDateTEntry");

                entity.Property(e => e.ToothInitialNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ColorDraw).HasColumnType("int(11)");

                entity.Property(e => e.DrawingSegment)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InitialType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecDateTentry)
                    .HasColumnName("SecDateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ToothNum)
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.TransactionNum)
                    .HasName("PRIMARY");

                entity.ToTable("transaction");

                entity.HasIndex(e => e.SecUserNumEdit, "SecUserNumEdit");

                entity.Property(e => e.TransactionNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DepositNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayNum).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEdit).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Treatplan>(entity =>
            {
                entity.HasKey(e => e.TreatPlanNum)
                    .HasName("PRIMARY");

                entity.ToTable("treatplan");

                entity.HasIndex(e => e.DocNum, "DocNum");

                entity.HasIndex(e => e.SecUserNumEntry, "SecUserNumEntry");

                entity.HasIndex(e => e.UserNumPresenter, "UserNumPresenter");

                entity.HasIndex(e => e.PatNum, "indexPatNum");

                entity.Property(e => e.TreatPlanNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTp)
                    .HasColumnType("date")
                    .HasColumnName("DateTP")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTpracticeSigned)
                    .HasColumnName("DateTPracticeSigned")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTsigned)
                    .HasColumnName("DateTSigned")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DocNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Heading)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ResponsParty).HasColumnType("bigint(20)");

                entity.Property(e => e.SecDateEntry)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.SecDateTedit)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SecDateTEdit")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecUserNumEntry).HasColumnType("bigint(20)");

                entity.Property(e => e.Signature)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SignaturePractice)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SignaturePracticeText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SignatureText)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tpstatus)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("TPStatus");

                entity.Property(e => e.Tptype)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("TPType");

                entity.Property(e => e.UserNumPresenter).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Treatplanattach>(entity =>
            {
                entity.HasKey(e => e.TreatPlanAttachNum)
                    .HasName("PRIMARY");

                entity.ToTable("treatplanattach");

                entity.HasIndex(e => e.Priority, "Priority");

                entity.HasIndex(e => e.ProcNum, "ProcNum");

                entity.HasIndex(e => e.TreatPlanNum, "TreatPlanNum");

                entity.Property(e => e.TreatPlanAttachNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Priority).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TreatPlanNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Tsitranslog>(entity =>
            {
                entity.HasKey(e => e.TsiTransLogNum)
                    .HasName("PRIMARY");

                entity.ToTable("tsitranslog");

                entity.HasIndex(e => e.AggTransLogNum, "AggTransLogNum");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => new { e.Fkey, e.FkeyType }, "FKeyAndType");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.TsiTransLogNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AggTransLogNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DemandType).HasColumnType("tinyint(4)");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.FkeyType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("FKeyType");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.RawMsgText)
                    .IsRequired()
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceCode).HasColumnType("tinyint(4)");

                entity.Property(e => e.TransDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.TransJson)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TransType).HasColumnType("tinyint(4)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Ucum>(entity =>
            {
                entity.HasKey(e => e.UcumNum)
                    .HasName("PRIMARY");

                entity.ToTable("ucum");

                entity.HasIndex(e => e.UcumCode, "UcumCode");

                entity.Property(e => e.UcumNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsInUse).HasColumnType("tinyint(4)");

                entity.Property(e => e.UcumCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Updatehistory>(entity =>
            {
                entity.HasKey(e => e.UpdateHistoryNum)
                    .HasName("PRIMARY");

                entity.ToTable("updatehistory");

                entity.Property(e => e.UpdateHistoryNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeUpdated).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ProgramVersion)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Userclinic>(entity =>
            {
                entity.HasKey(e => e.UserClinicNum)
                    .HasName("PRIMARY");

                entity.ToTable("userclinic");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.UserClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Usergroup>(entity =>
            {
                entity.HasKey(e => e.UserGroupNum)
                    .HasName("PRIMARY");

                entity.ToTable("usergroup");

                entity.HasIndex(e => e.UserGroupNumCemt, "UserGroupNumCEMT");

                entity.Property(e => e.UserGroupNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserGroupNumCemt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("UserGroupNumCEMT");
            });

            modelBuilder.Entity<Usergroupattach>(entity =>
            {
                entity.HasKey(e => e.UserGroupAttachNum)
                    .HasName("PRIMARY");

                entity.ToTable("usergroupattach");

                entity.HasIndex(e => e.UserGroupNum, "UserGroupNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.UserGroupAttachNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserGroupNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Userod>(entity =>
            {
                entity.HasKey(e => e.UserNum)
                    .HasName("PRIMARY");

                entity.ToTable("userod");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.HasIndex(e => e.UserGroupNum, "UserGroupNum");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");

                entity.Property(e => e.AnesthProvType)
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.ClinicIsRestricted).HasColumnType("tinyint(4)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTfail)
                    .HasColumnName("DateTFail")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTlastLogin)
                    .HasColumnName("DateTLastLogin")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DefaultHidePopups).HasColumnType("tinyint(4)");

                entity.Property(e => e.DomainUser)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmployeeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FailedAttempts).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.InboxHidePopups).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsPasswordResetRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.MobileWebPin)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MobileWebPinFailedAttempts).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Password)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PasswordIsStrong).HasColumnType("tinyint(4)");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.TaskListInBox).HasColumnType("bigint(20)");

                entity.Property(e => e.UserGroupNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserNumCemt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("UserNumCEMT");
            });

            modelBuilder.Entity<Userodapptview>(entity =>
            {
                entity.HasKey(e => e.UserodApptViewNum)
                    .HasName("PRIMARY");

                entity.ToTable("userodapptview");

                entity.HasIndex(e => e.ApptViewNum, "ApptViewNum");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.UserodApptViewNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ApptViewNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Userodpref>(entity =>
            {
                entity.HasKey(e => e.UserOdPrefNum)
                    .HasName("PRIMARY");

                entity.ToTable("userodpref");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.Fkey, "Fkey");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.UserOdPrefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Fkey).HasColumnType("bigint(20)");

                entity.Property(e => e.FkeyType).HasColumnType("tinyint(4)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ValueString)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Userquery>(entity =>
            {
                entity.HasKey(e => e.QueryNum)
                    .HasName("PRIMARY");

                entity.ToTable("userquery");

                entity.Property(e => e.QueryNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileName)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsPromptSetup)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsReleased)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QueryText)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Userweb>(entity =>
            {
                entity.HasKey(e => e.UserWebNum)
                    .HasName("PRIMARY");

                entity.ToTable("userweb");

                entity.HasIndex(e => e.Fkey, "FKey");

                entity.Property(e => e.UserWebNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeLastLogin).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.Fkey)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("FKey");

                entity.Property(e => e.FkeyType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("FKeyType");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PasswordResetCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RequirePasswordChange).HasColumnType("tinyint(4)");

                entity.Property(e => e.RequireUserNameChange).HasColumnType("tinyint(4)");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Vaccinedef>(entity =>
            {
                entity.HasKey(e => e.VaccineDefNum)
                    .HasName("PRIMARY");

                entity.ToTable("vaccinedef");

                entity.HasIndex(e => e.DrugManufacturerNum, "DrugManufacturerNum");

                entity.Property(e => e.VaccineDefNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Cvxcode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CVXCode")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DrugManufacturerNum).HasColumnType("bigint(20)");

                entity.Property(e => e.VaccineName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Vaccineob>(entity =>
            {
                entity.HasKey(e => e.VaccineObsNum)
                    .HasName("PRIMARY");

                entity.ToTable("vaccineobs");

                entity.HasIndex(e => e.VaccineObsNumGroup, "VaccineObsNumGroup");

                entity.HasIndex(e => e.VaccinePatNum, "VaccinePatNum");

                entity.Property(e => e.VaccineObsNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateObs)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.IdentifyingCode).HasColumnType("tinyint(4)");

                entity.Property(e => e.MethodCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UcumCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VaccineObsNumGroup).HasColumnType("bigint(20)");

                entity.Property(e => e.VaccinePatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ValCodeSystem).HasColumnType("tinyint(4)");

                entity.Property(e => e.ValReported)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValType).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Vaccinepat>(entity =>
            {
                entity.HasKey(e => e.VaccinePatNum)
                    .HasName("PRIMARY");

                entity.ToTable("vaccinepat");

                entity.HasIndex(e => e.DrugUnitNum, "DrugUnitNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.ProvNumAdminister, "ProvNumAdminister");

                entity.HasIndex(e => e.ProvNumOrdering, "ProvNumOrdering");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.HasIndex(e => e.VaccineDefNum, "VaccineDefNum");

                entity.Property(e => e.VaccinePatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ActionCode).HasColumnType("tinyint(4)");

                entity.Property(e => e.AdministrationNoteCode).HasColumnType("tinyint(4)");

                entity.Property(e => e.AdministrationRoute).HasColumnType("tinyint(4)");

                entity.Property(e => e.AdministrationSite).HasColumnType("tinyint(4)");

                entity.Property(e => e.CompletionStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.DateExpire)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DrugUnitNum).HasColumnType("bigint(20)");

                entity.Property(e => e.FilledCity)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FilledSt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("FilledST")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LotNumber)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNumAdminister).HasColumnType("bigint(20)");

                entity.Property(e => e.ProvNumOrdering).HasColumnType("bigint(20)");

                entity.Property(e => e.RefusalReason).HasColumnType("tinyint(4)");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");

                entity.Property(e => e.VaccineDefNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Vitalsign>(entity =>
            {
                entity.HasKey(e => e.VitalsignNum)
                    .HasName("PRIMARY");

                entity.ToTable("vitalsign");

                entity.HasIndex(e => e.EhrNotPerformedNum, "EhrNotPerformedNum");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.PregDiseaseNum, "PregDiseaseNum");

                entity.HasIndex(e => e.WeightCode, "WeightCode");

                entity.Property(e => e.VitalsignNum).HasColumnType("bigint(20)");

                entity.Property(e => e.BmiexamCode)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("BMIExamCode")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bmipercentile)
                    .HasColumnType("int(11)")
                    .HasColumnName("BMIPercentile");

                entity.Property(e => e.BpDiastolic).HasColumnType("smallint(6)");

                entity.Property(e => e.BpSystolic).HasColumnType("smallint(6)");

                entity.Property(e => e.ChildGotNutrition).HasColumnType("tinyint(4)");

                entity.Property(e => e.ChildGotPhysCouns).HasColumnType("tinyint(4)");

                entity.Property(e => e.DateTaken)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Documentation)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EhrNotPerformedNum).HasColumnType("bigint(20)");

                entity.Property(e => e.HasFollowupPlan).HasColumnType("tinyint(4)");

                entity.Property(e => e.HeightExamCode)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsIneligible).HasColumnType("tinyint(4)");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PregDiseaseNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Pulse).HasColumnType("int(11)");

                entity.Property(e => e.WeightCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WeightExamCode)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Webschedrecall>(entity =>
            {
                entity.HasKey(e => e.WebSchedRecallNum)
                    .HasName("PRIMARY");

                entity.ToTable("webschedrecall");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.DateTimeReminderSent, "DateTimeReminderSent");

                entity.HasIndex(e => e.GuidMessageToMobile, "GuidMessageToMobile")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.RecallNum, "RecallNum");

                entity.Property(e => e.WebSchedRecallNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateDue)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DateTimeEntry).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeReminderSent).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTimeSendFailed).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.EmailPat)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailSendStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.EmailSubj)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailSubjTemplate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmailTextTemplate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GuidMessageToMobile)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MsgTextToMobile)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MsgTextToMobileTemplate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PhonePat)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PreferRecallMethod).HasColumnType("tinyint(4)");

                entity.Property(e => e.RecallNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ReminderCount).HasColumnType("int(11)");

                entity.Property(e => e.ResponseDescript)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShortGuidemail)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ShortGUIDEmail")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShortGuidsms)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ShortGUIDSms")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SmsSendStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.Source).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Wikilistheaderwidth>(entity =>
            {
                entity.HasKey(e => e.WikiListHeaderWidthNum)
                    .HasName("PRIMARY");

                entity.ToTable("wikilistheaderwidth");

                entity.Property(e => e.WikiListHeaderWidthNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ColName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ColWidth).HasColumnType("int(11)");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PickList)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Wikilisthist>(entity =>
            {
                entity.HasKey(e => e.WikiListHistNum)
                    .HasName("PRIMARY");

                entity.ToTable("wikilisthist");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.WikiListHistNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeSaved).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.ListContent)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ListHeaders)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Wikipage>(entity =>
            {
                entity.HasKey(e => e.WikiPageNum)
                    .HasName("PRIMARY");

                entity.ToTable("wikipage");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.WikiPageNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeSaved).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.IsDeleted).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsDraft).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsLocked).HasColumnType("tinyint(4)");

                entity.Property(e => e.KeyWords)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageContent)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageContentPlainText)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Wikipagehist>(entity =>
            {
                entity.HasKey(e => e.WikiPageNum)
                    .HasName("PRIMARY");

                entity.ToTable("wikipagehist");

                entity.HasIndex(e => e.UserNum, "UserNum");

                entity.Property(e => e.WikiPageNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTimeSaved).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.IsDeleted).HasColumnType("tinyint(4)");

                entity.Property(e => e.PageContent)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserNum).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Xchargetransaction>(entity =>
            {
                entity.HasKey(e => e.XchargeTransactionNum)
                    .HasName("PRIMARY");

                entity.ToTable("xchargetransaction");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.TransactionDateTime, "TransactionDateTime");

                entity.Property(e => e.XchargeTransactionNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("XChargeTransactionNum");

                entity.Property(e => e.ApprCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BatchNum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ccentry)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CCEntry")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cctype)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CCType")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClerkId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ClerkID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreditCardNum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Expiration)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ItemNum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResultCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TransactionDateTime).HasDefaultValueSql("'0001-01-01 00:00:00'");
            });

            modelBuilder.Entity<Xwebresponse>(entity =>
            {
                entity.HasKey(e => e.XwebResponseNum)
                    .HasName("PRIMARY");

                entity.ToTable("xwebresponse");

                entity.HasIndex(e => e.ClinicNum, "ClinicNum");

                entity.HasIndex(e => e.DateTupdate, "DateTUpdate");

                entity.HasIndex(e => e.PatNum, "PatNum");

                entity.HasIndex(e => e.PaymentNum, "PaymentNum");

                entity.HasIndex(e => e.ProvNum, "ProvNum");

                entity.Property(e => e.XwebResponseNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("XWebResponseNum");

                entity.Property(e => e.AccountExpirationDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ApprovalCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BatchNum).HasColumnType("int(11)");

                entity.Property(e => e.CardBrand)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardBrandShort)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardCodeResponse)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CardType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ccsource)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("CCSource");

                entity.Property(e => e.ClinicNum).HasColumnType("bigint(20)");

                entity.Property(e => e.DateTentry)
                    .HasColumnName("DateTEntry")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DateTupdate)
                    .HasColumnName("DateTUpdate")
                    .HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.DebugError)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EntryMethod)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExpDate)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HpfExpiration).HasDefaultValueSql("'0001-01-01 00:00:00'");

                entity.Property(e => e.HpfUrl)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MaskedAcctNum)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Otk)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OTK")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PatNum).HasColumnType("bigint(20)");

                entity.Property(e => e.PayNote)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ProcessorResponse)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvNum).HasColumnType("bigint(20)");

                entity.Property(e => e.ReceiptId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReceiptID");

                entity.Property(e => e.ResponseCode).HasColumnType("int(11)");

                entity.Property(e => e.ResponseDescription)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TransactionId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TransactionID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TransactionStatus).HasColumnType("tinyint(4)");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.XwebResponseCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("XWebResponseCode")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Zipcode>(entity =>
            {
                entity.HasKey(e => e.ZipCodeNum)
                    .HasName("PRIMARY");

                entity.ToTable("zipcode");

                entity.Property(e => e.ZipCodeNum).HasColumnType("bigint(20)");

                entity.Property(e => e.City)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsFrequent).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.State)
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZipCodeDigits)
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
