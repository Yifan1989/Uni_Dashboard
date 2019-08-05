using Microsoft.EntityFrameworkCore;
using Uni_Dash.Models;

// a class that communicates with the database
namespace Uni_Dash.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //Data querying in Entity Framework Core is performed against the
        //DbSet properties of the DbContext. The DbSet represents a collection
        //of entities of a specific type - the type specified by the type parameter.
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}
