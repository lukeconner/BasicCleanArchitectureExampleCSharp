using System;
using System.Collections.Generic;

#nullable disable

namespace Ddp.Domain.Models;

    public class GroupType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OwnerOrganizationId { get; set; }
        public bool PubliclyAvailable { get; set; }
        public bool Active { get; set; }
        public int CreatedByUserId { get; set; }
    }

