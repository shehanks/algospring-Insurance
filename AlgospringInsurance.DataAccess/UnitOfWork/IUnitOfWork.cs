using AlgospringInsurance.DataAccess.Repository.Contracts;

namespace AlgospringInsurance.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IUserRepository UserRepository { get; }

        IEmailReceiverRegistrationRepository EmailReceiverRegistrationRepository { get; }

        void Complete();
    }
}
