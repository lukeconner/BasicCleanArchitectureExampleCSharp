using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Repository.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] Salt { get; set; }
        public int? ProfilePhotoId { get; set; }
        public bool Active { get; set; }
        public bool Admin { get; set; }
        public bool Support { get; set; }
        public int PrimaryLanguageId { get; set; }
    }
}
