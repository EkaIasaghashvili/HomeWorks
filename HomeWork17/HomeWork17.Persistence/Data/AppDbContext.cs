using System;
using System.Collections.Generic;
using System.Text;
using Authentication.Models.Users;
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
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
