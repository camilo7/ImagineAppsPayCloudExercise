using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class Language
{
    public int Id { get; set; }

    public string English { get; set; } = null!;

    public string? Spanish { get; set; }

    public string? France { get; set; }

    public string? Language1 { get; set; }

    public string? Language2 { get; set; }

    public string? Language3 { get; set; }

    public string? Language4 { get; set; }

    public string? Language5 { get; set; }
}
