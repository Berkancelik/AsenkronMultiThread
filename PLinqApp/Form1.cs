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

namespace PLinqApp
{
    public partial class Form1 : Form
    {
        private bool Hesapla(int x)
        {
            // Cpu da vermiş olduğumuz iterasyon kadar kod gönderir.
            // While döngüsü gibi düşünülebilir.
            Thread.SpinWait(500);
            return x % 12 == 0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Task.Run(() =>
            //{
            //    try
            //    {
            //        Enumerable.Range(1, 100000).AsParallel().WithCancellation(cts.Token).Where(Hesapla).ToList().
            //   ForEach(x =>
            //   {
            //       Thread.Sleep(100);
            //       cts.To
            //       listBox1.Invoke((MethodInvoker)delegate { listBox1.Items.Add(x); });
            //   });
            //    }
            //    catch (OperationCanceledException ex)
            //    {

            //        MessageBox.Show("İşlem iptal edildi");
            //    }
            //    catch (Exception ex2)
            //    {
            //        MessageBox.Show("Genel bir hata meydana geldi");
            //    }
            //});
           
        }
    }
}
