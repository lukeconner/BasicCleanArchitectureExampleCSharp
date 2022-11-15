using AutoMapper;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ddp.App.Interfaces.Repository;
using Ddp.Domain.DTOs;
using Ddp.Domain.Models;
using Ddp.Domain.Wrappers;
using Microsoft.IdentityModel.Tokens;

namespace Ddp.App.Features.Auth.Query;

public class LoginQuery : IRequest<ApiResponse<LoginResponseDto>>
{
    public string Username { get; set; }
    public string Password { get; set; }
}

public class LoginQueryHandler : IRequestHandler<LoginQuery, ApiResponse<LoginResponseDto>>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public LoginQueryHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<ApiResponse<LoginResponseDto>> Handle(LoginQuery request, CancellationToken token)
    {
        var user = await _userRepository.GetByUsername(request.Username);
        if (user == null)
            return new ApiResponse<LoginResponseDto>("No user found with this username");


        if (!StructuralComparisons.StructuralEqualityComparer.Equals(ComputeHash(request.Password, user.Salt),
                user.Password))
            return new ApiResponse<LoginResponseDto>("Invalid username/password");

        user.Salt = null;
        user.Password = null;
        var userPermissions = _mapper.Map<UserPermissionDto>(user);

        var expiresIn = DateTime.Now.AddDays(30);
        var authToken = GenerateToken(userPermissions, expiresIn);



        var response = new LoginResponseDto
        {
            User = userPermissions,
            ExpiresIn = TokenAuthOption.ExpiresSpan.TotalSeconds,
            Token = authToken
        };



        return new ApiResponse<LoginResponseDto>(response);
    }

    private string GenerateToken(UserPermissionDto user, DateTime expires)
    {

        var handler = new JwtSecurityTokenHandler();

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes("io(O(O:(47lif&*(YOiaut#$%^KHhHLlk04");

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, user.Email),
            }),
            Expires = DateTime.Now.AddHours(10),
            SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),

        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    private void LogLogin()
    {

    }

    private byte[] ComputeHash(string password, byte[] salt, int iterations = 10101, int hashByteSize = 24)
    {
        using var hashGenerator = new Rfc2898DeriveBytes(password, salt) { IterationCount = iterations };
        return hashGenerator.GetBytes(hashByteSize);
    }

    private byte[] GenerateSalt(int saltByteSize = 24)
    {
        var saltGenerator = RandomNumberGenerator.Create();
        var salt = new byte[saltByteSize];
        saltGenerator.GetBytes(salt);
        return salt;
    }

    private bool VerifyPassword(string password, byte[] passwordSalt, byte[] passwordHash)
    {
        var computedHash = ComputeHash(password, passwordSalt);
        return AreHashesEqual(computedHash, passwordHash);
    }

    private bool AreHashesEqual(byte[] firstHash, byte[] secondHash)
    {
        var minHashLenght = firstHash.Length <= secondHash.Length ? firstHash.Length : secondHash.Length;
        var xor = firstHash.Length ^ secondHash.Length;
        for (var i = 0; i < minHashLenght; i++)
            xor |= firstHash[i] ^ secondHash[i];
        return 0 == xor;
    }
}

public static class TokenAuthOption
{
    public static string Audience { get; } = "MyAudience";
    public static string Issuer { get; } = "MyIssuer";
    private static RsaSecurityKey Key { get; } = new RsaSecurityKey(RsaKeyHelper.GenerateKey());

    public static SigningCredentials SigningCredentials { get; } =
        new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);

    public static TimeSpan ExpiresSpan { get; } = TimeSpan.FromDays(30);
    public static string TokenType { get; } = "Bearer";
}

public static class RsaKeyHelper
{
    public static RSAParameters GenerateKey()
    {
        using var key = new RSACryptoServiceProvider(2048);
        return key.ExportParameters(true);
    }
}

