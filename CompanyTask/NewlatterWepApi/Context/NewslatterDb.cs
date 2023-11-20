using Microsoft.EntityFrameworkCore;
using NewlatterWepApi.Models;

namespace NewlatterWepApi.Context
{
    public class NewslatterDb : DbContext
    {
        public NewslatterDb(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Newslatter> Newslaters { get; set;}
    }
}
