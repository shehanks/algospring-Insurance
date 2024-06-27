using Microsoft.EntityFrameworkCore;
using AlgospringInsurance.DataAccess.Models;

namespace AlgospringInsurance.DataAccess.Data
{
    public class AppDBContext : DbContext
    {
        private static DbContextOptions? dbContextOptions;

        public AppDBContext()
            : base(dbContextOptions!)
        {
        }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
            dbContextOptions = options;
        }

        public DbSet<User> User { get; set; }

        public DbSet<EmailReceivers> EmailReceiver { get; set; }
    }
}
