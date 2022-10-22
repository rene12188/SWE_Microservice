using PersonManagementService.DB.Model;

namespace PersonManagementService.DB;

public class PersonRepository
{

    private readonly PersonContext ctx;
    public PersonRepository(PersonContext ctx)
    {
        this.ctx = ctx;
    }
    
    public IList<Person> GetAllPersons()
    {
        return ctx.Persons.ToList();
    }

    public Person GetPersonById(Guid pid)
    {
        return ctx.Persons.FirstOrDefault(p => p.Id == pid)!;
    }  
    
    public Guid CreatePerson(Person person)
    {
        person.Id = Guid.NewGuid();
        ctx.Persons.Add(person);
        ctx.SaveChanges();
        return person.Id;
    }
    
    public Guid UpdatePerson(Guid pid, Person person)
    {
        var savedPerson = ctx.Persons.FirstOrDefault(p => p.Id == person.Id);

        if (savedPerson != null)
        {
            savedPerson = person;
        }

        return savedPerson.Id;
    }

    public Guid DeletePerson(Guid pid)
    {
        var savedPerson = ctx.Persons.FirstOrDefault(p => p.Id == pid);

        if (savedPerson != null)
        {
            ctx.Persons.Remove(savedPerson);
        }

        return savedPerson.Id;
    }
}