using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Repository.Models
{
    public partial class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupTypeId { get; set; }
        public int Active { get; set; }
        public int CreatedByUserId { get; set; }
        public bool RequiresPostApproval { get; set; }
        public bool RequiresCommentApproval { get; set; }
        public bool RequiresMembership { get; set; }
    }
}
