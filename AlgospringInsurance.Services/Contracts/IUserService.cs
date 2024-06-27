using AlgospringInsurance.DataAccess.Models;

namespace AlgospringInsurance.Services.Contracts
{
    public interface IUserService
    {
        User AddUser(User user);

        User? GetUser(int id);

        bool DeleteUser(int id);
    }
}
