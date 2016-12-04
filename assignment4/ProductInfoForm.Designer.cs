namespace assignment4
{
    partial class ProductInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productIDlbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.model = new System.Windows.Forms.Label();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.osBox = new System.Windows.Forms.TextBox();
            this.oslbl = new System.Windows.Forms.Label();
            this.manufacturerlbl = new System.Windows.Forms.Label();
            this.manufacturerBox = new System.Windows.Forms.TextBox();
            this.platformBox = new System.Windows.Forms.TextBox();
            this.platformlbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webcamBox = new System.Windows.Forms.TextBox();
            this.gputBox = new System.Windows.Forms.TextBox();
            this.hddBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cpusBox = new System.Windows.Forms.TextBox();
            this.cpunBox = new System.Windows.Forms.TextBox();
            this.lcdBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cputBox = new System.Windows.Forms.TextBox();
            this.cpubBox = new System.Windows.Forms.TextBox();
            this.memBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.memorylbl = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.conditionlbl = new System.Windows.Forms.Label();
            this.conditionBox = new System.Windows.Forms.TextBox();
            this.costlbl = new System.Windows.Forms.Label();
            this.costBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Se&lect Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.selectAnotherProductToolStripMenuItem_Click);
            // 
            // productIDlbl
            // 
            this.productIDlbl.AutoSize = true;
            this.productIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDlbl.Location = new System.Drawing.Point(28, 43);
            this.productIDlbl.Name = "productIDlbl";
            this.productIDlbl.Size = new System.Drawing.Size(85, 20);
            this.productIDlbl.TabIndex = 1;
            this.productIDlbl.Text = "Product ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.model);
            this.groupBox1.Controls.Add(this.modelBox);
            this.groupBox1.Controls.Add(this.osBox);
            this.groupBox1.Controls.Add(this.oslbl);
            this.groupBox1.Controls.Add(this.manufacturerlbl);
            this.groupBox1.Controls.Add(this.manufacturerBox);
            this.groupBox1.Controls.Add(this.platformBox);
            this.groupBox1.Controls.Add(this.platformlbl);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.Location = new System.Drawing.Point(347, 75);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(52, 20);
            this.model.TabIndex = 9;
            this.model.Text = "Model";
            // 
            // modelBox
            // 
            this.modelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelBox.Location = new System.Drawing.Point(405, 72);
            this.modelBox.Name = "modelBox";
            this.modelBox.ReadOnly = true;
            this.modelBox.Size = new System.Drawing.Size(533, 26);
            this.modelBox.TabIndex = 7;
            // 
            // osBox
            // 
            this.osBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osBox.Location = new System.Drawing.Point(405, 25);
            this.osBox.Name = "osBox";
            this.osBox.ReadOnly = true;
            this.osBox.Size = new System.Drawing.Size(533, 26);
            this.osBox.TabIndex = 5;
            // 
            // oslbl
            // 
            this.oslbl.AutoSize = true;
            this.oslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oslbl.Location = new System.Drawing.Point(367, 28);
            this.oslbl.Name = "oslbl";
            this.oslbl.Size = new System.Drawing.Size(32, 20);
            this.oslbl.TabIndex = 8;
            this.oslbl.Text = "OS";
            // 
            // manufacturerlbl
            // 
            this.manufacturerlbl.AutoSize = true;
            this.manufacturerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerlbl.Location = new System.Drawing.Point(6, 75);
            this.manufacturerlbl.Name = "manufacturerlbl";
            this.manufacturerlbl.Size = new System.Drawing.Size(104, 20);
            this.manufacturerlbl.TabIndex = 7;
            this.manufacturerlbl.Text = "Manufacturer";
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerBox.Location = new System.Drawing.Point(119, 72);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.ReadOnly = true;
            this.manufacturerBox.Size = new System.Drawing.Size(122, 26);
            this.manufacturerBox.TabIndex = 6;
            // 
            // platformBox
            // 
            this.platformBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformBox.Location = new System.Drawing.Point(119, 25);
            this.platformBox.Name = "platformBox";
            this.platformBox.ReadOnly = true;
            this.platformBox.Size = new System.Drawing.Size(122, 26);
            this.platformBox.TabIndex = 4;
            // 
            // platformlbl
            // 
            this.platformlbl.AutoSize = true;
            this.platformlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformlbl.Location = new System.Drawing.Point(42, 28);
            this.platformlbl.Name = "platformlbl";
            this.platformlbl.Size = new System.Drawing.Size(68, 20);
            this.platformlbl.TabIndex = 0;
            this.platformlbl.Text = "Platform";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webcamBox);
            this.groupBox2.Controls.Add(this.gputBox);
            this.groupBox2.Controls.Add(this.hddBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cpusBox);
            this.groupBox2.Controls.Add(this.cpunBox);
            this.groupBox2.Controls.Add(this.lcdBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cputBox);
            this.groupBox2.Controls.Add(this.cpubBox);
            this.groupBox2.Controls.Add(this.memBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.memorylbl);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(955, 158);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tech Specs";
            // 
            // webcamBox
            // 
            this.webcamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webcamBox.Location = new System.Drawing.Point(642, 111);
            this.webcamBox.Name = "webcamBox";
            this.webcamBox.ReadOnly = true;
            this.webcamBox.Size = new System.Drawing.Size(296, 26);
            this.webcamBox.TabIndex = 16;
            // 
            // gputBox
            // 
            this.gputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gputBox.Location = new System.Drawing.Point(642, 67);
            this.gputBox.Name = "gputBox";
            this.gputBox.ReadOnly = true;
            this.gputBox.Size = new System.Drawing.Size(296, 26);
            this.gputBox.TabIndex = 13;
            // 
            // hddBox
            // 
            this.hddBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddBox.Location = new System.Drawing.Point(642, 24);
            this.hddBox.Name = "hddBox";
            this.hddBox.ReadOnly = true;
            this.hddBox.Size = new System.Drawing.Size(296, 26);
            this.hddBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Webcam";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "GPU Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(571, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "HDD";
            // 
            // cpusBox
            // 
            this.cpusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpusBox.Location = new System.Drawing.Point(405, 111);
            this.cpusBox.Name = "cpusBox";
            this.cpusBox.ReadOnly = true;
            this.cpusBox.Size = new System.Drawing.Size(122, 26);
            this.cpusBox.TabIndex = 15;
            // 
            // cpunBox
            // 
            this.cpunBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpunBox.Location = new System.Drawing.Point(405, 67);
            this.cpunBox.Name = "cpunBox";
            this.cpunBox.ReadOnly = true;
            this.cpunBox.Size = new System.Drawing.Size(122, 26);
            this.cpunBox.TabIndex = 12;
            // 
            // lcdBox
            // 
            this.lcdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcdBox.Location = new System.Drawing.Point(405, 24);
            this.lcdBox.Name = "lcdBox";
            this.lcdBox.ReadOnly = true;
            this.lcdBox.Size = new System.Drawing.Size(122, 26);
            this.lcdBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "CPU speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "CPU number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "LCD Size";
            // 
            // cputBox
            // 
            this.cputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cputBox.Location = new System.Drawing.Point(116, 111);
            this.cputBox.Name = "cputBox";
            this.cputBox.ReadOnly = true;
            this.cputBox.Size = new System.Drawing.Size(122, 26);
            this.cputBox.TabIndex = 14;
            // 
            // cpubBox
            // 
            this.cpubBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpubBox.Location = new System.Drawing.Point(116, 67);
            this.cpubBox.Name = "cpubBox";
            this.cpubBox.ReadOnly = true;
            this.cpubBox.Size = new System.Drawing.Size(122, 26);
            this.cpubBox.TabIndex = 11;
            // 
            // memBox
            // 
            this.memBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memBox.Location = new System.Drawing.Point(116, 24);
            this.memBox.Name = "memBox";
            this.memBox.ReadOnly = true;
            this.memBox.Size = new System.Drawing.Size(122, 26);
            this.memBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPU Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU Brand";
            // 
            // memorylbl
            // 
            this.memorylbl.AutoSize = true;
            this.memorylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memorylbl.Location = new System.Drawing.Point(45, 27);
            this.memorylbl.Name = "memorylbl";
            this.memorylbl.Size = new System.Drawing.Size(65, 20);
            this.memorylbl.TabIndex = 0;
            this.memorylbl.Text = "Memory";
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(131, 40);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(122, 26);
            this.idBox.TabIndex = 0;
            // 
            // conditionlbl
            // 
            this.conditionlbl.AutoSize = true;
            this.conditionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionlbl.Location = new System.Drawing.Point(335, 43);
            this.conditionlbl.Name = "conditionlbl";
            this.conditionlbl.Size = new System.Drawing.Size(76, 20);
            this.conditionlbl.TabIndex = 4;
            this.conditionlbl.Text = "Condition";
            // 
            // conditionBox
            // 
            this.conditionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionBox.Location = new System.Drawing.Point(417, 40);
            this.conditionBox.Name = "conditionBox";
            this.conditionBox.ReadOnly = true;
            this.conditionBox.Size = new System.Drawing.Size(134, 26);
            this.conditionBox.TabIndex = 1;
            // 
            // costlbl
            // 
            this.costlbl.AutoSize = true;
            this.costlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costlbl.Location = new System.Drawing.Point(667, 43);
            this.costlbl.Name = "costlbl";
            this.costlbl.Size = new System.Drawing.Size(42, 20);
            this.costlbl.TabIndex = 5;
            this.costlbl.Text = "Cost";
            // 
            // costBox
            // 
            this.costBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costBox.Location = new System.Drawing.Point(715, 40);
            this.costBox.Name = "costBox";
            this.costBox.ReadOnly = true;
            this.costBox.Size = new System.Drawing.Size(139, 26);
            this.costBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click Next to Confirm Your selection";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(532, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Select Another Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(747, 381);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 34);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Canel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(860, 381);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(107, 34);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(261, 28);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 10;
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 425);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.costlbl);
            this.Controls.Add(this.conditionBox);
            this.Controls.Add(this.conditionlbl);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.productIDlbl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ProductInfoForm";
            this.Text = "ProductInfoForm";
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label productIDlbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox osBox;
        private System.Windows.Forms.Label oslbl;
        private System.Windows.Forms.Label manufacturerlbl;
        private System.Windows.Forms.TextBox manufacturerBox;
        private System.Windows.Forms.TextBox platformBox;
        private System.Windows.Forms.Label platformlbl;
        private System.Windows.Forms.TextBox webcamBox;
        private System.Windows.Forms.TextBox gputBox;
        private System.Windows.Forms.TextBox hddBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cpusBox;
        private System.Windows.Forms.TextBox cpunBox;
        private System.Windows.Forms.TextBox lcdBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cputBox;
        private System.Windows.Forms.TextBox cpubBox;
        private System.Windows.Forms.TextBox memBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label memorylbl;
        private System.Windows.Forms.Label conditionlbl;
        private System.Windows.Forms.TextBox conditionBox;
        private System.Windows.Forms.Label costlbl;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox textBox;
    }
}