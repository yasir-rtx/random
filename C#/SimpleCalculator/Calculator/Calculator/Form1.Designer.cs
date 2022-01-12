namespace Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBil1 = new System.Windows.Forms.TextBox();
            this.txtBil2 = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.butttonPlus = new System.Windows.Forms.Button();
            this.buttonSplit = new System.Windows.Forms.Button();
            this.buttonMultiple = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator Simple";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilangan1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bilangan2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil         :";
            // 
            // txtBil1
            // 
            this.txtBil1.Location = new System.Drawing.Point(395, 59);
            this.txtBil1.Name = "txtBil1";
            this.txtBil1.Size = new System.Drawing.Size(100, 20);
            this.txtBil1.TabIndex = 4;
            this.txtBil1.TextChanged += new System.EventHandler(this.txtBil1_TextChanged);
            // 
            // txtBil2
            // 
            this.txtBil2.Location = new System.Drawing.Point(395, 94);
            this.txtBil2.Name = "txtBil2";
            this.txtBil2.Size = new System.Drawing.Size(100, 20);
            this.txtBil2.TabIndex = 5;
            this.txtBil2.TextChanged += new System.EventHandler(this.txtBil2_TextChanged);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(395, 129);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(100, 20);
            this.txtHasil.TabIndex = 6;
            // 
            // butttonPlus
            // 
            this.butttonPlus.Location = new System.Drawing.Point(236, 182);
            this.butttonPlus.Name = "butttonPlus";
            this.butttonPlus.Size = new System.Drawing.Size(75, 23);
            this.butttonPlus.TabIndex = 7;
            this.butttonPlus.Text = "+";
            this.butttonPlus.UseVisualStyleBackColor = true;
            this.butttonPlus.Click += new System.EventHandler(this.butttonPlus_Click);
            // 
            // buttonSplit
            // 
            this.buttonSplit.Location = new System.Drawing.Point(317, 182);
            this.buttonSplit.Name = "buttonSplit";
            this.buttonSplit.Size = new System.Drawing.Size(75, 23);
            this.buttonSplit.TabIndex = 8;
            this.buttonSplit.Text = "-";
            this.buttonSplit.UseVisualStyleBackColor = true;
            this.buttonSplit.Click += new System.EventHandler(this.buttonSplit_Click);
            // 
            // buttonMultiple
            // 
            this.buttonMultiple.Location = new System.Drawing.Point(398, 182);
            this.buttonMultiple.Name = "buttonMultiple";
            this.buttonMultiple.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiple.TabIndex = 9;
            this.buttonMultiple.Text = "x";
            this.buttonMultiple.UseVisualStyleBackColor = true;
            this.buttonMultiple.Click += new System.EventHandler(this.buttonMultiple_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(479, 182);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(75, 23);
            this.buttonDivision.TabIndex = 10;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiple);
            this.Controls.Add(this.buttonSplit);
            this.Controls.Add(this.butttonPlus);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.txtBil2);
            this.Controls.Add(this.txtBil1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBil1;
        private System.Windows.Forms.TextBox txtBil2;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button butttonPlus;
        private System.Windows.Forms.Button buttonSplit;
        private System.Windows.Forms.Button buttonMultiple;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button button1;
    }
}

