using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Softdent2OpenDentalConversion.Models.Softdent;

#nullable disable

namespace Softdent2OpenDentalConversion.Context.Softdent
{
    public partial class SoftdentContext : DbContext
    {
        public SoftdentContext()
        {
        }

        public SoftdentContext(DbContextOptions<SoftdentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ADACodes> ADACodes { get; set; }

        public virtual DbSet<ExplosionCodes> ExplosionCodes { get; set; }
        public virtual DbSet<SdAcct> SdAccts { get; set; }
        public virtual DbSet<SdAdum> SdAda { get; set; }
        public virtual DbSet<SdAppt> SdAppts { get; set; }
        public virtual DbSet<SdBlueBook> SdBlueBooks { get; set; }
        public virtual DbSet<SdContact> SdContacts { get; set; }
        public virtual DbSet<SdDentist> SdDentists { get; set; }
        public virtual DbSet<SdDrug> SdDrugs { get; set; }
        public virtual DbSet<SdEmpl> SdEmpls { get; set; }
        public virtual DbSet<SdExpCode> SdExpCodes { get; set; }
        public virtual DbSet<SdInsurco> SdInsurcos { get; set; }
        public virtual DbSet<SdPat> SdPats { get; set; }
        public virtual DbSet<SdPlan> SdPlans { get; set; }
        public virtual DbSet<SdRefDr> SdRefDrs { get; set; }
        public virtual DbSet<SdRefRpt> SdRefRpts { get; set; }
        public virtual DbSet<SdRx> SdRxes { get; set; }
        public virtual DbSet<SdTran> SdTrans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=EF-VS-DEV;Database=SoftdentDataConversions;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADACodes>(entity =>
            {
                entity.HasKey(e => e.ID);

                entity.ToTable("ADACodes");

                entity.Property(e => e.ID)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Code");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Description");

                entity.Property(e => e.CodeNumeric)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CodeNumeric");
            });

            modelBuilder.Entity<ExplosionCodes>(entity =>
            {
                entity.HasKey(e => e.ID);
 
                entity.ToTable("ExplosionCodes");
                
                entity.Property(e => e.ID)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
                
                entity.Property(e => e.ExplosionCode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ExplosionCode");
                
                entity.Property(e => e.ADACode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADACode");
            });
            
            modelBuilder.Entity<SdAcct>(entity =>
            {
                entity.HasKey(e => e.AcctId);

                entity.ToTable("SD_Acct");

                entity.Property(e => e.AcctId)
                    .ValueGeneratedNever()
                    .HasColumnName("Acct_ID");

                entity.Property(e => e.AcctDefaultDr)
                    .HasColumnName("Acct_DefaultDr")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AcctG1address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1Address");

                entity.Property(e => e.AcctG1birthday)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1Birthday");

                entity.Property(e => e.AcctG1city)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1City");

                entity.Property(e => e.AcctG1cmmethod)
                    .HasColumnName("Acct_G1CMMethod")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AcctG1empId)
                    .HasColumnName("Acct_G1EmpID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AcctG1fname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1FName");

                entity.Property(e => e.AcctG1gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1Gender");

                entity.Property(e => e.AcctG1hphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1HPhone");

                entity.Property(e => e.AcctG1lname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1LName");

                entity.Property(e => e.AcctG1marital)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1Marital");

                entity.Property(e => e.AcctG1medicaidId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1MedicaidID");

                entity.Property(e => e.AcctG1mname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1MName");

                entity.Property(e => e.AcctG1planDed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Acct_G1PlanDed");

                entity.Property(e => e.AcctG1planId)
                    .HasColumnName("Acct_G1PlanID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AcctG1ssn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1SSN");

                entity.Property(e => e.AcctG1state)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1State");

                entity.Property(e => e.AcctG1title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1Title");

                entity.Property(e => e.AcctG1wphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1WPhone");

                entity.Property(e => e.AcctG1zip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G1Zip");

                entity.Property(e => e.AcctG2address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2Address");

                entity.Property(e => e.AcctG2birthday)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2Birthday");

                entity.Property(e => e.AcctG2city)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2City");

                entity.Property(e => e.AcctG2empId)
                    .HasColumnName("Acct_G2EmpID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AcctG2fname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2FName");

                entity.Property(e => e.AcctG2gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2Gender");

                entity.Property(e => e.AcctG2hphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2HPhone");

                entity.Property(e => e.AcctG2lname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2LName");

                entity.Property(e => e.AcctG2marital)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2Marital");

                entity.Property(e => e.AcctG2medicaidId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2MedicaidID");

                entity.Property(e => e.AcctG2mname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2MName");

                entity.Property(e => e.AcctG2planDed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Acct_G2PlanDed");

                entity.Property(e => e.AcctG2planId)
                    .HasColumnName("Acct_G2PlanID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AcctG2ssn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2SSN");

                entity.Property(e => e.AcctG2state)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2State");

                entity.Property(e => e.AcctG2title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2Title");

                entity.Property(e => e.AcctG2wphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2WPhone");

                entity.Property(e => e.AcctG2zip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_G2Zip");

                //entity.Property(e => e.AcctG3address)
                //    .HasMaxLength(50)
                //    .IsUnicode(false)
                //    .HasColumnName("Acct_G3Address");

                //entity.Property(e => e.AcctG3birthday)
                //    .HasMaxLength(50)
                //    .IsUnicode(false)
                //    .HasColumnName("Acct_G3Birthday");

                //entity.Property(e => e.AcctG3city)
                //    .HasMaxLength(50)
                //    .IsUnicode(false)
                //    .HasColumnName("Acct_G3City");

                //entity.Property(e => e.AcctG3first)
                //    .HasMaxLength(50)
                //    .IsUnicode(false)
                //    .HasColumnName("Acct_G3First");

                //entity.Property(e => e.AcctG3gender)
                //    .HasMaxLength(50)
                //    .IsUnicode(false)
                //    .HasColumnName("Acct_G3Gender");

                //entity.Property(e => e.AcctG3hphone)
                //    .HasMaxLength(50)
                //    .IsUnicode(false)
                //    .HasColumnName("Acct_G3Hphone");

                //entity.Property(e => e.AcctG3last)
                //    .HasMaxLength(50)
                //    .IsUnicode(false)
                //    .HasColumnName("Acct_G3Last");

                //entity.Property(e => e.AcctG3middle)
                //    .HasMaxLength(50)
                //    .IsUnicode(false)
                //    .HasColumnName("Acct_G3Middle");

                //entity.Property(e => e.AcctG3ssn)
                //    .HasMaxLength(50)
                //    .IsUnicode(false)
                //    .HasColumnName("Acct_G3SSN");

                //entity.Property(e => e.AcctG3state)
                //    .HasMaxLength(50)
                //    .IsUnicode(false)
                //    .HasColumnName("Acct_G3State");

                //entity.Property(e => e.AcctG3wphone)
                //    .HasMaxLength(50)
                //    .IsUnicode(false)
                //    .HasColumnName("Acct_G3Wphone");

                //entity.Property(e => e.AcctG3zip)
                //    .HasMaxLength(50)
                //    .IsUnicode(false)
                //    .HasColumnName("Acct_G3Zip");

                entity.Property(e => e.AcctLastPmtDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_LastPmtDate");

                entity.Property(e => e.AcctLastStmtDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_LastStmtDate");

                entity.Property(e => e.AcctNotes1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_Notes1");

                entity.Property(e => e.AcctNotes2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_Notes2");

                entity.Property(e => e.AcctOfficeId).HasColumnName("Acct_OfficeID");

                entity.Property(e => e.AcctRegionalId).HasColumnName("Acct_RegionalID");

                entity.Property(e => e.AcctUserCodes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Acct_UserCodes");
            });

            modelBuilder.Entity<SdAdum>(entity =>
            {
                entity.HasKey(e => e.AdaCode);

                entity.ToTable("SD_ADA");

                entity.Property(e => e.AdaCode)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("ADA_Code");

                entity.Property(e => e.AdaDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADA_Description");

                entity.Property(e => e.AdaFee01)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADA_Fee01");

                entity.Property(e => e.AdaFee02)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADA_Fee02");

                entity.Property(e => e.AdaFee03)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADA_Fee03");

                entity.Property(e => e.AdaFee04)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADA_Fee04");

                entity.Property(e => e.AdaFee05)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADA_Fee05");

                entity.Property(e => e.AdaFee06)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADA_Fee06");

                entity.Property(e => e.AdaFee07)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADA_Fee07");

                entity.Property(e => e.AdaFee08)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADA_Fee08");

                entity.Property(e => e.AdaFee09)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADA_Fee09");

                entity.Property(e => e.AdaFee10)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ADA_Fee10");

                entity.Property(e => e.AdaShortDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADA_ShortDesc");

                entity.Property(e => e.AdaTimeUnits)
                    .HasColumnName("ADA_TimeUnits")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SdAppt>(entity =>
            {
                entity.HasKey(e => e.ApptPatId);

                entity.ToTable("SD_Appt");

                entity.Property(e => e.ApptPatId)
                    .ValueGeneratedNever()
                    .HasColumnName("Appt_PatID");

                entity.Property(e => e.ApptAdacode)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Appt_ADACode");

                entity.Property(e => e.ApptAdacode2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Appt_ADACode2");

                entity.Property(e => e.ApptAdacode3)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Appt_ADACode3");

                entity.Property(e => e.ApptAdacode4)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Appt_ADACode4");

                entity.Property(e => e.ApptAdacode5)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Appt_ADACode5");

                entity.Property(e => e.ApptAdacode6)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Appt_ADACode6");

                entity.Property(e => e.ApptAdadesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_ADADesc");

                entity.Property(e => e.ApptChartId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_ChartID");

                entity.Property(e => e.ApptDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Date");

                entity.Property(e => e.ApptDentist).HasColumnName("Appt_Dentist");

                entity.Property(e => e.ApptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Name");

                entity.Property(e => e.ApptOperatory).HasColumnName("Appt_Operatory");

                entity.Property(e => e.ApptSurface1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Surface1");

                entity.Property(e => e.ApptSurface2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Surface2");

                entity.Property(e => e.ApptSurface3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Surface3");

                entity.Property(e => e.ApptSurface4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Surface4");

                entity.Property(e => e.ApptSurface5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Surface5");

                entity.Property(e => e.ApptSurface6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Surface6");

                entity.Property(e => e.ApptTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Time");

                entity.Property(e => e.ApptTimeUnits).HasColumnName("Appt_TimeUnits");

                entity.Property(e => e.ApptTooth1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Tooth1");

                entity.Property(e => e.ApptTooth2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Tooth2");

                entity.Property(e => e.ApptTooth3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Tooth3");

                entity.Property(e => e.ApptTooth4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Tooth4");

                entity.Property(e => e.ApptTooth5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Tooth5");

                entity.Property(e => e.ApptTooth6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appt_Tooth6");
            });

            modelBuilder.Entity<SdBlueBook>(entity =>
            {
                entity.HasKey(e => e.BlueBookPlanId);

                entity.ToTable("SD_BlueBook");

                entity.Property(e => e.BlueBookPlanId)
                    .ValueGeneratedNever()
                    .HasColumnName("BlueBook_PlanID");

                entity.Property(e => e.BlueBookAdjSvc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_AdjSvc");

                entity.Property(e => e.BlueBookCrown)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_Crown");

                entity.Property(e => e.BlueBookDiagnostic)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_Diagnostic");

                entity.Property(e => e.BlueBookEffectiveMonth).HasColumnName("BlueBook_EffectiveMonth");

                entity.Property(e => e.BlueBookEndo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_Endo");

                entity.Property(e => e.BlueBookFamDed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_FamDed");

                entity.Property(e => e.BlueBookFormNum).HasColumnName("BlueBook_FormNum");

                entity.Property(e => e.BlueBookGroupNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BlueBook_GroupNum");

                entity.Property(e => e.BlueBookIndDed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_IndDed");

                entity.Property(e => e.BlueBookInscoName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BlueBook_InscoName");

                entity.Property(e => e.BlueBookMaxCov)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_MaxCov");

                entity.Property(e => e.BlueBookOralSurg)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_OralSurg");

                entity.Property(e => e.BlueBookOrtho)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_Ortho");

                entity.Property(e => e.BlueBookOrthoMax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_OrthoMax");

                entity.Property(e => e.BlueBookPerio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_Perio");

                entity.Property(e => e.BlueBookPlanName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BlueBook_PlanName");

                entity.Property(e => e.BlueBookPreventative)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_Preventative");

                entity.Property(e => e.BlueBookPriorAuth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BlueBook_PriorAuth");

                entity.Property(e => e.BlueBookProstF)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_ProstF");

                entity.Property(e => e.BlueBookProstR)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_ProstR");

                entity.Property(e => e.BlueBookRestorative)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_Restorative");

                entity.Property(e => e.BlueBookXray)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BlueBook_Xray");
            });

            modelBuilder.Entity<SdContact>(entity =>
            {
                entity.ToTable("SD_Contacts");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DateMade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Date_Made");

                entity.Property(e => e.MadeBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Made_By");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Regarding)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SdDentist>(entity =>
            {
                entity.HasKey(e => e.ProvId);

                entity.ToTable("SD_Dentist");

                entity.Property(e => e.ProvId)
                    .ValueGeneratedNever()
                    .HasColumnName("Prov_ID");

                entity.Property(e => e.ProvAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_Address");

                entity.Property(e => e.ProvBcbsid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_BCBSID");

                entity.Property(e => e.ProvBirthday)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_Birthday");

                entity.Property(e => e.ProvCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_City");

                entity.Property(e => e.ProvDeaid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_DEAID");

                entity.Property(e => e.ProvDegree)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_Degree");

                entity.Property(e => e.ProvDeltaId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_DeltaID");

                entity.Property(e => e.ProvFirst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_First");

                entity.Property(e => e.ProvHomeAddr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_HomeAddr");

                entity.Property(e => e.ProvHomeCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_HomeCity");

                entity.Property(e => e.ProvHomePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_HomePhone");

                entity.Property(e => e.ProvHomeState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_HomeState");

                entity.Property(e => e.ProvHomeZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_HomeZipCode");

                entity.Property(e => e.ProvLast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_Last");

                entity.Property(e => e.ProvLicNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_LicNo");

                entity.Property(e => e.ProvMiddle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_Middle");

                entity.Property(e => e.ProvNotes)
                    .IsUnicode(false)
                    .HasColumnName("Prov_Notes");

                entity.Property(e => e.ProvPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_Phone");

                entity.Property(e => e.ProvSsn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_SSN");

                entity.Property(e => e.ProvState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_State");

                entity.Property(e => e.ProvTin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_TIN");

                entity.Property(e => e.ProvTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_Title");

                entity.Property(e => e.ProvType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_Type");

                entity.Property(e => e.ProvZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Prov_ZipCode");
            });

            modelBuilder.Entity<SdDrug>(entity =>
            {
                entity.HasKey(e => e.DrugId);

                entity.ToTable("SD_Drug");

                entity.Property(e => e.DrugId)
                    .ValueGeneratedNever()
                    .HasColumnName("Drug_ID");

                entity.Property(e => e.DrugName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Drug_Name");

                entity.Property(e => e.DrugQty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Drug_Qty");

                entity.Property(e => e.DrugRx)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Drug_RX");
            });

            modelBuilder.Entity<SdEmpl>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("SD_Empl");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("Emp_ID");

                entity.Property(e => e.EmpAddr1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Addr1");

                entity.Property(e => e.EmpAddr2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Addr2");

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Emp_City");

                entity.Property(e => e.EmpContact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Contact");

                entity.Property(e => e.EmpFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Fax");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Name");

                entity.Property(e => e.EmpPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Phone");

                entity.Property(e => e.EmpState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Emp_State");

                entity.Property(e => e.EmpZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Emp_ZipCode");
            });

            modelBuilder.Entity<SdExpCode>(entity =>
            {
                entity.HasKey(e => e.EcEcode);

                entity.ToTable("SD_ExpCodes");

                entity.Property(e => e.EcEcode)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("EC_ECode");

                entity.Property(e => e.EcAdacode)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("EC_ADACode");
            });

            modelBuilder.Entity<SdInsurco>(entity =>
            {
                entity.HasKey(e => e.InsId);

                entity.ToTable("SD_Insurco");

                entity.Property(e => e.InsId)
                    .ValueGeneratedNever()
                    .HasColumnName("Ins_ID");

                entity.Property(e => e.InsAddr1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ins_Addr1");

                entity.Property(e => e.InsAddr2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ins_Addr2");

                entity.Property(e => e.InsCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ins_City");

                entity.Property(e => e.InsContact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ins_Contact");

                entity.Property(e => e.InsEscid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ins_ESCID");

                entity.Property(e => e.InsFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ins_Fax");

                entity.Property(e => e.InsName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ins_Name");

                entity.Property(e => e.InsPhone1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ins_Phone1");

                entity.Property(e => e.InsPhone2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ins_Phone2");

                entity.Property(e => e.InsState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ins_State");

                entity.Property(e => e.InsZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ins_ZipCode");
            });

            modelBuilder.Entity<SdPat>(entity =>
            {
                entity.HasKey(e => e.PatId);

                entity.ToTable("SD_Pat");

                entity.Property(e => e.PatId)
                    .ValueGeneratedNever()
                    .HasColumnName("Pat_ID");

                entity.Property(e => e.PatAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Address");

                entity.Property(e => e.PatArbalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Pat_ARBalance");

                entity.Property(e => e.PatBirthday)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Birthday");

                entity.Property(e => e.PatCellPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_CellPhone");

                entity.Property(e => e.PatChartId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_ChartID");

                entity.Property(e => e.PatCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_City");

                entity.Property(e => e.PatDocId).HasColumnName("Pat_DocID");

                entity.Property(e => e.PatDueBackDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_DueBackDate");

                entity.Property(e => e.PatEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Email");

                entity.Property(e => e.PatFeeSched).HasColumnName("Pat_FeeSched");

                entity.Property(e => e.PatFirstVisit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_FirstVisit");

                entity.Property(e => e.PatFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_FName");

                entity.Property(e => e.PatGender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Gender");

                entity.Property(e => e.PatHphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_HPhone");

                entity.Property(e => e.PatHygId).HasColumnName("Pat_HygID");

                entity.Property(e => e.PatIns1MedicaidId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Ins1MedicaidID");

                entity.Property(e => e.PatIns1RelDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Ins1RelDesc");

                entity.Property(e => e.PatInsDed1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Pat_InsDed1");

                entity.Property(e => e.PatInsDed2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Pat_InsDed2");

                entity.Property(e => e.PatInsRel1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_InsRel1");

                entity.Property(e => e.PatInsRel2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_InsRel2");

                entity.Property(e => e.PatLastBiteWing)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_LastBiteWing");

                entity.Property(e => e.PatLastExam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_LastExam");

                entity.Property(e => e.PatLastFullSeries)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_LastFullSeries");

                entity.Property(e => e.PatLastMedHistory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_LastMedHistory");

                entity.Property(e => e.PatLastPanoral)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_LastPanoral");

                entity.Property(e => e.PatLastPerioChart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_LastPerioChart");

                entity.Property(e => e.PatLastUpdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_LastUpdate");

                entity.Property(e => e.PatLastVisit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_LastVisit");

                entity.Property(e => e.PatLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_LName");

                entity.Property(e => e.PatMarital)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Marital");

                entity.Property(e => e.PatMedAlert)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_MedAlert");

                entity.Property(e => e.PatMname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_MName");

                entity.Property(e => e.PatNickname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Nickname");

                entity.Property(e => e.PatNotes1)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Notes1");

                entity.Property(e => e.PatNotes2)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Notes2");

                entity.Property(e => e.PatRecallCode)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Pat_RecallCode");

                entity.Property(e => e.PatRecallInt).HasColumnName("Pat_RecallInt");

                entity.Property(e => e.PatRecallTimeUnits).HasColumnName("Pat_RecallTimeUnits");

                entity.Property(e => e.PatRefDrId).HasColumnName("Pat_RefDrID");

                entity.Property(e => e.PatRpId).HasColumnName("Pat_RpID");

                entity.Property(e => e.PatSdoffice).HasColumnName("Pat_SDOffice");

                entity.Property(e => e.PatSsn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_SSN");

                entity.Property(e => e.PatState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_State");

                entity.Property(e => e.PatTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Title");

                entity.Property(e => e.PatUserCodes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_UserCodes");

                entity.Property(e => e.PatWphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_WPhone");

                entity.Property(e => e.PatZip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Zip");
            });

            modelBuilder.Entity<SdPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("SD_Plan");

                entity.Property(e => e.PlanId)
                    .ValueGeneratedNever()
                    .HasColumnName("Plan_ID");

                entity.Property(e => e.PlanElPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plan_ElPhone");

                entity.Property(e => e.PlanFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plan_Fax");

                entity.Property(e => e.PlanGroupNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plan_GroupNo");

                entity.Property(e => e.PlanInscoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plan_InscoID");

                entity.Property(e => e.PlanName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plan_Name");

                entity.Property(e => e.PlanPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plan_Phone");
            });

            modelBuilder.Entity<SdRefDr>(entity =>
            {
                entity.HasKey(e => e.RefDrId);

                entity.ToTable("SD_RefDr");

                entity.Property(e => e.RefDrId)
                    .ValueGeneratedNever()
                    .HasColumnName("RefDr_ID");

                entity.Property(e => e.RefDrAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefDr_Address");

                entity.Property(e => e.RefDrCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefDr_City");

                entity.Property(e => e.RefDrFirst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefDr_First");

                entity.Property(e => e.RefDrLast)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefDr_Last");

                entity.Property(e => e.RefDrMiddle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefDr_Middle");

                entity.Property(e => e.RefDrPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefDr_Phone");

                entity.Property(e => e.RefDrProvId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefDr_ProvID");

                entity.Property(e => e.RefDrSpecialty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefDr_Specialty");

                entity.Property(e => e.RefDrSpecialtyId).HasColumnName("RefDr_SpecialtyID");

                entity.Property(e => e.RefDrState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefDr_State");

                entity.Property(e => e.RefDrTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefDr_Title");

                entity.Property(e => e.RefDrZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RefDr_ZipCode");
            });

            modelBuilder.Entity<SdRefRpt>(entity =>
            {
                entity.HasKey(e => e.RefDrId);

                entity.ToTable("SD_RefRpt");

                entity.Property(e => e.RefDrId)
                    .ValueGeneratedNever()
                    .HasColumnName("RefDr_ID");

                entity.Property(e => e.PatId).HasColumnName("Pat_ID");

                entity.Property(e => e.RefDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Date");
            });

            modelBuilder.Entity<SdRx>(entity =>
            {
                entity.ToTable("SD_RX");
                entity.HasNoKey();

                entity.Property(e => e.RxDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RX_Date");

                entity.Property(e => e.RxDrId).HasColumnName("RX_DrID");

                entity.Property(e => e.RxDrugId).HasColumnName("RX_DrugID");

                entity.Property(e => e.RxDrugName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RX_DrugName");

                entity.Property(e => e.RxDrugQty)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RX_DrugQty");

                entity.Property(e => e.RxDrugRefills).HasColumnName("RX_DrugRefills");

                entity.Property(e => e.RxPatId).HasColumnName("RX_PatID");
            });

            modelBuilder.Entity<SdTran>(entity =>
            {
                entity.ToTable("SD_Trans");
                entity.HasNoKey();

                entity.Property(e => e.TransCash)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Trans_Cash");

                entity.Property(e => e.TransCharges)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Trans_Charges");

                entity.Property(e => e.TransChecks)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Trans_Checks");

                entity.Property(e => e.TransCode)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Trans_Code");

                entity.Property(e => e.TransCodeType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Trans_CodeType");

                entity.Property(e => e.TransCredit)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Trans_Credit");

                entity.Property(e => e.TransD).HasColumnName("Trans_D$");

                entity.Property(e => e.TransDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.TransDr).HasColumnName("Trans_Dr");

                entity.Property(e => e.TransPatId).HasColumnName("Trans_PatID");

                entity.Property(e => e.TransPatName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Trans_PatName");

                entity.Property(e => e.TransPayAdj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Trans_PayAdj");

                entity.Property(e => e.TransProd)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Trans_Prod");

                entity.Property(e => e.TransProdAdj)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Trans_ProdAdj");

                entity.Property(e => e.TransSurface)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Trans_Surface");

                entity.Property(e => e.TransTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("Trans_Tax");

                entity.Property(e => e.TransTooth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Trans_Tooth");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
