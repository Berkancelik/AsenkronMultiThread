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
    internal class Program
    {
        private async static Task Main(string[] args)
        {
            Console.WriteLine("Main thread :" + Thread.CurrentThread.ManagedThreadId);
            List<string> urlsList = new List<string>()
            {
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.n11.com",
                "https://www.haberturk.com"
            };
            
            List<Task<Content>> taskList = new List<Task<Content>>();

            urlsList.ToList().ForEach(x =>
            {
                taskList.Add(GetContentAsync(x));
            });

            Console.WriteLine("WaitAll methodundan önce");
            bool result = Task.WaitAll(taskList.ToArray(),300);
            Console.WriteLine("3 saniiye de geldi mi " + result);
            Console.WriteLine("WaitAll methodundan sonra");
            Console.WriteLine($"{taskList.First().Result.Site} - {taskList.First().Result.Length}");

            
        }
        public static async Task<Content> GetContentAsync(string url)
        {
            Content content = new Content();
            var data = await new HttpClient().GetStringAsync(url);
            content.Site = url;
            content.Length = data.Length;
            // Thread.CurrentThread.ManagedThreadId); çalışan thread'in id'sini almaktadır.
            Console.WriteLine("GetContentAsync theread:" + Thread.CurrentThread.ManagedThreadId);
            return content;
        }
    }


}
