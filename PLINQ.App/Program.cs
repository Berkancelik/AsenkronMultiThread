using PLINQ.App.Models;
using System;
using System.Linq;
using System.Threading;

namespace PLINQ.App
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            AdventureWorks2017Context context = new AdventureWorks2017Context();

            context.Products.Take(10).ToList().ForEach(x =>
            {
                Console.WriteLine(x.Name);
            });



        }
    }
}
