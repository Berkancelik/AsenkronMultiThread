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
            Console.WriteLine(GetData());
        }

        public static string GetData()
        {
            var task = new HttpClient().GetStringAsync("https://www.google.com");

            return task.Result;
        }




    }


}
