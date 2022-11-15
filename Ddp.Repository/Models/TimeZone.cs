using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Repository.Models
{
    public partial class TimeZone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NixName { get; set; }
        public string DisplayName { get; set; }
        public bool ObservesDst { get; set; }
    }
}
