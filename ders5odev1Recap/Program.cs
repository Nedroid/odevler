// See https://aka.ms/new-console-template for more information
using ders5odev1Recap;

Console.WriteLine("Hello, World!");
CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

Customer customer = new Customer();
customer.FirstName = "Engin";
customer.LastName = "DEmiirog";
customer.City = "Ankara";
customer.Id = 1;

Customer customer2 = new Customer();
customer2.FirstName = "Derin";
customer2.LastName = "Serı";
customer2.City = "Van";
customer2.Id = 2;


