using ders5odev4AbstractInterface.Absrtract;
using ders5odev4AbstractInterface.Abstract;
using ders5odev4AbstractInterface.Entities;
using System;
namespace ders5odev4AbstractInterface.Concrete
{
    public class StarCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;
        
        public StarCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person ");
            }
        }

        
    }
}
 