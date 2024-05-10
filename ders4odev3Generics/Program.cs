using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        MyList<string> sehirler = new MyList<string>();
        sehirler.Add("ankara");
        sehirler.Add("istanbul");
        sehirler.Add("Bursa");
        foreach (var item in sehirler.Array)
        {
            Console.WriteLine(item);
        }

    }
    class MyList<T>//Generic class 
    {
        T[] array;
        T[] tempArray;
        public MyList()
        {
            array = new T[0];
        }
        public void Add(T item)
        {
            tempArray = array;
            array= new T[array.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
                
            }
            array[array.Length - 1] = item;

            



            

        }
        public T[] Array
        {
            get { return array; }
        }
        public int Length
        {
            get { return array.Length; }
        }
      

    }
}
