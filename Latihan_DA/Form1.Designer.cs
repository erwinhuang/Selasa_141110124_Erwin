namespace Latihan_DA
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
            this.dgvDaftar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txPhoneNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txID = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txAddress = new System.Windows.Forms.TextBox();
            this.txZipCode = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDaftar
            // 
            this.dgvDaftar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaftar.Location = new System.Drawing.Point(11, 166);
            this.dgvDaftar.Name = "dgvDaftar";
            this.dgvDaftar.Size = new System.Drawing.Size(513, 176);
            this.dgvDaftar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zip Code";
            // 
            // txPhoneNumber
            // 
            this.txPhoneNumber.AutoSize = true;
            this.txPhoneNumber.Location = new System.Drawing.Point(8, 116);
            this.txPhoneNumber.Name = "txPhoneNumber";
            this.txPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.txPhoneNumber.TabIndex = 5;
            this.txPhoneNumber.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "E-mail";
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(98, 6);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(100, 20);
            this.txID.TabIndex = 7;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(98, 32);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(100, 20);
            this.txName.TabIndex = 8;
            // 
            // txAddress
            // 
            this.txAddress.Location = new System.Drawing.Point(98, 59);
            this.txAddress.Name = "txAddress";
            this.txAddress.Size = new System.Drawing.Size(197, 20);
            this.txAddress.TabIndex = 9;
            // 
            // txZipCode
            // 
            this.txZipCode.Location = new System.Drawing.Point(98, 87);
            this.txZipCode.Name = "txZipCode";
            this.txZipCode.Size = new System.Drawing.Size(100, 20);
            this.txZipCode.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(98, 140);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(100, 20);
            this.txEmail.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 30);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(410, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 37);
            this.button4.TabIndex = 16;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 354);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txZipCode);
            this.Controls.Add(this.txAddress);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDaftar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDaftar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txAddress;
        private System.Windows.Forms.TextBox txZipCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

