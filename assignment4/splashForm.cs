using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Jeff Hall
//200328772
//2016/12/02
//App used to steal money from people looking to buy computers
namespace assignment4
{
    public partial class splashForm : Form
    {
        public splashForm()
        {
            InitializeComponent();
        }

        //load start form and hide splash screen
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            startForm startForm = new startForm();
            startForm.Show();
            this.Hide();
        }
    }
}
