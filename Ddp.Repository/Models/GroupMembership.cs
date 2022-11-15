using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Repository.Models
{
    public partial class GroupMembership
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int Active { get; set; }
    }
}
