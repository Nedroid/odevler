using ders5odev4AbstractInterfaceDemo.Abstract;
using ders5odev4AbstractInterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev4AbstractInterfaceDemo.Concrete
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
            if (_customerCheckService.CheckIfRealPerson(customer).Result)
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
