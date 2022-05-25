using System;
using System.Linq;

namespace PLINQ.App
{
    internal class Program
    {


        private static  bool Islem(int x)
        {
            return x % 2 == 0;
        }

        static void Main(string[] args)
        {
            var arrays = Enumerable.Range(1, 100).ToList();

            //100 5 thread
            // 1 therad 1-20 2 4 6
            // 2 therad 21-40 22 24 26
            arrays.Where(x=> x % 2 == 0).ToList().ForEach(x =>
            {
                Console.WriteLine(x);
            });

            var newArray = arrays.AsParallel().Where(Islem);

            newArray.ToList().ForEach(x =>
            {
                Console.WriteLine(x);
            });

        }
    }
}
