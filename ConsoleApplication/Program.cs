using System;
using WcfServiceREST;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ps = new ProductService();

            Console.WriteLine(ps.GetProduct(1.ToString()));

            Console.Read();
        }
    }
}