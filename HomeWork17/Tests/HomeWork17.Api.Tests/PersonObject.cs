using HomeWork17.Domain.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17.Api.Tests
{
    public class PersonObject
    {
        public static List<Person> GetPersonList()
        {
            var persons = new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    FirstName = "Eka",
                    LastName = "Iasag",
                    JobPosition = "Dev",
                    CreateDate = DateTime.Now,
                    Salary = 10_000,
                    WorkExperince = 1,
                    Address = new List<Address>()
                    {
                        new Address()
                        {
                            PersonId = 1,
                            Country = "Georgia",
                            City = "Tbilisi",
                            HomeNumber = 1234567
                        }
                    }
                },
                new Person()
                {
                    Id = 2,
                    FirstName = "TTT",
                    LastName = "EEE",
                    JobPosition = "Dev",
                    CreateDate = DateTime.Now,
                    Salary = 10_000,
                    WorkExperince = 1,
                    Address = new List<Address>()
                    {
                        new Address()
                        {
                            PersonId = 1,
                            Country = "Georgia",
                            City = "Tbilisi",
                            HomeNumber = 1234567
                        }
                    }
                },
            };
            return persons;
        }

        public static Person GetPersonObject() => new Person()
        {
            Id = 1,
            FirstName = "Eka",
            LastName = "Iasag",
            JobPosition = "Dev",
            CreateDate = DateTime.Now,
            Salary = 10_000,
            WorkExperince = 1,
            Address = new List<Address>()
            {
                new Address()
                {
                    PersonId = 1,
                    Country = "Georgia",
                    City = "Tbilisi",
                    HomeNumber = 1234567
                }
            }
        };
        public static Person GetNewPersonObject() => new Person()
        {
            Id = 1,
            FirstName = "EEE",
            LastName = "GGG",
            JobPosition = "Dev",
            CreateDate = DateTime.Now,
            Salary = 1000,
            WorkExperince = 1,
            Address = new List<Address>()
            {
                new Address()
                {
                    PersonId = 1,
                    Country = "Georgia",
                    City = "Tbilisi",
                    HomeNumber = 1234567
                }
            }
        };
} }
