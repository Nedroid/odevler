using ders5odev4AbstractInterface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev4AbstractInterface.Absrtract
{
   
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("saved to db " + customer.FirstName);
        }

        
    }
}
