using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Repository.Models
{
    public partial class UploadType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool PubliclyAvailable { get; set; }
        public string FileExtensions { get; set; }
    }
}
