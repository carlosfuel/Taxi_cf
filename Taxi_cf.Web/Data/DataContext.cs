using Microsoft.EntityFrameworkCore;
using Taxi_cf.Web.Data.Entities;

namespace Taxi_cf.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<TaxiEntity> Taxis { get; set; }
    }
}
