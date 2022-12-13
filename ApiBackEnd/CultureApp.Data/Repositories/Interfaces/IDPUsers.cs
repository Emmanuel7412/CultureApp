using ApiBackEnd.CultureApp.Data.Entities;

namespace ApiBackEnd.CultureApp.Data.Repositories.Interfaces
{
    public interface IDPUsers
    {
        Task<bool> UserExists(string email);
        Task<bool> AddUser(User user);
    }
}