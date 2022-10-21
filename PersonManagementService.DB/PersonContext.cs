using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PersonManagementService.DB.Model;

namespace PersonManagementService.DB;

public class PersonContext : DbContext
{
    private readonly IConfiguration _configuration;
    public DbSet<Person> Persons { get; set; }
    public PersonContext(IConfiguration configuration)
    {
        configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(_configuration.GetConnectionString("Database"));
    }
}
