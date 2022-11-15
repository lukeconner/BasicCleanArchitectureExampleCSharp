using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Repository.Models
{
    public partial class PostActivityLog
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public int PostActivityLogTypeId { get; set; }
        public string Comment { get; set; }
    }
}
