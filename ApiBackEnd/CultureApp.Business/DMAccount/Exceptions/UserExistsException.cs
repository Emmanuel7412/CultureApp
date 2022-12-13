namespace ApiBackEnd.CultureApp.Business.DMAccount.Exceptions
{
    public class UserExistsException : Exception
    {
        public UserExistsException(string message) : base(message)
        {
        }
    }
}