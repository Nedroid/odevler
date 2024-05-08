// See https://aka.ms/new-console-template for more information
using odev6eCommerce;
Console.WriteLine("Merhaba, Eklemek istediğiniz ürün adedini girin");
baslangic:

int aded = Convert.ToInt32(Console.ReadLine());
//bool converted = int.TryParse(Console.ReadLine(), out int aded);
while (aded > 0)
{

    //list of product
    Product[] products = new Product[aded];
    for (int i = 0; i < aded; i++)
    {
        products[i] = Product.CreateProduct();


    }

    Product.ListProduct(products);
    break;
}


    Console.WriteLine("Lütfen sayısal bir değer girin");
goto baslangic;

