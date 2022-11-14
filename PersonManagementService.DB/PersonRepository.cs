using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
        return ctx.Persons.Include("Products").ToList();
    }

    public Person GetPersonById(Guid pid)
    {
        return ctx.Persons.Include("Products").FirstOrDefault(p => p.Id == pid)!;
    }  
    
    public Guid CreatePerson(Person person)
    {
        person.Id = Guid.NewGuid();
        foreach (var product in person.Products)
        {
            product.Id = Guid.NewGuid();
            ctx.Products.Add(product);
        }
        ctx.Persons.Add(person);
        ctx.SaveChanges();
        return person.Id;
    }
    
    public Guid UpdatePerson(Guid pid, Person person)
    {
        var savedPerson = ctx.Persons.FirstOrDefault(p => p.Id ==pid);

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