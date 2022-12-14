using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Repository.Models
{
    public partial class Plan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool PubliclyAvailable { get; set; }
        public bool Active { get; set; }
        public int Price { get; set; }
    }
}
