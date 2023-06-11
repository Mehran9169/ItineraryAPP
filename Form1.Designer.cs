namespace FlightApp
{
    partial class Form1
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
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.InfantCount = new System.Windows.Forms.NumericUpDown();
            this.ChildCount = new System.Windows.Forms.NumericUpDown();
            this.AdultCount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InfantCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdultCount)).BeginInit();
            this.SuspendLayout();
            // 
            // originTextBox
            // 
            this.originTextBox.Location = new System.Drawing.Point(132, 35);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(202, 20);
            this.originTextBox.TabIndex = 0;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(132, 74);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(202, 20);
            this.destinationTextBox.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Origin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(132, 152);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Of Origin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Of Destination";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfantCount
            // 
            this.InfantCount.Location = new System.Drawing.Point(132, 197);
            this.InfantCount.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.InfantCount.Name = "InfantCount";
            this.InfantCount.Size = new System.Drawing.Size(202, 20);
            this.InfantCount.TabIndex = 7;
            this.InfantCount.ValueChanged += new System.EventHandler(this.InfantCount_ValueChanged);
            // 
            // ChildCount
            // 
            this.ChildCount.Location = new System.Drawing.Point(132, 223);
            this.ChildCount.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.ChildCount.Name = "ChildCount";
            this.ChildCount.Size = new System.Drawing.Size(202, 20);
            this.ChildCount.TabIndex = 8;
            // 
            // AdultCount
            // 
            this.AdultCount.Location = new System.Drawing.Point(132, 249);
            this.AdultCount.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.AdultCount.Name = "AdultCount";
            this.AdultCount.Size = new System.Drawing.Size(202, 20);
            this.AdultCount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Infant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Child";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adult";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdultCount);
            this.Controls.Add(this.ChildCount);
            this.Controls.Add(this.InfantCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.originTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfantCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdultCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown InfantCount;
        private System.Windows.Forms.NumericUpDown ChildCount;
        private System.Windows.Forms.NumericUpDown AdultCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

