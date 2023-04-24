using Dev.Fluent.Common.Interfaces;
using Dev.Fluent.Domain.Models;

namespace Dev.Fluent.Data.Reprository
{
    public class CustomerRepository : IRepositoryBase<Customer>
    {
        public void CreateOrUpdate(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
