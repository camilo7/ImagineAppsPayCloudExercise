using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class UserPassHistory
{
    public string UserId { get; set; } = null!;

    public DateTime? PassDate { get; set; }

    public byte[]? Password { get; set; }

    public long IdentityId { get; set; }
}
