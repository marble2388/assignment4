namespace assignment4
{
    partial class startForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startForm));
            this.newButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(12, 397);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(164, 60);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New Order";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(406, 397);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(164, 60);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load Order";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(809, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::assignment4.Properties.Resources.Netflix_Older_Logo;
            this.ClientSize = new System.Drawing.Size(985, 469);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.newButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "startForm";
            this.Text = "startForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button button3;
    }
}