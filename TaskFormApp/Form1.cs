using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFormApp
{
    public partial class Form1 : Form
    {
        public int counnter { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            string data = ReadFile();
            richTextBox1.Text = data;
        }

        private void BtnCounter_Click(object sender, EventArgs e)
        {
            textBoxXounter.Text = counnter++.ToString();
        }

        private string ReadFile()
        {
            string data = string.Empty;
            using (StreamReader s = new StreamReader("TextFile1.txt"))
            {
                Thread.Sleep(5000);
                data = s.ReadToEnd();
            }
            return data;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private async Task<string> ReadFileAsync()
        //{
        //    string data = string.Empty;
        //    using (StreamReader s = new StreamReader("TextFile1.txt"))
        //    {
        //        Task<string> myTask = s.ReadToEndAsync();
        //        myTask.Wait();
        //        data = await myTask;

        //    }
        //}


    }
}
