namespace Ddp.Domain.Models;

public class PasswordReset
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime Expires { get; set; }
    public string IpAddress { get; set; }
}