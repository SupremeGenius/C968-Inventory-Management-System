namespace C968_Inventory_Program
{
    partial class Add_Part
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
            this.label1 = new System.Windows.Forms.Label();
            this.InHouseRB = new System.Windows.Forms.RadioButton();
            this.OutsourcedRB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.InvTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.MaxTB = new System.Windows.Forms.TextBox();
            this.MinTB = new System.Windows.Forms.TextBox();
            this.CompanyNameTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Part";
            // 
            // InHouseRB
            // 
            this.InHouseRB.AutoSize = true;
            this.InHouseRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHouseRB.Location = new System.Drawing.Point(170, 36);
            this.InHouseRB.Name = "InHouseRB";
            this.InHouseRB.Size = new System.Drawing.Size(106, 24);
            this.InHouseRB.TabIndex = 2;
            this.InHouseRB.TabStop = true;
            this.InHouseRB.Text = "In-House";
            this.InHouseRB.UseVisualStyleBackColor = true;
            this.InHouseRB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // OutsourcedRB
            // 
            this.OutsourcedRB.AutoSize = true;
            this.OutsourcedRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutsourcedRB.Location = new System.Drawing.Point(327, 36);
            this.OutsourcedRB.Name = "OutsourcedRB";
            this.OutsourcedRB.Size = new System.Drawing.Size(127, 24);
            this.OutsourcedRB.TabIndex = 3;
            this.OutsourcedRB.TabStop = true;
            this.OutsourcedRB.Text = "Outsourced";
            this.OutsourcedRB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price/Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Min";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Company Name";
            // 
            // IDTB
            // 
            this.IDTB.Location = new System.Drawing.Point(204, 98);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(155, 22);
            this.IDTB.TabIndex = 11;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(204, 135);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(155, 22);
            this.NameTB.TabIndex = 12;
            // 
            // InvTB
            // 
            this.InvTB.Location = new System.Drawing.Point(204, 173);
            this.InvTB.Name = "InvTB";
            this.InvTB.Size = new System.Drawing.Size(155, 22);
            this.InvTB.TabIndex = 13;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(204, 210);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(155, 22);
            this.PriceTB.TabIndex = 14;
            // 
            // MaxTB
            // 
            this.MaxTB.Location = new System.Drawing.Point(121, 249);
            this.MaxTB.Name = "MaxTB";
            this.MaxTB.Size = new System.Drawing.Size(155, 22);
            this.MaxTB.TabIndex = 15;
            // 
            // MinTB
            // 
            this.MinTB.Location = new System.Drawing.Point(340, 249);
            this.MinTB.Name = "MinTB";
            this.MinTB.Size = new System.Drawing.Size(155, 22);
            this.MinTB.TabIndex = 16;
            // 
            // CompanyNameTB
            // 
            this.CompanyNameTB.Location = new System.Drawing.Point(204, 288);
            this.CompanyNameTB.Name = "CompanyNameTB";
            this.CompanyNameTB.Size = new System.Drawing.Size(155, 22);
            this.CompanyNameTB.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Add_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(523, 434);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CompanyNameTB);
            this.Controls.Add(this.MinTB);
            this.Controls.Add(this.MaxTB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.InvTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.IDTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutsourcedRB);
            this.Controls.Add(this.InHouseRB);
            this.Controls.Add(this.label1);
            this.Name = "Add_Part";
            this.Text = "Add_Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InHouseRB;
        private System.Windows.Forms.RadioButton OutsourcedRB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox InvTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox MaxTB;
        private System.Windows.Forms.TextBox MinTB;
        private System.Windows.Forms.TextBox CompanyNameTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}