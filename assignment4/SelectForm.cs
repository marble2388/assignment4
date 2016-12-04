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
    public partial class SelectForm : Form
    {
        //start of form add comp object and pervious form
        public startForm previousForm;
        product comp = Program.comp;
        public SelectForm()
        {
            InitializeComponent();
        }
        //im really bad at the name thing
        //loads the selectForm and fills the table with dataset info
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dataSet1.products);

        }
        //selects the row the user clicks on and shows the basic info in the selectionbox text
        //it then loads all the selection info in to the comp object because i couldnt get it to work in a method
        //fairly certain this allows a load with no info if you follow a certain path
        private void selection(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //seems to select the row before unless +1
                var compSelect = dataGrid.SelectedCells[0].RowIndex + 1;
                var selectedComp = (from product
                                           in dataSet1.products
                                    where product.productID == compSelect
                                    select product).FirstOrDefault();
                selectionBox.Text = selectedComp.manufacturer + " " + selectedComp.model + " Priced at: $" + Math.Round(selectedComp.cost,2);
                

                comp.productID = selectedComp.productID;
                comp.cost = Math.Round(Convert.ToDouble(selectedComp.cost), 2);
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
                comp.GPU_type = selectedComp.GPU_Type;
                comp.optical_drive = selectedComp.optical_drive;
                comp.Audio_type = selectedComp.Audio_type;
                comp.LAN = selectedComp.LAN;
                comp.WIFI = selectedComp.WIFI;
                comp.width = selectedComp.width;
                comp.height = selectedComp.height;
                comp.depth = selectedComp.depth;
                comp.weight = selectedComp.weight;
                comp.mouse_type = selectedComp.moust_type;
                comp.power = selectedComp.power;
                comp.webcam = selectedComp.webcam;
            }
            //turns the next button on for use
            nextButton.Enabled = true;
        }
        /* no idea why this wont work. i cant get selectedComp to be an object
        // and i cant get it to give variables when loaded so now every click you make changes the comp object
        private void compSelection(selectedComp)
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
        */
        //this was used to make the selection smoother otherwise it will only load the first row clicked sometimes
        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selection(e);
        }
        //closes the program
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // this is how i feel the cancel button should function
            // previousForm.Show();
            // this.Hide();
            Application.Exit();
        }
        //next button loads next form hides this one
        private void nextButton_Click(object sender, EventArgs e)
        {

            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.previousForm = this;
            productInfoForm.Show();
            this.Hide();
            

        }
    }
}
