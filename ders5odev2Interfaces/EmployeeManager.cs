using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev2Interfaces
{
    internal class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Emploee added"); 
        }

        public void Update()
        {
            Console.WriteLine("emplayee updated");
        }
    }
}
