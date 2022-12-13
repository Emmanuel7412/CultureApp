using ApiBackEnd.CultureApp.Business.DMAccount.DTOs;

namespace ApiBackEnd.CultureApp.Business.DMAccount.Business.Interfaces
{
    public interface IBSAccount
    {
        Task<UserDto> Register(RegisterDto registerDto);
    }
}