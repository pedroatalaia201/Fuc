using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using Entities;

namespace aula225_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // ---- List to recive the names -----//
            Func<Product, string> func = product => product.Name.ToUpper();

            List<string> result = list.Select(func).ToList();
            foreach(string res in result)
            {
                Console.WriteLine(res);
            }
        }
    }
}
