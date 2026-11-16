using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public LoginDbContext() : base("name=MyConn")
        {
            Database.SetInitializer<LoginDbContext>(null);
        }
    }
}
