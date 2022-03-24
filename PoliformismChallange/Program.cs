using PoliformismChallange.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;


namespace PoliformismChallange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products : ");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Product #" + (i + 1) + " data:");
                Console.Write("Common, used or imported (c/u/i)");
                char type = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Price : ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (type == 'c')
                {
                    products.Add(new Product(name, price));
                }else if(type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name,price,manufactureDate));
                    
                }else if(type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));

                }
                else
                {
                    Console.WriteLine("!!ERROR!!");
                }
            }
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
            Console.ReadKey();
        }
    }
}
