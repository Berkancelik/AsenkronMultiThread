using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TaskConsoleApp
{
    public class Content
    {
        public string Site { get; set; }
        public int Length { get; set; }
    }
    public class Status
    {
        public int TheradId { get; set; }
        public DateTime Date { get; set; }
    }

    internal class Program
    {

        private async Task Main(string[] args)
        {
            Task myTask = Task.Run(() =>
            {
                Console.WriteLine("My Task çalıştı");
            });

            await myTask;
            Console.WriteLine("işlem birri");

            
        }

     



    }


}
