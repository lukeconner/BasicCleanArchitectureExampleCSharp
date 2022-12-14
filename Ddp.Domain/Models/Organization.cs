using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Domain.Models;

public class Organization
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CreatedByUserId { get; set; }
    public int OwnerUserId { get; set; }
    public byte Active { get; set; }
    public int PlanId { get; set; }
}

