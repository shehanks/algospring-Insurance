using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgospringInsurance.Infrastructure
{
    public class ConnectionProvider : IConnectionProvider
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["algospringInsurance"].ConnectionString;
        }
    }
}
