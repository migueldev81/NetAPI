﻿using System;
using System.Collections.Generic;

namespace NetAPI.Data;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Describe { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
