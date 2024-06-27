using AlgospringInsurance.DataAccess.Data;
using AlgospringInsurance.DataAccess.Models;
using AlgospringInsurance.DataAccess.Repository.Contracts;

namespace AlgospringInsurance.DataAccess.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AppDBContext dbContext)
            : base(dbContext)
        {
        }
    }
}
