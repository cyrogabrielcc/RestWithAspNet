using System;
using System.Collections.Generic;
using System.Linq;
using RestWithAspNet.context;
using RestWithAspNet.model;
using RestWithAspNet.Repository;

namespace RestWithAspNet.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;
        
        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }
        Person IPersonBusiness.FindById(long id)
        {
            return _repository.FindById(id);
        }

        
        List<Person> IPersonBusiness.FindAll()
        {
        
        return _repository.FindAll();
        }


        Person IPersonBusiness.Create(Person person)
        {
            return _repository.Create(person);
        }

        void IPersonBusiness.Delete(long id)
        {
              _repository.Delete(id);
            
        }
   

         Person IPersonBusiness.Update(Person person)
        {
           return _repository.Update(person);
        }

    }
}