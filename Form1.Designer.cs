namespace CarList
{
    partial class carListForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.addCarButton = new System.Windows.Forms.Button();
            this.makeLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.carLabel = new System.Windows.Forms.Label();
            this.carInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.displayCarsButton = new System.Windows.Forms.Button();
            this.carInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(335, 227);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // addCarButton
            // 
            this.addCarButton.Location = new System.Drawing.Point(41, 179);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(99, 23);
            this.addCarButton.TabIndex = 1;
            this.addCarButton.Text = "Add Car to List";
            this.addCarButton.UseVisualStyleBackColor = true;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(32, 19);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(37, 13);
            this.makeLabel.TabIndex = 2;
            this.makeLabel.Text = "Make:";
            this.makeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(37, 53);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year:";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Location = new System.Drawing.Point(26, 89);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(47, 13);
            this.mileageLabel.TabIndex = 4;
            this.mileageLabel.Text = "Mileage:";
            this.mileageLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(75, 19);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 5;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(75, 53);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 6;
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Location = new System.Drawing.Point(75, 89);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(100, 20);
            this.mileageTextBox.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(248, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 95);
            this.listBox1.TabIndex = 8;
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Location = new System.Drawing.Point(245, 12);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(45, 13);
            this.carLabel.TabIndex = 9;
            this.carLabel.Text = "Car List:";
            // 
            // carInfoGroupBox
            // 
            this.carInfoGroupBox.Controls.Add(this.makeLabel);
            this.carInfoGroupBox.Controls.Add(this.makeTextBox);
            this.carInfoGroupBox.Controls.Add(this.yearLabel);
            this.carInfoGroupBox.Controls.Add(this.mileageTextBox);
            this.carInfoGroupBox.Controls.Add(this.yearTextBox);
            this.carInfoGroupBox.Controls.Add(this.mileageLabel);
            this.carInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.carInfoGroupBox.Name = "carInfoGroupBox";
            this.carInfoGroupBox.Size = new System.Drawing.Size(212, 152);
            this.carInfoGroupBox.TabIndex = 10;
            this.carInfoGroupBox.TabStop = false;
            this.carInfoGroupBox.Text = "Car Information";
            // 
            // displayCarsButton
            // 
            this.displayCarsButton.Location = new System.Drawing.Point(305, 179);
            this.displayCarsButton.Name = "displayCarsButton";
            this.displayCarsButton.Size = new System.Drawing.Size(96, 23);
            this.displayCarsButton.TabIndex = 11;
            this.displayCarsButton.Text = "Display Cars";
            this.displayCarsButton.UseVisualStyleBackColor = true;
            // 
            // carListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 262);
            this.Controls.Add(this.displayCarsButton);
            this.Controls.Add(this.carInfoGroupBox);
            this.Controls.Add(this.carLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.exitButton);
            this.Name = "carListForm";
            this.Text = "Car List";
            this.carInfoGroupBox.ResumeLayout(false);
            this.carInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.GroupBox carInfoGroupBox;
        private System.Windows.Forms.Button displayCarsButton;
    }
}

