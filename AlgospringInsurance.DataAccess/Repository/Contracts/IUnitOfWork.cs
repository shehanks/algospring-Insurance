using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgospringInsurance.DataAccess.Repository.Contracts
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IUserRepository UserRepository { get; }

        void Complete();
    }
}
