using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskThreadApp
{
    public partial class Form1 : Form
    {
        public static int Counter { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private async void baslat_Click(object sender, EventArgs e)
        {
            await Go(progressBar1);
            await Go(progressBar2);
        }

        private void Sayac_Click(object sender, EventArgs e)
        {
            Sayac.Text = Counter.ToString();
        }

        public async Task Go(System.Windows.Forms.ProgressBar pb)
        {
            await Task.Run(() =>{ Enumerable.Range(1, 100).ToList().ForEach(x =>
            {
              //  Thread.Sleep();
                pb.Invoke((MethodInvoker)delegate { pb.Value = x; });
            });
        });
    }
}}
