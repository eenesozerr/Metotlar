using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            SepetMenager sepetMenager = new SepetMenager();
            Product product1 = new Product();

            product1.Name = "Elma";
            product1.Explanation = "Amasya Elma";
            product1.Price = 10;
            product1.Id = 1;

            Product product2 = new Product();
            product2.Name = "visne";
            product2.Explanation = "Afyon Visne";
            product2.Price = 15;
            product2.Id = 2;

            Product[] products = new Product[] { product1, product2 };
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Explanation);
                Console.WriteLine(product.Price);
                sepetMenager.Add(product);
                Console.WriteLine(" ");
            }
            Console.WriteLine("-------Metotlar-------");
        }
    }
}
