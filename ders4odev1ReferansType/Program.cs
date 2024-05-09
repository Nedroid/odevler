using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders4odev1ReferansType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int ,decimal,enum,boolean value types
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayi1=" + sayi1);
            //array,class,interface ... reference type
            //heap de degerler tututluyor stack de adres tutuluyor
            //newlendiği zaman stack de yeni adres oluşuyor

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            //sayilar1 in adresi = sayilar2 nin adresi 

            sayilar1 = sayilar2;
            //sayılar2 nin adresinn 0 .elemanı 
            sayilar2[0] = 1000;

            Console.WriteLine("sayilar1[0]=" + sayilar1[0]);
            //Reference type olduu i.in adres tutuluyor
            //
            Person person1= new Person();
            Person person2= new Person();
            person1.Name = "Engin";
            //Deger eşitlemesi deeğil adres eşitlemesi yapıyorsun

            person2 = person1;
            person2.Name = "Derin";
            Console.WriteLine("person1="+person1.Name);

            Person person3= new Customer();


            Customer customer= new Customer();
            customer.Name = "Salih";

            Person person4 = customer;
            Console.WriteLine(((Customer)person4).CreditCardNumber);
            //
            Employee employee= new Employee();
            employee.Name = "Ahmet";
            //customer = employee; diiyemezsin

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(employee);
            personManager.Add(person1);
            personManager.Add(person2);
            personManager.Add(person3);
            personManager.Add(person4);

            Console.ReadLine();
        }
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
        }
        //inheritance
        //Persona ek olarak creditNumberı var
        class Customer:Person
        {
            public string CreditCardNumber { get; set; }
        }
        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }
        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
