using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_RestWithASPNET.Models;

namespace _01_RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService

    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            List<Person> persons = null;
           return persons;
        }

        public Person FindById(long id)
        {
             return new Person
            {
                Id = 1,
                FirstName = "Cyro",
                LastName = "Cunha",
                Gender = "Male",
                Address = "Rua dos Bobos, 25"
            };
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}