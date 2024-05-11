using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev2Interfaces
{
    internal class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("customer added");
        }

        public void Update()
        {
            Console.WriteLine("customer updated");
        }
    }
}
