using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ParallelForAndForEachConcellationApp
{
    public partial class Form1 : Form
    {
        CancellationTokenSource ct;
        public int counter { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> urls = new List<string>()
            {
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
            };
            HttpClient client = new HttpClient();
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.CancellationToken = ct.Token;

            Task.Run(() =>
            {
                try
                {
                    Parallel.ForEach<string>(urls, parallelOptions, (url) =>
                    {
                        string content = client.GetStringAsync(url).Result;
                        string data = $"{url}:{content.Length}";
                        ct.Token.ThrowIfCancellationRequested();
                        listBox1.Invoke((MethodInvoker)delegate { listBox1.Items.Add(data); });
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem iptal edildi" + ex.Message);
                }
            
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ct.Cancel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = counter++.ToString();
        }
    }
}
