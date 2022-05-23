using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TaskConsoleApp
{
  
    internal class Program
    {
        private async static Task Main(string[] args)
        {

        }

        public async Task<string> GetContent()
        {
            var content = await new HttpClient().GetStringAsync("https://www.google.com");
            return content;
        }



    }


}
