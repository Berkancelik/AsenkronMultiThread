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
            var myTask = Task.Factory.StartNew((objectobj) =>
            {
                Console.WriteLine("myTask çalıştır");
                var status = objectobj as Status;
                status.TheradId = Thread.CurrentThread.ManagedThreadId;

            },new Status() { Date = DateTime.Now });
            await myTask;

            Status s = myTask.AsyncState as Status;
            Console.WriteLine(s.Date);
            Console.WriteLine(s.TheradId);
        }





    }


}
