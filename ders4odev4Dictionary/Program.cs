// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Dictionary<anahtar_type,deger_type> referans=
//girilen plakaya göre ili geetiren console uygulaması
Dictionary<int,string> il = new Dictionary<int,string>(); ;
il.Add(34, "istanbul");
il.Add(06, "Ankara");
il.Add(04, "Ağri");
il.Add(16, "bursa");
Console.WriteLine("lütfen plaka numarasını giriniz");
int plaka =int.Parse(Console.ReadLine());
int elemanSayisi=il.Count;
Console.WriteLine("eleman sayısı" +elemanSayisi);
//il.Clear() metodu ile bütün datayı silebilirsin

Console.Write(il[plaka]);

Dictionary<int,string> student = new Dictionary<int,string>();
student.Add(13, "eda");
student.Add(90, "ayse");
student.Add(88, "nese");
student.Add(81, "sema");
student.Add(82, "seda");
student.Add(25, "Arda");
Dictionary<int, string>.KeyCollection studentNumber = student.Keys;
foreach(int key in studentNumber)
    Console.WriteLine(key);
Dictionary<int,string>.ValueCollection studentName = student.Values;
foreach(string name in studentName)
    Console.WriteLine(name);