using AlgospringInsurance.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

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

        public DbSet<User> Users { get; set; }

        public DbSet<EmailReceiverRegistration> EmailReceiverRegistrations { get; set; }
    }
}
