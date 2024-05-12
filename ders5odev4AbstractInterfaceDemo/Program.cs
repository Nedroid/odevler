// See https://aka.ms/new-console-template for more information
using ders5odev4AbstractInterfaceDemo.Concrete;
using ders5odev4AbstractInterfaceDemo.Entities;

Console.WriteLine("Hello, World!");
BaseCustomerManager customerManager = new NeroCustomerManager();
customerManager.Save(new Customer { FirstName = "NEŞE", LastName = "Sargın", DateofBirth = 1988, NationalityId = 17548724008, Id = 1 });