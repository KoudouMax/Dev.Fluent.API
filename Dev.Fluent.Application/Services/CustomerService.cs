using Dev.Fluent.Data.Reprository;

namespace Dev.Fluent.API.Application.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _customerRepository;
        
        #region Service Constructor
        public CustomerService(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        #endregion
    }
}
