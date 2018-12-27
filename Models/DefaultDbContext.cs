using Microsoft.EntityFrameworkCore;

namespace dotnet_psql_hangfire.Models
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
            : base(options)
        { }
    }
}