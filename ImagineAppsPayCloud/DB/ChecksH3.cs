﻿using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class ChecksH3
{
    public long BatchId { get; set; }

    public int RecordNo { get; set; }

    public string? CheckNo { get; set; }

    public string? BankId { get; set; }

    public string AccountId { get; set; } = null!;

    public int? CheckDate { get; set; }

    public string? VendorRedundant { get; set; }

    public string? State { get; set; }

    public string? PayorName { get; set; }

    public string? AccountType { get; set; }

    public bool? ToBePrinted { get; set; }

    public int? ImportDate { get; set; }

    public bool? Printed { get; set; }

    public int? PrintedDate { get; set; }

    public string? UserId { get; set; }

    public short? Counter { get; set; }

    public string? PayorId { get; set; }

    public string? PayeeId { get; set; }

    public string? PayeeName { get; set; }

    public decimal? CheckAmount { get; set; }

    public string? CheckType { get; set; }

    public string? CurrencyId { get; set; }

    public string? Transit1 { get; set; }

    public string? Transit2 { get; set; }

    public string? CheckDateAlpha { get; set; }

    public int? CheckDateYear { get; set; }

    public string? PayeeName2 { get; set; }

    public string? CheckAmountAlpha { get; set; }

    public string? BankName { get; set; }

    public string? BankAddr1 { get; set; }

    public string? BankAddr2 { get; set; }

    public string? CostCenter4Sign { get; set; }

    public short? NumberofSignatures { get; set; }

    public bool? WhileSigningFlag { get; set; }

    public string? ProcessTime { get; set; }

    public string? Ssn { get; set; }

    public string? Cdv2 { get; set; }

    public decimal? UserVal13 { get; set; }

    public decimal? UserVal14 { get; set; }

    public decimal? UserVal15 { get; set; }

    public string? RequestNumber { get; set; }

    public string? Concept1 { get; set; }

    public string? Concept2 { get; set; }

    public string? Concept3 { get; set; }

    public string? Concept4 { get; set; }

    public string? StringAmount2 { get; set; }

    public string? StringAmount3 { get; set; }

    public string? ForTheAccountOf { get; set; }

    public string? ProgramName { get; set; }

    public string? PrintedDateAlpha { get; set; }

    public string? PrintedTime { get; set; }

    public string? PrintedBy { get; set; }

    public string? PrintedType { get; set; }

    public decimal? Userval1 { get; set; }

    public decimal? Userval2 { get; set; }

    public decimal? Userval3 { get; set; }

    public decimal? Userval4 { get; set; }

    public decimal? Userval5 { get; set; }

    public decimal? Userval6 { get; set; }

    public string? CdvAccountNo { get; set; }

    public bool? WhileProcessingVoi { get; set; }

    public bool? Void { get; set; }

    public string? GlacctReference { get; set; }

    public decimal? GlDebit { get; set; }

    public decimal? GlCredit { get; set; }

    public string? Signature1 { get; set; }

    public string? Signature2 { get; set; }

    public string? DirectDepositBankNam { get; set; }

    public string? DirectDepositAccNumb { get; set; }

    public int? ClaimOrPurchaseOrde { get; set; }

    public decimal? Userval7 { get; set; }

    public decimal? Userval8 { get; set; }

    public decimal? Userval9 { get; set; }

    public decimal? Userval10 { get; set; }

    public string? AchroutingCdv { get; set; }

    public decimal? Userval11 { get; set; }

    public decimal? Userval12 { get; set; }

    public string? SpecialLongDescripti { get; set; }

    public string? PayeeAddr1 { get; set; }

    public string? PayeeAddr2 { get; set; }

    public string? PayeeAddr3 { get; set; }

    public string? City { get; set; }

    public string? Zipcode { get; set; }

    public string? ConsecutiveNumber { get; set; }

    public int? InvoiceDate { get; set; }

    public string? VoucherOrPurOrder { get; set; }

    public bool? CopyPrinted { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? Irscode { get; set; }

    public decimal? Userval16 { get; set; }

    public decimal? Userval17 { get; set; }

    public decimal? Userval18 { get; set; }

    public decimal? Discounttotal { get; set; }

    public decimal? Grosstotal { get; set; }

    public string? UserFieldMicr { get; set; }

    public string? Signature { get; set; }

    public string? DateAlphaY2k { get; set; }

    public string? PayeeAddr4 { get; set; }

    public string? PayeeAddr5 { get; set; }

    public string? UserbatchId { get; set; }

    public bool? RePrinted { get; set; }

    public string? ClientLocation { get; set; }

    public string? BarCode { get; set; }

    public int? CreationTime { get; set; }

    public int? CreationDate { get; set; }

    public string? RequesterUser { get; set; }

    public string? Us1200 { get; set; }

    public string? Us2100 { get; set; }

    public string? Us3100 { get; set; }

    public string? Us4200 { get; set; }

    public string? ReceivingDfi { get; set; }

    public string? DfiacctNo { get; set; }

    public string? RoutingNumberMicr { get; set; }

    public string? Email { get; set; }

    public string? Contact { get; set; }

    public bool? ReconciledQ { get; set; }

    public string? AchTypeAcct { get; set; }

    public decimal? EarnDeductAmt { get; set; }

    public bool? DontSendEmail { get; set; }

    public string? VoidDate { get; set; }

    public long? BatchIdr { get; set; }

    public int? RecordNoR { get; set; }

    public string? AchStdEntryClassCode { get; set; }

    public string? AchTranCode { get; set; }

    public string? ReconcDate { get; set; }

    public string? Filler15 { get; set; }

    public byte[]? EncryptAmount { get; set; }

    public byte[]? EncryptPayee { get; set; }

    public byte[]? EncryptCheckNo { get; set; }

    public DateTime? CheckPrintedDateTime { get; set; }

    public string? UserStr5 { get; set; }

    public string? UserStr6 { get; set; }

    public string? UserStr7 { get; set; }

    public string? UserStr8 { get; set; }

    public string? UserStr9 { get; set; }

    public string? UserStr10 { get; set; }

    public string? UserStr11 { get; set; }

    public string? UserStr12 { get; set; }

    public string? UserStr13 { get; set; }

    public string? UserStr14 { get; set; }

    public string? UserStr15 { get; set; }

    public string? RecCheckNo { get; set; }

    public bool? RecBatchPurgeQ { get; set; }

    public bool? AchaddendaQ { get; set; }

    public string? UserStr16 { get; set; }

    public string? UserStr17 { get; set; }

    public string? UserStr18 { get; set; }

    public string? UserStr19 { get; set; }

    public string? UserStr20 { get; set; }

    public string? Pdfname { get; set; }

    public int? ReprintCount { get; set; }

    public bool? PdfuniqueNameQ { get; set; }

    public bool? Achq { get; set; }

    public bool? AchreEnableQ { get; set; }

    public bool? ExportQ { get; set; }

    public bool? PositivePayQ { get; set; }

    public string? RePrintUserId { get; set; }

    public string? RePrintReason { get; set; }

    public DateTime? RePrintDateTime { get; set; }

    public string? AdditionalUserId { get; set; }

    public string? VoidReason { get; set; }

    public string? Reason1 { get; set; }

    public string? Reason2 { get; set; }

    public virtual BtchDet Batch { get; set; } = null!;
}
