using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithAspNet.model;

namespace RestWithAspNet.Service.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        Person IPersonService.Create(Person person)
        {
            throw new NotImplementedException();
        }

        void IPersonService.Delete(long id)
        {
            
        }

        List<Person> IPersonService.FindAll()
        {
            throw new NotImplementedException();
        }

        Person IPersonService.FindById(long id)
        {
            throw new NotImplementedException();
        }

        Person IPersonService.Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}