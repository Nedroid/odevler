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

for (int i = 0; i < key.Count; i++) 
{
    Console.WriteLine("City="+key+"\n city number"+value);
}
Console.ReadLine();