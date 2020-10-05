using Microsoft.EntityFrameworkCore;
using Workspp.API.Models;

namespace Workspp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions <DataContext> options) : base(options)  { }
        public DbSet<Value> Values { get; set; }
    }
}