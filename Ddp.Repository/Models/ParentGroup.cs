using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Repository.Models
{
    public partial class ParentGroup
    {
        public int Id { get; set; }
        public int ParentGroupId { get; set; }
        public bool IsPrimaryParentGroup { get; set; }
    }
}
