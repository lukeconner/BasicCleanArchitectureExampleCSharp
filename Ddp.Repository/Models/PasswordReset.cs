using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Repository.Models
{
    public partial class PasswordReset
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Expires { get; set; }
        public string IpAddress { get; set; }
    }
}
