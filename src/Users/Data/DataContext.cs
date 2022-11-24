using Microsoft.EntityFrameworkCore;

namespace Users.Data;

public class DataContext : DbContext
{
    public DbSet<User> Users => Set<User>();

    public DataContext(DbContextOptions options) : base(options)
    {
    }
}