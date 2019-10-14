using Microsoft.EntityFrameworkCore;
using SocialNetworking.API.Model;

namespace SocialNetworking.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
{
}
        public DbSet<Value> Values { get; set; }
    }
}