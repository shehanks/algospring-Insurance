using AlgospringInsurance.DataAccess.Data;
using AlgospringInsurance.DataAccess.Models;
using AlgospringInsurance.DataAccess.Repository.Contracts;

namespace AlgospringInsurance.DataAccess.Repository
{
    public class EmailReceiverRegistrationRepository : RepositoryBase<EmailReceiverRegistration>, IEmailReceiverRegistrationRepository
    {
        public EmailReceiverRegistrationRepository(AppDBContext dbContext)
            : base(dbContext)
        {
        }
    }
}
