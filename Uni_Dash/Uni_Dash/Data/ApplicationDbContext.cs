using System;
using Microsoft.EntityFrameworkCore;


// a class that communicates with the database
namespace Uni_Dash.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
