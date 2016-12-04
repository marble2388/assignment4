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
//2016/12/03
//App used to steal money from people looking to buy computers
namespace assignment4
{
    public partial class orderForm : Form
    {
        //perviouse form and loading the chosen comp info
        public ProductInfoForm previousForm;
        product comp = Program.comp;
        public orderForm()
        {
            InitializeComponent();
        }
        //same as product info form fills form textboxes
        private void fillForm()
        {

            //add product info to the form and show cost,tax and total
            costBox.Text = "$" + Math.Round((comp.cost), 2).ToString();
            taxBox.Text = "$" + Math.Round((comp.cost * .13), 2).ToString();
            totalBox.Text = "$" + Math.Round((comp.cost * 13 + comp.cost), 2).ToString();
            conditionBox.Text = comp.condition;
            platformBox.Text = comp.platform;
            osBox.Text = comp.OS;
            manufacturerBox.Text = comp.manufacturer;
            modelBox.Text = comp.model;
            lcdBox.Text = comp.screensize;
            memBox.Text = comp.RAM_size;
            cpubBox.Text = comp.CPU_brand;
            cputBox.Text = comp.CPU_type;
            cpunBox.Text = comp.CPU_number;
            cpusBox.Text = comp.CPU_speed;
            hddBox.Text = comp.HDD_size;
            gputBox.Text = comp.GPU_type;
            webcamBox.Text = comp.webcam;
            //this is the pretend code to make the picture apear
            //i did not want to find a picture for each one and this just made it a static one
            //compPicBox.Iamge =(Image)from assignment4 images based on productID 
        }
        //so happy i found the even tab for objects makes all of this so much easier
        //back button returns to previous form
        private void backButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Hide();
        }
        //exits program
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //loads the product info on form load
        private void orderForm_Load(object sender, EventArgs e)
        {
            fillForm();
        }
        //about program author and such
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Author Jeff Hall st#200328772.\nDollar Computers Inc.\nWebsite: www.dollarComps.ca. \nPhone Number: 1 999 999 9999", "Program Information");
        }
        //print message for those who would like a paper copy of their computer info
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("why would you even try this");
        }
        // finish button ends program and shows a nice message
        // i know " " would work
        private void finishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for the money\n Have a nice day","Order will be recieved in 7-10 business days", MessageBoxButtons.OK);
            Application.Exit();
        }
    }
}
