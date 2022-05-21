using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TaskConsoleApp
{
    internal class Program
    {
        private async  static Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //ContinueWith parantez içinde ActionDelege istemektedir.
            // Not: ücretsiz delege kursunuz izle
            var myTask =new HttpClient().GetStringAsync("https://www.google.com").ContinueWith(
                ((data) =>
                {
                    Console.WriteLine("data uzunluk" +" "+ data.Result.Length);
                }));

            Console.WriteLine("Arada yapılacak işler");

            await myTask;
        }
    }
}
