namespace Ddp.Domain.Models;

public class GroupMembershipRequest
{
    public int Id { get; set; }
    public int GroupId { get; set; }
    public string UserId { get; set; }
    public bool Approved { get; set; }
}