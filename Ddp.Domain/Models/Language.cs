using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Domain.Models;

public class Language
{
    public int Id { get; set; }
    public string Name { get; set; }
    public byte PubliclyAvailable { get; set; }
}

