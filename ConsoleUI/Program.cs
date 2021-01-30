using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productmanager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productmanager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
