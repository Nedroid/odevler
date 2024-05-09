using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {//default constructor
            Customer customer = new Customer { Id = 1, FirstName = "Engin", LastName = "demirog", City = "Ankara" };
            //override parametreli constructor 
            Customer customer2 = new Customer(2, "Derin", "demirog", "bursa");
            Console.ReadLine();

            

        }
    }

    class Customer
    {

        //Default Constructor
        public Customer()
        {
            Console.WriteLine("Yapıcı blok Çalıştı");
          
        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName{ get; set; }
        
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
