using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestWithAspNet.model;

namespace RestWithAspNet.Service.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;
        Person IPersonService.Create(Person person)
        {
            throw new NotImplementedException();
        }

        void IPersonService.Delete(long id)
        {
            
        }

        List<Person> IPersonService.FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                Person person = mockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

       

        Person IPersonService.FindById(long id)
        {
            return new Person
            {
                Id= IncrementAndGet(),
                FirstName= "",
                LastName= "",
                Address= "",
                Gender= "M"
            };
        }

         Person IPersonService.Update(Person person)
        {
            return person;
        } 
        
        private Person mockPerson(int i)
        {
            return new Person
            {
                Id = 1,
                FirstName = "" + i,
                LastName = "" + i,
                Address = "" + i,
                Gender = "Male"
            }; ;
        }
        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}