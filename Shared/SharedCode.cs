using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Third party API for reading/writing text files.
using FileHelpers;

using Softdent2OpenDentalConversion.Context.OpenDental;
using Softdent2OpenDentalConversion.Models.OpenDental;

using Softdent2OpenDentalConversion.Models.Softdent;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.IO;

using Task = System.Threading.Tasks.Task;

namespace Softdent2OpenDentalConversion.Shared
{
    public abstract class SharedCode : LayoutComponentBase
    {

        #region dbContext Declarations

        // Entity Framework declaration for the Open Dental models.
        OpenDentalContext dbOpenDentalContext = new OpenDentalContext();

        #endregion (dbContext Declarations)

        #region String Declarations

        // Blazor string variables for updating screen display
        public string conversionStatusUpdate = "Idle";
        public string conversionStartTime = "";
        public string conversionEndTime = "";
        
        // The path for Softdent conversion text files.
        private string cnvPath = @"C:\SDCNV\Teitelbaum\";

        #endregion (String Declarations)

        #region Enumeration Declarations

        // Many of the Open Dental settings are enumeration based.
        // Below are the variable versions that are used during the 
        // conversion.

        private enum FeeSchedule
        {
            Fee01 = 53,
            Fee02 = 55,
            Fee03 = 54,
            Fee04 = 191,
            Fee05 = 192,
            Fee06 = 193,
            Fee07 = 194,
            Fee08 = 195,
            Fee09 = 196,
            Fee10 = 197
        }

        private enum ADACodeCategory
        {
            No_Fee = 85,
            Rarely_Used = 86,
            Never_Used = 87,
            No_Cat_W_Fee = 268,
            ExamAndXray = 73,
            Cleaning = 74,
            Filling = 75,
            Endo = 76,
            Perio = 77,
            Dentures = 78,
            Cosmetic = 79,
            Implants = 80,
            CrownAndBridge = 81,
            OralSurg = 82,
            Ortho = 83,
            Misc = 84,
            Obsolete = 114
        }

        private enum Gender
        {
            Male = 0,
            Female = 1,
            Unknown = 2
        }

        private enum FamilyPosition
        {
            Single = 0,
            Married = 1,
            Child = 2,
            Widowed = 3

        }

        private enum PatientStatus
        {
            Patient = 0,
            NonPatient = 1,
            Inactive = 2,
            Archived = 3,
            Deceased = 4
        }

        private enum BillingType
        {
            StandardAccount = 40,
            PreCollection = 41,
            Collection = 42
        }

        private enum RecallInterval
        {
            Months01 = 1,
            Months02 = 2,
            Months03 = 3,
            Months04 = 4,
            Months05 = 5,
            Months06 = 6,
            Months07 = 7,
            Months08 = 8,
            Months09 = 9,
            Months10 = 10,
            Months11 = 11,
            Months12 = 12
        }

        private enum ProviderSpecialty
        {
            General = 0,
            Hygenist = 1,
            Endo = 2,
            Pediatric = 3,
            Perio = 4,
            ProstH = 5,
            Ortho = 6,
            Denturist = 7,
            Surgery = 8,
            Assistant = 9,
            LabTech = 10,
            Pathology = 11,
            PublicHealth = 12,
            Radiology = 13
        }

        private enum ProviderColors
        {
            Doc1 = -8323073,
            Doc2 = -32513,
            Doc3 = -16776961,
            Doc4 = -65536,
            Doc5 = -16744193,
            Hyg1 = -256,
            Hyg2 = -16711936,
            Hyg3 = -32640,
            Hyg4 = -16744448,
            Hyg5 = -8372224,
            Hyg6 = -8388480,
            Hyg7 = -32768,
            OutlineColor = -16777216
        }

        private enum Operatories
        {
            Op1 = 191,
            Op2 = 192,
            Op3 = 193,
            Op4 = 194,
            Op5 = 195,
            Op6 = 196,
            Op7 = 197,
            Op8 = 198,
            Op9 = 199,
            Op10 = 200,
            Op11 = 201,
            Op12 = 202,
            Op13 = 203,
            Op14 = 204,
            Op15 = 205,
            Op16 = 206,
            Op17 = 207,
            Op18 = 208,
            Op19 = 209,
            Op20 = 210,
            Op21 = 211,
            Op22 = 212,
            Op23 = 213,
            Op24 = 214,
            Op25 = 215,
            Op26 = 216,
            Op27 = 217,
            Op28 = 218,
            Op29 = 219,
            Op30 = 220,
            Op31 = 221,
            Op32 = 222,
            Op33 = 223,
            Op34 = 224,
            Op35 = 225,
            Op36 = 226,
            Op37 = 227,
            Op38 = 228,
            Op39 = 229,
            Op40 = 230,
            Op41 = 231,
            Op42 = 232,
            Op43 = 233,
            Op44 = 234,
            Op45 = 235,
            Op46 = 236,
            Op47 = 237,
            Op48 = 238,
            Op49 = 239,
            Op50 = 240,
            Op51 = 241,
            Op52 = 242,
            Op53 = 243,
            Op54 = 244,
            Op55 = 245,
            Op56 = 246,
            Op57 = 247,
            Op58 = 248,
            Op59 = 249,
            Op60 = 250,
            Doc1 = 64,
            Doc2 = 65,
            Doc3 = 191,
            Doc4 = 191,
            NoDoc = 191,
            Hyg1 = 68,
            Hyg2 = 129,
            Hyg3 = 188,
            Hyg4 = 189,
            Hyg5 = 190,
            AST1 = 191
        }

        private enum CoverageCategories
        {
            General = 1,
            Diagnostic = 2,
            Preventive = 3,
            Restorative = 4,
            Endo = 5,
            Perio = 6,
            OralSurgery = 7,
            Crowns = 8,
            Prosth = 9,
            MaxilofacialProsth = 10,
            Accident = 11,
            Ortho = 12,
            XRay = 13,
            Adjunctive = 14,
            Implants = 15
        }

        private enum InsuranceRelationship
        {
            Self = 0,
            Spouse = 1,
            Child = 2,
            Employee = 3,
            HandicapDep = 4,
            SignifOther = 5,
            InjuredPlaintiff = 6,
            LifePartner = 7,
            Dependent = 8
        }

        private enum PaymentType
        {
            Cash = 70,
            InsCheck = 72,
            PersonalCheck = 69,
            CreditCard = 71
        }

        private enum AdjustmentType
        {
            SalesTax = 200,
            MiscNegAdj = 1,
            MiscPosAdj = 2,
            StartingDebitBalance = 201,
            StartingCreditBalance = 202,

        }

        #endregion (Enumaration Declarations)

        #region Integer Declarations

        // Maximum number of operatories for the conversion default.
        // The practice will show actual operatories and hide the rest
        // post conversion.
        private int maxOperatories = 60;

        // Next ID number variables.  Will be converted to a structure.
        public int nextPatientID = 1;
        public int nextAppointmentID = 1;
        public int nextBillingTransactionID = 1;
        public int nextMedicationPatRXID = 1;
        public int nextInsuranceSubscriberID = 1;
        public int nextBenefitID = 1;
        public int nextPatientPlanNumber = 1;
        public int nextPaymentNumber = 1;
        public int nextAdjustmentNumber = 1;
        public int nextPaymentSplitNumber = 1;

        #endregion (Integer Declarations)

        #region Structure Declarations

        // Blazor screen display numeric variables.
        public struct _CounterVariables
        {
            public int totalAccounts;
            public int totalAppointments;
            public int totalADACodes;
            public int totalDentists;
            public int totalDrugs;
            public int totalEmployers;
            public int totalFeeSchedules;
            public int totalInsuranceCompanies;
            public int totalInsurancePlans;
            public int totalOperatories;
            public int totalPatients;
            public int totalReferringDoctors;
            public int totalBillingTransactions;
            public int totalAccountBillingTransactions;
            public int totalRXDefinitions;
            public int totalPrescriptions;
            public int totalPlansUpdated;
            public int totalInsuranceSubscribers;
            public int total2ndGuarantorInsuranceSubscribers;
            public int total2ndGuarantors;
            public int sdPatients;
        }

        public _CounterVariables CounterVariables = new _CounterVariables();

        #endregion (Structure Declarations)

        #region List Declarations

        // These lists are created in memory and filled in order
        // to minimize DB search calls during the conversion process.
        List<SdTran> patientBillingTransactionsList;
        List<SdAppt> patientAppointmentList;
        List<SdRx> patientPrescriptionsList;
        List<Inssub> _InsuranceSubscribers = new List<Inssub>();
        List<Patplan> _PatientPlans = new List<Patplan>();

        #endregion (List Declarations)

        #region Dependency Injections

        // Injected so that the Navigation Manager can be available
        // as a shared resource for page movement.
        
        [Inject]
        protected NavigationManager _UriHelper { get; set; }

        #endregion (Dependency Injections)

        #region Constructors

        // The default constructor is required in order for NaviationManager
        // to properly instantiate.
        public SharedCode() { }

        public SharedCode(NavigationManager navigationManager)
        {
            _UriHelper = navigationManager;
        }

        public void GoToPage(string uri)
        {
            _UriHelper.NavigateTo(uri);
        }

        #endregion (Constructors)

        #region Model Declarations

        // The Open Dental "Patient" model is declared at this level
        // so that it will be avilable throughout the conversion process.
        Patient Account = new Patient();

        #endregion (Model Declarations)

        public async Task StartConversion(MouseEventArgs args)
        {
            // Store and display the conversion start time, 
            // then force a screen update.
            conversionStartTime = DateTime.Now.ToString();
            StateHasChanged();

            await TruncateTables();
            await CreateOperatories();
            await AddDentists();
            await AddReferringDoctors();
            await AddADACodesAndFees();
            await AddMedications();
            await AddRXDefinitions();
            await AddEmployers();
            await AddInsuranceCompanies();
            await AddInsurancePlans();
            await AddAccounts();
            await UpdateDisplay("Conversion complete!");

            // Store and display the conversion end time, 
            // then force a screen update.
            conversionEndTime = DateTime.Now.ToString();
            StateHasChanged();
        }

        async Task TruncateTables()
        {
            // Truncate Open Dental tables.
            await UpdateDisplay("Truncating Open Dental tables ...please stand by");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE operatory");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE carrier");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE employer");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE medication");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE fee");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE procedurecode");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE patient");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE referral");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE provider");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE appointment");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE procedurelog");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE rxdef");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE medicationpat");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE insplan");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE inssub");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE benefit");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE patplan");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE payment");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE adjustment");
            dbOpenDentalContext.Database.ExecuteSqlRaw("TRUNCATE TABLE paysplit");
        }

        async Task CreateOperatories()
        {
            // Create a record for each operatory.  The practice will need to designate
            // a default provider and scheduler color for each upon first use following
            // the completion of the data conversion.
            await UpdateDisplay("Creating Operatories ...please stand by");
            for (int x = 1; x <= maxOperatories; x++)
            {
                // Open Dental Model folder = Models/OpenDental
                var Operatory = new Operatory();
                Operatory.OperatoryNum = x;
                Operatory.OpName = "Operatory " + x.ToString().Trim();
                Operatory.Abbrev = "OP-" + x.ToString().Trim();
                Operatory.ItemOrder = (ushort)(x - 1);
                
                // Add the in memory record to the Entity Framework connection 
                // and update the screen counter display.
                await dbOpenDentalContext.AddAsync(Operatory);
                await UpdateCounter("operatory");
            }
            // Save outstanding Entity Framework DB changes.
            await dbOpenDentalContext.SaveChangesAsync();
        }

        async Task AddInsuranceCompanies()
        {
            await UpdateDisplay("Adding Insurance Companies ...please stand by");

            // Softdent Model folder = Models/Softdent
            // Create a new FileHelper object and read the Softdent Insurance
            // Company delimited text file.
            var cnvSDInsurco = new FileHelperEngine<SdInsurco>();
            var results = cnvSDInsurco.ReadFile(cnvPath + "SDInsurc.REP");

            foreach (var record in results)
            {
                // Open Dental Model folder = Models/OpenDental
                var Carrier = new Carrier();
                Carrier.CarrierNum = record.InsId;
                Carrier.CarrierName = record.InsName;
                Carrier.Address = record.InsAddr1;
                Carrier.Address2 = record.InsAddr2;
                Carrier.City = record.InsCity;
                Carrier.State = record.InsState;
                Carrier.Zip = record.InsZipCode;
                Carrier.Phone = record.InsPhone1;
                Carrier.Tin = "";
                Carrier.ElectId = record.InsEscid;

                // Add the in memory record to the Entity Framework connection 
                // and update the screen counter display.
                await dbOpenDentalContext.AddAsync(Carrier);
                await UpdateCounter("carrier");
            }
            // Save outstanding Entity Framework DB changes.
            await dbOpenDentalContext.SaveChangesAsync();
        }

        async Task AddInsurancePlans()
        {
            await UpdateDisplay("Adding Insurance Plans ...please stand by");

            // Softdent Model folder = Models/Softdent
            // Create a new FileHelper object and read the Softdent Insurance
            // Plan delimited text file.
            var cnvSDInsurancePlan = new FileHelperEngine<SdPlan>();
            var results = cnvSDInsurancePlan.ReadFile(cnvPath + "SDPlan.REP");

            // Create a new FileHelper object and read the Softdent Insurance
            // BlueBook delimited text file.
            var cnvSDBlueBook = new FileHelperEngine<SdBlueBook>();
            var sdBlueBook = cnvSDBlueBook.ReadFile(cnvPath + "SDBlueBo.REP");

            foreach (var record in results)
            {
                var InsPlan = new Insplan();
                InsPlan.PlanNum = record.PlanId;
                InsPlan.GroupName = record.PlanName;
                InsPlan.GroupNum = record.PlanGroupNo;
                InsPlan.CarrierNum = record.PlanInscoId;

                // Values based on viewing the "insplan" table after manually adding
                // a plan in Open Dental.
                InsPlan.ClaimFormNum = 4;
                InsPlan.CobRule = 1;
                InsPlan.SecUserNumEntry = 1;
                InsPlan.SecDateEntry = DateTime.Now;
                InsPlan.SecDateTedit = DateTime.Now;
                InsPlan.HasPpoSubstWriteoffs = 1;

                // Required columns (designated NOT NULL in schema)
                InsPlan.CanadianPlanFlag = "";
                InsPlan.CanadianDiagnosticCode = "";
                InsPlan.CanadianInstitutionCode = "";
                InsPlan.RxBin = "";
                InsPlan.SopCode = "";
                InsPlan.PlanNote = "";

                // Add the in memory record to the Entity Framework connection 
                // and update the screen counter display.
                await dbOpenDentalContext.AddAsync(InsPlan);

                // Add Benefit data
                var sdBlueBookEntry = sdBlueBook.Where(e => e.BlueBookPlanId == record.PlanId).FirstOrDefault();

                // The Softdent Bluebook data is column based rather than record
                // based, so loop through until all column data is collected.
                for (int x = 1; x <= 12; x++)
                {
                    Benefit benefit = new Benefit();

                    benefit.BenefitNum = nextBenefitID;
                    benefit.PlanNum = record.PlanId;

                    // Values based on viewing the "insplan" table after manually adding
                    // a plan in Open Dental.
                    benefit.SecDateTentry = DateTime.Now;
                    benefit.SecDateTedit = DateTime.Now;

                    switch (x)
                    {
                        case 1:
                            // Diagnostic
                            benefit.CovCatNum = (byte)CoverageCategories.Diagnostic;
                            benefit.Percent = (sbyte)sdBlueBookEntry.BlueBookDiagnostic;
                            benefit.MonetaryAmt = -1;
                            benefit.BenefitType = 2;
                            break;
                        case 2:
                            // X-Ray
                            benefit.CovCatNum = (byte)CoverageCategories.XRay;
                            benefit.Percent = (sbyte)sdBlueBookEntry.BlueBookXray;
                            benefit.MonetaryAmt = -1;
                            break;
                        case 3:
                            // Preventive
                            benefit.CovCatNum = (byte)CoverageCategories.Preventive;
                            benefit.Percent = (sbyte)sdBlueBookEntry.BlueBookPreventative;
                            benefit.BenefitType = 2;
                            break;
                        case 4:
                            // Restorative
                            benefit.CovCatNum = (byte)CoverageCategories.Restorative;
                            benefit.Percent = (sbyte)sdBlueBookEntry.BlueBookRestorative;
                            benefit.BenefitType = 1;
                            break;
                        case 5:
                            // Endo
                            benefit.CovCatNum = (byte)CoverageCategories.Endo;
                            benefit.Percent = (sbyte)sdBlueBookEntry.BlueBookEndo;
                            benefit.BenefitType = 1;
                            break;
                        case 6:
                            // Perio
                            benefit.CovCatNum = (byte)CoverageCategories.Perio;
                            benefit.Percent = (sbyte)sdBlueBookEntry.BlueBookPerio;
                            benefit.BenefitType = 1;
                            break;
                        case 7:
                            benefit.CovCatNum = (byte)CoverageCategories.Prosth;
                            benefit.Percent = (sbyte)sdBlueBookEntry.BlueBookProstR;
                            benefit.BenefitType = 1;
                            // ProstR
                            break;
                        case 8:
                            // ProstF
                            benefit.CovCatNum = (byte)CoverageCategories.MaxilofacialProsth;
                            benefit.Percent = (sbyte)sdBlueBookEntry.BlueBookProstF;
                            benefit.BenefitType = 1;
                            break;
                        case 9:
                            // Crown
                            benefit.CovCatNum = (byte)CoverageCategories.Crowns;
                            benefit.Percent = (sbyte)sdBlueBookEntry.BlueBookCrown;
                            benefit.BenefitType = 1;
                            break;
                        case 10:
                            // Oral Surgery
                            benefit.CovCatNum = (byte)CoverageCategories.OralSurgery;
                            benefit.Percent = (sbyte)sdBlueBookEntry.BlueBookOralSurg;
                            benefit.BenefitType = 1;
                            break;
                        case 11:
                            // Ortho
                            benefit.CovCatNum = (byte)CoverageCategories.Ortho;
                            benefit.Percent = (sbyte)sdBlueBookEntry.BlueBookOrtho;
                            benefit.BenefitType = 5;
                            break;
                        case 12:
                            // AdjSvc
                            benefit.CovCatNum = (byte)CoverageCategories.Adjunctive;
                            benefit.Percent = (sbyte)sdBlueBookEntry.BlueBookAdjSvc;
                            break;
                        default:
                            break;
                    }
                    // Add the in memory record to the Entity Framework connection. 
                    await dbOpenDentalContext.AddAsync(benefit);
                    nextBenefitID += 1;
                }

                // Update screen counter display.
                await UpdateCounter("insplan");
            }
            // Save outstanding Entity Framework DB changes.
            await dbOpenDentalContext.SaveChangesAsync();
        }

        async Task AddEmployers()
        {
            await UpdateDisplay("Adding Employers...please stand by");

            // Softdent Model folder = Models/Softdent
            // Create a new FileHelper object and read the Softdent Employer
            // delimited text file.
            var cnvSDEmpl = new FileHelperEngine<SdEmpl>();
            var results = cnvSDEmpl.ReadFile(cnvPath + "SDEmpl.REP");

            foreach (var record in results)
            {
                // Open Dental Model folder = Models/OpenDental
                var Employer = new Employer();
                Employer.EmployerNum = record.EmpId;
                Employer.EmpName = record.EmpName.Trim();
                Employer.Address = record.EmpAddr1;
                Employer.Address2 = record.EmpAddr2;
                Employer.City = record.EmpCity;
                Employer.State = record.EmpState;
                Employer.Zip = record.EmpZipCode;
                Employer.Phone = record.EmpPhone;

                // Add the in memory record to the Entity Framework connection 
                // and update the screen counter display.
                await dbOpenDentalContext.AddAsync(Employer);
                await UpdateCounter("employer");
            }
            // Save outstanding Entity Framework DB changes.
            await dbOpenDentalContext.SaveChangesAsync();
        }

        #region ProvidersAndReferringDoctors

        async Task AddDentists()
        {
            await UpdateDisplay("Adding Dentists and Hygenists ...please stand by");

            // Softdent Model folder = Models/Softdent
            // Create a new FileHelper object and read the Softdent Employer
            // delimited text file.
            var cnvSDDentist = new FileHelperEngine<SdDentist>();
            var results = cnvSDDentist.ReadFile(cnvPath + "SDDentis.REP");

            // Counter to keep track of selecting a scheduler color for
            // the provider.
            int doctorCount = 1;
            int hygenistCount = 1;

            foreach (var record in results)
            {
                var Provider = new Provider();
                Provider.ProvNum = record.ProvId;
                Provider.Lname = record.ProvLast;
                Provider.Fname = record.ProvFirst;
                Provider.Mi = record.ProvMiddle;
                Provider.Suffix = record.ProvDegree;
                Provider.Ssn = record.ProvSsn;
                Provider.StateLicense = record.ProvLicNo;
                Provider.Deanum = record.ProvDeaid;
                Provider.Birthdate = ValidateDateField(record.ProvBirthday);
                Provider.BlueCrossId = record.ProvBcbsid;

                // Required columns designated as NOT NULL in the MySQL schema.
                Provider.TaxonomyCodeOverride = "";
                Provider.EcwId = "";
                Provider.StateRxId = "";
                Provider.StateWhereLicensed = "";
                Provider.CustomId = "";
                Provider.SchedNote = "";
                Provider.WebSchedImageLocation = "";
                Provider.WebSchedDescript = "";
                Provider.OutlineColor = (int)ProviderColors.OutlineColor;

                switch (record.ProvType)
                {
                    case "0":
                        Provider.Specialty = (byte)ProviderSpecialty.General;

                        // Determine scheduler colors for the first 5 doctors.
                        switch (doctorCount)
                        {
                            case 1:
                                Provider.ProvColor = (int)ProviderColors.Doc1;
                                break;
                            case 2:
                                Provider.ProvColor = (int)ProviderColors.Doc2;
                                break;
                            case 3:
                                Provider.ProvColor = (int)ProviderColors.Doc3;
                                break;
                            case 4:
                                Provider.ProvColor = (int)ProviderColors.Doc4;
                                break;
                            case 5:
                                Provider.ProvColor = (int)ProviderColors.Doc5;
                                break;
                            default:
                                break;
                        }

                        doctorCount += 1;

                        break;
                    case "1":
                        Provider.Specialty = (byte)ProviderSpecialty.Hygenist;

                        // Determine scheduler colors for the first 5 hygenists.
                        switch (hygenistCount)
                        {
                            case 1:
                                Provider.ProvColor = (int)ProviderColors.Hyg1;
                                break;
                            case 2:
                                Provider.ProvColor = (int)ProviderColors.Hyg2;
                                break;
                            case 3:
                                Provider.ProvColor = (int)ProviderColors.Hyg3;
                                break;
                            case 4:
                                Provider.ProvColor = (int)ProviderColors.Hyg4;
                                break;
                            case 5:
                                Provider.ProvColor = (int)ProviderColors.Hyg5;
                                break;
                            default:
                                break;
                        }

                        hygenistCount += 1;

                        break;
                    case "2":
                        Provider.Specialty = (byte)ProviderSpecialty.Assistant;
                        break;
                    case "3":
                        Provider.Specialty = (byte)ProviderSpecialty.Assistant;
                        break;
                    case "4":
                        Provider.Specialty = (byte)ProviderSpecialty.LabTech;
                        break;
                    default:
                        Provider.Specialty = (byte)ProviderSpecialty.General;
                        break;
                }

                // Add the in memory record to the Entity Framework connection 
                // and update the screen counter display.
                await dbOpenDentalContext.AddAsync(Provider);
                await UpdateCounter("provider");
            }
            // Save outstanding Entity Framework DB changes.
            await dbOpenDentalContext.SaveChangesAsync();
        }

        async Task AddReferringDoctors()
        {
            await UpdateDisplay("Adding Referring Doctors ...please stand by");

            // Softdent Model folder = Models/Softdent
            // Create a new FileHelper object and read the Softdent Referring
            // Doctor delimited text file.
            var cnvSDReferringDoctor = new FileHelperEngine<SdRefDr>();
            var results = cnvSDReferringDoctor.ReadFile(cnvPath + "SDRefDr.REP");

            foreach (var record in results)
            {
                var Referral = new Referral();
                Referral.ReferralNum = record.RefDrId;
                Referral.Title = record.RefDrTitle;
                Referral.Fname = record.RefDrFirst;
                Referral.Mname = record.RefDrMiddle;
                Referral.Lname = record.RefDrLast;
                Referral.Address = record.RefDrAddress;
                Referral.City = record.RefDrCity;
                Referral.St = record.RefDrState;
                Referral.Zip = record.RefDrZipCode;
                // Remove dashes and parentheses from the phone number.
                Referral.Telephone = ValidatePhoneNumber(record.RefDrPhone).Replace("(", "").Replace(")", "").Replace("-", "");

                // Add the specialty designation to this provider's record.
                switch (record.RefDrSpecialtyId)
                {
                    case 301:
                        Referral.Specialty = (byte)ProviderSpecialty.General;
                        break;
                    case 302:
                        Referral.Specialty = (byte)ProviderSpecialty.Hygenist;
                        break;
                    case 303:
                        Referral.Specialty = (byte)ProviderSpecialty.Endo;
                        break;
                    case 304:
                        Referral.Specialty = (byte)ProviderSpecialty.Pediatric;
                        break;
                    case 305:
                        Referral.Specialty = (byte)ProviderSpecialty.Perio;
                        break;
                    case 306:
                        Referral.Specialty = (byte)ProviderSpecialty.ProstH;
                        break;
                    case 307:
                        Referral.Specialty = (byte)ProviderSpecialty.Ortho;
                        break;
                    case 308:
                        Referral.Specialty = (byte)ProviderSpecialty.Denturist;
                        break;
                    case 309:
                        Referral.Specialty = (byte)ProviderSpecialty.Surgery;
                        break;
                    default:
                        Referral.Specialty = (byte)ProviderSpecialty.General;
                        break;
                }

                // Add the in memory record to the Entity Framework connection 
                // and update the screen counter display.
                await dbOpenDentalContext.AddAsync(Referral);
                await UpdateCounter("referral");
            }
            // Save outstanding Entity Framework DB changes.
            await dbOpenDentalContext.SaveChangesAsync();
        }

        #endregion

        async Task AddMedications()
        {
            await UpdateDisplay("Adding Softdent Drugs...please stand by");

            // Softdent Model folder = Models/Softdent
            // Create a new FileHelper object and read the Softdent Employer
            // delimited text file.
            var cnvSDDrug = new FileHelperEngine<SdDrug>();
            var results = cnvSDDrug.ReadFile(cnvPath + "SDDrug.REP");

            foreach (var record in results)
            {
                // Open Dental Model folder = Models/OpenDental
                var Medication = new Medication();
                Medication.MedicationNum = record.DrugId;
                Medication.GenericNum = record.DrugId;
                Medication.MedName = record.DrugName;
                Medication.Notes = record.DrugQty;

                // Add the in memory record to the Entity Framework connection 
                // and update the screen counter display.
                await dbOpenDentalContext.AddAsync(Medication);
                await UpdateCounter("medication");
            }
            // Save outstanding Entity Framework DB changes.
            await dbOpenDentalContext.SaveChangesAsync();
        }

        async Task AddRXDefinitions()
        {
            await UpdateDisplay("Adding Prescription Definitions ...please stand by");

            // Softdent Model folder = Models/Softdent
            // Create a new FileHelper object and read the Softdent Employer
            // delimited text file.
            var cnvSDRXDefinitions = new FileHelperEngine<SdRx>();
            var results = cnvSDRXDefinitions.ReadFile(cnvPath + "SDRX.REP");

            int nextRXDefinition = 1;

            // This list rather than the DB table will be searched to make sure
            // all drug entries are unique.  Dramatically improves I/O.
            List<Rxdef> tempRXDef = new List<Rxdef>();

            foreach (var record in results)
            {
                var searchRXDefTable = tempRXDef.Where(s => s.Drug == record.RxDrugName).ToList();
                if (searchRXDefTable.Count() == 0)
                {
                    var RXDef = new Rxdef();
                    RXDef.RxDefNum = nextRXDefinition;
                    RXDef.Drug = record.RxDrugName;
                    RXDef.Disp = record.RxDrugQty;

                    // Required columns designated as NOT NULL in the MySQL schema.
                    RXDef.PatientInstruction = "";

                    await dbOpenDentalContext.AddAsync(RXDef);

                    // Save the record to the temp list for searching purposes and
                    // update screen counter.
                    tempRXDef.Add(RXDef);
                    await UpdateCounter("rxdef");

                    nextRXDefinition += 1;
                }
            }
            // Save outstanding Entity Framework DB changes.
            await dbOpenDentalContext.SaveChangesAsync();
        }

        async Task AddADACodesAndFees()
        {
            await UpdateDisplay("Adding Softdent ADA Codes and Fees...please stand by");

            // Softdent Model folder = Models/Softdent
            // Create a new FileHelper object and read the Softdent Employer
            // delimited text file.
            var cnvSDADA = new FileHelperEngine<SdAdum>();
            var results = cnvSDADA.ReadFile(cnvPath + "SDADA.REP");

            string ADAField = "";

            long feeID = 1;
            long procedureCodeID = 1;

            // During the creation of ProcedureCode records later in this method
            // the table cannot be queried for the existence of a code because
            // the context is not completely saved until all codes are added.  
            // This list will store just the code and will be an in memory
            // lookup so the context does not have to be saved with each record.
            List<string> procedureCodeList = new List<string>();

            foreach (var record in results)
            {

                string tempADACode = "";

                for (int x = 1; x <= 10; x++)
                {
                    var Fee = new Fee();
                    Fee.FeeNum = feeID;
                    Fee.OldCode = FormatADACodeForFeeSchedule(record.AdaCode);
                    switch (x)
                    {
                        case 1:
                            Fee.FeeSched = (long)FeeSchedule.Fee01;
                            Fee.Amount = (double)record.AdaFee01;
                            ADAField = "ADA_Fee01";
                            break;
                        case 2:
                            Fee.FeeSched = (long)FeeSchedule.Fee02;
                            Fee.Amount = (double)record.AdaFee02;
                            ADAField = "ADA_Fee02";
                            break;
                        case 3:
                            Fee.FeeSched = (long)FeeSchedule.Fee03;
                            Fee.Amount = (double)record.AdaFee03;
                            ADAField = "ADA_Fee03";
                            break;
                        case 4:
                            Fee.FeeSched = (long)FeeSchedule.Fee04;
                            Fee.Amount = (double)record.AdaFee04;
                            ADAField = "ADA_Fee04";
                            break;
                        case 5:
                            Fee.FeeSched = (long)FeeSchedule.Fee05;
                            Fee.Amount = (double)record.AdaFee05;
                            ADAField = "ADA_Fee05";
                            break;
                        case 6:
                            Fee.FeeSched = (long)FeeSchedule.Fee06;
                            Fee.Amount = (double)record.AdaFee06;
                            ADAField = "ADA_Fee06";
                            break;
                        case 7:
                            Fee.FeeSched = (long)FeeSchedule.Fee07;
                            Fee.Amount = (double)record.AdaFee07;
                            ADAField = "ADA_Fee07";
                            break;
                        case 8:
                            Fee.FeeSched = (long)FeeSchedule.Fee08;
                            Fee.Amount = (double)record.AdaFee08;
                            ADAField = "ADA_Fee08";
                            break;
                        case 9:
                            Fee.FeeSched = (long)FeeSchedule.Fee09;
                            Fee.Amount = (double)record.AdaFee09;
                            ADAField = "ADA_Fee09";
                            break;
                        case 10:
                            Fee.FeeSched = (long)FeeSchedule.Fee10;
                            Fee.Amount = (double)record.AdaFee10;
                            ADAField = "ADA_Fee10";
                            break;
                        default:
                            break;
                    }
                    // Add the in memory record to the Entity Framework connection 
                    // and update the screen counter display.
                    await dbOpenDentalContext.AddAsync(Fee);

                    feeID += 1;

                    // Since the ProcedureCode changes are not saved until the end, adding
                    // to this list and then checking for the existence allows for much
                    // faster execution.
                    bool codeExists = procedureCodeList.Exists(x => x.Contains(Fee.OldCode));

                    if (!codeExists)
                    {
                        procedureCodeList.Add(Fee.OldCode);

                        var ProcedureCode = new Procedurecode();
                        ProcedureCode.CodeNum = procedureCodeID;

                        Fee.CodeNum = procedureCodeID;

                        tempADACode = Fee.OldCode;

                        ProcedureCode.ProcCode = Fee.OldCode;
                        ProcedureCode.Descript = record.AdaDescription;
                        ProcedureCode.AbbrDesc = record.AdaShortDesc;
                        ProcedureCode.ProcCat = GetADACodeCategory(record.AdaCode);

                        // Required columns designated as NOT NULL in the MySQL schema.
                        ProcedureCode.DefaultClaimNote = "";
                        ProcedureCode.DefaultTpnote = "";
                        ProcedureCode.DrugNdc = "";
                        ProcedureCode.RevenueCodeDefault = "";
                        ProcedureCode.TaxCode = "";

                        // Add the in memory record to the Entity Framework connection 
                        // and update the screen counter display.
                        await dbOpenDentalContext.AddAsync(ProcedureCode);
                    }
                }

                // Save outstanding Entity Framework DB changes.
                await dbOpenDentalContext.SaveChangesAsync();

                // Update each fee record to include the code number
                var _fees = dbOpenDentalContext.Fees.Where(e => e.OldCode == tempADACode);
                foreach (var fee in _fees)
                {
                    fee.CodeNum = procedureCodeID;
                }

                await UpdateCounter("fee");
                procedureCodeID += 1;

            }
        }

        async Task AddPatients(int sdAcctID, List<SdPat> SDPatList, bool hasInsurance)
        {
            // Parameter list:
            // sdAcctID = The current Softdent account holder ID
            // List<SdPat> = The in memory list for all patients within this account.
            // hasInsurance = Does the account have insurance coverages.
            foreach (SdPat pat in SDPatList.FindAll(e => e.PatRpId == sdAcctID).ToList())
            {
                await UpdateCounter("patient");

                var Patient = new Patient();
                Patient.PatNum = nextPatientID;
                Patient.Guarantor = Account.Guarantor;
                Patient.ChartNumber = pat.PatId.ToString();
                Patient.Fname = pat.PatFname;
                Patient.MiddleI = pat.PatMname;
                Patient.Lname = pat.PatLname;
                Patient.Salutation = pat.PatFname;
                Patient.Preferred = pat.PatNickname;
                Patient.PatStatus = ValidatePatientStatus(pat.PatUserCodes);
                Patient.Gender = ValidateGender(pat.PatGender);
                Patient.Position = ValidateFamilyPosition(pat.PatMarital);
                Patient.Birthdate = ValidateDateField(pat.PatBirthday);
                Patient.Ssn = ValidateSSN(pat.PatSsn);
                Patient.Address = pat.PatAddress;
                Patient.City = pat.PatCity;
                Patient.State = pat.PatState;
                Patient.Zip = pat.PatZip;
                Patient.HmPhone = ValidatePhoneNumber(pat.PatHphone);
                Patient.WkPhone = ValidatePhoneNumber(pat.PatWphone);
                Patient.WirelessPhone = ValidatePhoneNumber(pat.PatCellPhone);
                Patient.PriProv = pat.PatDocId;
                Patient.Email = pat.PatEmail;
                Patient.BillingType = ValidateBillingType(pat.PatUserCodes);
                Patient.FeeSched = (long)FeeSchedule.Fee01 + pat.PatFeeSched;
                Patient.DateFirstVisit = ValidateDateField(pat.PatFirstVisit);

                // Required columns designated as NOT NULL in the MySQL schema.
                Patient.SchoolName = "";
                Patient.SmokingSnoMed = "";
                Patient.Country = "";

                // Best effort to see if the patient is also the guarantor.  If so,
                // do not add a new record, rather update the existing one.
                bool PatientIsAlsoGuarantor = false;
                if ((Account.Ssn.Length > 0 && Patient.Ssn.Length > 0) && (Account.Ssn == Patient.Ssn)) PatientIsAlsoGuarantor = true;
                if ((Account.Birthdate.ToString() != "1901-01-01" && Patient.Birthdate.ToString() != "1901-01-01") && (Account.Birthdate == Patient.Birthdate)) PatientIsAlsoGuarantor = true;

                // All appointments and transactions must be added before checking to
                // see if the patient is also the guarantor as the nextPatientID will
                // be incremented during the process.

                // Add patient appoinments.
                await AddPatientAppointments(pat.PatId, nextPatientID, patientAppointmentList);

                // Add patient prescriptions
                await AddPatientPrescriptions(pat.PatId, nextPatientID, patientPrescriptionsList);

                // Add patient billing transactions
                await AddPatientBillingTransactions(false, pat.PatId, nextPatientID, patientBillingTransactionsList);

                if (!PatientIsAlsoGuarantor)
                {
                    // Add the in memory record to the Entity Framework connection 
                    // and update the screen counter display.
                    await dbOpenDentalContext.AddAsync(Patient);
                    await UpdateCounter("patient");

                    // The guarantor patient has insurance, so lookup details and then add a record to the 
                    // "patplan" table.
                    if (hasInsurance)
                    {
                        // For some reason the insurance plan was not created.  This section should be 
                        // updated to better allow for no plans rather than use an empty Catch().
                        try
                        {
                            long insuranceSubscriber = dbOpenDentalContext.Patplans.Where(e => e.PatNum == Account.Guarantor).Select(e => e.InsSubNum).FirstOrDefault();
                            // "nextOrdinal" represents the on screen display order for patients within the guarantor's plan coverages.
                            int nextOrdinal = _PatientPlans.Where(e => e.PatNum == Account.Guarantor).Max(e => e.Ordinal) + 1;

                            var patPlan = new Patplan();
                            patPlan.PatPlanNum = nextPatientPlanNumber;
                            patPlan.PatNum = Patient.PatNum;
                            patPlan.Ordinal = (byte)nextOrdinal;
                            patPlan.Relationship = (byte)InsuranceRelationship.Dependent;
                            patPlan.InsSubNum = insuranceSubscriber;

                            // Add the in memory record to the Entity Framework connection. 
                            await dbOpenDentalContext.AddAsync(patPlan);

                            // Add "patPlan" record to in memory list.  Will speed up lookups and minimize DB writes.
                            _PatientPlans.Add(patPlan);

                            //await dbOpenDentalContext.SaveChangesAsync();

                            nextPatientPlanNumber += 1;
                        }
                        catch { }
                    }

                    nextPatientID += 1;
                }
                else
                {
                    // The current patient is also the guarantor and was added earlier.  Update the existing
                    // patient record with the changes below.

                    Account.PatStatus = Patient.PatStatus;
                    if (Patient.Ssn.Length > 0) Account.Ssn = Patient.Ssn;
                    if (Patient.HmPhone.Length > 0) Account.HmPhone = Patient.HmPhone;
                    if (Patient.WkPhone.Length > 0) Account.WkPhone = Patient.WkPhone;
                    if (Patient.WirelessPhone.Length > 0) Account.WirelessPhone = Patient.WirelessPhone;
                    // If the patient is also the guarantor then leave the chart number as the account #
                    if (Patient.DateFirstVisit.ToString() != "0001-01-01") Account.DateFirstVisit = Patient.DateFirstVisit;

                    // Changes to the current guarantor record will be updated once the loop
                    // is returned to the AddAccounts method.

                    // Update the screen display.
                    await UpdateCounter("sd patients");
                }

            }
        }

        async Task AddPatientPrescriptions(int sdPatientID, int odPatientID, List<SdRx> SDPatientPrescriptions)
        {
            // Parameters:
            // sdPatientID = The old Softdent patient ID
            // odPatientID = The new Open Dental patient ID
            // SDPatientPrescriptions = In memory list of all patient prescriptions for lookup purposes.
            foreach (SdRx patRX in SDPatientPrescriptions.FindAll(e => e.RxPatId == sdPatientID))
            {
                var MedicationPat = new Medicationpat();
                MedicationPat.MedicationPatNum = nextMedicationPatRXID;
                MedicationPat.PatNum = odPatientID;
                MedicationPat.MedicationNum = patRX.RxDrugId;
                MedicationPat.ProvNum = (long)patRX.RxDrId;
                MedicationPat.DateStart = ValidateDateField(patRX.RxDate);

                // Required columns designated as NOT NULL in the MySQL schema.
                MedicationPat.MedDescript = "";
                MedicationPat.ErxGuid = "";

                // Add the in memory record to the Entity Framework connection 
                // and update the screen counter display.
                await dbOpenDentalContext.AddAsync(MedicationPat);
                await UpdateCounter("medicationpat");

                nextMedicationPatRXID += 1;
            }
        }

        async Task AddPatientBillingTransactions(bool isAccountTransaction, int sdPatientID, int odPatientID, List<SdTran> SDPatientBillingTransactions)
        {
            foreach (SdTran patTrans in SDPatientBillingTransactions.FindAll(e => e.TransPatId == sdPatientID))
            {
                // Make sure this is not a payment.  Payments will be added later in the
                // "paytype" table.
                if (patTrans.TransCash == 0 && patTrans.TransChecks == 0 && patTrans.TransCredit == 0 && patTrans.TransPayAdj == 0)
                {

                    var ProcedureLog = new Procedurelog();
                    ProcedureLog.ProcNum = nextBillingTransactionID;
                    ProcedureLog.PatNum = odPatientID;
                    ProcedureLog.BillingNote = patTrans.TransPatId.ToString() + "/" + patTrans.TransCode.ToString();
                    ProcedureLog.ProcDate = Convert.ToDateTime(patTrans.TransDate);
                    ProcedureLog.Surf = patTrans.TransSurface;
                    ProcedureLog.ToothNum = patTrans.TransTooth;
                    ProcedureLog.ProvNum = (long)patTrans.TransDr;
                    ProcedureLog.ProcFee = (double)patTrans.TransProd;
                    ProcedureLog.CodeNum = dbOpenDentalContext.Procedurecodes
                        .Where(e => e.ProcCode == FormatADACodeForFeeSchedule((decimal)patTrans.TransCode))
                        .Select(e => e.CodeNum)
                        .FirstOrDefault();

                    // TransCodeType = "P" = Treatment Plan
                    if (patTrans.TransCodeType == "P")
                    {
                        // Treatment Plan
                        ProcedureLog.ProcStatus = 1;
                        ProcedureLog.ProcFee = dbOpenDentalContext.Fees
                            .Where(e => e.CodeNum == ProcedureLog.CodeNum && e.FeeSched == (long)FeeSchedule.Fee01)
                            .Select(e => e.Amount)
                            .FirstOrDefault();
                    }
                    {
                        // Production, payment or adjustment.
                        ProcedureLog.ProcStatus = 2;
                    }

                    // Required columns designated as NOT NULL in the MySQL schema.
                    ProcedureLog.OldCode = "";
                    ProcedureLog.CanadianTypeCodes = "";
                    ProcedureLog.SnomedBodySite = "";
                    ProcedureLog.DiagnosticCode2 = "";
                    ProcedureLog.DiagnosticCode3 = "";
                    ProcedureLog.DiagnosticCode4 = "";

                    if (isAccountTransaction) await UpdateCounter("account transactions");

                    await dbOpenDentalContext.AddAsync(ProcedureLog);
                    await UpdateCounter("procedurelog");

                    nextBillingTransactionID += 1;
                }
                else if (patTrans.TransPayAdj == 0 && (patTrans.TransCash != 00 || patTrans.TransChecks != 0 || patTrans.TransCredit != 0))
                // This is a payment
                {
                    var payment = new Payment();
                    payment.PayNum = nextPaymentNumber;
                    payment.PayDate = Convert.ToDateTime(patTrans.TransDate);
                    payment.PatNum = odPatientID;
                    payment.PayNote = sdPatientID.ToString() + "/" + patTrans.TransCode.ToString();

                    // Required columns
                    payment.ExternalId = "";
                    payment.Receipt = "";

                    if (patTrans.TransCash != 0)
                    {
                        payment.PayType = (byte)PaymentType.Cash;
                        payment.PayAmt = (double)patTrans.TransCash;
                    }
                    else if (patTrans.TransChecks != 0)
                    {
                        payment.PayType = (byte)PaymentType.PersonalCheck;
                        payment.PayAmt = (double)patTrans.TransChecks;
                    }
                    else if (patTrans.TransCredit != 0)
                    {
                        payment.PayType = (byte)PaymentType.CreditCard;
                        payment.PayAmt = (double)patTrans.TransCredit;
                    }

                    await dbOpenDentalContext.AddAsync(payment);
                    nextPaymentNumber += 1;

                    var paySplit = new Paysplit();
                    paySplit.SplitNum = nextPaymentSplitNumber;
                    paySplit.SplitAmt = payment.PayAmt;
                    paySplit.PatNum = odPatientID;
                    paySplit.ProcDate = Convert.ToDateTime(patTrans.TransDate);
                    paySplit.PayNum = payment.PayNum;
                    paySplit.ProvNum = (long)patTrans.TransD;

                    // Add the in memory record to the Entity Framework connection 
                    // and update the screen counter display.
                    await dbOpenDentalContext.AddAsync(paySplit);
                    nextPaymentSplitNumber += 1;

                    await UpdateCounter("procedurelog");
                }
                else if (patTrans.TransPayAdj != 0)
                // This is an adjustment
                {
                    var adjustment = new Adjustment();
                    adjustment.AdjNum = nextAdjustmentNumber;
                    adjustment.AdjDate = Convert.ToDateTime(patTrans.TransDate);
                    adjustment.AdjAmt = (double)patTrans.TransPayAdj;
                    adjustment.PatNum = odPatientID;
                    adjustment.AdjNote = sdPatientID.ToString() + "/" + patTrans.TransCode.ToString();

                    switch (patTrans.TransCode)
                    {
                        case 29:  // Softdent Starting Credit Balance
                        case 21:  // Softdent Credit Adjustment
                            adjustment.AdjType = (byte)AdjustmentType.StartingCreditBalance;
                            adjustment.ProvNum = (long)patTrans.TransDr;
                            break;
                        default:
                            break;
                    }

                    // Add the in memory record to the Entity Framework connection 
                    // and update the screen counter display.
                    await dbOpenDentalContext.AddAsync(adjustment);
                    await UpdateCounter("procedurelog");
                    nextAdjustmentNumber += 1;
                }
            }
        }

        async Task AddPatientAppointments(int sdPatientID, int odPatientID, List<SdAppt> SDPatientAppointments)
        {
            foreach (SdAppt patAppt in SDPatientAppointments.FindAll(e => e.ApptPatId == sdPatientID).ToList())
            {
                var Appointment = new Appointment();
                Appointment.AptNum = nextAppointmentID;
                Appointment.PatNum = odPatientID;
                Appointment.ProvNum = patAppt.ApptDentist;
                Appointment.Op = patAppt.ApptOperatory;
                Appointment.Pattern = string.Concat(Enumerable.Repeat("/", patAppt.ApptTimeUnits));
                Appointment.AptStatus = 1;
                Appointment.ProcDescript = patAppt.ApptAdadesc;

                string apptTime = patAppt.ApptTime;
                if (apptTime.Contains("a"))
                {
                    apptTime = apptTime.Substring(0, 5) + " AM";
                }
                else
                {
                    apptTime = apptTime.Substring(0, 5) + " PM";
                }

                Appointment.AptDateTime = Convert.ToDateTime(patAppt.ApptDate + " " + apptTime);

                // Required columns designated as NOT NULL in the MySQL schema.
                Appointment.PatternSecondary = "";
                Appointment.ProvBarText = "";
                Appointment.ProcsColored = "";

                // Add the in memory record to the Entity Framework connection 
                // and update the screen counter display.
                await dbOpenDentalContext.AddAsync(Appointment);
                await UpdateCounter("appointment");

                nextAppointmentID += 1;
            }
        }

        async Task AddAccounts()
        {
            await UpdateDisplay("Adding Accounts and Patients...please stand by");

            // Softdent Accounts
            var cnvSDAccount = new FileHelperEngine<SdAcct>();
            var results = cnvSDAccount.ReadFile(cnvPath + "SDAcct.REP");

            // Softdent Patients
            var cnvSDPatient = new FileHelperEngine<SdPat>();
            var patResults = cnvSDPatient.ReadFile(cnvPath + "SDPat.REP");
            List<SdPat> patList = patResults.ToList();

            // Softdent Patient Appointments
            var cnvSDPatientAppointments = new FileHelperEngine<SdAppt>();
            cnvSDPatientAppointments.ErrorManager.ErrorMode = ErrorMode.SaveAndContinue;

            var patientAppointments = cnvSDPatientAppointments.ReadFile(cnvPath + "SDAppt.REP");
            if (cnvSDPatientAppointments.ErrorManager.HasErrors)
            {
                cnvSDPatientAppointments.ErrorManager.SaveErrors(@"C:\Temp\ApptErrors.txt");
            }
            patientAppointmentList = patientAppointments.ToList();

            // Softdent Patient Prescriptions
            var cnvSDPatientPrescriptions = new FileHelperEngine<SdRx>();
            var patientPrescriptions = cnvSDPatientPrescriptions.ReadFile(cnvPath + "SDRX.REP");
            patientPrescriptionsList = patientPrescriptions.ToList();

            // Softdent Billing Transactions (Account and Patient)
            var cnvSDPatientBillingTransactions = new FileHelperEngine<SdTran>();
            var patientBillingTransactions = cnvSDPatientBillingTransactions.ReadFile(cnvPath + "SDTrans.REP");
            patientBillingTransactionsList = patientBillingTransactions.ToList();

            foreach (var record in results)
            {
                // Open Dental Model folder = Models/OpenDental
                // var Account = new Patient();
                Account = new Patient();

                Account.PatNum = nextPatientID;
                Account.Guarantor = nextPatientID;

                Account.Fname = record.AcctG1fname;
                Account.MiddleI = record.AcctG1mname;
                Account.Lname = record.AcctG1lname;
                Account.Title = record.AcctG1title;
                Account.Salutation = record.AcctG1fname;
                Account.Birthdate = ValidateDateField(record.AcctG1birthday);
                Account.Ssn = ValidateSSN(record.AcctG1ssn);
                Account.Address = record.AcctG1address;
                Account.City = record.AcctG1city;
                Account.State = record.AcctG1state;
                Account.Zip = record.AcctG1zip;
                Account.HmPhone = ValidatePhoneNumber(record.AcctG1hphone);
                Account.WkPhone = ValidatePhoneNumber(record.AcctG1wphone);
                Account.Gender = ValidateGender(record.AcctG1gender);
                Account.Position = ValidateFamilyPosition(record.AcctG1marital);
                Account.PatStatus = (byte)PatientStatus.NonPatient;
                Account.PriProv = (long)record.AcctDefaultDr;
                Account.BillingType = ValidateBillingType(record.AcctUserCodes);
                Account.FeeSched = (byte)FeeSchedule.Fee01;
                Account.EmployerNum = (long)record.AcctG1empId;
                Account.ChartNumber = record.AcctId.ToString() + "-1";

                // Required columns designated as NOT NULL in the MySQL schema.
                Account.Country = "";
                Account.SchoolName = "";
                Account.SmokingSnoMed = "";

                // Add the in memory record to the Entity Framework connection 
                // and update the screen counter display.
                await dbOpenDentalContext.AddAsync(Account);
                await UpdateCounter("account");

                // Add account billing transactions
                await AddPatientBillingTransactions(true, record.AcctId, nextPatientID, patientBillingTransactionsList);

                // Add patient insurance
                bool hasInsurance = false;
                if (record.AcctG1planId != 0)
                {
                    hasInsurance = true;
                    await AddPatientInsurance((int)record.AcctG1planId, (int)record.AcctG1empId, nextPatientID, Account.Ssn, false);
                }

                nextPatientID += 1;

                // Add Patients
                await AddPatients(record.AcctId, patList, hasInsurance);

                // Add 2nd guarantors as non-patients
                bool SecondGuarantorExists = record.AcctG2fname.Trim() != "" && record.AcctG2lname.Trim() != "" && record.AcctG2planId != 0;
                if (SecondGuarantorExists)
                {
                    Patient Account2 = new Patient();

                    // Do not create a whole new "Account" record here.  Just change the demographic
                    // info from AcctG1 to AcctG2 in the SDAcct.REP file.
                    Account2.PatNum = nextPatientID;
                    Account2.Guarantor = Account.Guarantor;

                    Account2.Fname = record.AcctG2fname;
                    Account2.MiddleI = record.AcctG2mname;
                    Account2.Lname = record.AcctG2lname;
                    Account2.Title = record.AcctG2title;
                    Account2.Salutation = record.AcctG2fname;
                    Account2.Birthdate = ValidateDateField(record.AcctG2birthday);
                    Account2.Ssn = ValidateSSN(record.AcctG2ssn);
                    Account2.HmPhone = ValidatePhoneNumber(record.AcctG2hphone);
                    Account2.WkPhone = ValidatePhoneNumber(record.AcctG2wphone);
                    Account2.Gender = ValidateGender(record.AcctG2gender);
                    Account2.Position = ValidateFamilyPosition(record.AcctG2marital);
                    Account2.PatStatus = (byte)PatientStatus.NonPatient;

                    Account2.PriProv = (long)record.AcctDefaultDr;
                    Account2.BillingType = ValidateBillingType(record.AcctUserCodes);
                    Account2.FeeSched = (byte)FeeSchedule.Fee01;

                    Account2.EmployerNum = (long)record.AcctG2empId;
                    Account2.ChartNumber = record.AcctId.ToString() + "-2";

                    // Required columns designated as NOT NULL in the MySQL schema.
                    Account2.Country = "";
                    Account2.SchoolName = "";
                    Account2.SmokingSnoMed = "";

                    // Add the in memory record to the Entity Framework connection 
                    // and update the screen counter display.
                    await dbOpenDentalContext.AddAsync(Account2);
                    await UpdateCounter("2nd guarantor");

                    // Add 2nd guarantor insurance
                    await AddPatientInsurance((int)record.AcctG2planId, (int)record.AcctG2empId, nextPatientID, Account.Ssn, true);

                    nextPatientID += 1;
                }

                //await dbOpenDentalContext.SaveChangesAsync();
            }
            await UpdateDisplay("Saving new Guarantor and Patient records to database ...please stand by");
            // Add the in memory record to the Entity Framework connection.
            await dbOpenDentalContext.SaveChangesAsync();
        }

        async Task AddPatientInsurance(int guarantorPlanID, int guarantorEmplID, int patientID, string patientSSN, bool is2ndGuarantor)
        {
            if (guarantorPlanID != 0 && guarantorEmplID != 0)
            {
                var InsPlan = dbOpenDentalContext.Insplans.Where(e => e.PlanNum == guarantorPlanID).FirstOrDefault();
                if (InsPlan != null)
                {
                    InsPlan.EmployerNum = guarantorEmplID;
                    CounterVariables.totalPlansUpdated += 1;

                    // Create the "inssub" (Subscriber) record if it does not already exist.
                    //var insuranceSubscriber = dbOpenDentalContext.Inssubs.Where(e => e.Subscriber == patientID).FirstOrDefault();
                    var insuranceSubscriber = _InsuranceSubscribers.Where(e => e.Subscriber == patientID).FirstOrDefault();
                    if (insuranceSubscriber == null)
                    {
                        Inssub insSub = new Inssub();

                        insSub.InsSubNum = nextInsuranceSubscriberID;
                        insSub.PlanNum = InsPlan.PlanNum;
                        insSub.Subscriber = patientID;
                        insSub.SubscriberId = patientSSN;

                        // Values based on viewing the "insplan" table after manually adding
                        // a plan in Open Dental.
                        insSub.ReleaseInfo = 1;
                        insSub.AssignBen = 1;
                        insSub.SecUserNumEntry = 1;
                        insSub.SecDateEntry = DateTime.Now;
                        insSub.SecDateTedit = DateTime.Now;

                        // Required columns designated as NOT NULL in the MySQL schema.
                        insSub.BenefitNotes = "";

                        if (!is2ndGuarantor)
                        {
                            insSub.SubscNote = "Family 1st Insurance";
                        }
                        else
                        {
                            insSub.SubscNote = "Family 2nd Insurance";
                        }

                        nextInsuranceSubscriberID += 1;
                        // Add the in memory record to the Entity Framework connection 
                        // and update the screen counter display.
                        await dbOpenDentalContext.AddAsync(insSub);

                        // Add "insSub" record to in memory list.  Will speed up lookups and minimize DB writes.
                        _InsuranceSubscribers.Add(insSub);

                        await UpdateCounter("inssub");

                        Patplan patPlan = new Patplan();
                        patPlan.PatPlanNum = nextPatientPlanNumber;
                        patPlan.PatNum = patientID;
                        patPlan.Ordinal = 1;
                        patPlan.InsSubNum = insSub.InsSubNum;

                        // Add the in memory record to the Entity Framework connection 
                        // and update the screen counter display.
                        await dbOpenDentalContext.AddAsync(patPlan);

                        // Add "patPlan" record to in memory list.  Will speed up lookups and minimize DB writes.
                        _PatientPlans.Add(patPlan);

                        //await dbOpenDentalContext.SaveChangesAsync();
                        nextPatientPlanNumber += 1;

                        if (is2ndGuarantor) await UpdateCounter("2nd subscriber");

                        // The changes to the "inssub" table with be updated when the account record is saved.
                    }

                    // The changes to the "insplan" table with be updated when the account record is saved.
                }
            }
        }

        #region DisplayRelatedMethods

        async Task UpdateDisplay(string info)
        {
            conversionStatusUpdate = info;
            await Task.Delay(1);
            StateHasChanged();
        }

        async Task UpdateCounter(string tableName)
        {
            switch (tableName)
            {
                case "account":
                    CounterVariables.totalAccounts += 1;
                    break;
                case "inssub":
                    CounterVariables.totalInsuranceSubscribers += 1;
                    break;
                case "appointment":
                    CounterVariables.totalAppointments += 1;
                    break;
                case "carrier":
                    CounterVariables.totalInsuranceCompanies += 1;
                    break;
                case "insplan":
                    CounterVariables.totalInsurancePlans += 1;
                    break;
                case "employer":
                    CounterVariables.totalEmployers += 1;
                    break;
                case "fee":
                    CounterVariables.totalADACodes += 1;
                    break;
                case "medication":
                    CounterVariables.totalDrugs += 1;
                    break;
                case "medicationpat":
                    CounterVariables.totalPrescriptions += 1;
                    break;
                case "operatory":
                    CounterVariables.totalOperatories += 1;
                    break;
                case "patient":
                    CounterVariables.totalPatients += 1;
                    break;
                case "procedurelog":
                    CounterVariables.totalBillingTransactions += 1;
                    break;
                case "account transactions":
                    CounterVariables.totalAccountBillingTransactions += 1;
                    break;
                case "rxdef":
                    CounterVariables.totalRXDefinitions += 1;
                    break;
                case "provider":
                    ;
                    CounterVariables.totalDentists += 1;
                    break;
                case "referral":
                    CounterVariables.totalReferringDoctors += 1;
                    break;
                case "sd patients":
                    CounterVariables.sdPatients += 1;
                    break;
                case "plans updated":
                    CounterVariables.totalPlansUpdated += 1;
                    break;
                case "2nd guarantor":
                    CounterVariables.total2ndGuarantors += 1;
                    break;
                case "2nd subscriber":
                    CounterVariables.total2ndGuarantorInsuranceSubscribers += 1;
                    break;
                default:
                    break;
            }
            await Task.Delay(1);
            StateHasChanged();
        }

        #endregion

        #region ValidationMethods

        private string FormatADACodeForFeeSchedule(decimal ADACodeIN)
        {
            string ADACodeOUT = "";

            if (ADACodeIN.ToString().Contains(".00"))
            {
                ADACodeOUT = "D" + ADACodeIN.ToString("0000");
            }
            else
            {
                ADACodeOUT = "D" + ADACodeIN.ToString("0000.00");
            }

            return ADACodeOUT;
        }

        private int GetADACodeCategory(decimal ADACode)
        {
            int ProcedureCategory = 0;

            if (ADACode < 100)
            {
                ProcedureCategory = (int)ADACodeCategory.Never_Used;
            }
            else if (ADACode >= 100 && ADACode <= 999)
            {
                ProcedureCategory = (int)ADACodeCategory.ExamAndXray;
            }
            else if (ADACode >= 1000 && ADACode <= 1999)
            {
                ProcedureCategory = (int)ADACodeCategory.Cleaning;
            }
            else if (ADACode >= 2000 && ADACode <= 2999)
            {
                ProcedureCategory = (int)ADACodeCategory.Filling;
            }
            else if (ADACode >= 3000 && ADACode <= 3999)
            {
                ProcedureCategory = (int)ADACodeCategory.Endo;
            }
            else if (ADACode >= 4000 && ADACode <= 4999)
            {
                ProcedureCategory = (int)ADACodeCategory.Perio;
            }
            else if (ADACode >= 5000 && ADACode <= 5999)
            {
                ProcedureCategory = (int)ADACodeCategory.Dentures;
            }
            else if (ADACode >= 6000 && ADACode <= 6199)
            {
                ProcedureCategory = (int)ADACodeCategory.Implants;
            }
            else if (ADACode >= 7000 && ADACode <= 7999)
            {
                ProcedureCategory = (int)ADACodeCategory.OralSurg;
            }
            else if (ADACode >= 8000 && ADACode <= 8999)
            {
                ProcedureCategory = (int)ADACodeCategory.Ortho;
            }

            else if (ADACode >= 9000 && ADACode <= 9999)
            {
                ProcedureCategory = (int)ADACodeCategory.Misc;
            }

            if ((ADACode >= 2700 && ADACode <= 2999) || (ADACode >= 6200 && ADACode <= 6999))
            {
                ProcedureCategory = (int)ADACodeCategory.CrownAndBridge;
            }

            else if (ADACode >= 1500 && ADACode <= 1599)
            {
                ProcedureCategory = (int)ADACodeCategory.Ortho;
            }

            return ProcedureCategory;
        }

        private DateTime ValidateDateField(string dateFieldIN)
        {
            DateTime dateFieldOUT = Convert.ToDateTime("01/01/1901");

            if (dateFieldIN != "  /  /  ")
            {
                string year = dateFieldIN.ToString().Substring(6, 2);

                int twoDigitYear = int.Parse(year);
                int fourDigitYear = CultureInfo.CurrentCulture.Calendar.ToFourDigitYear(twoDigitYear);

                string tempDate = dateFieldOUT.Month.ToString() + "/" + dateFieldOUT.Day.ToString() + "/" + fourDigitYear.ToString();

                dateFieldOUT = Convert.ToDateTime(tempDate);
            }

            return dateFieldOUT;
        }

        private string ValidateSSN(string ssnIN)
        {
            string ssnOUT = ssnIN;
            ssnOUT = ssnOUT.Replace(" ", "");

            if (ssnOUT == "--") ssnOUT = "";

            return ssnOUT;
        }

        private string ValidatePhoneNumber(string phoneNumberIN)
        {
            string phoneNumberOUT = phoneNumberIN;

            if (phoneNumberOUT == "(   )   -    ")
            {
                phoneNumberOUT = "";
            }
            return phoneNumberOUT;
        }

        private byte ValidateGender(string genderIN)
        {
            byte genderOUT = (byte)Gender.Unknown;

            if (genderIN == "M")
            {
                genderOUT = (byte)Gender.Male;
            }
            else if (genderIN == "F")
            {
                genderOUT = (byte)Gender.Female;
            }

            return genderOUT;
        }

        private byte ValidateFamilyPosition(string familyPositionIN)
        {
            byte familyPositionOUT = (byte)FamilyPosition.Single;

            if (familyPositionIN == "M") familyPositionOUT = (byte)FamilyPosition.Married;

            return familyPositionOUT;
        }

        private byte ValidateBillingType(string billingCodeIN)
        {
            byte billingCodeOUT = (byte)BillingType.StandardAccount;

            if (billingCodeIN.Contains("C")) billingCodeOUT = (byte)BillingType.Collection;

            return billingCodeOUT;
        }

        private byte ValidatePatientStatus(string patientUserCodeIN)
        {
            byte patientUserCodeOut = 0;

            if (patientUserCodeIN.Contains("I")) patientUserCodeOut = (byte)PatientStatus.Inactive;

            return patientUserCodeOut;
        }

        #endregion

    }

}
