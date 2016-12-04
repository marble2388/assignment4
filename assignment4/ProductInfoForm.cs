using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Jeff Hall
//200328772
//2016/12/02-03
//App used to steal money from people looking to buy computers
//didnt test a single thing im just trusting that it will work
namespace assignment4
{
    public partial class ProductInfoForm : Form
    {
        //add the selected comp to the form = pervious form reference
        public SelectForm previousForm;
        product comp = Program.comp;
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        // method to save order to a file
        //had to do lots of googling for this and the method to open files.
        private void saveFile()
        {
            //opens up save file dialog to allow the user to decide to save their order or not.
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Product";
            saveFile.Filter = "Text Files(*.txt) | *.txt ";
            saveFile.InitialDirectory = Directory.GetCurrentDirectory();
            saveFile.Title = "Save an Image File";
            DialogResult result = saveFile.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                //create writer to save variables to file
                StreamWriter saver = new StreamWriter(saveFile.FileName, true);
                //serj had suggested this soltuion to me as i couldnt get my comp object to save to the file and be read
                //the streamwriter opens saves the variables then closes and informs the user
                //now that i know i was having issues with my variable in selectForm 
                //this might not have been needed 
                saver.WriteLine(comp.productID + ";" +
                comp.cost + ";" +
                comp.manufacturer + ";" +
                comp.model + ";" +
                comp.RAM_type + ";" +
                comp.RAM_size + ";" +
                comp.displaytype + ";" +
                comp.screensize + ";" +
                comp.resolution + ";" +
                comp.CPU_brand + ";" +
                comp.CPU_Class + ";" +
                comp.CPU_number + ";" +
                comp.CPU_speed + ";" +
                comp.CPU_type + ";" +
                comp.condition + ";" +
                comp.OS + ";" +
                comp.platform + ";" +
                comp.HDD_size + ";" +
                comp.HDD_speed + ";" +
                comp.GPU_type + ";" +
                comp.optical_drive + ";" +
                comp.Audio_type + ";" +
                comp.LAN + ";" +
                comp.WIFI + ";" +
                comp.width + ";" +
                comp.height + ";" +
                comp.depth + ";" +
                comp.weight + ";" +
                comp.mouse_type + ";" +
                comp.power + ";" +
                comp.webcam);
                saver.Close();
                MessageBox.Show("File succesfully saved", "You did it!", MessageBoxButtons.OK);
            }

        }
        //method to open a save order file
        private void OpenSaveFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Directory.GetCurrentDirectory();
            openFile.Title = "Open File";
            openFile.Filter = "Text Files(*.txt) | *.txt";
            DialogResult result = openFile.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                //make the file reader and then open the file and save it to an array split at the ;
                //part of the save solution serj explained to me its a similar set up to saving the file
                StreamReader open = new StreamReader(openFile.FileName);
                string orderVariables = open.ReadLine();
                string[] orderArray = orderVariables.Split(';');
                loadOrder(orderArray);
                MessageBox.Show("Your order has been restored", "", MessageBoxButtons.OK);
                fillForm();
            }
        }
        // method for loading orders to the comp object
        private void loadOrder(String[] orderArray)
        {
            comp.productID = short.Parse(orderArray[0]);
            comp.cost = Convert.ToDouble(orderArray[1]);
            comp.manufacturer = orderArray[2];
            comp.model = orderArray[3];
            comp.RAM_type = orderArray[4];
            comp.RAM_size = orderArray[5];
            comp.displaytype = orderArray[6];
            comp.screensize = orderArray[7];
            comp.resolution = orderArray[8];
            comp.CPU_brand = orderArray[9];
            comp.CPU_Class = orderArray[10];
            comp.CPU_number = orderArray[11];
            comp.CPU_speed = orderArray[12];
            comp.CPU_type = orderArray[13];
            comp.condition = orderArray[14];
            comp.OS = orderArray[15];
            comp.platform = orderArray[16];
            comp.HDD_size = orderArray[17];
            comp.HDD_speed = orderArray[18];
            comp.GPU_type = orderArray[19];
            comp.optical_drive = orderArray[20];
            comp.Audio_type = orderArray[21];
            comp.LAN = orderArray[22];
            comp.WIFI = orderArray[23];
            comp.width = orderArray[24];
            comp.height = orderArray[25];
            comp.depth = orderArray[26];
            comp.weight = orderArray[27];
            comp.mouse_type = orderArray[28];
            comp.power = orderArray[29];
            comp.webcam = orderArray[30];
        }
        //fills the form with info from the chosen computer
        private void fillForm()
        {
            idBox.Text = comp.productID.ToString();
            conditionBox.Text = comp.condition;
            costBox.Text = "$" + Math.Round((comp.cost), 2).ToString();           
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
            // enable next button
            nextButton.Enabled = true;
           // textBox.Text = "test";

        }
        //i forgot to change the name of the button
        //this is the select another product button
        //it checks to see if there is a selectform already then either shows or creates it
        private void button1_Click(object sender, EventArgs e)
        {
            if (previousForm == null)
            {
                previousForm = new SelectForm();
            }
            previousForm.Show();
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //on load fill the form
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            if (Program.loadFile)
            {
                OpenSaveFile();
                Program.loadFile = false;
            }
                fillForm();
                //textBox.Text = "test";
            
        }
        // same as button1 click loads selectform for a different product selection
        // it is such a small piece of code i felt i could just copy from button1 method 
        //instead of make them both call a seperate method
        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previousForm == null)
            {
                previousForm = new SelectForm();
            }
            previousForm.Show();
            this.Hide();
        }
        //exits the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //saves the order to a file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {          
                DialogResult result = MessageBox.Show("Are you sure you would like to save this order?"," ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    saveFile();
                }
            
        }
        //opens saved order
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to open this order?", " ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                OpenSaveFile();
            }
        }
        //next button loads orderForm and hides this one
        private void nextButton_Click(object sender, EventArgs e)
        {
            orderForm orderForm = new orderForm();
            orderForm.previousForm = this;
            orderForm.Show();
            this.Hide();
        }
    }
}
