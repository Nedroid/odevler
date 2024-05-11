using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev1Interface
{
    internal class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get ; set; }
        public string LastName { get; set ; }
    }
}
