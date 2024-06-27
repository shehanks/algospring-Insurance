using AlgospringInsurance.DataAccess.Models;
using AlgospringInsurance.DataAccess.UnitOfWork;
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
    }
}
