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
    public partial class SelectForm : Form
    {
        public startForm previousForm;
        product comp = Program.comp;
        public SelectForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dataSet1.products);

        }
        private void selection(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var compSelect = dataGrid.SelectedCells[0].RowIndex + 1;
                var selectedComp = (from product
                                           in dataSet1.products
                                    where product.productID == compSelect
                                    select product).FirstOrDefault();
                selectionBox.Text = selectedComp.manufacturer + " " + selectedComp.model + " Priced at: $" + Math.Round(selectedComp.cost,2);
            }
            nextButton.Enabled = true;
        }
        private void compSelection(product selectedComp)
        {
            comp.productID = selectedComp.productID;
            comp.cost = selectedComp.cost;
            comp.manufacturer = selectedComp.manufacturer;
            comp.model = selectedComp.model;
            comp.RAM_type = selectedComp.RAM_type;
            comp.RAM_size = selectedComp.RAM_size;
            comp.displaytype = selectedComp.displaytype;
            comp.screensize = selectedComp.screensize;
            comp.resolution = selectedComp.resolution;
            comp.CPU_Class = selectedComp.CPU_Class;
            comp.CPU_brand = selectedComp.CPU_brand;
            comp.CPU_type = selectedComp.CPU_type;
            comp.CPU_number = selectedComp.CPU_number;
            comp.condition = selectedComp.condition;
            comp.OS = selectedComp.OS;
            comp.platform = selectedComp.platform;
            comp.HDD_size = selectedComp.HDD_size;
            comp.HDD_speed = selectedComp.HDD_speed;
            comp.GPU_type = selectedComp.GPU_type;
            comp.optical_drive = selectedComp.optical_drive;
            comp.Audio_type = selectedComp.Audio_type;
            comp.LAN = selectedComp.LAN;
            comp.WIFI = selectedComp.WIFI;
            comp.width = selectedComp.width;
            comp.height = selectedComp.height;
            comp.depth = selectedComp.depth;
            comp.weight = selectedComp.weight;
            comp.mouse_type = selectedComp.mouse_type;
            comp.power = selectedComp.power;
            comp.webcam = selectedComp.webcam;

        }
        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selection(e);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // this is how i feel the cancel button should function
            // previousForm.Show();
            // this.Hide();
            Application.Exit();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.previousForm = this;
            productInfoForm.Show();
            this.Hide();

        }
    }
}
