namespace DlsCalculation_
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
            this.label1 = new System.Windows.Forms.Label();
            this.Incl1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Azm1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Md1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Incl2 = new System.Windows.Forms.TextBox();
            this.Azm2 = new System.Windows.Forms.TextBox();
            this.Md2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incl1";
            // 
            // Incl1
            // 
            this.Incl1.BackColor = System.Drawing.Color.PapayaWhip;
            this.Incl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Incl1.Location = new System.Drawing.Point(77, 61);
            this.Incl1.Name = "Incl1";
            this.Incl1.Size = new System.Drawing.Size(142, 26);
            this.Incl1.TabIndex = 1;
            this.Incl1.Text = "0";
            this.Incl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Incl1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Azm1";
            // 
            // Azm1
            // 
            this.Azm1.BackColor = System.Drawing.Color.PapayaWhip;
            this.Azm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Azm1.Location = new System.Drawing.Point(77, 104);
            this.Azm1.Name = "Azm1";
            this.Azm1.Size = new System.Drawing.Size(142, 26);
            this.Azm1.TabIndex = 3;
            this.Azm1.Text = "0";
            this.Azm1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Azm1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Md1";
            // 
            // Md1
            // 
            this.Md1.BackColor = System.Drawing.Color.PapayaWhip;
            this.Md1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Md1.Location = new System.Drawing.Point(77, 19);
            this.Md1.Name = "Md1";
            this.Md1.Size = new System.Drawing.Size(142, 26);
            this.Md1.TabIndex = 5;
            this.Md1.Text = "0";
            this.Md1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Md1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(262, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inc2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(250, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Azm2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(261, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Md2";
            // 
            // Incl2
            // 
            this.Incl2.BackColor = System.Drawing.Color.PapayaWhip;
            this.Incl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Incl2.Location = new System.Drawing.Point(318, 61);
            this.Incl2.Name = "Incl2";
            this.Incl2.Size = new System.Drawing.Size(152, 26);
            this.Incl2.TabIndex = 9;
            this.Incl2.Text = "0";
            this.Incl2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Incl2_KeyPress);
            // 
            // Azm2
            // 
            this.Azm2.BackColor = System.Drawing.Color.PapayaWhip;
            this.Azm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Azm2.Location = new System.Drawing.Point(318, 101);
            this.Azm2.Name = "Azm2";
            this.Azm2.Size = new System.Drawing.Size(152, 26);
            this.Azm2.TabIndex = 10;
            this.Azm2.Text = "0";
            this.Azm2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Azm2_KeyPress);
            // 
            // Md2
            // 
            this.Md2.BackColor = System.Drawing.Color.PapayaWhip;
            this.Md2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Md2.Location = new System.Drawing.Point(318, 19);
            this.Md2.Name = "Md2";
            this.Md2.Size = new System.Drawing.Size(152, 26);
            this.Md2.TabIndex = 11;
            this.Md2.Text = "0";
            this.Md2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Md2_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(265, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 72);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(337, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "DLS";
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.Snow;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.ForeColor = System.Drawing.Color.Red;
            this.Result.Location = new System.Drawing.Point(265, 193);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(206, 35);
            this.Result.TabIndex = 14;
            this.Result.Text = "0.00";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(77, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 359);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Md2);
            this.Controls.Add(this.Azm2);
            this.Controls.Add(this.Incl2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Md1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Azm1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Incl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DLS Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Incl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Azm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Md1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Incl2;
        private System.Windows.Forms.TextBox Azm2;
        private System.Windows.Forms.TextBox Md2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button button2;
    }
}

