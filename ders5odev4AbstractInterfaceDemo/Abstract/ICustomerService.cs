using ders5odev4AbstractInterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev4AbstractInterfaceDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
