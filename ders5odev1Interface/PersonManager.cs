using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev1Interface
{
    internal class PersonManager
    {
        public void Add(ICustomerDal customerDal)
        {
            // Console.WriteLine(person.Name);
            customerDal.Add();


        }
    }

}

