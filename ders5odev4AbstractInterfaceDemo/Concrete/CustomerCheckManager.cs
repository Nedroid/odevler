using ders5odev4AbstractInterfaceDemo.Abstract;
using ders5odev4AbstractInterfaceDemo.Entities;

namespace ders5odev4AbstractInterfaceDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public Task<bool> CheckIfRealPerson(Customer customer)
        {
            return Task.FromResult(true);
        }
    }
}
