using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using RestWithAspNet.context;
using RestWithAspNet.model;

namespace RestWithAspNet.Repository.Implementations
{
    public class PersonRepositoryImplementation : IPersonRepository
    {
        private SQLContext _context;
        
        public PersonRepositoryImplementation(SQLContext context)
        {
            _context = context;
        }
        Person IPersonRepository.FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        
        List<Person> IPersonRepository.FindAll()
        {
        
        return _context.Persons.ToList();
        }


        Person IPersonRepository.Create(Person person)
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

        void IPersonRepository.Delete(long id)
        {
             var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null) 
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }
        }
   

         Person IPersonRepository.Update(Person person)
        {
            if (!Exists(person.Id)) return null;

            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));

            if (result != null) 
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }
            return person;
        }

        private bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Equals(id));
        }
    }
}