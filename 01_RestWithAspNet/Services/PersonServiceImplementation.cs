using _01_RestWithAspNet.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_RestWithAspNet.Services
{
    public class PersonServiceImplementation : IPersonSerice
    {
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
                
            };
        }

        Person IPersonSerice.FindById(long id)
        {
            throw new NotImplementedException();
        }

        Person IPersonSerice.Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}