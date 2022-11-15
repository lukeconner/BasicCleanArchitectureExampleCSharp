using Ddp.Domain.Models;

namespace Ddp.Domain.DTOs;

public class UserPermissionDto : User
{
    public List<Group> Groups { get; set; }
}