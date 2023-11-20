using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data;

public class CarsDbContext : DbContext
{
    public CarsDbContext(DbContextOptions<CarsDbContext> options)
        : base(options) 
    {
        Database.EnsureCreated();
    }

    public DbSet<Car> Cars { get; set; }
}
