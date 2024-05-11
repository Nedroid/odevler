using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev1Interface
{
    internal interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
    }
}
