using ders5odev4AbstractInterfaceDemo.Abstract;
using ders5odev4AbstractInterfaceDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev4AbstractInterfaceDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId,
                customer.FirstName, customer.LastName, customer.DateofBirth);
        }
    }
}
