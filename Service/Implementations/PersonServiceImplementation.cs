using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using RestWithAspNet.context;
using RestWithAspNet.model;

namespace RestWithAspNet.Service.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private SQLContext _context;
        
        public PersonServiceImplementation(SQLContext context)
        {
            _context = context;
        }

        Person IPersonService.Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

            return person;
        }

        void IPersonService.Delete(long id)
        {
            
        }

        List<Person> IPersonService.FindAll()
        {
           return _context.Persons.ToList();
        }

        Person IPersonService.FindById(long id)
        {
            return new Person
            {
                Id= 1,
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
        
        private long IncrementAndGet(long id)
        {
            return id;
        }
    }
}