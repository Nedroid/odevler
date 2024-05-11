// See https://aka.ms/new-console-template for more information
using ders5odev1Inheritance;

Console.WriteLine("Hello, World!");
Person[] persons = new Person[3] {
new Customer{Name="Engin"},
new Student{Name="Derin"},
new Person{Name="Salih"}

};
foreach (var person in persons)
{
    Console.WriteLine(person.Name);
}