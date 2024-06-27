using AlgospringInsurance.DataAccess.Models;
using AlgospringInsurance.DataAccess.Repository.Contracts;
using AlgospringInsurance.Services.Contracts;

namespace AlgospringInsurance.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public User AddUser(User user)
        {
            unitOfWork.UserRepository.Insert(user);
            unitOfWork.Complete();
            return user;
        }

        public bool DeleteUser(int id)
        {
            var user = unitOfWork.UserRepository.GetById(id);
            if (user == null)
                return false;

            unitOfWork.UserRepository.Delete(user);
            unitOfWork.Complete();
            return true;
        }

        public User? GetUser(int id)
        {
            return unitOfWork.UserRepository.GetById(id);
        }
    }
}
