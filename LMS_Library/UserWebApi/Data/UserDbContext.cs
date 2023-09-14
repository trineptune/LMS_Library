using Microsoft.EntityFrameworkCore;
using UserWebApi.Models;

namespace UserWebApi.Data
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }


    }

}
