﻿using System;
using System.Collections.Generic;

namespace UserRegistrationNew.DataLayer;

public partial class User
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? EmailId { get; set; }

    public string? MobileNumber { get; set; }

    public string? Address { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? Password { get; set; }
}
