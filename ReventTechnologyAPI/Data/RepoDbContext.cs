using Microsoft.EntityFrameworkCore;
using ReventTechnologyAPI.Models;

namespace ReventTechnologyAPI.Data
{
    public class RepoDbContext: DbContext
    {
        public RepoDbContext(DbContextOptions<RepoDbContext> options) : base(options) { }
        public DbSet<RevApi> RevApis { get; set; }  
    }
}
