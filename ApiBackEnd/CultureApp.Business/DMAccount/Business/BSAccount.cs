using System.Security.Cryptography;
using System.Text;
using ApiBackEnd.CultureApp.Business.DMAccount.Business.Interfaces;
using ApiBackEnd.CultureApp.Business.DMAccount.DTOs;
using ApiBackEnd.CultureApp.Business.DMAccount.Exceptions;
using ApiBackEnd.CultureApp.Data.Entities;
using ApiBackEnd.CultureApp.Data.Repositories;
using ApiBackEnd.CultureApp.Data.Repositories.Interfaces;

namespace ApiBackEnd.CultureApp.Business.DMAccount.Business
{
    public class BSAccount : IBSAccount
    {
        private readonly IDPUsers _dpUsers;

        private readonly IBSToken _bsToken;

        public BSAccount(IDPUsers dpUsers, IBSToken bsToken)
        {
            _bsToken = bsToken;
            _dpUsers = dpUsers;
        }

        public async Task<UserDto> Register(RegisterDto registerDto)
        {
            if (await _dpUsers.UserExists(registerDto.Email)) throw new UserExistsException("Email is taken");

            using var hmac = new HMACSHA512();

            var user = new User
            {
                Email = registerDto.Email.ToLower(),
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                PasswordSalt = hmac.Key
            };

            await _dpUsers.AddUser(user);

            return new UserDto
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Token = _bsToken.CreateToken(user)
            };
        }
    }
}