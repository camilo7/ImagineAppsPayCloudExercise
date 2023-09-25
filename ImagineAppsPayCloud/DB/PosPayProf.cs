using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class PosPayProf
{
    public string? BatchOrdate { get; set; }

    public string? BankId { get; set; }

    public string? AccountId { get; set; }

    public string? PayorId { get; set; }

    public string? LayoutId { get; set; }

    public string? DefinitionCode { get; set; }

    public bool? PrintedDocumentsQ { get; set; }

    public bool? SelectedQ { get; set; }

    public string? LastDefaultValue { get; set; }

    public int? SentDate { get; set; }

    public int? SentTime { get; set; }

    public int? SelectedDateFrom { get; set; }

    public int? SelectedDateTo { get; set; }

    public long? SelectedBatch { get; set; }

    public string? Application { get; set; }

    public bool? ExternalFunctionQ { get; set; }

    public string? AdditionalDescriptio { get; set; }

    public string? SeqId { get; set; }

    public bool? SchedulerQ { get; set; }

    public string? Mode { get; set; }

    public string? Ftpprofile { get; set; }
}
