namespace Ddp.Domain.DTOs;

public class LoginResponseDto
{
    public string Token { get; set; }
    public double ExpiresIn { get; set; }
    public UserPermissionDto User { get; set; }
}