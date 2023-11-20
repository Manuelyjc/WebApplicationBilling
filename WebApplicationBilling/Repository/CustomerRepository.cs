using WebApplicationBilling.Models.DTO;
using WebApplicationBilling.Repository.Interfaces;

namespace WebApplicationBilling.Repository
{
    public class CustomerRepository : Repository<CustomerDTO> , ICustomerRepository
    {
        public ICustomerRepository() { }
    }
}
