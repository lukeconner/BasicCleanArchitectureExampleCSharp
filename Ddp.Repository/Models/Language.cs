using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Repository.Models
{
    public partial class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte PubliclyAvailable { get; set; }
    }
}
