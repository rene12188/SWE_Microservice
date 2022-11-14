﻿using Microsoft.EntityFrameworkCore;
using PersonManagementService.DB.Model;

namespace PersonManagementService.DB;

public sealed class PersonContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<FinancialProducts> Products { get; set; }

    public PersonContext(DbContextOptions<PersonContext> ctx) : base(ctx)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FinancialProducts>(entity => { entity.HasKey(e => e.Id); });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id);
            
        });

        base.OnModelCreating(modelBuilder);
    }
}