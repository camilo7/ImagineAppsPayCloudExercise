using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ImagineAppsPayCloud.DB;

public partial class CheckPlus235Context : DbContext
{
    public CheckPlus235Context()
    {
    }

    public CheckPlus235Context(DbContextOptions<CheckPlus235Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AchbatchCntrlRec> AchbatchCntrlRecs { get; set; }

    public virtual DbSet<AchbatchDetail> AchbatchDetails { get; set; }

    public virtual DbSet<AchbatchHeadRec> AchbatchHeadRecs { get; set; }

    public virtual DbSet<AchfileCntrlRec> AchfileCntrlRecs { get; set; }

    public virtual DbSet<AchfileHeadRec> AchfileHeadRecs { get; set; }

    public virtual DbSet<Achqueue> Achqueues { get; set; }

    public virtual DbSet<Achtemplate> Achtemplates { get; set; }

    public virtual DbSet<AsaltSignat> AsaltSignats { get; set; }

    public virtual DbSet<Audit> Audits { get; set; }

    public virtual DbSet<AuthSignBank> AuthSignBanks { get; set; }

    public virtual DbSet<AuthSignCompany> AuthSignCompanies { get; set; }

    public virtual DbSet<AuthSignature> AuthSignatures { get; set; }

    public virtual DbSet<AutoNum> AutoNums { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<BatchSignatory> BatchSignatories { get; set; }

    public virtual DbSet<BtchDet> BtchDets { get; set; }

    public virtual DbSet<CbooksBankFin> CbooksBankFins { get; set; }

    public virtual DbSet<CbooksBranchesFin> CbooksBranchesFins { get; set; }

    public virtual DbSet<CbooksCbooksPrint> CbooksCbooksPrints { get; set; }

    public virtual DbSet<CbooksCbooksReq> CbooksCbooksReqs { get; set; }

    public virtual DbSet<CbooksChkBooksEntry> CbooksChkBooksEntries { get; set; }

    public virtual DbSet<CbooksImportHeader> CbooksImportHeaders { get; set; }

    public virtual DbSet<CbooksMicrline> CbooksMicrlines { get; set; }

    public virtual DbSet<CbooksSynonym> CbooksSynonyms { get; set; }

    public virtual DbSet<CbooksTypeOfAccount> CbooksTypeOfAccounts { get; set; }

    public virtual DbSet<ChecksD1> ChecksD1s { get; set; }

    public virtual DbSet<ChecksH3> ChecksH3s { get; set; }

    public virtual DbSet<ClientLocation> ClientLocations { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CustomFont> CustomFonts { get; set; }

    public virtual DbSet<DatabasesC> DatabasesCs { get; set; }

    public virtual DbSet<EAlertAuditLog> EAlertAuditLogs { get; set; }

    public virtual DbSet<EAlertCustom> EAlertCustoms { get; set; }

    public virtual DbSet<EAlertEmail> EAlertEmails { get; set; }

    public virtual DbSet<EAlertEvent> EAlertEvents { get; set; }

    public virtual DbSet<EAlertWildcard> EAlertWildcards { get; set; }

    public virtual DbSet<EalertsSamplePatern> EalertsSamplePaterns { get; set; }

    public virtual DbSet<ElegiblePrinter> ElegiblePrinters { get; set; }

    public virtual DbSet<EmailCustomization> EmailCustomizations { get; set; }

    public virtual DbSet<EmailPref> EmailPrefs { get; set; }

    public virtual DbSet<EventsSource> EventsSources { get; set; }

    public virtual DbSet<FeesTable> FeesTables { get; set; }

    public virtual DbSet<FieldsList> FieldsLists { get; set; }

    public virtual DbSet<Fontlist> Fontlists { get; set; }

    public virtual DbSet<FormItemEntity> FormItemEntities { get; set; }

    public virtual DbSet<Format> Formats { get; set; }

    public virtual DbSet<FtptransProf> FtptransProfs { get; set; }

    public virtual DbSet<GenParBlank> GenParBlanks { get; set; }

    public virtual DbSet<GenParamManCheck> GenParamManChecks { get; set; }

    public virtual DbSet<GenSysPar> GenSysPars { get; set; }

    public virtual DbSet<GenSysUser> GenSysUsers { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupRight> GroupRights { get; set; }

    public virtual DbSet<IeScreenDet> IeScreenDets { get; set; }

    public virtual DbSet<IeScreenHead> IeScreenHeads { get; set; }

    public virtual DbSet<Iedetail> Iedetails { get; set; }

    public virtual DbSet<Ieheader> Ieheaders { get; set; }

    public virtual DbSet<IelayoutLineItemX> IelayoutLineItemXes { get; set; }

    public virtual DbSet<IelayoutLineheader> IelayoutLineheaders { get; set; }

    public virtual DbSet<IelayoutlineItem> IelayoutlineItems { get; set; }

    public virtual DbSet<IesortDefinit> IesortDefinits { get; set; }

    public virtual DbSet<Ietemplate> Ietemplates { get; set; }

    public virtual DbSet<ImpCheckLog> ImpCheckLogs { get; set; }

    public virtual DbSet<ImportHeader> ImportHeaders { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<MicrlineLayout> MicrlineLayouts { get; set; }

    public virtual DbSet<OutDataMapMaindet> OutDataMapMaindets { get; set; }

    public virtual DbSet<OutDataMapMainhead> OutDataMapMainheads { get; set; }

    public virtual DbSet<OutMapDetailsStub> OutMapDetailsStubs { get; set; }

    public virtual DbSet<OutMapHeadStub> OutMapHeadStubs { get; set; }

    public virtual DbSet<Payee> Payees { get; set; }

    public virtual DbSet<Payor> Payors { get; set; }

    public virtual DbSet<PclCheck> PclChecks { get; set; }

    public virtual DbSet<PclStub> PclStubs { get; set; }

    public virtual DbSet<PosPayProf> PosPayProfs { get; set; }

    public virtual DbSet<PropertyPcl> PropertyPcls { get; set; }

    public virtual DbSet<ReconcBtchDet> ReconcBtchDets { get; set; }

    public virtual DbSet<ReconcChecksH3> ReconcChecksH3s { get; set; }

    public virtual DbSet<ReconcImportHeader> ReconcImportHeaders { get; set; }

    public virtual DbSet<ReportsXright> ReportsXrights { get; set; }

    public virtual DbSet<Right> Rights { get; set; }

    public virtual DbSet<SignComboD> SignComboDs { get; set; }

    public virtual DbSet<SignComboH> SignComboHs { get; set; }

    public virtual DbSet<SignatCostCenter> SignatCostCenters { get; set; }

    public virtual DbSet<SynLinkChildDoc> SynLinkChildDocs { get; set; }

    public virtual DbSet<Synonym> Synonyms { get; set; }

    public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }

    public virtual DbSet<TemplatesxPrinter> TemplatesxPrinters { get; set; }

    public virtual DbSet<TemplatesxPrintersAll> TemplatesxPrintersAlls { get; set; }

    public virtual DbSet<TemplatesxPrintersByUsersCheckBook> TemplatesxPrintersByUsersCheckBooks { get; set; }

    public virtual DbSet<TemplatesxPrintersByUsersManageCheck> TemplatesxPrintersByUsersManageChecks { get; set; }

    public virtual DbSet<TemplatesxPrintersPcsNetwork> TemplatesxPrintersPcsNetworks { get; set; }

    public virtual DbSet<TemplatesxPrintersSplit> TemplatesxPrintersSplits { get; set; }

    public virtual DbSet<TemplxPrinterSecurityFeat> TemplxPrinterSecurityFeats { get; set; }

    public virtual DbSet<TraysXlayoutPool> TraysXlayoutPools { get; set; }

    public virtual DbSet<TypesAccount> TypesAccounts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    public virtual DbSet<UserPassHistory> UserPassHistories { get; set; }

    public virtual DbSet<UserRight> UserRights { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=Camilo\\SQLEXPRESS;Database=CheckPlus_235;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => new { e.BankId, e.AccountId });

            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .HasColumnName("Bank_ID");
            entity.Property(e => e.AccountId)
                .HasMaxLength(50)
                .HasColumnName("Account_ID");
            entity.Property(e => e.AccountName)
                .HasMaxLength(70)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .HasColumnName("Account_Number");
            entity.Property(e => e.BranchId)
                .HasMaxLength(10)
                .HasColumnName("BranchID");
            entity.Property(e => e.CheckType).HasMaxLength(10);
            entity.Property(e => e.CheckTypf).HasMaxLength(10);
            entity.Property(e => e.CheckbookId).HasMaxLength(15);
            entity.Property(e => e.Filler1)
                .HasMaxLength(8)
                .HasColumnName("filler1");
            entity.Property(e => e.Filler2)
                .HasMaxLength(10)
                .HasColumnName("FILLER2");
            entity.Property(e => e.FirstCheckNo).HasColumnType("smallmoney");
            entity.Property(e => e.FontId)
                .HasMaxLength(10)
                .HasColumnName("FontID");
            entity.Property(e => e.Laguage).HasMaxLength(15);
            entity.Property(e => e.Line2).HasMaxLength(30);
            entity.Property(e => e.Line3).HasMaxLength(30);
            entity.Property(e => e.Line4).HasMaxLength(30);
            entity.Property(e => e.LineAddr1).HasMaxLength(30);
            entity.Property(e => e.Mask).HasMaxLength(24);
            entity.Property(e => e.PayorId)
                .HasMaxLength(22)
                .HasColumnName("PayorID");
        });

        modelBuilder.Entity<AchbatchCntrlRec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACHBatch_cntrl_rec", tb => tb.HasTrigger("TRG_ACHBatch_cntrl_rec"));

            entity.Property(e => e.BatchNumber).HasDefaultValueSql("((0))");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CompanyID");
            entity.Property(e => e.EntryAddendaCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.EntryHash)
                .HasDefaultValueSql("((0))")
                .HasColumnType("smallmoney");
            entity.Property(e => e.MessageAuthCd)
                .HasMaxLength(19)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.OriginatingDfiId)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("OriginatingDFI_Id");
            entity.Property(e => e.RecordTypeCode)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Reserved)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("RESERVED");
            entity.Property(e => e.ServiceClassCode).HasDefaultValueSql("((0))");
            entity.Property(e => e.TotCreditAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.TotDebitAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<AchbatchDetail>(entity =>
        {
            entity.HasKey(e => e.BatchId);

            entity.ToTable("ACHBatchDetails", tb => tb.HasTrigger("TRG_ACHBatchDetails"));

            entity.Property(e => e.BatchId)
                .ValueGeneratedNever()
                .HasColumnName("Batch_ID");
            entity.Property(e => e.AchwhileProcessingFl)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ACHwhileProcessingFL");
            entity.Property(e => e.AllAchGeneratedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.AllChecksPrintedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.Alpha12)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.AutorizedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.BatchImportDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.BatchPostedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.BatchPurgeDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.BatchPurgedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.BatchType)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Date1).HasDefaultValueSql("((0))");
            entity.Property(e => e.Date2).HasDefaultValueSql("((0))");
            entity.Property(e => e.Date3).HasDefaultValueSql("((0))");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Filler15)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("FILLER15");
            entity.Property(e => e.ImportDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.ImportTime).HasDefaultValueSql("((0))");
            entity.Property(e => e.Logical1).HasDefaultValueSql("((0))");
            entity.Property(e => e.Numeric10)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.OtherInfo)
                .HasMaxLength(78)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Password1)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("password1");
            entity.Property(e => e.Password2)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("password2");
            entity.Property(e => e.PayorId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PayorID");
            entity.Property(e => e.Posted2AchbookQ)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Posted2ACHbookQ");
            entity.Property(e => e.ServerRefresedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.Time1).HasDefaultValueSql("((0))");
            entity.Property(e => e.Time2).HasDefaultValueSql("((0))");
            entity.Property(e => e.TotalAcknowledged)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.TotalAmountValue)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.TotalChecksInBatch).HasDefaultValueSql("((0))");
            entity.Property(e => e.UserBatchId)
                .HasMaxLength(14)
                .HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.Batch).WithOne(p => p.AchbatchDetail)
                .HasForeignKey<AchbatchDetail>(d => d.BatchId)
                .HasConstraintName("FK_ACHBatchDetails_ACHBatchDetails");
        });

        modelBuilder.Entity<AchbatchHeadRec>(entity =>
        {
            entity.HasKey(e => e.BatchNumber);

            entity.ToTable("ACHbatch_head_rec", tb => tb.HasTrigger("TRG_ACHbatch_head_rec"));

            entity.HasIndex(e => e.BatchNumber, "key0")
                .IsUnique()
                .HasFillFactor(30);

            entity.Property(e => e.BatchNumber).ValueGeneratedNever();
            entity.Property(e => e.CompanyDescriptiveDa)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyDiscretionary)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyEntryDescript)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyIdentificatio)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.EffectiveEntryDate)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.OriginatingDfiIdent)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("OriginatingDFI_Ident");
            entity.Property(e => e.OriginatorStatusCode)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RecordTypeCode)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ServiceClassCode).HasDefaultValueSql("((0))");
            entity.Property(e => e.SettlementDateJulia)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SettlementDate(Julia");
            entity.Property(e => e.StandardEntryClassCo)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<AchfileCntrlRec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACHFile_Cntrl_rec", tb => tb.HasTrigger("TRG_ACHFile_Cntrl_rec"));

            entity.Property(e => e.BatchCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.BlockCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.EntryAddendaCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.EntryHash)
                .HasDefaultValueSql("((0))")
                .HasColumnType("smallmoney");
            entity.Property(e => e.RecordTypeCode)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Reserved)
                .HasMaxLength(39)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.TopCreditAmnt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.TotDebitAmnt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
        });

        modelBuilder.Entity<AchfileHeadRec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACHfile_head_rec", tb => tb.HasTrigger("TRG_ACHfile_head_rec"));

            entity.Property(e => e.BlockingFactor)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FileCreationDate)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FileCreationTime)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FileIdmodifier)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("FileIDModifier");
            entity.Property(e => e.FormatCode)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.InmediateDestination)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.InmediateDestinatioo)
                .HasMaxLength(23)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.InmediateOrigin)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.InmediateOriginName)
                .HasMaxLength(23)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PriorityCode).HasDefaultValueSql("((0))");
            entity.Property(e => e.RecordSize)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RecordTypeCode)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ReferenceCode)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<Achqueue>(entity =>
        {
            entity.HasKey(e => new { e.BatchId, e.RecordNo });

            entity.ToTable("ACHQueue", tb => tb.HasTrigger("TRG_ACHQueue"));

            entity.Property(e => e.BatchId).HasColumnName("Batch_ID");
            entity.Property(e => e.RecordNo).HasColumnName("Record_No");
            entity.Property(e => e.AccountId)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Account_ID");
            entity.Property(e => e.AccountType)
                .HasMaxLength(35)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Account_Type");
            entity.Property(e => e.AchStdEntryClassCode)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("achStdEntryClassCode");
            entity.Property(e => e.AchTranCode)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("achTranCode");
            entity.Property(e => e.AchTypeAcct)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("achTypeAcct");
            entity.Property(e => e.AchaddendaQ)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACHAddendaQ");
            entity.Property(e => e.Achq)
                .HasDefaultValueSql("(N'0')")
                .HasColumnName("ACHQ");
            entity.Property(e => e.AchreEnableQ)
                .HasDefaultValueSql("(N'0')")
                .HasColumnName("ACHRe_EnableQ");
            entity.Property(e => e.AchroutingCdv)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ACHroutingCDV");
            entity.Property(e => e.AdditionalUserId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("AdditionalUserID");
            entity.Property(e => e.BankAddr1)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BankAddr2)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Bank_ID");
            entity.Property(e => e.BankName)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BarCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BatchIdr)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BatchIDR");
            entity.Property(e => e.Cdv2)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CDV2");
            entity.Property(e => e.CdvAccountNo)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CDV_Account_No");
            entity.Property(e => e.CheckAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.CheckAmountAlpha)
                .HasMaxLength(120)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CheckDate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Check_Date");
            entity.Property(e => e.CheckDateAlpha)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CheckDateYear).HasDefaultValueSql("((0))");
            entity.Property(e => e.CheckNo)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Check_No");
            entity.Property(e => e.CheckPrintedDateTime)
                .HasDefaultValueSql("(((1)/(1))/(1))")
                .HasColumnType("datetime");
            entity.Property(e => e.CheckType)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.City)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ClaimOrPurchaseOrde)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Claim_orPurchaseOrde");
            entity.Property(e => e.ClientLocation)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Concept1)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Concept2)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Concept3)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Concept4)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ConsecutiveNumber)
                .HasMaxLength(13)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Contact)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CopyPrinted).HasDefaultValueSql("((0))");
            entity.Property(e => e.CostCenter4Sign)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Counter).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreationDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreationTime).HasDefaultValueSql("((0))");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.DateAlphaY2k)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("DateAlphaY2K");
            entity.Property(e => e.DfiacctNo)
                .HasMaxLength(17)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("DFIacctNo");
            entity.Property(e => e.DirectDepositAccNumb)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DirectDepositBankNam)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Discounttotal)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.DontSendEmail).HasDefaultValueSql("((0))");
            entity.Property(e => e.EarnDeductAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("email");
            entity.Property(e => e.EncryptAmount).HasMaxLength(100);
            entity.Property(e => e.EncryptCheckNo).HasMaxLength(100);
            entity.Property(e => e.EncryptPayee).HasMaxLength(140);
            entity.Property(e => e.ExportQ).HasDefaultValueSql("(N'0')");
            entity.Property(e => e.Filler15)
                .HasMaxLength(33)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler15");
            entity.Property(e => e.ForTheAccountOf)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("For_the_account_of");
            entity.Property(e => e.GlCredit)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("GL_Credit");
            entity.Property(e => e.GlDebit)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("GL_Debit");
            entity.Property(e => e.GlacctReference)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("GLAcctReference");
            entity.Property(e => e.Grosstotal)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.ImportDate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Import_Date");
            entity.Property(e => e.InvoiceDate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Invoice_Date");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Irscode)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("IRScode");
            entity.Property(e => e.NumberofSignatures).HasDefaultValueSql("((0))");
            entity.Property(e => e.PayeeAddr1)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeAddr2)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeAddr3)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeAddr4)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeAddr5)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeId)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PayeeID");
            entity.Property(e => e.PayeeName)
                .HasMaxLength(70)
                .HasDefaultValueSql("('VOID VOID')");
            entity.Property(e => e.PayeeName2)
                .HasMaxLength(48)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayorId)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PayorID");
            entity.Property(e => e.PayorName)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Payor_Name");
            entity.Property(e => e.Pdfname)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PDFName");
            entity.Property(e => e.PdfuniqueNameQ)
                .HasDefaultValueSql("(N'1')")
                .HasColumnName("PDFUniqueNameQ");
            entity.Property(e => e.PositivePayQ).HasDefaultValueSql("(N'0')");
            entity.Property(e => e.Printed).HasDefaultValueSql("((0))");
            entity.Property(e => e.PrintedBy)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Printed_By");
            entity.Property(e => e.PrintedDate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Printed_Date");
            entity.Property(e => e.PrintedDateAlpha)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Printed_DateAlpha");
            entity.Property(e => e.PrintedTime)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Printed_Time");
            entity.Property(e => e.PrintedType)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Printed_Type");
            entity.Property(e => e.ProcessTime)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ProgramName)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Program_Name");
            entity.Property(e => e.RePrintDateTime)
                .HasDefaultValueSql("(N'getdate()')")
                .HasColumnType("datetime");
            entity.Property(e => e.RePrintReason)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RePrintUserId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("RePrintUserID");
            entity.Property(e => e.RePrinted).HasDefaultValueSql("((0))");
            entity.Property(e => e.ReceivingDfi)
                .HasMaxLength(9)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ReceivingDFI");
            entity.Property(e => e.ReconcDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ReconciledQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.RecordNoR).HasDefaultValueSql("((0))");
            entity.Property(e => e.ReprintCount).HasDefaultValueSql("(N'0')");
            entity.Property(e => e.RequestNumber)
                .HasMaxLength(13)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RequesterUser)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RoutingNumberMicr)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("RoutingNumberMICR");
            entity.Property(e => e.Signature)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Signature1)
                .HasMaxLength(24)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Signature2)
                .HasMaxLength(24)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.SpecialLongDescripti)
                .HasMaxLength(180)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Ssn)
                .HasMaxLength(11)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("SSN");
            entity.Property(e => e.State)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.StringAmount2)
                .HasMaxLength(48)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.StringAmount3)
                .HasMaxLength(27)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ToBePrinted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("To_Be_Printed");
            entity.Property(e => e.Transit1)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Transit2)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Us1200)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("US1200");
            entity.Property(e => e.Us2100)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("US2100");
            entity.Property(e => e.Us3100)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("US3100");
            entity.Property(e => e.Us4200)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("US4200");
            entity.Property(e => e.UserFieldMicr)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserFieldMICR");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserID");
            entity.Property(e => e.UserStr10).HasMaxLength(100);
            entity.Property(e => e.UserStr11).HasMaxLength(50);
            entity.Property(e => e.UserStr12).HasMaxLength(50);
            entity.Property(e => e.UserStr13).HasMaxLength(50);
            entity.Property(e => e.UserStr14).HasMaxLength(50);
            entity.Property(e => e.UserStr15).HasMaxLength(50);
            entity.Property(e => e.UserStr16)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr17)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr18)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr19)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr20)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr5).HasMaxLength(100);
            entity.Property(e => e.UserStr6).HasMaxLength(100);
            entity.Property(e => e.UserStr7).HasMaxLength(100);
            entity.Property(e => e.UserStr8).HasMaxLength(100);
            entity.Property(e => e.UserStr9).HasMaxLength(100);
            entity.Property(e => e.UserVal13)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal14)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal15)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserbatchId)
                .HasMaxLength(24)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserbatchID");
            entity.Property(e => e.Userval1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval1");
            entity.Property(e => e.Userval10)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval10");
            entity.Property(e => e.Userval11)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval11");
            entity.Property(e => e.Userval12)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval12");
            entity.Property(e => e.Userval16)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval16");
            entity.Property(e => e.Userval17)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval17");
            entity.Property(e => e.Userval18)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval18");
            entity.Property(e => e.Userval2)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval2");
            entity.Property(e => e.Userval3)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval3");
            entity.Property(e => e.Userval4)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval4");
            entity.Property(e => e.Userval5)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval5");
            entity.Property(e => e.Userval6)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval6");
            entity.Property(e => e.Userval7)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval7");
            entity.Property(e => e.Userval8)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval8");
            entity.Property(e => e.Userval9)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval9");
            entity.Property(e => e.VendorRedundant)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Vendor_Redundant");
            entity.Property(e => e.Void)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VOID");
            entity.Property(e => e.VoidDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.VoucherOrPurOrder)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.WhileProcessingVoi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("While_Processing_Voi");
            entity.Property(e => e.WhileSigningFlag).HasDefaultValueSql("((0))");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.Batch).WithMany(p => p.Achqueues)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_ACHQueue_BtchDet");
        });

        modelBuilder.Entity<Achtemplate>(entity =>
        {
            entity.HasKey(e => new { e.StdEntryClassCode5, e.ProjectKey });

            entity.ToTable("ACHTemplate", tb => tb.HasTrigger("TRG_ACHTemplate"));

            entity.Property(e => e.StdEntryClassCode5)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Achmanager)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ACHManager");
            entity.Property(e => e.BatchCount9).HasDefaultValueSql("((0))");
            entity.Property(e => e.BatchNumber5).HasDefaultValueSql("((0))");
            entity.Property(e => e.BatchNumber8).HasDefaultValueSql("((0))");
            entity.Property(e => e.BentryAddendaCount8)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BEntryAddendaCount8");
            entity.Property(e => e.BlockCount9).HasDefaultValueSql("((0))");
            entity.Property(e => e.BlockingFactor4)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CheckDigit6).HasMaxLength(1);
            entity.Property(e => e.Column1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Column2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Column3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Column4)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Column5)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Column6)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyDescriptiveDa)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyDiscretionary)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyEntryDescript)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyIdent5)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyIdentificatio)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyName5)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DfiaccountNumber6)
                .HasMaxLength(17)
                .HasColumnName("DFIaccountNumber6");
            entity.Property(e => e.DiscretionaryData6).HasMaxLength(2);
            entity.Property(e => e.EffectiveEntryDate5)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.EncrDailyProcedureNa).HasMaxLength(10);
            entity.Property(e => e.EncrFiller).HasMaxLength(48);
            entity.Property(e => e.EncrInitProcedureNam).HasMaxLength(10);
            entity.Property(e => e.EncrLog).HasMaxLength(16);
            entity.Property(e => e.EncrPath).HasMaxLength(80);
            entity.Property(e => e.EncrUseridPgp)
                .HasMaxLength(40)
                .HasColumnName("EncrUseridPGP");
            entity.Property(e => e.EntryHash8).HasDefaultValueSql("((0))");
            entity.Property(e => e.EntryHash9).HasDefaultValueSql("((0))");
            entity.Property(e => e.FentryAddendaCount9)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FEntryAddendaCount9");
            entity.Property(e => e.FileCreationDate4)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FileCreationTime4)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FileFormatCode)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FileIdmodifier4)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("FileIDmodifier4");
            entity.Property(e => e.FillerCompanyBatchco)
                .HasMaxLength(48)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillerCompanyBATCHco");
            entity.Property(e => e.FillerCompanyBatchhe)
                .HasMaxLength(48)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillerCompanyBATCHhe");
            entity.Property(e => e.FillerCtxaddendaRec7)
                .HasMaxLength(48)
                .HasColumnName("fillerCTXaddendaRec7");
            entity.Property(e => e.FillerCtxentryDetail)
                .HasMaxLength(48)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillerCTXentryDetail");
            entity.Property(e => e.FillerEncriptionSect)
                .HasMaxLength(46)
                .HasColumnName("fillerEncriptionSect");
            entity.Property(e => e.FillerFilecontrolRec)
                .HasMaxLength(48)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("FillerFILEcontrolRec");
            entity.Property(e => e.FillerFileheaderReco)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FillerFtpsection)
                .HasMaxLength(128)
                .HasColumnName("FillerFTPsection");
            entity.Property(e => e.Fillercnt)
                .HasMaxLength(132)
                .HasColumnName("FILLERcnt");
            entity.Property(e => e.FormatCode4)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FtpCommandName)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ftpCommandName");
            entity.Property(e => e.FtpFile2receive)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ftpFile2receive");
            entity.Property(e => e.FtpFile2send)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ftpFile2send");
            entity.Property(e => e.FtpLogname)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ftpLogname");
            entity.Property(e => e.FtpPacingDelay)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ftpPacingDelay");
            entity.Property(e => e.FtpPassword)
                .HasMaxLength(24)
                .HasColumnName("ftpPassword");
            entity.Property(e => e.FtpScriptName)
                .HasMaxLength(16)
                .HasColumnName("ftpScriptName");
            entity.Property(e => e.FtpServerName)
                .HasMaxLength(64)
                .HasColumnName("ftpServerName");
            entity.Property(e => e.FtpStartAt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ftpStartAt");
            entity.Property(e => e.FtpUserId)
                .HasMaxLength(20)
                .HasColumnName("ftpUserId");
            entity.Property(e => e.IdentNumber6).HasMaxLength(15);
            entity.Property(e => e.InmediateDestination)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.InmediateDestinatioo)
                .HasMaxLength(23)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.InmediateOrigin4)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.InmediateOriginName4)
                .HasMaxLength(23)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.LastFiller)
                .HasMaxLength(298)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("lastFILLER");
            entity.Property(e => e.MsgAuthenticCode8)
                .HasMaxLength(19)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.OriginatDfiident8)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("OriginatDFIident8");
            entity.Property(e => e.OriginatingDfiident5)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("OriginatingDFIident5");
            entity.Property(e => e.OriginatorStatusCode)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Path4outputFile).HasMaxLength(80);
            entity.Property(e => e.PaymentRelatedInfo7).HasMaxLength(80);
            entity.Property(e => e.PickRoutingAcctValue).HasMaxLength(1);
            entity.Property(e => e.PriorityCode4)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PublicKey4PaymentsGa)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'(N'')0')");
            entity.Property(e => e.ReceivingDfiident6)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ReceivingDFIident6");
            entity.Property(e => e.RecevingCompanyNameI).HasMaxLength(16);
            entity.Property(e => e.RecordSize4)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RecordTypeCode4)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RecordTypeCode5)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RecordTypeCode6)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RecordTypeCode7).HasMaxLength(1);
            entity.Property(e => e.RecordTypeCode8)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RecordTypeCode9)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ReferenceCode4)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Reserved6).HasMaxLength(2);
            entity.Property(e => e.Reserved8)
                .HasMaxLength(6)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Reserved9)
                .HasMaxLength(39)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ServiceClassCode5)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ServiceClassCode8)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.SettlementDateJulian)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.TotCreditAmtFile9)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.TotDebitAmtFile9)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.TotalAmount6).HasColumnType("money");
            entity.Property(e => e.TotalCreditAmount8)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.TotalDebitAmount8)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.TraceNumber6).HasColumnType("money");
            entity.Property(e => e.TransactionCode6)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.TransmitterId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TransmitterID");
        });

        modelBuilder.Entity<AsaltSignat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ASAltSignat", tb => tb.HasTrigger("TRG_ASAltSignat"));

            entity.Property(e => e.AltSignatoryalt).HasDefaultValueSql("((0))");
            entity.Property(e => e.AssignedQalt).HasDefaultValueSql("((0))");
            entity.Property(e => e.ExtendedAmountLimita)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.FillerAs)
                .HasMaxLength(13)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillerAs");
            entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
            entity.Property(e => e.SignatureFontIdalt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SignatureFontIDalt");
        });

        modelBuilder.Entity<Audit>(entity =>
        {
            entity.HasKey(e => e.AtransactNo);

            entity.ToTable("Audit", tb => tb.HasTrigger("TRG_Audit"));

            entity.HasIndex(e => e.AuditDateTime, "AuditDate").HasFillFactor(30);

            entity.Property(e => e.AtransactNo).HasColumnName("ATransactNo");
            entity.Property(e => e.Adate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ADate");
            entity.Property(e => e.AeditType)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("AEditType");
            entity.Property(e => e.AobjectId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("AObjectID");
            entity.Property(e => e.ArecordId)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ARecordID");
            entity.Property(e => e.Atime)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ATime");
            entity.Property(e => e.AuditDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Audit_DateTime");
            entity.Property(e => e.AuserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("AUserID");
            entity.Property(e => e.BatchId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BatchID");
            entity.Property(e => e.FieldChangeString).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<AuthSignBank>(entity =>
        {
            entity.HasKey(e => new { e.FontId, e.BankId });

            entity.ToTable(tb => tb.HasTrigger("TRG_AuthSignBanks"));

            entity.Property(e => e.FontId).HasColumnName("FontID");
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .HasColumnName("Bank_ID");
            entity.Property(e => e.AcoountId)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Acoount_ID");
            entity.Property(e => e.AssignedQbnk).HasDefaultValueSql("((0))");
            entity.Property(e => e.Filler1)
                .HasMaxLength(31)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler1");
        });

        modelBuilder.Entity<AuthSignCompany>(entity =>
        {
            entity.HasKey(e => new { e.FontId, e.PayorId });

            entity.ToTable(tb => tb.HasTrigger("TRG_AuthSignCompanies"));

            entity.Property(e => e.FontId).HasColumnName("FontID");
            entity.Property(e => e.PayorId)
                .HasMaxLength(22)
                .HasColumnName("PayorID");
            entity.Property(e => e.AssignedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.Filler1)
                .HasMaxLength(35)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler1");
        });

        modelBuilder.Entity<AuthSignature>(entity =>
        {
            entity.HasKey(e => e.FontId);

            entity.HasIndex(e => new { e.ActiveQ, e.LowValueRange, e.HighValueRange }, "AuthSig_Idx").HasFillFactor(30);

            entity.Property(e => e.FontId)
                .ValueGeneratedNever()
                .HasColumnName("FontID");
            entity.Property(e => e.ActivationChars)
                .HasMaxLength(7)
                .HasDefaultValueSql("(N'A')");
            entity.Property(e => e.ActiveQ).HasDefaultValueSql("((1))");
            entity.Property(e => e.HighValueRange)
                .HasDefaultValueSql("((1))")
                .HasColumnType("money");
            entity.Property(e => e.Initials)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.LowValueRange)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.PrimaryOrSecondary)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RecordCreatedModifie).HasDefaultValueSql("((0))");
            entity.Property(e => e.SignatureAccompanyMe)
                .HasMaxLength(65)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.SignatureDescription)
                .HasMaxLength(65)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Spare1)
                .HasMaxLength(51)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserCode)
                .HasMaxLength(24)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserID");
            entity.Property(e => e.Waiting4ReplicationQ).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<AutoNum>(entity =>
        {
            entity.ToTable("AutoNum", tb => tb.HasTrigger("TRG_AutoNum"));

            entity.Property(e => e.AutonumId)
                .ValueGeneratedNever()
                .HasColumnName("autonumID");
            entity.Property(e => e.AutoDescription)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength()
                .HasColumnName("autoDescription");
            entity.Property(e => e.NextNumber).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasIndex(e => new { e.BankName, e.FontId, e.AddendaYesNo }, "Banks_Idx").HasFillFactor(30);

            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .HasColumnName("Bank_ID");
            entity.Property(e => e.AddendaNoLines)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Addenda_No_Lines");
            entity.Property(e => e.AddendaYesNo)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Addenda_YesNo");
            entity.Property(e => e.Address1)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Address_1");
            entity.Property(e => e.Address2)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Address_2");
            entity.Property(e => e.Address3)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Address_3");
            entity.Property(e => e.Address4)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Address_4");
            entity.Property(e => e.BankCode)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Bank_Code");
            entity.Property(e => e.BankName)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Bank_Name");
            entity.Property(e => e.BranchOfficeCode)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Branch_Office_Code");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col4)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col5)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DefAccountMask)
                .HasMaxLength(24)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Def_Account_Mask");
            entity.Property(e => e.DefTransitMicr)
                .HasMaxLength(9)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Def_Transit_MICR");
            entity.Property(e => e.DefUserMicrValue)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Def_User_Micr_Value");
            entity.Property(e => e.DutyStampFontId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Duty_Stamp_FontID");
            entity.Property(e => e.Filler1)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler1");
            entity.Property(e => e.Filler2)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler2");
            entity.Property(e => e.FontId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FontID");
            entity.Property(e => e.LastCheckNo)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Last_Check_No");
            entity.Property(e => e.MicrFont)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'E')")
                .HasColumnName("MICR_Font");
            entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
            entity.Property(e => e.StampDuty)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Stamp_Duty");
            entity.Property(e => e.TransactFraction1)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Transact_Fraction_1");
            entity.Property(e => e.TransactFraction2)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Transact_Fraction_2");
            entity.Property(e => e.TransactFraction3)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Transact_Fraction_3");
        });

        modelBuilder.Entity<BatchSignatory>(entity =>
        {
            entity.HasKey(e => new { e.BatchId, e.RecordNo, e.UserId });

            entity.ToTable(tb => tb.HasTrigger("TRG_BatchSignatories"));

            entity.HasIndex(e => e.FontId, "BatchSign_Idx").HasFillFactor(30);

            entity.Property(e => e.BatchId).HasColumnName("Batch_ID");
            entity.Property(e => e.RecordNo).HasColumnName("Record_No");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .HasColumnName("UserID");
            entity.Property(e => e.DateBs)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DateBS");
            entity.Property(e => e.EnableOrDisable).HasDefaultValueSql("(N'')");
            entity.Property(e => e.FillerBs)
                .HasMaxLength(28)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillerBS");
            entity.Property(e => e.FontId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("fontID");
            entity.Property(e => e.PrimaryOrSecondary)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.TimeBs)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TimeBS");

            entity.HasOne(d => d.Batch).WithMany(p => p.BatchSignatories)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_BatchSignatories_BtchDet1");
        });

        modelBuilder.Entity<BtchDet>(entity =>
        {
            entity.HasKey(e => e.BatchId);

            entity.ToTable("BtchDet", tb => tb.HasTrigger("TRG_BtchDet"));

            entity.HasIndex(e => new { e.BatchImportDateTime, e.BatchPostedDateTime, e.Description, e.AllChecksBatchPrinte }, "BtchDet_Idx").HasFillFactor(30);

            entity.Property(e => e.BatchId)
                .ValueGeneratedNever()
                .HasColumnName("Batch_ID");
            entity.Property(e => e.AchGeneratedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.AchwhileprocessingFl)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ACHwhileprocessingFL");
            entity.Property(e => e.AllChecksBatchPrinte).HasDefaultValueSql("((0))");
            entity.Property(e => e.AutorizedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.BatchImportDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.BatchPostedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.BatchPurgeDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.BatchPurgedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.CopyprintedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.DatePosted).HasDefaultValueSql("((0))");
            entity.Property(e => e.DatePostedReptPrinte).HasDefaultValueSql("((0))");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Filler9915)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("FILLER99_15");
            entity.Property(e => e.GpbatchId)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("GPBatchId");
            entity.Property(e => e.Gpdate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("GPDate");
            entity.Property(e => e.ImportDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.ImportTime).HasDefaultValueSql("((0))");
            entity.Property(e => e.OtherInfo)
                .HasMaxLength(78)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Password1)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("password1");
            entity.Property(e => e.Password2)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("password2");
            entity.Property(e => e.PostedTobookQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.PostingGroupId)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.ServerRefresedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.TimePosted).HasDefaultValueSql("((0))");
            entity.Property(e => e.TimePostedReportPrin).HasDefaultValueSql("((0))");
            entity.Property(e => e.TotalChecksinBatch).HasDefaultValueSql("((0))");
            entity.Property(e => e.Totalacknowledged)
                .HasDefaultValueSql("(N'')")
                .HasColumnType("money");
            entity.Property(e => e.Totalamountvalue)
                .HasDefaultValueSql("(N'')")
                .HasColumnType("money");
            entity.Property(e => e.TypeofBatch)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Userbatchid)
                .HasMaxLength(14)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("userbatchid");
        });

        modelBuilder.Entity<CbooksBankFin>(entity =>
        {
            entity.HasKey(e => e.BankId);

            entity.ToTable("CBooks_BankFin", tb => tb.HasTrigger("TRG_CBooks_BankFin"));

            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BankID");
            entity.Property(e => e.Addr1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Addr2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Addr3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Addr4)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ApplF)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BankCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BankName)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BranchOfficeCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col4)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col5)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DefaultCurrency)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Filler)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler");
            entity.Property(e => e.FontId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FontID");
            entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
            entity.Property(e => e.TransitFraccion1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.TransitFraccion2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.TransitFraccion3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.TransitMicr)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("TransitMICR");
        });

        modelBuilder.Entity<CbooksBranchesFin>(entity =>
        {
            entity.HasKey(e => new { e.BankId, e.BranchId });

            entity.ToTable("CBooks_BranchesFin", tb => tb.HasTrigger("TRG_CBooks_BranchesFin"));

            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BankID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BranchID");
            entity.Property(e => e.Addr1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Addr2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Addr3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Addr4)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BranchName)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Brtransit1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("BRtransit1");
            entity.Property(e => e.Brtransit2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("BRtransit2");
            entity.Property(e => e.Brtransit3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("BRtransit3");
            entity.Property(e => e.BrtransitMicr)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("BRtransitMICR");
            entity.Property(e => e.CheckSeqNumber).HasDefaultValueSql("((0))");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col4)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.Fillerb)
                .HasMaxLength(170)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillerb");
            entity.Property(e => e.FontId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FontID");
        });

        modelBuilder.Entity<CbooksCbooksPrint>(entity =>
        {
            entity.HasKey(e => e.BatchId);

            entity.ToTable("CBooks_CBooksPrint", tb => tb.HasTrigger("TRG_CBooks_CBooksPrint"));

            entity.HasIndex(e => new { e.CustName1, e.BankId, e.Checks2Print, e.TypeAccount, e.CheckStatus, e.CurrencyId }, "IDX2").HasFillFactor(30);

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Addr1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Addr2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Addr3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Addr4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Applicat)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('CBook')");
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("BankID");
            entity.Property(e => e.BaseCurrencyId)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("BaseCurrencyID");
            entity.Property(e => e.BaseCurrencyPrice)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.BranchId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("BranchID");
            entity.Property(e => e.CheckBookPrice)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.CheckLayoutNo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.CheckStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ChkbookDescript)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("chkbookDescript");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col4)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CreationDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.CurrencyIdexchange)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("CurrencyIDExchange");
            entity.Property(e => e.CustName1)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CustName2)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CustNameLegal)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CustomerName3)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("email");
            entity.Property(e => e.EndCheckNo).HasDefaultValueSql("((0))");
            entity.Property(e => e.EndChkNoCompute)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EndChkNo_Compute");
            entity.Property(e => e.Filler)
                .HasMaxLength(113)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler");
            entity.Property(e => e.FlgprintNotAllowed)
                .HasDefaultValueSql("((0))")
                .HasColumnName("flgprintNotAllowed");
            entity.Property(e => e.InhibitPrintFlag).HasDefaultValueSql("((0))");
            entity.Property(e => e.InitialCheckNo).HasDefaultValueSql("((1))");
            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("LayoutID");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.OperationDateTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Phone)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PriceStyle1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.PriceStyle2)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.PriceStyle3)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.PrintedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Processtime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordNumber).HasDefaultValueSql("((1))");
            entity.Property(e => e.ReprintControlFlag)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.RequestTimeUsrAlph5)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RoutingTransitInfo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.SelectedStyle)
                .HasMaxLength(2)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.Source)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.TypeAccount)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserAlpah432)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserAlpha164)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserAlpha264)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserAlpha336)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserID");
            entity.Property(e => e.UserVal1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal2)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal3)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal4)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal5)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
        });

        modelBuilder.Entity<CbooksCbooksReq>(entity =>
        {
            entity.HasKey(e => e.AccountNo);

            entity.ToTable("CBooks_CBooksReq", tb => tb.HasTrigger("TRG_CBooks_CBooksReq"));

            entity.HasIndex(e => new { e.CustName1, e.TypeAccount, e.BankId, e.CurrencyId }, "Idx_2").HasFillFactor(30);

            entity.Property(e => e.AccountNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AccessedTime).HasColumnType("datetime");
            entity.Property(e => e.Addr1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Addr2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Addr3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Addr4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Applicat)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('CBook')");
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("BankID");
            entity.Property(e => e.BaseCurrencyId)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("BaseCurrencyID");
            entity.Property(e => e.BaseCurrencyPrice)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.BatchId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BatchID");
            entity.Property(e => e.BranchId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("BranchID");
            entity.Property(e => e.CheckBookPrice)
                .HasDefaultValueSql("((1))")
                .HasColumnType("money");
            entity.Property(e => e.CheckLayoutNo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CheckStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ChkbookDescript)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("chkbookDescript");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col4)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CreationDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.CurrencyIdexchange)
                .HasDefaultValueSql("((1))")
                .HasColumnType("money")
                .HasColumnName("CurrencyIDExchange");
            entity.Property(e => e.CustName1)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CustName2)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CustNameLegal)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CustomerName3)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("email");
            entity.Property(e => e.EndCheckNo).HasDefaultValueSql("((0))");
            entity.Property(e => e.EndChkNoCompute)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EndChkNo_Compute");
            entity.Property(e => e.Filler)
                .HasMaxLength(113)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler");
            entity.Property(e => e.FlgprintNotAllowed)
                .HasDefaultValueSql("((0))")
                .HasColumnName("flgprintNotAllowed");
            entity.Property(e => e.FormName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InhibitPrintFlag).HasDefaultValueSql("((0))");
            entity.Property(e => e.InitialCheckNo).HasDefaultValueSql("((1))");
            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("LayoutID");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.OperationDateTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Phone)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PriceStyle1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.PriceStyle2)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.PriceStyle3)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.PrintedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Processtime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordNumber).HasDefaultValueSql("((1))");
            entity.Property(e => e.ReprintControlFlag)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.RequestTimeUsrAlph5)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RoutingTransitInfo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.SelectedStyle)
                .HasMaxLength(10)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.Source)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Trtype)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeAccount)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserID");
            entity.Property(e => e.UserVal1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal2)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal3)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal4)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal5)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
        });

        modelBuilder.Entity<CbooksChkBooksEntry>(entity =>
        {
            entity.HasKey(e => e.AccountNo).HasName("PK_ChkBooks");

            entity.ToTable("CBooks_ChkBooksEntries", tb => tb.HasTrigger("TRG_CBooks_ChkBooksEntries"));

            entity.Property(e => e.AccountNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("BankID");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col4)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col5)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CreationDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FillerCb)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillerCB");
            entity.Property(e => e.FlagprintNotAllowed).HasDefaultValueSql("((0))");
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("LocationID");
            entity.Property(e => e.NoChecks2Print).HasDefaultValueSql("((0))");
            entity.Property(e => e.PrintedDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.RoutingTransitInfo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.StatusofCheck)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.TypeAccount)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<CbooksImportHeader>(entity =>
        {
            entity.HasKey(e => e.BatchId);

            entity.ToTable("CBooks_ImportHeader", tb => tb.HasTrigger("TRG_CBooks_ImportHeader"));

            entity.Property(e => e.BatchId)
                .ValueGeneratedNever()
                .HasColumnName("Batch_ID");
            entity.Property(e => e.Filefilter)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filefilter");
            entity.Property(e => e.Filenameih)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("FILENAMEih");
            entity.Property(e => e.Filesizeih)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("FILESIZEih");
            entity.Property(e => e.Filler)
                .HasMaxLength(135)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler");
            entity.Property(e => e.Importdate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IMPORTDATE");
            entity.Property(e => e.Importtime)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IMPORTTIME");
            entity.Property(e => e.RecordType)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Recordcode)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<CbooksMicrline>(entity =>
        {
            entity.HasKey(e => new { e.BankId, e.LayoutId }).HasName("PK_CBooks_MICRLine_1");

            entity.ToTable("CBooks_MICRLine", tb => tb.HasTrigger("TRG_CBooks_MICRLine"));

            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BankID");
            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LayoutID");
            entity.Property(e => e.AccNoEffectiveLength).HasDefaultValueSql("((0))");
            entity.Property(e => e.AcctLength).HasDefaultValueSql("((0))");
            entity.Property(e => e.AcctNoMask)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Acctoff).HasDefaultValueSql("((0))");
            entity.Property(e => e.AmtLength).HasDefaultValueSql("((0))");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Column0)
                .HasDefaultValueSql("((0))")
                .HasColumnName("column0");
            entity.Property(e => e.FillerM)
                .HasMaxLength(11)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillerM");
            entity.Property(e => e.Micrline)
                .HasMaxLength(63)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("MICRLine");
            entity.Property(e => e.Notused)
                .HasDefaultValueSql("((0))")
                .HasColumnName("notused");
            entity.Property(e => e.SerialLength).HasDefaultValueSql("((0))");
            entity.Property(e => e.TransactLength).HasDefaultValueSql("((9))");
            entity.Property(e => e.ZeroFillacctL).HasDefaultValueSql("((0))");
            entity.Property(e => e.ZeroFillcheckNumberL).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CbooksSynonym>(entity =>
        {
            entity.HasKey(e => e.TypeOfAccount);

            entity.ToTable("CBooks_Synonyms", tb => tb.HasTrigger("TRG_CBooks_Synonyms"));

            entity.Property(e => e.TypeOfAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApplS)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CheckLayoutNo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.EndLayout)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FillerS)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillerS");
            entity.Property(e => e.HorizMicrmicroAdjust)
                .HasDefaultValueSql("((0))")
                .HasColumnName("HorizMICRmicroAdjust");
            entity.Property(e => e.Layout1)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Layout2)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("LayoutID");
            entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
            entity.Property(e => e.SetLastCheckNumber).HasDefaultValueSql("((0))");
            entity.Property(e => e.SynonymId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("SynonymID");
            entity.Property(e => e.VertMicrmicroAdjust)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VertMICRmicroAdjust");
        });

        modelBuilder.Entity<CbooksTypeOfAccount>(entity =>
        {
            entity.HasKey(e => new { e.RecordNo, e.CheckLayoutNo }).HasName("PK_CBooks_TypeOfAccount_1");

            entity.ToTable("CBooks_TypeOfAccount", tb => tb.HasTrigger("TRG_CBooks_TypeOfAccount"));

            entity.Property(e => e.RecordNo).ValueGeneratedOnAdd();
            entity.Property(e => e.CheckLayoutNo)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ApplF)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('CBook')");
            entity.Property(e => e.FillerT)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillerT");
            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("LayoutID");
            entity.Property(e => e.PageNumbering)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'P')")
                .IsFixedLength();
            entity.Property(e => e.PriceStyle1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.PriceStyle2)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.PriceStyle3)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SelectedStyle)
                .HasMaxLength(2)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.TotalsChecksPerCbook)
                .HasDefaultValueSql("((1))")
                .HasColumnName("TotalsChecksPerCBook");
            entity.Property(e => e.TypeOfaccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("TypeOFAccount");
        });

        modelBuilder.Entity<ChecksD1>(entity =>
        {
            entity.HasKey(e => new { e.BatchId, e.RecordNo, e.SeqNoThisDoc });

            entity.ToTable("ChecksD1", tb => tb.HasTrigger("TRG_ChecksD1"));

            entity.HasIndex(e => new { e.BatchId, e.RecordNo, e.OperationType, e.SeqNoThisDoc }, "key0")
                .IsUnique()
                .IsDescending(false, false, true, false)
                .HasFillFactor(30);

            entity.Property(e => e.BatchId).HasColumnName("Batch_ID");
            entity.Property(e => e.RecordNo).HasColumnName("Record_No");
            entity.Property(e => e.AditionalRefGl)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("AditionalRefGL");
            entity.Property(e => e.BankAccountNumber)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CalculateNetAmount)
                .HasComputedColumnSql("([GrossAmount]-[DiscountTaken]/(100))", false)
                .HasColumnType("money");
            entity.Property(e => e.CheckDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.CheckNo)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ConceptOrdescription)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("conceptORdescription");
            entity.Property(e => e.CreditGl)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("CreditGL");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.DebitGl)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("DebitGL");
            entity.Property(e => e.Descript1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript10)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript11)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript12)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript13)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript14)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript15)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript4)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript5)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript6)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript7)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript8)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descript9)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DiscountTaken)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.EarnDeductiRate)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.EarnedDeductAmtMtd)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("EarnedDeductAmtMTD");
            entity.Property(e => e.EarnedDeductedAmtYtd)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("EarnedDeductedAmtYTD");
            entity.Property(e => e.GrossAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.InvoiceDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.LongDescription)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.NetAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.OperationType)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ProllPreTxLog).HasDefaultValueSql("((0))");
            entity.Property(e => e.StubDate)
                .HasDefaultValueSql("(N'')")
                .HasColumnType("datetime");
            entity.Property(e => e.StubDate1)
                .HasDefaultValueSql("(N'')")
                .HasColumnType("datetime");
            entity.Property(e => e.TriggerMultistub)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.TypeOfAccount)
                .HasMaxLength(35)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UnitsHoursQ)
                .HasDefaultValueSql("((0))")
                .HasColumnType("smallmoney");
            entity.Property(e => e.UserString122)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserString1_22");
            entity.Property(e => e.Value1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value10)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value11)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value12)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value13)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value14)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value15)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value16)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value17)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value18)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value19)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value2)
                .HasDefaultValueSql("((0))")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value20)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value3)
                .HasDefaultValueSql("((0))")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value4)
                .HasDefaultValueSql("((0))")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value5)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("money");
            entity.Property(e => e.Value6)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("money");
            entity.Property(e => e.Value7)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value8)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Value9)
                .HasDefaultValueSql("(N'0')")
                .HasColumnType("smallmoney");
            entity.Property(e => e.VoucherNo)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Voucherdate).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Batch).WithMany(p => p.ChecksD1s)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_ChecksD1_BtchDet");
        });

        modelBuilder.Entity<ChecksH3>(entity =>
        {
            entity.HasKey(e => new { e.BatchId, e.RecordNo });

            entity.ToTable("ChecksH3", tb => tb.HasTrigger("TRG_ChecksH3"));

            entity.HasIndex(e => new { e.CheckPrintedDateTime, e.BankId, e.AccountId, e.PayorId, e.CheckType, e.PayeeName, e.CheckAmount }, "ChecksH3_Index")
                .IsDescending(true, false, false, false, false, false, false)
                .HasFillFactor(30);

            entity.HasIndex(e => new { e.BatchId, e.CheckPrintedDateTime, e.RecordNo, e.CheckNo, e.BankId, e.AccountId, e.PayeeName }, "IDX_ChecksH3")
                .IsDescending(true, true, false, false, false, false, false)
                .HasFillFactor(30);

            entity.Property(e => e.BatchId).HasColumnName("Batch_ID");
            entity.Property(e => e.RecordNo).HasColumnName("Record_No");
            entity.Property(e => e.AccountId)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Account_ID");
            entity.Property(e => e.AccountType)
                .HasMaxLength(35)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Account_Type");
            entity.Property(e => e.AchStdEntryClassCode)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("achStdEntryClassCode");
            entity.Property(e => e.AchTranCode)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("achTranCode");
            entity.Property(e => e.AchTypeAcct)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("achTypeAcct");
            entity.Property(e => e.AchaddendaQ)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACHAddendaQ");
            entity.Property(e => e.Achq)
                .HasDefaultValueSql("(N'0')")
                .HasColumnName("ACHQ");
            entity.Property(e => e.AchreEnableQ)
                .HasDefaultValueSql("(N'0')")
                .HasColumnName("ACHRe_EnableQ");
            entity.Property(e => e.AchroutingCdv)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ACHroutingCDV");
            entity.Property(e => e.AdditionalUserId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("AdditionalUserID");
            entity.Property(e => e.BankAddr1)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BankAddr2)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Bank_ID");
            entity.Property(e => e.BankName)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BarCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BatchIdr)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BatchIDR");
            entity.Property(e => e.Cdv2)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CDV2");
            entity.Property(e => e.CdvAccountNo)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CDV_Account_No");
            entity.Property(e => e.CheckAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.CheckAmountAlpha)
                .HasMaxLength(120)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CheckDate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Check_Date");
            entity.Property(e => e.CheckDateAlpha)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CheckDateYear).HasDefaultValueSql("((0))");
            entity.Property(e => e.CheckNo)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Check_No");
            entity.Property(e => e.CheckPrintedDateTime)
                .HasDefaultValueSql("(((1)/(1))/(1))")
                .HasColumnType("datetime");
            entity.Property(e => e.CheckType)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.City)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ClaimOrPurchaseOrde)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Claim_orPurchaseOrde");
            entity.Property(e => e.ClientLocation)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Concept1)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Concept2)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Concept3)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Concept4)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ConsecutiveNumber)
                .HasMaxLength(13)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Contact)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CopyPrinted).HasDefaultValueSql("((0))");
            entity.Property(e => e.CostCenter4Sign)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Counter).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreationDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreationTime).HasDefaultValueSql("((0))");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.DateAlphaY2k)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("DateAlphaY2K");
            entity.Property(e => e.DfiacctNo)
                .HasMaxLength(17)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("DFIacctNo");
            entity.Property(e => e.DirectDepositAccNumb)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DirectDepositBankNam)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Discounttotal)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.DontSendEmail).HasDefaultValueSql("((0))");
            entity.Property(e => e.EarnDeductAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("email");
            entity.Property(e => e.EncryptAmount).HasMaxLength(100);
            entity.Property(e => e.EncryptCheckNo).HasMaxLength(100);
            entity.Property(e => e.EncryptPayee).HasMaxLength(140);
            entity.Property(e => e.ExportQ).HasDefaultValueSql("(N'0')");
            entity.Property(e => e.Filler15)
                .HasMaxLength(33)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler15");
            entity.Property(e => e.ForTheAccountOf)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("For_the_account_of");
            entity.Property(e => e.GlCredit)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("GL_Credit");
            entity.Property(e => e.GlDebit)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("GL_Debit");
            entity.Property(e => e.GlacctReference)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("GLAcctReference");
            entity.Property(e => e.Grosstotal)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.ImportDate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Import_Date");
            entity.Property(e => e.InvoiceDate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Invoice_Date");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Irscode)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("IRScode");
            entity.Property(e => e.NumberofSignatures).HasDefaultValueSql("((0))");
            entity.Property(e => e.PayeeAddr1)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeAddr2)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeAddr3)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeAddr4)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeAddr5)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeId)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PayeeID");
            entity.Property(e => e.PayeeName)
                .HasMaxLength(70)
                .HasDefaultValueSql("('VOID VOID')");
            entity.Property(e => e.PayeeName2)
                .HasMaxLength(48)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayorId)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PayorID");
            entity.Property(e => e.PayorName)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Payor_Name");
            entity.Property(e => e.Pdfname)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PDFName");
            entity.Property(e => e.PdfuniqueNameQ)
                .HasDefaultValueSql("(N'1')")
                .HasColumnName("PDFUniqueNameQ");
            entity.Property(e => e.PositivePayQ).HasDefaultValueSql("(N'0')");
            entity.Property(e => e.Printed).HasDefaultValueSql("((0))");
            entity.Property(e => e.PrintedBy)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Printed_By");
            entity.Property(e => e.PrintedDate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Printed_Date");
            entity.Property(e => e.PrintedDateAlpha)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Printed_DateAlpha");
            entity.Property(e => e.PrintedTime)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Printed_Time");
            entity.Property(e => e.PrintedType)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Printed_Type");
            entity.Property(e => e.ProcessTime)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ProgramName)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Program_Name");
            entity.Property(e => e.RePrintDateTime)
                .HasDefaultValueSql("(N'getdate()')")
                .HasColumnType("datetime");
            entity.Property(e => e.RePrintReason)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RePrintUserId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("RePrintUserID");
            entity.Property(e => e.RePrinted).HasDefaultValueSql("((0))");
            entity.Property(e => e.Reason1).HasMaxLength(50);
            entity.Property(e => e.Reason2).HasMaxLength(50);
            entity.Property(e => e.RecBatchPurgeQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.RecCheckNo)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("RecCheck_No");
            entity.Property(e => e.ReceivingDfi)
                .HasMaxLength(9)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ReceivingDFI");
            entity.Property(e => e.ReconcDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ReconciledQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.RecordNoR).HasDefaultValueSql("((0))");
            entity.Property(e => e.ReprintCount).HasDefaultValueSql("(N'0')");
            entity.Property(e => e.RequestNumber)
                .HasMaxLength(13)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RequesterUser)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RoutingNumberMicr)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("RoutingNumberMICR");
            entity.Property(e => e.Signature)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Signature1)
                .HasMaxLength(24)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Signature2)
                .HasMaxLength(24)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.SpecialLongDescripti)
                .HasMaxLength(180)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Ssn)
                .HasMaxLength(11)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("SSN");
            entity.Property(e => e.State)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.StringAmount2)
                .HasMaxLength(48)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.StringAmount3)
                .HasMaxLength(27)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ToBePrinted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("To_Be_Printed");
            entity.Property(e => e.Transit1)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Transit2)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Us1200)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("US1200");
            entity.Property(e => e.Us2100)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("US2100");
            entity.Property(e => e.Us3100)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("US3100");
            entity.Property(e => e.Us4200)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("US4200");
            entity.Property(e => e.UserFieldMicr)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserFieldMICR");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserID");
            entity.Property(e => e.UserStr10)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr11)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr12)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr13)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr14)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr15)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr16)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr17)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr18)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr19)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr20)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr5)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr6)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr7)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr8)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr9)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserVal13)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal14)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal15)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserbatchId)
                .HasMaxLength(24)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserbatchID");
            entity.Property(e => e.Userval1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval1");
            entity.Property(e => e.Userval10)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval10");
            entity.Property(e => e.Userval11)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval11");
            entity.Property(e => e.Userval12)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval12");
            entity.Property(e => e.Userval16)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval16");
            entity.Property(e => e.Userval17)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval17");
            entity.Property(e => e.Userval18)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval18");
            entity.Property(e => e.Userval2)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval2");
            entity.Property(e => e.Userval3)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval3");
            entity.Property(e => e.Userval4)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval4");
            entity.Property(e => e.Userval5)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval5");
            entity.Property(e => e.Userval6)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval6");
            entity.Property(e => e.Userval7)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval7");
            entity.Property(e => e.Userval8)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval8");
            entity.Property(e => e.Userval9)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval9");
            entity.Property(e => e.VendorRedundant)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Vendor_Redundant");
            entity.Property(e => e.Void)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VOID");
            entity.Property(e => e.VoidDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.VoidReason).HasMaxLength(150);
            entity.Property(e => e.VoucherOrPurOrder)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.WhileProcessingVoi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("While_Processing_Voi");
            entity.Property(e => e.WhileSigningFlag).HasDefaultValueSql("((0))");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.Batch).WithMany(p => p.ChecksH3s)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("FK_ChecksH3_BtchDet");
        });

        modelBuilder.Entity<ClientLocation>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable(tb => tb.HasTrigger("TRG_ClientLocations"));

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CsRefreshTime)
                .HasDefaultValueSql("((0))")
                .HasColumnName("csRefreshTime");
            entity.Property(e => e.CsTimeOut)
                .HasDefaultValueSql("((0))")
                .HasColumnName("csTimeOut");
            entity.Property(e => e.Csreplicated)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CSReplicated");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PrinterId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PrinterID");
            entity.Property(e => e.PrinterName)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Selected).HasDefaultValueSql("((1))");
            entity.Property(e => e.Template)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.ToTable("Currency");

            entity.Property(e => e.CurrencyId)
                .HasMaxLength(5)
                .HasColumnName("CurrencyID");
            entity.Property(e => e.CurrencySymbol)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DescriptionAddl)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ExchangeRate)
                .HasDefaultValueSql("((1))")
                .HasColumnType("smallmoney");
            entity.Property(e => e.Filler)
                .HasMaxLength(38)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler");
            entity.Property(e => e.FractionName)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CustomFont>(entity =>
        {
            entity.HasKey(e => new { e.CfeEntity, e.ProjectKey });

            entity.ToTable(tb => tb.HasTrigger("TRG_CustomFonts"));

            entity.Property(e => e.CfeEntity).HasColumnName("cfeEntity");
            entity.Property(e => e.CfeData)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("cfeData");
            entity.Property(e => e.CfeFiller)
                .HasMaxLength(29)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("cfeFILLER");
            entity.Property(e => e.CfeKeyCode)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cfeKeyCode");
            entity.Property(e => e.CfeOperand1Entity)
                .HasDefaultValueSql("((0))")
                .HasColumnName("cfeOperand1Entity");
            entity.Property(e => e.CfeOperator)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("cfeOperator");
            entity.Property(e => e.CfeRecType)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("cfeRecType");
            entity.Property(e => e.FontId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FontID");
        });

        modelBuilder.Entity<DatabasesC>(entity =>
        {
            entity.HasKey(e => e.DatabaseId);

            entity.ToTable("DatabasesC", tb => tb.HasTrigger("TRG_DatabasesC"));

            entity.Property(e => e.DatabaseId)
                .ValueGeneratedNever()
                .HasColumnName("DatabaseID");
            entity.Property(e => e.DatabaseNameC)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<EAlertAuditLog>(entity =>
        {
            entity.HasKey(e => e.Idnumber);

            entity.ToTable("eAlertAuditLog", tb => tb.HasTrigger("TRG_eAlertAuditLog"));

            entity.Property(e => e.Idnumber).HasColumnName("IDNumber");
            entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");
            entity.Property(e => e.DatabaseName).HasMaxLength(50);
            entity.Property(e => e.EventMenu).HasMaxLength(100);
        });

        modelBuilder.Entity<EAlertCustom>(entity =>
        {
            entity.ToTable("eAlertCustom", tb => tb.HasTrigger("TRG_eAlertCustom"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount1).HasColumnType("money");
            entity.Property(e => e.Amount2).HasColumnType("money");
            entity.Property(e => e.AmountOver).HasColumnType("money");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date1).HasColumnType("datetime");
            entity.Property(e => e.Date2).HasColumnType("datetime");
            entity.Property(e => e.EmailFrom).HasMaxLength(500);
            entity.Property(e => e.Entity1).HasMaxLength(50);
            entity.Property(e => e.Entity1Text).HasMaxLength(250);
            entity.Property(e => e.Entity2).HasMaxLength(50);
            entity.Property(e => e.Entity2Text).HasMaxLength(250);
            entity.Property(e => e.Entity3).HasMaxLength(50);
            entity.Property(e => e.Entity3Text).HasMaxLength(250);
            entity.Property(e => e.Entity4).HasMaxLength(50);
            entity.Property(e => e.Entity4Text).HasMaxLength(250);
            entity.Property(e => e.Entity5).HasMaxLength(50);
            entity.Property(e => e.Entity5Text).HasMaxLength(250);
            entity.Property(e => e.NameId)
                .HasMaxLength(500)
                .HasColumnName("NameID");
        });

        modelBuilder.Entity<EAlertEmail>(entity =>
        {
            entity.HasKey(e => new { e.DatabaseId, e.IdentityId, e.EMail });

            entity.ToTable("eAlertEmails", tb => tb.HasTrigger("TRG_eAlertEmails"));

            entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");
            entity.Property(e => e.IdentityId).HasColumnName("IdentityID");
            entity.Property(e => e.EMail)
                .HasMaxLength(150)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("eMail");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(N'')")
                .HasColumnType("datetime");
            entity.Property(e => e.CreationTime).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<EAlertEvent>(entity =>
        {
            entity.HasKey(e => e.IdentityId);

            entity.ToTable("eAlertEvents", tb => tb.HasTrigger("TRG_eAlertEvents"));

            entity.Property(e => e.IdentityId).HasColumnName("IdentityID");
            entity.Property(e => e.AuditPattern)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.AuditTrailBypassQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.DatabaseId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DatabaseID");
            entity.Property(e => e.EfillerW)
                .HasMaxLength(28)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("efillerW");
            entity.Property(e => e.PurgeBypassQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.SourceTable)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<EAlertWildcard>(entity =>
        {
            entity.HasKey(e => e.IdentityId).HasName("PK_eAlertWildcards_1");

            entity.ToTable("eAlertWildcards", tb => tb.HasTrigger("TRG_eAlertWildcards"));

            entity.Property(e => e.IdentityId)
                .ValueGeneratedNever()
                .HasColumnName("IdentityID");
            entity.Property(e => e.AuditTrailBypassQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.DatabaseId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DatabaseID");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.EfillerW)
                .HasMaxLength(28)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("efillerW");
            entity.Property(e => e.MatchPattern)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PurgeBypassQ).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<EalertsSamplePatern>(entity =>
        {
            entity.HasKey(e => new { e.DatabaseId, e.EventName });

            entity.ToTable(tb => tb.HasTrigger("TRG_EalertsSamplePaterns"));

            entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");
            entity.Property(e => e.EventName).HasMaxLength(30);
            entity.Property(e => e.Efiller3)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("efiller3");
        });

        modelBuilder.Entity<ElegiblePrinter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb => tb.HasTrigger("TRG_ElegiblePrinters"));

            entity.Property(e => e.AssignedPrinter)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.AvailablePrinters).HasDefaultValueSql("((0))");
            entity.Property(e => e.InitString)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.LoadBalanceQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.MarginName)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.OmitInitQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.Orientation)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.PaperSize)
                .HasMaxLength(2)
                .HasDefaultValueSql("((2))");
            entity.Property(e => e.PrinterId).HasColumnName("PrinterID");
            entity.Property(e => e.ProjectKey).HasDefaultValueSql("((1))");
            entity.Property(e => e.SecurePrinterQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.SelectedQ).HasDefaultValueSql("((1))");
            entity.Property(e => e.TrayNumber).HasDefaultValueSql("((5))");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<EmailCustomization>(entity =>
        {
            entity.HasKey(e => e.Category);

            entity.ToTable("EmailCustomization", tb => tb.HasTrigger("TRG_EmailCustomization"));

            entity.Property(e => e.Category).HasMaxLength(16);
            entity.Property(e => e.AccountReference)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Account Reference:')");
            entity.Property(e => e.AtCurrentDateTime).HasMaxLength(50);
            entity.Property(e => e.Bit1).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit2).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit21).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit22).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit23).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit24).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit25).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit26).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit27).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit28).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit3).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit31).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit32).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit33).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit34).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit35).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit36).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit37).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit4).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit41).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit42).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit43).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit5).HasDefaultValueSql("((1))");
            entity.Property(e => e.Bit6).HasDefaultValueSql("((1))");
            entity.Property(e => e.Confidentiality)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'CONFIDENTIALITY NOTE')");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Description')");
            entity.Property(e => e.Description2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Desc')");
            entity.Property(e => e.Description3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Desc')");
            entity.Property(e => e.Description4).HasMaxLength(50);
            entity.Property(e => e.Description5).HasMaxLength(50);
            entity.Property(e => e.Description6).HasMaxLength(50);
            entity.Property(e => e.Description7).HasMaxLength(50);
            entity.Property(e => e.Description8).HasMaxLength(50);
            entity.Property(e => e.Discount)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'DISCOUNT')");
            entity.Property(e => e.FormatCode)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Format Code =')");
            entity.Property(e => e.GrossAmount)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'GROSS AMOUNT')");
            entity.Property(e => e.MessageLine1)
                .HasMaxLength(1050)
                .HasDefaultValueSql("(N'If you have receive this communication in error please delete or destroy it and notify the sender immediately. Thanks.')");
            entity.Property(e => e.MessageLine2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.NetAmount)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'NET AMOUNT')");
            entity.Property(e => e.Notifiedby)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Email notified by CheckPlus Software')");
            entity.Property(e => e.PayeeName)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Name: ')");
            entity.Property(e => e.PaymentAmount)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Payment Amount:')");
            entity.Property(e => e.PaymentDate)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Payment Date:')");
            entity.Property(e => e.PaymentDetails1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Payment Details')");
            entity.Property(e => e.PaymentReference)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Payment Reference:')");
            entity.Property(e => e.ProcessedbyUserId)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'Processed by:')")
                .HasColumnName("ProcessedbyUserID");
            entity.Property(e => e.ReferenceDate)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'REF/INV DATE')");
            entity.Property(e => e.ReferenceInvoice)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'REFER/INV')");
            entity.Property(e => e.Remittance)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'REMITTANCE/DESCRIPTION')");
            entity.Property(e => e.Withholding)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'WITHHOLDING')");
        });

        modelBuilder.Entity<EmailPref>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmailPref", tb => tb.HasTrigger("TRG_EmailPref"));

            entity.Property(e => e.AttachmentE)
                .HasMaxLength(1984)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("attachmentE");
            entity.Property(e => e.BlattOptions)
                .HasMaxLength(260)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CategoryE)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DefaultValueE).HasDefaultValueSql("(N'')");
            entity.Property(e => e.DigitsDisclose).HasDefaultValueSql("((0))");
            entity.Property(e => e.FromE)
                .HasMaxLength(260)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.MessageE)
                .HasMaxLength(500)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PacingTimer).HasDefaultValueSql("((0))");
            entity.Property(e => e.SmptServer)
                .HasMaxLength(260)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.SubjectE)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ToE)
                .HasMaxLength(3000)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("toE");
        });

        modelBuilder.Entity<EventsSource>(entity =>
        {
            entity.HasKey(e => e.DatabaseId);

            entity.ToTable("Events_Sources", tb => tb.HasTrigger("TRG_Events_Sources"));

            entity.Property(e => e.DatabaseId)
                .ValueGeneratedNever()
                .HasColumnName("DatabaseID");
            entity.Property(e => e.DatabaseName)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<FeesTable>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TRG_FeesTables"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountOrpercent)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength()
                .HasColumnName("AmountORPercent");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.Description)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Fee)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.FeeCurrency)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FromAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.PercentComm)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("Percent_Comm");
            entity.Property(e => e.ToAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
        });

        modelBuilder.Entity<FieldsList>(entity =>
        {
            entity.HasKey(e => new { e.DatabaseId, e.FieldNoC });

            entity.ToTable("FieldsList");

            entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");
            entity.Property(e => e.FieldNameC)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<Fontlist>(entity =>
        {
            entity.HasKey(e => new { e.ProjectKey, e.FontId });

            entity.ToTable("Fontlist");

            entity.Property(e => e.FontId).HasColumnName("FontID");
            entity.Property(e => e.ActivationChar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.AdditionalActivation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.Filler1)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.FontSymbolName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.Fspec1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.Fspec2)
                .HasMaxLength(29)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.PdfQ)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pdfQ");
            entity.Property(e => e.SelectedQ)
                .HasDefaultValueSql("((1))")
                .HasColumnName("selectedQ");
            entity.Property(e => e.SystemOrUser)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
        });

        modelBuilder.Entity<FormItemEntity>(entity =>
        {
            entity.HasKey(e => e.EntityId);

            entity.ToTable(tb => tb.HasTrigger("TRG_FormItemEntities"));

            entity.Property(e => e.EntityId).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(28)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Relationship).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<Format>(entity =>
        {
            entity.HasKey(e => e.LayoutId);

            entity.ToTable(tb => tb.HasTrigger("TRG_Formats"));

            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .HasColumnName("LayoutID");
            entity.Property(e => e.Appearance)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Filler)
                .HasMaxLength(9)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.LinesStub).HasDefaultValueSql("((0))");
            entity.Property(e => e.OverflowQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
            entity.Property(e => e.SelectedQ).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<FtptransProf>(entity =>
        {
            entity.HasKey(e => e.ProfileId);

            entity.ToTable("FTPTransProf", tb => tb.HasTrigger("TRG_FTPTransProf"));

            entity.Property(e => e.ProfileId)
                .HasMaxLength(4)
                .HasColumnName("ProfileID");
            entity.Property(e => e.CommandName)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CryFilePath)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("cryFilePath");
            entity.Property(e => e.CryInitProcedure)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("cryInitProcedure");
            entity.Property(e => e.CryLogFileName)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("cryLogFileName");
            entity.Property(e => e.CryRunProcedure)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("cryRunProcedure");
            entity.Property(e => e.CryUserId)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("cryUserID");
            entity.Property(e => e.DateStampM)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Description)
                .HasMaxLength(25)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.File2Receive)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.File2Send)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FillerEncryptionSect)
                .HasMaxLength(36)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FillerFtpsection)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("FillerFTPsection");
            entity.Property(e => e.LastProcessingDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.Logname)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PacingDelay)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Password1)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ServerName)
                .HasMaxLength(64)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.StartAt).HasDefaultValueSql("((0))");
            entity.Property(e => e.TimeStampM)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserId)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<GenParBlank>(entity =>
        {
            entity.HasKey(e => e.StyleDescriptiongpb);

            entity.ToTable("GenParBlank", tb => tb.HasTrigger("TRG_GenParBlank"));

            entity.Property(e => e.StyleDescriptiongpb)
                .HasMaxLength(35)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.AccountId)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Account_ID");
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Bank_ID");
            entity.Property(e => e.CostCentergpb)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.DateDefgpb).HasDefaultValueSql("((0))");
            entity.Property(e => e.Fillergpb)
                .HasMaxLength(103)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillergpb");
            entity.Property(e => e.FormIdgpb)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("formIDgpb");
            entity.Property(e => e.PayeeId)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PayeeID");
            entity.Property(e => e.PayorId)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PayorID");
            entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
            entity.Property(e => e.UserMicrvaluegpb)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserMICRValuegpb");
        });

        modelBuilder.Entity<GenParamManCheck>(entity =>
        {
            entity.HasKey(e => e.DescriptTypegpm);

            entity.ToTable("GenParamManCheck", tb => tb.HasTrigger("TRG_GenParamManCheck"));

            entity.Property(e => e.DescriptTypegpm)
                .HasMaxLength(35)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.AccountId)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Account_ID");
            entity.Property(e => e.ApplicationTitleRi)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Bank_ID");
            entity.Property(e => e.Cdv1gpm)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CDV1gpm");
            entity.Property(e => e.Cdv2gpm)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CDV2gpm");
            entity.Property(e => e.CheckAmountLimitgpm)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.ClientLocgpm)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CostCentergpm)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.DateUsedgpm)
                .HasDefaultValueSql("((0))")
                .HasColumnName("dateUsedgpm");
            entity.Property(e => e.Fillergpm)
                .HasMaxLength(71)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillergpm");
            entity.Property(e => e.FormIdgpm)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("FormIDgpm");
            entity.Property(e => e.PayeeId)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PayeeID");
            entity.Property(e => e.PayorId)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PayorID");
            entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
            entity.Property(e => e.ScreenCodegpm)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserMicrvaluegpm)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserMICRValuegpm");
        });

        modelBuilder.Entity<GenSysPar>(entity =>
        {
            entity.HasKey(e => e.ProjectKey);

            entity.ToTable("GenSysPar", tb => tb.HasTrigger("TRG_GenSysPar"));

            entity.Property(e => e.ProjectKey).ValueGeneratedNever();
            entity.Property(e => e.AchManager)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ACH_Manager");
            entity.Property(e => e.Achq)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ACHQ");
            entity.Property(e => e.AchschedulingQ)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ACHSchedulingQ");
            entity.Property(e => e.ActivationRequestStr).HasMaxLength(30);
            entity.Property(e => e.AddressFormat)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Address_Format");
            entity.Property(e => e.AllowCheckRangesQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.Application2run).HasMaxLength(2);
            entity.Property(e => e.BaseCurrency).HasMaxLength(5);
            entity.Property(e => e.BlankChecksQ)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Blank_ChecksQ");
            entity.Property(e => e.CheckPrintingOrder)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Check_Printing_Order");
            entity.Property(e => e.CityOfIssue)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("City_of_Issue");
            entity.Property(e => e.ClientModuleQ)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Client_ModuleQ");
            entity.Property(e => e.CompanyAddr2).HasMaxLength(35);
            entity.Property(e => e.CompanyAddr3).HasMaxLength(35);
            entity.Property(e => e.CompanyAddr4).HasMaxLength(35);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.CompanyName2).HasMaxLength(35);
            entity.Property(e => e.CompanyName3).HasMaxLength(35);
            entity.Property(e => e.CompanyNameLogo).HasMaxLength(35);
            entity.Property(e => e.CsRefreshRate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CS_Refresh_Rate");
            entity.Property(e => e.DefApplicationQ).HasDefaultValueSql("((1))");
            entity.Property(e => e.DefaultAccount).HasMaxLength(16);
            entity.Property(e => e.DefaultBank).HasMaxLength(10);
            entity.Property(e => e.DefaultCurrency).HasMaxLength(5);
            entity.Property(e => e.DefaultMicrLineLayou).HasMaxLength(63);
            entity.Property(e => e.DefaultTypeOfcheck).HasMaxLength(2);
            entity.Property(e => e.DiskSerialNumber)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Dummy1)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("dummy1");
            entity.Property(e => e.Dummy3)
                .HasMaxLength(2)
                .HasColumnName("dummy3");
            entity.Property(e => e.Dummy5)
                .HasMaxLength(2)
                .HasColumnName("dummy5");
            entity.Property(e => e.Dummy6)
                .HasMaxLength(3)
                .HasColumnName("dummy6");
            entity.Property(e => e.Dummy7)
                .HasMaxLength(10)
                .HasColumnName("dummy7");
            entity.Property(e => e.EmailErrors)
                .HasDefaultValueSql("((0))")
                .HasColumnName("email_errors");
            entity.Property(e => e.EncryptExpirationDate).HasMaxLength(50);
            entity.Property(e => e.EncryptLicense).HasMaxLength(100);
            entity.Property(e => e.EncryptLicenseStr).HasMaxLength(200);
            entity.Property(e => e.EncryptServerName).HasMaxLength(100);
            entity.Property(e => e.EncryptTempLicense).HasMaxLength(50);
            entity.Property(e => e.ExpirationDate1)
                .HasColumnType("datetime")
                .HasColumnName("Expiration_Date");
            entity.Property(e => e.Filler2)
                .HasMaxLength(65)
                .HasColumnName("filler2");
            entity.Property(e => e.FloatingSignatureLoc).HasDefaultValueSql("((0))");
            entity.Property(e => e.HoldingFontId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Holding_FontID");
            entity.Property(e => e.ImportFileNameEditin).HasDefaultValueSql("((0))");
            entity.Property(e => e.ImportLog)
                .HasMaxLength(24)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.IntegratedPrintEngin).HasDefaultValueSql("((1))");
            entity.Property(e => e.Language).HasMaxLength(3);
            entity.Property(e => e.LinkedBankAccountQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.LoginAttemptsAllowed).HasDefaultValueSql("((0))");
            entity.Property(e => e.MatchPayorAccountQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.Message2customers).HasMaxLength(70);
            entity.Property(e => e.MicrFontString)
                .HasMaxLength(57)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("micr_font_string");
            entity.Property(e => e.MicrModePrefix)
                .HasMaxLength(30)
                .HasColumnName("Micr_mode_Prefix");
            entity.Property(e => e.MicrModeSuffix)
                .HasMaxLength(30)
                .HasColumnName("Micr_mode_suffix");
            entity.Property(e => e.Micrfont)
                .HasMaxLength(1)
                .HasColumnName("MICRfont");
            entity.Property(e => e.NetworkDiskSerialNum).HasMaxLength(30);
            entity.Property(e => e.OutputXtemplateQ).HasColumnName("OutputXTemplateQ");
            entity.Property(e => e.PasswordSecurityFeat).HasMaxLength(10);
            entity.Property(e => e.PdfgenerationQ).HasColumnName("PDFgenerationQ");
            entity.Property(e => e.PermanentFontsQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.PollingModeQ)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Polling_ModeQ");
            entity.Property(e => e.PrinterPoolingAutoMo).HasDefaultValueSql("((0))");
            entity.Property(e => e.PrinterPoolingQ)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Printer_PoolingQ");
            entity.Property(e => e.PrinterSecurityFeatu).HasMaxLength(1);
            entity.Property(e => e.PrinterStyle)
                .HasMaxLength(30)
                .HasColumnName("Printer_Style");
            entity.Property(e => e.PrinterTimeoutAllowe).HasDefaultValueSql("((0))");
            entity.Property(e => e.PurgePayeeFileQ)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Purge_Payee_FileQ");
            entity.Property(e => e.ResourcesPassword).HasMaxLength(10);
            entity.Property(e => e.RigorousPrinterSta)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Rigorous_Printer_Sta");
            entity.Property(e => e.SerialStamp).HasMaxLength(30);
            entity.Property(e => e.SignatureAssigning)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Signature_Assigning_");
            entity.Property(e => e.SignatureCatergoryDe)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.SignatureCombosQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.SimultaneousVisualSi).HasDefaultValueSql("((0))");
            entity.Property(e => e.SingleCheckBatchesQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.SortRequestsB4Pri)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Sort_requests_b4_pri");
            entity.Property(e => e.Spare)
                .HasMaxLength(11)
                .HasColumnName("SPARE");
            entity.Property(e => e.StatusImportedChec)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Status_Imported_Chec");
            entity.Property(e => e.Style).HasMaxLength(1);
            entity.Property(e => e.TypeChecksLimithighX)
                .HasMaxLength(1)
                .HasColumnName("TypeChecksLIMIThighX");
            entity.Property(e => e.UniqueCheckNumbers)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Unique_Check_Numbers");
        });

        modelBuilder.Entity<GenSysUser>(entity =>
        {
            entity.HasKey(e => e.NumberOfUsers);

            entity.ToTable(tb => tb.HasTrigger("TRG_GenSysUsers"));

            entity.Property(e => e.NumberOfUsers).HasMaxLength(50);
            entity.Property(e => e.LicenseDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TRG_Groups"));

            entity.Property(e => e.GroupId)
                .HasMaxLength(10)
                .HasColumnName("GroupID");
            entity.Property(e => e.GDescription)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("gDescription");
        });

        modelBuilder.Entity<GroupRight>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.RightId });

            entity.ToTable(tb => tb.HasTrigger("TRG_GroupRights"));

            entity.Property(e => e.GroupId)
                .HasMaxLength(10)
                .HasColumnName("GroupID");
            entity.Property(e => e.RightId)
                .HasMaxLength(10)
                .HasColumnName("RightID");
            entity.Property(e => e.GrAssignedQ)
                .HasDefaultValueSql("((0))")
                .HasColumnName("grAssignedQ");
        });

        modelBuilder.Entity<IeScreenDet>(entity =>
        {
            entity.HasKey(e => new { e.GenCode, e.RecType, e.IeidFieldCode });

            entity.ToTable("ieScreenDet", tb => tb.HasTrigger("TRG_ieScreenDet"));

            entity.Property(e => e.GenCode).HasMaxLength(4);
            entity.Property(e => e.RecType).HasMaxLength(1);
            entity.Property(e => e.IeidFieldCode)
                .HasMaxLength(4)
                .HasColumnName("ieidFieldCode");
            entity.Property(e => e.IeidDescription)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieidDescription");
            entity.Property(e => e.IeidLengthInFile)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieidLengthInFile");
            entity.Property(e => e.IeidPosition)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieidPosition");
            entity.Property(e => e.Ieidtype)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieidtype");
            entity.Property(e => e.IesdFiller)
                .HasMaxLength(43)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("iesdFILLER");
            entity.Property(e => e.IesdKey)
                .HasDefaultValueSql("((0))")
                .HasColumnName("iesdKey");
            entity.Property(e => e.IesdMask)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("iesdMask");
        });

        modelBuilder.Entity<IeScreenHead>(entity =>
        {
            entity.HasKey(e => new { e.IeihPurpose, e.GenCode, e.RecType });

            entity.ToTable("ieScreenHead", tb => tb.HasTrigger("TRG_ieScreenHead"));

            entity.Property(e => e.IeihPurpose)
                .HasMaxLength(1)
                .HasColumnName("ieihPurpose");
            entity.Property(e => e.GenCode).HasMaxLength(4);
            entity.Property(e => e.RecType).HasMaxLength(1);
            entity.Property(e => e.IehPaddingChar4Expor)
                .HasDefaultValueSql("((0))")
                .HasColumnName("iehPaddingChar4Expor");
            entity.Property(e => e.IeihAppl2run)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieihAppl2run");
            entity.Property(e => e.IeihDivideAmountsBy)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieihDivideAmountsBy");
            entity.Property(e => e.IeihEngineVersion)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieihEngineVersion");
            entity.Property(e => e.IeihFieldSeparatorDe)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieihFieldSeparatorDe");
            entity.Property(e => e.IeihGenCheckNumberQ)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieihGenCheckNumberQ");
            entity.Property(e => e.IeihGenDescript)
                .HasMaxLength(57)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieihGenDescript");
            entity.Property(e => e.IeihModeVertHoriz)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieihModeVertHoriz");
            entity.Property(e => e.IeihOmitBlanksQ)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieihOmitBlanksQ");
            entity.Property(e => e.IeihSelectedQ)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ieihSelectedQ");
            entity.Property(e => e.IeihSpare)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieihSpare");
            entity.Property(e => e.Ieihfilter)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieihfilter");
            entity.Property(e => e.Ieihpath)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieihpath");
            entity.Property(e => e.IeshFiller)
                .HasMaxLength(81)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieshFILLER");
            entity.Property(e => e.IeshTimer)
                .HasDefaultValueSql("((5))")
                .HasColumnName("ieshTimer");
            entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<Iedetail>(entity =>
        {
            entity.HasKey(e => new { e.GeneralCode, e.RecordType, e.FieldCode });

            entity.ToTable("IEdetail", tb => tb.HasTrigger("TRG_IEdetail"));

            entity.Property(e => e.GeneralCode).HasMaxLength(4);
            entity.Property(e => e.RecordType).HasMaxLength(1);
            entity.Property(e => e.FieldCode).HasMaxLength(4);
            entity.Property(e => e.ColDet1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ColDet2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ColDet3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.IedKey)
                .HasDefaultValueSql("((0))")
                .HasColumnName("iedKey");
            entity.Property(e => e.IedRealQ)
                .HasDefaultValueSql("((1))")
                .HasColumnName("iedRealQ");
            entity.Property(e => e.IeidDescription)
                .HasMaxLength(29)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieidDescription");
            entity.Property(e => e.IeidFieldLengh)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieidFieldLengh");
            entity.Property(e => e.IeidOffset)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieidOffset");
            entity.Property(e => e.IeidType)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieidType");
        });

        modelBuilder.Entity<Ieheader>(entity =>
        {
            entity.HasKey(e => new { e.Purpose, e.GeneralCode, e.RecordType });

            entity.ToTable("IEheader");

            entity.Property(e => e.Purpose).HasMaxLength(1);
            entity.Property(e => e.GeneralCode).HasMaxLength(4);
            entity.Property(e => e.RecordType).HasMaxLength(1);
            entity.Property(e => e.Column1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Column2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Column3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Column4)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Column5)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Column6)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Column7)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Column8)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.IehPaddingChar4Expor)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("iehPaddingChar4Expor");
            entity.Property(e => e.IeihAppl2run)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieihAppl2run");
            entity.Property(e => e.IeihDivideMultiplyAm)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ieihDivideMultiplyAm");
            entity.Property(e => e.IeihEngineVersion)
                .HasDefaultValueSql("((4))")
                .HasColumnName("ieihEngineVersion");
            entity.Property(e => e.IeihFilter)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieihFilter");
            entity.Property(e => e.IeihGeneralDescripti)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieihGeneralDescripti");
            entity.Property(e => e.IeihGenerateCheckNum)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieihGenerateCheckNum");
            entity.Property(e => e.IeihModeManAuto)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieihModeManAuto");
            entity.Property(e => e.IeihOmitBlanksQ)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieihOmitBlanksQ");
            entity.Property(e => e.IeihSingleRecDetailH)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieihSingleRecDetailH");
            entity.Property(e => e.IeihfieldDelimiter)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieihfieldDelimiter");
            entity.Property(e => e.Ieihpath)
                .HasMaxLength(120)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieihpath");
            entity.Property(e => e.IeihselectedQ)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ieihselectedQ");
            entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
            entity.Property(e => e.Timer).HasDefaultValueSql("((5))");
        });

        modelBuilder.Entity<IelayoutLineItemX>(entity =>
        {
            entity.HasKey(e => new { e.GeneralCode, e.FieldCode, e.IeXkey, e.IeXparentCode });

            entity.ToTable("IElayoutLineItemX", tb => tb.HasTrigger("TRG_IElayoutLineItemX"));

            entity.Property(e => e.GeneralCode).HasMaxLength(4);
            entity.Property(e => e.FieldCode).HasMaxLength(4);
            entity.Property(e => e.IeXkey).HasColumnName("ieXKey");
            entity.Property(e => e.IeXparentCode)
                .HasMaxLength(4)
                .HasColumnName("ieXParentCode");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.IeXdescription)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieXDescription");
            entity.Property(e => e.IeXlength)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieXLength");
            entity.Property(e => e.IeXoffset)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieXOFFSET");
            entity.Property(e => e.IeXoperatorX)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'I')")
                .HasColumnName("ieXOperatorX");
            entity.Property(e => e.IeXtype)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieXtype");
            entity.Property(e => e.RecordType)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.XFiller)
                .HasMaxLength(26)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("xFILLER");
            entity.Property(e => e.XdataOperand)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("XDataOperand");
        });

        modelBuilder.Entity<IelayoutLineheader>(entity =>
        {
            entity.HasKey(e => new { e.GeneralCode, e.RecordType, e.IeidLinecode });

            entity.ToTable("IElayoutLineheader", tb => tb.HasTrigger("TRG_IElayoutLineheader"));

            entity.Property(e => e.GeneralCode).HasMaxLength(4);
            entity.Property(e => e.RecordType).HasMaxLength(1);
            entity.Property(e => e.IeidLinecode)
                .HasMaxLength(4)
                .HasColumnName("ieidLINEcode");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Filler)
                .HasMaxLength(88)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("FILLER");
            entity.Property(e => e.IeidDescription)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieidDescription");
            entity.Property(e => e.IeidOperation)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieidOperation");
        });

        modelBuilder.Entity<IelayoutlineItem>(entity =>
        {
            entity.HasKey(e => new { e.GeneralCode, e.RecordType, e.FieldCode, e.Kkey, e.KparentCode });

            entity.ToTable("IElayoutlineItem", tb => tb.HasTrigger("TRG_IElayoutlineItem"));

            entity.Property(e => e.GeneralCode).HasMaxLength(4);
            entity.Property(e => e.RecordType).HasMaxLength(1);
            entity.Property(e => e.FieldCode).HasMaxLength(4);
            entity.Property(e => e.Kkey).HasColumnName("KKey");
            entity.Property(e => e.KparentCode)
                .HasMaxLength(4)
                .HasColumnName("KParentCode");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Constant)
                .HasMaxLength(59)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.IeidDescription)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieidDescription");
            entity.Property(e => e.IeidLength)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieidLength");
            entity.Property(e => e.IeidOffsetpos)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieidOFFSETpos");
            entity.Property(e => e.IeidType)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ieidType");
        });

        modelBuilder.Entity<IesortDefinit>(entity =>
        {
            entity.HasKey(e => new { e.IesGenCode, e.IesRecType, e.IesFieldCode });

            entity.ToTable("IESortDefinit", tb => tb.HasTrigger("TRG_IESortDefinit"));

            entity.Property(e => e.IesGenCode)
                .HasMaxLength(4)
                .HasColumnName("iesGenCode");
            entity.Property(e => e.IesRecType)
                .HasMaxLength(1)
                .HasColumnName("iesRecType");
            entity.Property(e => e.IesFieldCode)
                .HasMaxLength(4)
                .HasColumnName("iesFieldCode");
            entity.Property(e => e.IeFieldLength)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ieFieldLength");
            entity.Property(e => e.IesCharPosition)
                .HasDefaultValueSql("((0))")
                .HasColumnName("iesCharPosition");
            entity.Property(e => e.IesDataType)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("iesDataType");
            entity.Property(e => e.IesDescript)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("iesDescript");
            entity.Property(e => e.IesFiller)
                .HasMaxLength(61)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("iesFILLER");
            entity.Property(e => e.IesKey)
                .HasDefaultValueSql("((0))")
                .HasColumnName("iesKey");
            entity.Property(e => e.IesMask)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("iesMASK");
            entity.Property(e => e.IesOmitPauseOnChange)
                .HasDefaultValueSql("((0))")
                .HasColumnName("iesOmitPauseOnChange");
            entity.Property(e => e.IesSortType)
                .HasMaxLength(10)
                .HasColumnName("iesSortType");
        });

        modelBuilder.Entity<Ietemplate>(entity =>
        {
            entity.HasKey(e => new { e.Tapplication2run, e.TrecordType, e.Tkey });

            entity.ToTable("IETemplate", tb => tb.HasTrigger("TRG_IETemplate"));

            entity.Property(e => e.Tapplication2run)
                .HasMaxLength(2)
                .HasColumnName("TApplication2run");
            entity.Property(e => e.TrecordType)
                .HasMaxLength(1)
                .HasColumnName("TRecordType");
            entity.Property(e => e.Tkey).HasColumnName("TKey");
            entity.Property(e => e.Tclassifier)
                .HasMaxLength(20)
                .HasColumnName("TClassifier");
            entity.Property(e => e.Tdescription)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("TDescription");
            entity.Property(e => e.TessentialQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.Tlength)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TLength");
            entity.Property(e => e.TselectedQ).HasDefaultValueSql("((1))");
            entity.Property(e => e.Ttype)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<ImpCheckLog>(entity =>
        {
            entity.HasKey(e => new { e.BatchId, e.AccountId, e.BankId });

            entity.ToTable("ImpCheckLog", tb => tb.HasTrigger("TRG_ImpCheckLog"));

            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.AccountId)
                .HasMaxLength(16)
                .HasColumnName("Account_ID");
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .HasColumnName("Bank_ID");
            entity.Property(e => e.CheckNumber)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PrintDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.PrintTime).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<ImportHeader>(entity =>
        {
            entity.HasKey(e => e.BatchId);

            entity.ToTable("ImportHeader", tb => tb.HasTrigger("TRG_ImportHeader"));

            entity.Property(e => e.BatchId)
                .ValueGeneratedNever()
                .HasColumnName("Batch_ID");
            entity.Property(e => e.Filefilter)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filefilter");
            entity.Property(e => e.Filenameih)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("FILENAMEih");
            entity.Property(e => e.Filesizeih)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("FILESIZEih");
            entity.Property(e => e.Filler)
                .HasMaxLength(135)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler");
            entity.Property(e => e.Importdate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IMPORTDATE");
            entity.Property(e => e.Importtime)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IMPORTTIME");
            entity.Property(e => e.RecordType)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Recordcode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.ToTable("Language", tb => tb.HasTrigger("TRG_Language"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.English).HasMaxLength(500);
            entity.Property(e => e.France).HasMaxLength(500);
            entity.Property(e => e.Language1).HasMaxLength(500);
            entity.Property(e => e.Language2).HasMaxLength(500);
            entity.Property(e => e.Language3).HasMaxLength(500);
            entity.Property(e => e.Language4).HasMaxLength(500);
            entity.Property(e => e.Language5).HasMaxLength(500);
            entity.Property(e => e.Spanish).HasMaxLength(500);
        });

        modelBuilder.Entity<MicrlineLayout>(entity =>
        {
            entity.HasKey(e => e.BankId);

            entity.ToTable("MICRLineLayout");

            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .HasColumnName("Bank_ID");
            entity.Property(e => e.AccountLeftJustifyQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.AccountLength).HasDefaultValueSql("((0))");
            entity.Property(e => e.AmtLength).HasDefaultValueSql("((0))");
            entity.Property(e => e.Dummy1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("dummy1");
            entity.Property(e => e.Dummy2)
                .HasDefaultValueSql("((0))")
                .HasColumnName("dummy2");
            entity.Property(e => e.Filler1)
                .HasMaxLength(37)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler1");
            entity.Property(e => e.Micrline)
                .HasMaxLength(63)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("MICRLine");
            entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
            entity.Property(e => e.SerialLength).HasDefaultValueSql("((0))");
            entity.Property(e => e.TransLength).HasDefaultValueSql("((0))");
            entity.Property(e => e.UserFieldLeftJustify).HasDefaultValueSql("((0))");
            entity.Property(e => e.UserLength).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Bank).WithOne(p => p.MicrlineLayout)
                .HasForeignKey<MicrlineLayout>(d => d.BankId)
                .HasConstraintName("FK_MICRLineLayout_Banks");
        });

        modelBuilder.Entity<OutDataMapMaindet>(entity =>
        {
            entity.HasKey(e => new { e.LayoutId, e.FomrItemId, e.Seq2Print, e.DetSequence });

            entity.ToTable("outDataMapMAINDet", tb => tb.HasTrigger("TRG_outDataMapMAINDet"));

            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("LayoutID");
            entity.Property(e => e.FomrItemId).HasColumnName("fomrItemID");
            entity.Property(e => e.PropValue).HasDefaultValueSql("((0))");
            entity.Property(e => e.PropertyId)
                .HasMaxLength(20)
                .HasColumnName("PropertyID");
        });

        modelBuilder.Entity<OutDataMapMainhead>(entity =>
        {
            entity.HasKey(e => new { e.LayoutId, e.Group1, e.ProjectKey, e.Seq2Print });

            entity.ToTable("outDataMapMAINHead", tb => tb.HasTrigger("TRG_outDataMapMAINHead"));

            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .HasColumnName("LayoutID");
            entity.Property(e => e.Description2Print)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.EntityId).HasDefaultValueSql("((0))");
            entity.Property(e => e.Flags)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("flags");
            entity.Property(e => e.Mask)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Note)
                .HasMaxLength(52)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<OutMapDetailsStub>(entity =>
        {
            entity.HasKey(e => new { e.LayoutId, e.PrintSequences, e.Sequenceds });

            entity.ToTable("outMapDetailsSTUB", tb => tb.HasTrigger("TRG_outMapDetailsSTUB"));

            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .HasColumnName("LayoutID");
            entity.Property(e => e.Sequenceds).HasColumnName("sequenceds");
            entity.Property(e => e.EntityIdds)
                .HasDefaultValueSql("((0))")
                .HasColumnName("entityIDds");
            entity.Property(e => e.PropValueDs)
                .HasDefaultValueSql("((0))")
                .HasColumnName("propValueDs");
            entity.Property(e => e.PropertyIdds)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("propertyIDds");
        });

        modelBuilder.Entity<OutMapHeadStub>(entity =>
        {
            entity.HasKey(e => new { e.LayoutId, e.Groups, e.ProjectKey, e.PrintSequences });

            entity.ToTable("outMapHeadSTUB", tb => tb.HasTrigger("TRG_outMapHeadSTUB"));

            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .HasColumnName("LayoutID");
            entity.Property(e => e.EntityIds).HasDefaultValueSql("((0))");
            entity.Property(e => e.Flags)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("flags");
            entity.Property(e => e.Masks)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Notes)
                .HasMaxLength(52)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.StaticValue2Print)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<Payee>(entity =>
        {
            entity.ToTable("Payee", tb => tb.HasTrigger("TRG_Payee"));

            entity.HasIndex(e => e.Name1, "Payee_Idx").HasFillFactor(30);

            entity.Property(e => e.PayeeId)
                .HasMaxLength(22)
                .HasColumnName("PayeeID");
            entity.Property(e => e.AdditionalRef)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Address5)
                .HasMaxLength(45)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyCity)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyState)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyZip)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Contact)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CountryPhone)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DefaultDiscretionary)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DfiaccountNumber)
                .HasMaxLength(17)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("DFIAccountNumber");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("email");
            entity.Property(e => e.Filler1)
                .HasMaxLength(312)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler1");
            entity.Property(e => e.FontId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FontID");
            entity.Property(e => e.Name1)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Name2)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayAddress1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayAddress2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayAddress3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayAddress4)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayorId)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PayorID");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(7)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ReceivingCompanyName)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ReceivingDfiid)
                .HasMaxLength(9)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ReceivingDFIid");
            entity.Property(e => e.Spare1)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("spare1");
            entity.Property(e => e.TypeOfAccount)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<Payor>(entity =>
        {
            entity.HasKey(e => new { e.ProjectKey, e.Payorid });

            entity.ToTable("Payor");

            entity.HasIndex(e => e.Name1, "Payor_Index").HasFillFactor(30);

            entity.Property(e => e.Payorid).HasMaxLength(22);
            entity.Property(e => e.Achtype7DetailsNumbers)
                .HasDefaultValueSql("((9999))")
                .HasColumnName("ACHType7DetailsNumbers");
            entity.Property(e => e.Achtype7Q)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ACHType7Q");
            entity.Property(e => e.CompanyCity)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyState)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CompanyZip)
                .HasMaxLength(9)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Desc1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Desc2)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Desc3)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Dfiachcdv)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("DFIACHcdv");
            entity.Property(e => e.Filler2)
                .HasMaxLength(525)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler2");
            entity.Property(e => e.Font1).HasDefaultValueSql("(N'0')");
            entity.Property(e => e.Font2).HasDefaultValueSql("(N'0')");
            entity.Property(e => e.Font3).HasDefaultValueSql("(N'0')");
            entity.Property(e => e.Font4).HasDefaultValueSql("(N'0')");
            entity.Property(e => e.FontId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FontID");
            entity.Property(e => e.FtpProfile)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ftpProfile");
            entity.Property(e => e.InmediateOrigin)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Irscode)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("IRScode");
            entity.Property(e => e.MerchantId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MerchantID");
            entity.Property(e => e.Name1)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Name2)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.OdfiInmediateName)
                .HasMaxLength(23)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.OriginatingDfiid)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("originatingDFIid");
            entity.Property(e => e.PayAddress1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayAddress2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayAddress3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayAddress4)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<PclCheck>(entity =>
        {
            entity.HasKey(e => new { e.LayoutId, e.Group1, e.Order2Print });

            entity.ToTable("pclCHECK", tb => tb.HasTrigger("TRG_pclCHECK"));

            entity.HasIndex(e => e.LineProperties, "pclCheck_Idx").HasFillFactor(30);

            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .HasColumnName("LayoutID");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.EntityId).HasDefaultValueSql("((0))");
            entity.Property(e => e.Flags)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("flags");
            entity.Property(e => e.LineProperties)
                .HasMaxLength(150)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Mask)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Note)
                .HasMaxLength(52)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<PclStub>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pclSTUB", tb => tb.HasTrigger("TRG_pclSTUB"));

            entity.HasIndex(e => new { e.LayoutId, e.GroupS, e.Order2PrintS }, "pclStub_Idx").HasFillFactor(30);

            entity.Property(e => e.DescriptionS)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.EntityIdS).HasDefaultValueSql("((0))");
            entity.Property(e => e.FlagsS)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("LayoutID");
            entity.Property(e => e.LinePropertiesS)
                .HasMaxLength(150)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.MaskS)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.NoteS)
                .HasMaxLength(52)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<PosPayProf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PosPayProf");

            entity.HasIndex(e => new { e.BatchOrdate, e.SeqId }, "PosPay_Idx").HasFillFactor(30);

            entity.Property(e => e.AccountId)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Account_ID");
            entity.Property(e => e.AdditionalDescriptio)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Application)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Bank_ID");
            entity.Property(e => e.BatchOrdate)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("batchOrdate");
            entity.Property(e => e.DefinitionCode)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ExternalFunctionQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.Ftpprofile)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("FTPprofile");
            entity.Property(e => e.LastDefaultValue)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("LayoutID");
            entity.Property(e => e.Mode)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayorId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PayorID");
            entity.Property(e => e.PrintedDocumentsQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.SchedulerQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.SelectedBatch).HasDefaultValueSql("((0))");
            entity.Property(e => e.SelectedDateFrom).HasDefaultValueSql("((0))");
            entity.Property(e => e.SelectedDateTo).HasDefaultValueSql("((0))");
            entity.Property(e => e.SelectedQ).HasDefaultValueSql("((1))");
            entity.Property(e => e.SentDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.SentTime).HasDefaultValueSql("((0))");
            entity.Property(e => e.SeqId)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("SeqID");
        });

        modelBuilder.Entity<PropertyPcl>(entity =>
        {
            entity.HasKey(e => e.PropertyId);

            entity.ToTable("PropertyPCL", tb => tb.HasTrigger("TRG_PropertyPCL"));

            entity.Property(e => e.PropertyId)
                .HasMaxLength(20)
                .HasColumnName("PropertyID");
            entity.Property(e => e.PrefixCommand)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PtyDefaultSequence).HasDefaultValueSql("((0))");
            entity.Property(e => e.SuffixCommand)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<ReconcBtchDet>(entity =>
        {
            entity.HasKey(e => e.BatchId);

            entity.ToTable("Reconc_BtchDet", tb => tb.HasTrigger("TRG_Reconc_BtchDet"));

            entity.Property(e => e.BatchId)
                .ValueGeneratedNever()
                .HasColumnName("Batch_ID");
            entity.Property(e => e.AchGeneratedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.AchwhileprocessingFl)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ACHwhileprocessingFL");
            entity.Property(e => e.AllChecksBatchPrinte).HasDefaultValueSql("((0))");
            entity.Property(e => e.AutorizedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.BatchImportDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.BatchPostedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.BatchPurgeDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.BatchPurgedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.CopyprintedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.DatePosted).HasDefaultValueSql("((0))");
            entity.Property(e => e.DatePostedReptPrinte).HasDefaultValueSql("((0))");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Filler9915)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("FILLER99_15");
            entity.Property(e => e.GpbatchId)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("GPBatchId");
            entity.Property(e => e.Gpdate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("GPDate");
            entity.Property(e => e.ImportDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.ImportTime).HasDefaultValueSql("((0))");
            entity.Property(e => e.OtherInfo)
                .HasMaxLength(78)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Password1)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("password1");
            entity.Property(e => e.Password2)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("password2");
            entity.Property(e => e.PostedTobookQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.PostingGroupId)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.ServerRefresedQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.TimePosted).HasDefaultValueSql("((0))");
            entity.Property(e => e.TimePostedReportPrin).HasDefaultValueSql("((0))");
            entity.Property(e => e.TotalChecksinBatch).HasDefaultValueSql("((0))");
            entity.Property(e => e.Totalacknowledged)
                .HasDefaultValueSql("(N'')")
                .HasColumnType("money");
            entity.Property(e => e.Totalamountvalue)
                .HasDefaultValueSql("(N'')")
                .HasColumnType("money");
            entity.Property(e => e.TypeofBatch)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Userbatchid)
                .HasMaxLength(14)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("userbatchid");
        });

        modelBuilder.Entity<ReconcChecksH3>(entity =>
        {
            entity.HasKey(e => new { e.BatchId, e.RecordNo });

            entity.ToTable("Reconc_ChecksH3", tb => tb.HasTrigger("TRG_Reconc_ChecksH3"));

            entity.HasIndex(e => new { e.BatchId, e.CheckPrintedDateTime, e.AccountId, e.BankId, e.PayeeName, e.CheckAmount }, "Non-Clustered")
                .IsDescending(true, true, false, false, false, false)
                .HasFillFactor(30);

            entity.Property(e => e.BatchId).HasColumnName("Batch_ID");
            entity.Property(e => e.RecordNo).HasColumnName("Record_No");
            entity.Property(e => e.AccountId)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Account_ID");
            entity.Property(e => e.AccountType)
                .HasMaxLength(35)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Account_Type");
            entity.Property(e => e.AchStdEntryClassCode)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("achStdEntryClassCode");
            entity.Property(e => e.AchTranCode)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("achTranCode");
            entity.Property(e => e.AchTypeAcct)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("achTypeAcct");
            entity.Property(e => e.AchaddendaQ)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ACHAddendaQ");
            entity.Property(e => e.Achq)
                .HasDefaultValueSql("(N'0')")
                .HasColumnName("ACHQ");
            entity.Property(e => e.AchreEnableQ)
                .HasDefaultValueSql("(N'0')")
                .HasColumnName("ACHRe_EnableQ");
            entity.Property(e => e.AchroutingCdv)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ACHroutingCDV");
            entity.Property(e => e.AdditionalUserId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("AdditionalUserID");
            entity.Property(e => e.BankAddr1)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BankAddr2)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BankId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Bank_ID");
            entity.Property(e => e.BankName)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BarCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.BatchIdr)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BatchIDR");
            entity.Property(e => e.Cdv2)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CDV2");
            entity.Property(e => e.CdvAccountNo)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CDV_Account_No");
            entity.Property(e => e.CheckAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.CheckAmountAlpha)
                .HasMaxLength(120)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CheckDate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Check_Date");
            entity.Property(e => e.CheckDateAlpha)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CheckDateYear).HasDefaultValueSql("((0))");
            entity.Property(e => e.CheckNo)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Check_No");
            entity.Property(e => e.CheckPrintedDateTime)
                .HasDefaultValueSql("(((1)/(1))/(1))")
                .HasColumnType("datetime");
            entity.Property(e => e.CheckType)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.City)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ClaimOrPurchaseOrde)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Claim_orPurchaseOrde");
            entity.Property(e => e.ClientLocation)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Concept1)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Concept2)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Concept3)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Concept4)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ConsecutiveNumber)
                .HasMaxLength(13)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Contact)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.CopyPrinted).HasDefaultValueSql("((0))");
            entity.Property(e => e.CostCenter4Sign)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Counter).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreationDate).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreationTime).HasDefaultValueSql("((0))");
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.DateAlphaY2k)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("DateAlphaY2K");
            entity.Property(e => e.DfiacctNo)
                .HasMaxLength(17)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("DFIacctNo");
            entity.Property(e => e.DirectDepositAccNumb)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DirectDepositBankNam)
                .HasMaxLength(32)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Discounttotal)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.DontSendEmail).HasDefaultValueSql("((0))");
            entity.Property(e => e.EarnDeductAmt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("email");
            entity.Property(e => e.EncryptAmount).HasMaxLength(100);
            entity.Property(e => e.EncryptCheckNo).HasMaxLength(100);
            entity.Property(e => e.EncryptPayee).HasMaxLength(140);
            entity.Property(e => e.ExportQ).HasDefaultValueSql("(N'0')");
            entity.Property(e => e.Filler15)
                .HasMaxLength(33)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler15");
            entity.Property(e => e.ForTheAccountOf)
                .HasMaxLength(75)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("For_the_account_of");
            entity.Property(e => e.GlCredit)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("GL_Credit");
            entity.Property(e => e.GlDebit)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("GL_Debit");
            entity.Property(e => e.GlacctReference)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("GLAcctReference");
            entity.Property(e => e.Grosstotal)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.ImportDate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Import_Date");
            entity.Property(e => e.InvoiceDate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Invoice_Date");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Irscode)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("IRScode");
            entity.Property(e => e.NumberofSignatures).HasDefaultValueSql("((0))");
            entity.Property(e => e.PayeeAddr1)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeAddr2)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeAddr3)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeAddr4)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeAddr5)
                .HasMaxLength(60)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayeeId)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PayeeID");
            entity.Property(e => e.PayeeName)
                .HasMaxLength(70)
                .HasDefaultValueSql("('VOID VOID')");
            entity.Property(e => e.PayeeName2)
                .HasMaxLength(48)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PayorId)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PayorID");
            entity.Property(e => e.PayorName)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Payor_Name");
            entity.Property(e => e.Pdfname)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PDFName");
            entity.Property(e => e.PdfuniqueNameQ)
                .HasDefaultValueSql("(N'1')")
                .HasColumnName("PDFUniqueNameQ");
            entity.Property(e => e.PositivePayQ).HasDefaultValueSql("(N'0')");
            entity.Property(e => e.Printed).HasDefaultValueSql("((0))");
            entity.Property(e => e.PrintedBy)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Printed_By");
            entity.Property(e => e.PrintedDate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Printed_Date");
            entity.Property(e => e.PrintedDateAlpha)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Printed_DateAlpha");
            entity.Property(e => e.PrintedTime)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Printed_Time");
            entity.Property(e => e.PrintedType)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Printed_Type");
            entity.Property(e => e.ProcessTime)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ProgramName)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Program_Name");
            entity.Property(e => e.RePrintDateTime)
                .HasDefaultValueSql("(N'getdate()')")
                .HasColumnType("datetime");
            entity.Property(e => e.RePrintReason)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RePrintUserId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("RePrintUserID");
            entity.Property(e => e.RePrinted).HasDefaultValueSql("((0))");
            entity.Property(e => e.RecBatchPurgeQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.RecCheckNo)
                .HasMaxLength(22)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("RecCheck_No");
            entity.Property(e => e.ReceivingDfi)
                .HasMaxLength(9)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ReceivingDFI");
            entity.Property(e => e.ReconcDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ReconciledQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.RecordNoR).HasDefaultValueSql("((0))");
            entity.Property(e => e.ReprintCount).HasDefaultValueSql("(N'0')");
            entity.Property(e => e.RequestNumber)
                .HasMaxLength(13)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RequesterUser)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RoutingNumberMicr)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("RoutingNumberMICR");
            entity.Property(e => e.Signature)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Signature1)
                .HasMaxLength(24)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Signature2)
                .HasMaxLength(24)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.SpecialLongDescripti)
                .HasMaxLength(180)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Ssn)
                .HasMaxLength(11)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("SSN");
            entity.Property(e => e.State)
                .HasMaxLength(5)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.StringAmount2)
                .HasMaxLength(48)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.StringAmount3)
                .HasMaxLength(27)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ToBePrinted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("To_Be_Printed");
            entity.Property(e => e.Transit1)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Transit2)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Us1200)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("US1200");
            entity.Property(e => e.Us2100)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("US2100");
            entity.Property(e => e.Us3100)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("US3100");
            entity.Property(e => e.Us4200)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("US4200");
            entity.Property(e => e.UserFieldMicr)
                .HasMaxLength(15)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserFieldMICR");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserID");
            entity.Property(e => e.UserStr10)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr11)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr12)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr13)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr14)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr15)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr16)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr17)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr18)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr19)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr20)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UserStr5)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr6)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr7)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr8)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserStr9)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .IsFixedLength();
            entity.Property(e => e.UserVal13)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal14)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserVal15)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.UserbatchId)
                .HasMaxLength(24)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserbatchID");
            entity.Property(e => e.Userval1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval1");
            entity.Property(e => e.Userval10)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval10");
            entity.Property(e => e.Userval11)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval11");
            entity.Property(e => e.Userval12)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval12");
            entity.Property(e => e.Userval16)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval16");
            entity.Property(e => e.Userval17)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval17");
            entity.Property(e => e.Userval18)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval18");
            entity.Property(e => e.Userval2)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval2");
            entity.Property(e => e.Userval3)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval3");
            entity.Property(e => e.Userval4)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval4");
            entity.Property(e => e.Userval5)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval5");
            entity.Property(e => e.Userval6)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval6");
            entity.Property(e => e.Userval7)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval7");
            entity.Property(e => e.Userval8)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval8");
            entity.Property(e => e.Userval9)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("USERval9");
            entity.Property(e => e.VendorRedundant)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Vendor_Redundant");
            entity.Property(e => e.Void)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VOID");
            entity.Property(e => e.VoidDate)
                .HasMaxLength(8)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.VoucherOrPurOrder)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.WhileProcessingVoi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("While_Processing_Voi");
            entity.Property(e => e.WhileSigningFlag).HasDefaultValueSql("((0))");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<ReconcImportHeader>(entity =>
        {
            entity.HasKey(e => e.BatchId);

            entity.ToTable("Reconc_ImportHeader", tb => tb.HasTrigger("TRG_Reconc_ImportHeader"));

            entity.Property(e => e.BatchId)
                .ValueGeneratedNever()
                .HasColumnName("Batch_ID");
            entity.Property(e => e.Filefilter)
                .HasMaxLength(12)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filefilter");
            entity.Property(e => e.Filenameih)
                .HasMaxLength(80)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("FILENAMEih");
            entity.Property(e => e.Filesizeih)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("FILESIZEih");
            entity.Property(e => e.Filler)
                .HasMaxLength(135)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler");
            entity.Property(e => e.Importdate)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IMPORTDATE");
            entity.Property(e => e.Importtime)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IMPORTTIME");
            entity.Property(e => e.RecordType)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Recordcode)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<ReportsXright>(entity =>
        {
            entity.HasKey(e => e.RightId);

            entity.ToTable(tb => tb.HasTrigger("TRG_ReportsXrights"));

            entity.Property(e => e.RightId)
                .HasMaxLength(10)
                .HasColumnName("RightID");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ExProg2Call)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ExternalRepQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.Filler)
                .HasMaxLength(17)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler");
        });

        modelBuilder.Entity<Right>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TRG_Rights"));

            entity.Property(e => e.RightId)
                .HasMaxLength(10)
                .HasColumnName("RightID");
            entity.Property(e => e.DescrptMainMenu)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DescrptSubMenu)
                .HasMaxLength(150)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descrption1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Descrption2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.RDescription)
                .HasMaxLength(28)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("rDescription");
            entity.Property(e => e.RDisableAlertsL)
                .HasDefaultValueSql("((0))")
                .HasColumnName("rDisableAlertsL");
            entity.Property(e => e.RReqAuth)
                .HasDefaultValueSql("((0))")
                .HasColumnName("rReqAuth");
        });

        modelBuilder.Entity<SignComboD>(entity =>
        {
            entity.HasKey(e => new { e.SeqNo, e.FontId });

            entity.ToTable("SignComboD", tb => tb.HasTrigger("TRG_SignComboD"));

            entity.Property(e => e.FontId).HasColumnName("FontID");
            entity.Property(e => e.FillerCd)
                .HasMaxLength(14)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillerCd");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<SignComboH>(entity =>
        {
            entity.HasKey(e => new { e.SeqNo, e.PayorId });

            entity.ToTable("SignComboH", tb => tb.HasTrigger("TRG_SignComboH"));

            entity.Property(e => e.PayorId)
                .HasMaxLength(22)
                .HasColumnName("PayorID");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FillerCh)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillerCh");
            entity.Property(e => e.FromAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.Reference)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.SuggestedFromValue)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
            entity.Property(e => e.SuggestedToValue)
                .HasDefaultValueSql("((1))")
                .HasColumnType("money");
            entity.Property(e => e.ToAmount)
                .HasDefaultValueSql("((1))")
                .HasColumnType("money");
        });

        modelBuilder.Entity<SignatCostCenter>(entity =>
        {
            entity.HasKey(e => new { e.TypeOfAccount, e.FontId, e.ProjectKey });

            entity.ToTable("signatCostCenters", tb => tb.HasTrigger("TRG_signatCostCenters"));

            entity.Property(e => e.TypeOfAccount).HasMaxLength(12);
            entity.Property(e => e.FontId).HasColumnName("FontID");
            entity.Property(e => e.Filler)
                .HasMaxLength(38)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler");
            entity.Property(e => e.MaxValue)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money");
        });

        modelBuilder.Entity<SynLinkChildDoc>(entity =>
        {
            entity.HasKey(e => new { e.LayoutId, e.SlUsePurpose, e.ProjectKey });

            entity.ToTable("SynLinkChildDoc", tb => tb.HasTrigger("TRG_SynLinkChildDoc"));

            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .HasColumnName("LayoutID");
            entity.Property(e => e.SlUsePurpose)
                .HasMaxLength(5)
                .HasColumnName("slUsePurpose");
            entity.Property(e => e.Desc1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Desc2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Desc3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.SlAdditionalFlags)
                .HasMaxLength(34)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("slAdditionalFlags");
            entity.Property(e => e.SlAppl)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("slAppl");
            entity.Property(e => e.SlDocsXpage)
                .HasDefaultValueSql("((0))")
                .HasColumnName("slDocsXpage");
            entity.Property(e => e.SlExportId)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("slExportID");
            entity.Property(e => e.SlInitString)
                .HasMaxLength(39)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("slInitString");
            entity.Property(e => e.SlLinesXdoc)
                .HasDefaultValueSql("((0))")
                .HasColumnName("slLinesXdoc");
            entity.Property(e => e.SlMode)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("slMode");
            entity.Property(e => e.SlOmitInit)
                .HasDefaultValueSql("((0))")
                .HasColumnName("slOmitInit");
            entity.Property(e => e.SlOrientation)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))")
                .HasColumnName("slOrientation");
            entity.Property(e => e.SlPaperSize)
                .HasMaxLength(2)
                .HasDefaultValueSql("((2))")
                .HasColumnName("slPaperSize");
            entity.Property(e => e.SlPrinterSecFeature)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("slPrinterSecFeature");
            entity.Property(e => e.SlTempFile)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("slTempFile");
            entity.Property(e => e.SlTray)
                .HasMaxLength(1)
                .HasDefaultValueSql("((5))")
                .HasColumnName("slTray");
            entity.Property(e => e.SlformId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("slformID");
        });

        modelBuilder.Entity<Synonym>(entity =>
        {
            entity.HasKey(e => new { e.UserCodeDocType, e.LayoutId, e.ProjectKey });

            entity.ToTable(tb => tb.HasTrigger("TRG_Synonyms"));

            entity.Property(e => e.UserCodeDocType).HasMaxLength(10);
            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .HasColumnName("LayoutID");
            entity.Property(e => e.Application).HasMaxLength(2);
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DescripSyn)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DetailStyle)
                .HasMaxLength(1)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.DocsXpage).HasDefaultValueSql("((0))");
            entity.Property(e => e.EndofBatchPathS)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.EobName)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("eobName");
            entity.Property(e => e.ExportFileCode)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Filler)
                .HasMaxLength(247)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("filler");
            entity.Property(e => e.HorizMicradj)
                .HasDefaultValueSql("((0))")
                .HasColumnName("HorizMICRadj");
            entity.Property(e => e.IntegratedPrintEngin).HasDefaultValueSql("((1))");
            entity.Property(e => e.PostProcessing)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.PrintEnginePath)
                .HasMaxLength(70)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ScreenCode)
                .HasMaxLength(4)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.VertMicradj)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VertMICRadj");
        });

        modelBuilder.Entity<Sysdiagram>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sysdiagrams", tb => tb.HasTrigger("TRG_sysdiagrams"));

            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.DiagramId).HasColumnName("diagram_id");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.PrincipalId).HasColumnName("principal_id");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<TemplatesxPrinter>(entity =>
        {
            entity.HasKey(e => new { e.LayoutId, e.ProjectKey });

            entity.ToTable(tb => tb.HasTrigger("TRG_TemplatesxPrinters"));

            entity.Property(e => e.LayoutId)
                .HasMaxLength(25)
                .HasColumnName("LayoutID");
            entity.Property(e => e.AssignedPrinter).HasMaxLength(100);
            entity.Property(e => e.Col1).HasMaxLength(50);
            entity.Property(e => e.Col2).HasMaxLength(50);
            entity.Property(e => e.Col3).HasMaxLength(50);
            entity.Property(e => e.InitString).HasMaxLength(100);
            entity.Property(e => e.Initializ).HasMaxLength(100);
            entity.Property(e => e.MarginName).HasMaxLength(100);
            entity.Property(e => e.Orientation).HasMaxLength(1);
            entity.Property(e => e.PaperSize).HasMaxLength(2);
            entity.Property(e => e.PrinterId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PrinterID");
            entity.Property(e => e.PrinterSecurityFeatu).HasMaxLength(1);
        });

        modelBuilder.Entity<TemplatesxPrintersAll>(entity =>
        {
            entity.ToTable("TemplatesxPrintersALL", tb => tb.HasTrigger("TRG_TemplatesxPrintersALL"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PrinterName)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ServerName)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ShareName)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.UpdDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UserID");
            entity.Property(e => e.WindowsPc)
                .HasMaxLength(150)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("WindowsPC");
            entity.Property(e => e.WindowsUser)
                .HasMaxLength(150)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<TemplatesxPrintersByUsersCheckBook>(entity =>
        {
            entity.HasKey(e => new { e.LayoutId, e.UserId });

            entity.ToTable("TemplatesxPrinters_ByUsersCheckBooks", tb => tb.HasTrigger("TRG_TemplatesxPrinters_ByUsersCheckBooks"));

            entity.Property(e => e.LayoutId)
                .HasMaxLength(25)
                .HasColumnName("LayoutID");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .HasColumnName("UserID");
            entity.Property(e => e.DateTimeEdit)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<TemplatesxPrintersByUsersManageCheck>(entity =>
        {
            entity.HasKey(e => new { e.LayoutId, e.UserId });

            entity.ToTable("TemplatesxPrinters_ByUsersManageChecks", tb => tb.HasTrigger("TRG_TemplatesxPrinters_ByUsersManageChecks"));

            entity.Property(e => e.LayoutId)
                .HasMaxLength(25)
                .HasColumnName("LayoutID");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .HasColumnName("UserID");
            entity.Property(e => e.DateTimeEdit)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<TemplatesxPrintersPcsNetwork>(entity =>
        {
            entity.HasKey(e => e.Idindex);

            entity.ToTable("TemplatesxPrintersPCsNetwork", tb => tb.HasTrigger("TRG_TemplatesxPrintersPCsNetwork"));

            entity.Property(e => e.Idindex).HasColumnName("IDIndex");
            entity.Property(e => e.Col1).HasMaxLength(50);
            entity.Property(e => e.Col2).HasMaxLength(50);
            entity.Property(e => e.Col3).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(400);
            entity.Property(e => e.Pcname)
                .HasMaxLength(300)
                .HasColumnName("PCName");
        });

        modelBuilder.Entity<TemplatesxPrintersSplit>(entity =>
        {
            entity.HasKey(e => e.SplitId);

            entity.ToTable("TemplatesxPrintersSplit", tb => tb.HasTrigger("TRG_TemplatesxPrintersSplit"));

            entity.Property(e => e.SplitId).HasColumnName("SplitID");
            entity.Property(e => e.AssignedPrinter).HasMaxLength(100);
            entity.Property(e => e.LayoutId)
                .HasMaxLength(25)
                .HasColumnName("LayoutID");
            entity.Property(e => e.LayoutPrinterLocation).HasMaxLength(25);
            entity.Property(e => e.PrinterDescription).HasMaxLength(100);
            entity.Property(e => e.PrinterId).HasColumnName("PrinterID");
            entity.Property(e => e.PrinterShareName).HasMaxLength(50);
            entity.Property(e => e.ServerName).HasMaxLength(50);
        });

        modelBuilder.Entity<TemplxPrinterSecurityFeat>(entity =>
        {
            entity.HasKey(e => e.PrinterSecurityFeatu);

            entity.ToTable("TemplxPrinterSecurityFeat", tb => tb.HasTrigger("TRG_TemplxPrinterSecurityFeat"));

            entity.Property(e => e.PrinterSecurityFeatu).HasMaxLength(1);
            entity.Property(e => e.AmtPrefix)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.AmtSufix)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Micrprefix)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("MICRPrefix");
            entity.Property(e => e.Micrsufix)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("MICRSufix");
            entity.Property(e => e.Pclinitialization)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PCLInitialization");
            entity.Property(e => e.Pclprefix)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PCLPrefix");
            entity.Property(e => e.Pclsuffix)
                .HasMaxLength(150)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("PCLSuffix");
        });

        modelBuilder.Entity<TraysXlayoutPool>(entity =>
        {
            entity.HasKey(e => e.LayoutId);

            entity.ToTable("traysXlayoutPool", tb => tb.HasTrigger("TRG_traysXlayoutPool"));

            entity.Property(e => e.LayoutId)
                .HasMaxLength(10)
                .HasColumnName("LayoutID");
            entity.Property(e => e.AssignedPrinterP)
                .HasMaxLength(39)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.InitStringP)
                .HasMaxLength(39)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.MarginNameP)
                .HasMaxLength(29)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.OmitInitializationQp).HasDefaultValueSql("((0))");
            entity.Property(e => e.OrderNumberP).HasDefaultValueSql("((0))");
            entity.Property(e => e.OrientationP)
                .HasMaxLength(1)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.PaperSizeP)
                .HasMaxLength(2)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.ProjectKey).HasDefaultValueSql("((0))");
            entity.Property(e => e.SelectedQp).HasDefaultValueSql("((0))");
            entity.Property(e => e.TrayNumberP).HasDefaultValueSql("((5))");
        });

        modelBuilder.Entity<TypesAccount>(entity =>
        {
            entity.HasKey(e => new { e.TypeofAccount, e.ProjectKey });

            entity.ToTable(tb => tb.HasTrigger("TRG_TypesAccounts"));

            entity.Property(e => e.TypeofAccount).HasMaxLength(12);
            entity.Property(e => e.AccountId)
                .HasMaxLength(16)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("Account_ID");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.FillerTa)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("fillerTA");
            entity.Property(e => e.MaxValueDefault)
                .HasDefaultValueSql("(N'')")
                .HasColumnType("money");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TRG_Users"));

            entity.HasIndex(e => new { e.LastPasscodeChange, e.EncryptPassword }, "Users_Idx").HasFillFactor(30);

            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .HasColumnName("UserID");
            entity.Property(e => e.Desc1)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Desc2)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.EncryptPassword).HasMaxLength(50);
            entity.Property(e => e.ExpiredPasscodeQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.InactiveQ).HasDefaultValueSql("((0))");
            entity.Property(e => e.LastPasscodeChange)
                .HasDefaultValueSql("((0))")
                .HasColumnName("lastPasscodeChange");
            entity.Property(e => e.NoofLogin).HasDefaultValueSql("((0))");
            entity.Property(e => e.UPasscode)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("uPasscode");
            entity.Property(e => e.Ufrist)
                .HasMaxLength(35)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UFrist");
            entity.Property(e => e.Ulast)
                .HasMaxLength(35)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("ULast");
            entity.Property(e => e.UserInfo)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'')");
            entity.Property(e => e.Utitle)
                .HasMaxLength(30)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("UTitle");
        });

        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.UserId });

            entity.ToTable(tb => tb.HasTrigger("TRG_UserGroups"));

            entity.Property(e => e.GroupId)
                .HasMaxLength(10)
                .HasColumnName("GroupID");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .HasColumnName("UserID");
            entity.Property(e => e.UgAssignedQ)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ugAssignedQ");

            entity.HasOne(d => d.User).WithMany(p => p.UserGroups)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserGroups_Users");
        });

        modelBuilder.Entity<UserPassHistory>(entity =>
        {
            entity.HasKey(e => e.IdentityId).HasName("PK_User_PassHistory_1");

            entity.ToTable("User_PassHistory", tb => tb.HasTrigger("TRG_User_PassHistory"));

            entity.Property(e => e.IdentityId).HasColumnName("IdentityID");
            entity.Property(e => e.PassDate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<UserRight>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RightId });

            entity.ToTable(tb => tb.HasTrigger("TRG_UserRights"));

            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .HasColumnName("UserID");
            entity.Property(e => e.RightId)
                .HasMaxLength(10)
                .HasColumnName("RightID");
            entity.Property(e => e.GroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("GroupID");
            entity.Property(e => e.UrAssigned)
                .HasDefaultValueSql("((0))")
                .HasColumnName("urAssigned");

            entity.HasOne(d => d.User).WithMany(p => p.UserRights)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserRights_Users");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
