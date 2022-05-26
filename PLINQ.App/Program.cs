using PLINQ.App.Models;
using System;
using System.Linq;
using System.Threading;

namespace PLINQ.App
{
    internal class Program
    {

        private static bool isTrue(Product p)
        {
            try
            {
                return p.Name[2] == 'a';
            }
            catch (Exception ex)
            {

                Console.WriteLine("Dizi sınırları aşıldı");
                return false;
            }
        }

        static void Main(string[] args)
        {
            AdventureWorks2017Context content = new AdventureWorks2017Context();

            var product = content.Products.Take(100).ToArray();

            product[3].Name = "##";
            //ahmet
            var query = product.AsParallel().Where(p => p.Name[2] == 'a');

            try
            {
                query.ForAll(x =>
                {
                    Console.WriteLine( $"{x.Name}");
                });
            }
            //birden fazla exception yakalabilmektedir
            catch (AggregateException ex)
            {

                ex.InnerExceptions.ToList().ForEach(x =>
                {
                    if (x is IndexOutOfRangeException)
                    {
                        Console.WriteLine($"Hata : array sınırları dışına çıktınız");

                    }
                });
            }

        }
    }
}
