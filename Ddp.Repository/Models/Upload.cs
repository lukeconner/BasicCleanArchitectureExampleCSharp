using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Repository.Models
{
    public partial class Upload
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int UploadTypeId { get; set; }
        public bool Deleted { get; set; }
        public bool Removed { get; set; }
    }
}
