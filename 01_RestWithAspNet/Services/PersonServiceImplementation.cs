using _01_RestWithAspNet.model;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _01_RestWithAspNet.Services
{
    public class PersonServiceImplementation : IPersonSerice
    {
        public volatile int count;

        Person IPersonSerice.Create(Person person)
        {
            return person;
        }

        void IPersonSerice.Delete(long id)
        {
            
        }

        List<Person> IPersonSerice.FindAll()
        {
            List<Person> persons = new List<Person>();
            
            foreach (var item in persons)
            {
                Person person = MockPerson(item);
                persons.Add(person);
            };

            return persons;
        }

        private Person MockPerson(object i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Cyro",
                LastName = "Cunha",
                Address = "Rua dos bobos, 012",
                Gender = "M"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        Person IPersonSerice.FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Cyro",
                LastName = "Cunha",
                Address = "Rua dos bobos, 012",
                Gender = "M"
            };
        }

        Person IPersonSerice.Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}