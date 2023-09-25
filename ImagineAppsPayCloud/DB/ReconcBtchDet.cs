﻿using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class ReconcBtchDet
{
    public long BatchId { get; set; }

    public string? Description { get; set; }

    public int? ImportDate { get; set; }

    public string? OtherInfo { get; set; }

    public bool? AchGeneratedQ { get; set; }

    public bool? ServerRefresedQ { get; set; }

    public int? BatchPurgeDate { get; set; }

    public bool? BatchPurgedQ { get; set; }

    public bool? AllChecksBatchPrinte { get; set; }

    public int? TotalChecksinBatch { get; set; }

    public string? GpbatchId { get; set; }

    public int? Gpdate { get; set; }

    public bool? CopyprintedQ { get; set; }

    public decimal? PostingGroupId { get; set; }

    public int? DatePosted { get; set; }

    public int? TimePosted { get; set; }

    public bool? PostedTobookQ { get; set; }

    public int? DatePostedReptPrinte { get; set; }

    public int? TimePostedReportPrin { get; set; }

    public string? TypeofBatch { get; set; }

    public string? Userbatchid { get; set; }

    public bool? AutorizedQ { get; set; }

    public string? Password1 { get; set; }

    public string? Password2 { get; set; }

    public int? ImportTime { get; set; }

    public decimal? Totalamountvalue { get; set; }

    public decimal? Totalacknowledged { get; set; }

    public bool? AchwhileprocessingFl { get; set; }

    public string? Filler9915 { get; set; }

    public DateTime? BatchImportDateTime { get; set; }

    public DateTime? BatchPostedDateTime { get; set; }
}
