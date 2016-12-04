using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm  = new SelectForm();
            selectForm.previousForm = this;
            selectForm.Show();
            this.Hide();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Program.loadFile = true;
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Show();
            this.Hide();
        }
    }
}
