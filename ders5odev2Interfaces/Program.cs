// See https://aka.ms/new-console-template for more information
using ders5odev2Interfaces;

Console.WriteLine("Hello, World!");
IPersonManager customerManager = new CustomerManager();

customerManager.Add();

IPersonManager employeeManager =new EmployeeManager(); ;
employeeManager.Add();

ProjectManager projectManager = new ProjectManager();
projectManager.AddManager(customerManager);
projectManager.AddManager(employeeManager);