using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev6eCommerce;
//Product class tanımlaması
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    //constructor
    public Product()
    {

    }
    public Product(int id, string name, string description, double price)
    {
        this.Id = id;
        this.Name = name;
        this.Description = description;
        this.Price = price;
    }
    //Add product method
    public static Product CreateProduct()
    {
        Console.WriteLine("Enter Product id");
        int i= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Product Name");
        string pName = Console.ReadLine();
        Console.WriteLine("Enter Product Description");
        string pDescription = Console.ReadLine();
        Console.WriteLine("Enter Product Price");
        double pPrice = Convert.ToDouble(Console.ReadLine());

        Product product =new(i, pName, pDescription, pPrice);


        return product;
    }
    //list of product method
    public static void ListProduct(Product[] product)

    {
        foreach (var item in product)
        {
            Console.WriteLine("Product List");
            Console.WriteLine("Id: " + item.Id);
            Console.WriteLine("Name: " + item.Name);
            Console.WriteLine("Description: " + item.Description);
            Console.WriteLine("Price: " + item.Price);
        }
    }


}
