using ExercicioPropostoDevSuperiorPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioPropostoDevSuperiorPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            var productList = new List<Product>();
            try
            {
                Console.Write("Enter the number of products: ");
                int numberProducts = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numberProducts; i++)
                {
                    Console.WriteLine($"Product #{i} data: ");
                    Console.Write("Common, used or imported (c/u/i)? ");
                    char type = char.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Price: ");
                    var price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (type == 'i' || type == 'I' )
                    {
                        Console.Write("Customs fee: ");
                        var customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        productList.Add(new ImportedProduct(name, price, customFee));            
                    }
                    else if (type == 'u' || type == 'U')
                    {
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        var manufactureDate = DateTime.Parse(Console.ReadLine());
                        productList.Add(new UsedProduct(name,price,manufactureDate));
                    } else
                    {
                        productList.Add(new Product(name,price));
                    }
                }
                Console.WriteLine("\nPRICE TAGS:");
                foreach (var product in productList)
                {
                    Console.WriteLine(product.PriceTag());
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
