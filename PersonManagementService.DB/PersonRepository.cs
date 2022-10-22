using PersonManagementService.DB.Model;

namespace PersonManagementService.DB;

public class PersonRepository
{

    private readonly PersonContext ctx;
    public PersonRepository(PersonContext ctx)
    {
        this.ctx = ctx;
    }
}