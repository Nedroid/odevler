// See https://aka.ms/new-console-template for more information
using ders4odev5MyDictionary;

Console.WriteLine("Hello, World!");
MyDictionary<int,string> myCity = new MyDictionary<int,string>();
myCity.Add(1, "Adana");
myCity.Add(2, "adıyaman");
myCity.Add(3, "antep");
myCity.Add(4, "Ankara");
myCity.Add(5, "bursa");
List<int> key=myCity.GetKeys();
List<string>value=myCity.GetValues();

foreach (int i in key)
{
    
    Console.WriteLine("City="+i+"\n city name="+ myCity.GetValueByKey(i));
}
Console.ReadLine();