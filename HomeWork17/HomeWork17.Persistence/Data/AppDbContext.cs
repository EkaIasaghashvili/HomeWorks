using System;
using System.Collections.Generic;
using System.Text;
using HomeWork17.Domain.Persons;
using Microsoft.EntityFrameworkCore;

namespace HomeWork17.Persistence.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addreses { get; set; }
    }
}
