using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID Yazılıma Yeni Bir Özeellik Ekliyorsan Hiçbir koda dokunamazsın
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(100,1000))
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
