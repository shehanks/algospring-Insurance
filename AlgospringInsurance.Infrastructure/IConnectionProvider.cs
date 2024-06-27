using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgospringInsurance.Infrastructure
{
    public interface IConnectionProvider
    {
        string GetConnectionString();
    }
}
