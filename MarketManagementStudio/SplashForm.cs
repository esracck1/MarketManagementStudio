using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementStudio
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 1;
            progressBar1.Value = sayac;
            if (progressBar1.Value==100)
            {
                progressBar1.ForeColor = Color.White;
                progressBar1.Value = 0;
                timer1.Stop();
                ProductForm login = new ProductForm();
                this.Hide();
                login.Show();
                
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
