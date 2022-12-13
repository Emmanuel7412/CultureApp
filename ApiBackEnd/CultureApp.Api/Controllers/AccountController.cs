using ApiBackEnd.CultureApp.Business.DMAccount.Business.Interfaces;
using ApiBackEnd.CultureApp.Business.DMAccount.DTOs;
using ApiBackEnd.CultureApp.Business.DMAccount.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace ApiBackEnd.CultureApp.Api.Controllers
{

    public class AccountController : BaseApiController
    {
        private readonly IBSAccount _bsAccount;
        public AccountController(IBSAccount bsAccount)
        {
            _bsAccount = bsAccount;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            try
            {
                var userDto = await _bsAccount.Register(registerDto);
                return Ok(userDto);
            }
            catch (UserExistsException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}