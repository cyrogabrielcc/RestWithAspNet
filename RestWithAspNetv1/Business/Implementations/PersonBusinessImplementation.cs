using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using RestWithAspNet.context;
using RestWithAspNet.model;

namespace RestWithAspNet.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private SQLContext _context;
        
        public PersonBusinessImplementation(SQLContext context)
        {
            _context = context;
        }
        Person IPersonBusiness.FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        
        List<Person> IPersonBusiness.FindAll()
        {
        
        return _context.Persons.ToList();
        }


        Person IPersonBusiness.Create(Person person)
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

        void IPersonBusiness.Delete(long id)
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
   

         Person IPersonBusiness.Update(Person person)
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