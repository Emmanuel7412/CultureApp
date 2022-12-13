using ApiBackEnd.CultureApp.Data.Entities;

namespace ApiBackEnd.CultureApp.Business.DMAccount.Business.Interfaces
{
    public interface IBSToken
    {
        
        string CreateToken(User user);
    }
}