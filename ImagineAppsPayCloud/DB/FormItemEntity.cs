﻿using System;
using System.Collections.Generic;

namespace ImagineAppsPayCloud.DB;

public partial class FormItemEntity
{
    public short EntityId { get; set; }

    public string? Description { get; set; }

    public short? Relationship { get; set; }
}
