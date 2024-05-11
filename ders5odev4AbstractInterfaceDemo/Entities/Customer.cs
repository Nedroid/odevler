using ders5odev4AbstractInterfaceDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5odev4AbstractInterfaceDemo.Entities
{
    public class Customer:IEntitiy
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateofBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
