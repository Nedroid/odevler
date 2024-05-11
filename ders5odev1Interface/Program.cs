// See https://aka.ms/new-console-template for more information
using ders5odev1Interface;

Console.WriteLine("Hello, World!");
PersonManager personManager = new PersonManager();
personManager.Add(new SqlServerCustomerDal());

ICustomerDal[] customerDals = new ICustomerDal[2]{

    new SqlServerCustomerDal(),
    new SqlServerCustomerDal()
};
foreach (var customerDal in customerDals)
{
    customerDal.Add();
}
//Soyut nesneleri implement edemeyiz
