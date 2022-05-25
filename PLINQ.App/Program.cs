using PLINQ.App.Models;
using System;
using System.Linq;
using System.Threading;

namespace PLINQ.App
{
    internal class Program
    {
      
        private static void WriteLog(Product p)
        {
            // log a yazdık
            Console.WriteLine(p.Name + " Log'a KAydedildi");
        }

        static void Main(string[] args)
        {
            AdventureWorks2017Context context = new AdventureWorks2017Context();

            // elimde var olan array üzerinde bir sogu yazmak ister isek
            //complex sorgular var ise aşağıdaki sorgu çeşidi kullanılmaktadır.
            // kod kadar okunabilirlik de çk önemlidir.
            // SQL Server sorgusu
            //var product = (from p in context.Products.AsParallel()
            //              where p.ListPrice >10M
            //              select p).Take(10);

            // Tek satır sorgu
            //var product2 = context.Products.AsParallel().Where(p => p.ListPrice >10M).Take(10);


            //product.ForAll(x =>
            //{
            //    Console.WriteLine(x.Name);
            //});

            context.Products.AsParallel().ForAll(p =>
            {
                WriteLog(p);
            });



        }
    }
}
