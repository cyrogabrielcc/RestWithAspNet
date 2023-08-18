using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using _01_RestWithASPNET.Models;

namespace _01_RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService

    {
        private volatile int count;
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
            foreach (var item in persons)
            {
                Person person = MockPerson(item);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Person Name",
                LastName = "Person LastName",
                Gender = "Male",
                Address = "Some Address"
            };
        }

        public Person Update(Person person)
        {
             return person;
        }

         private Person MockPerson(Person item)
        {
             return new Person
            {
                Id = 1,
                FirstName = "Person Name",
                LastName = "Person LastName",
                Gender = "Male",
                Address = "Some Address"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}