using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_RestWithASPNET.Models;

namespace _01_RestWithASPNET.Services.Implementations
{
    public interface IPersonService
    {
        Person Create (Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}