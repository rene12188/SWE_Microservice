using Microsoft.EntityFrameworkCore;

using PersonManagementService.DB.Model;

namespace PersonManagementService.DB;

public class PersonContext : DbContext
{
    public DbSet<Person> Persons { get; set; }

    public PersonContext(DbContextOptions<PersonContext> ctx): base(ctx)
    {
        
    }
}
