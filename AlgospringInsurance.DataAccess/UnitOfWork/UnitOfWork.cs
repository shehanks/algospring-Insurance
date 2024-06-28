using AlgospringInsurance.DataAccess.Data;
using AlgospringInsurance.DataAccess.Repository;
using AlgospringInsurance.DataAccess.Repository.Contracts;

namespace AlgospringInsurance.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private readonly AppDBContext appDBContext;
        private IUserRepository? userRepository;
        private IEmailReceiverRegistrationRepository? emailReceiverRegistrationRepository;

        public UnitOfWork(AppDBContext dbContext)
        {
            appDBContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public IUserRepository UserRepository =>
            userRepository ?? (userRepository = new UserRepository(appDBContext));

        public IEmailReceiverRegistrationRepository EmailReceiverRegistrationRepository =>
            emailReceiverRegistrationRepository ?? (emailReceiverRegistrationRepository = new EmailReceiverRegistrationRepository(appDBContext));

        public void Complete() => appDBContext.SaveChanges();

        protected virtual async ValueTask DisposeAsync(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                    await appDBContext.DisposeAsync();
            }
            disposed = true;
        }

        public async ValueTask DisposeAsync()
        {
            await DisposeAsync(true);
            GC.SuppressFinalize(this);
        }
    }
}
