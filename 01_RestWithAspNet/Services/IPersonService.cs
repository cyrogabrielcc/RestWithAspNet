using System.Collections.Generic;
using _01_RestWithAspNet.model;

namespace _01_RestWithAspNet.Services;

public interface IPersonSerice
{
    Person Create(Person person);
    Person FindById(long id);
    Person Update(Person person);
    List<Person> FindAll();
    void Delete(long id);

}



