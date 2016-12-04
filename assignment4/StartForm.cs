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
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }
        //start new order
        private void newButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm  = new SelectForm();
            selectForm.previousForm = this;
            selectForm.Show();
            this.Hide();
        }
        //load saved order
        private void loadButton_Click(object sender, EventArgs e)
        {
            Program.loadFile = true;
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Show();
            this.Hide();
        }
        //aptly named button3 is the exit button it exits the porgram
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}