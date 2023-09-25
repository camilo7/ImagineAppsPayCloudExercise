using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class TemplatesxPrintersByUsersCheckBook
{
    public string LayoutId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? DateTimeEdit { get; set; }
}
