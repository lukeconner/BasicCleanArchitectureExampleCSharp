using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Repository.Models
{
    public partial class Post
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string PostBody { get; set; }
        public bool Deleted { get; set; }
        public bool Approved { get; set; }
        public bool Edited { get; set; }
        public int UserId { get; set; }
    }
}
