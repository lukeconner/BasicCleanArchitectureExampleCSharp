using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Domain.Models;

public class OrganizationType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool PubliclyAvailable { get; set; }
}

