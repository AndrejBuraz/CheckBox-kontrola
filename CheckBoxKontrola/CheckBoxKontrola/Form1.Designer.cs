namespace CheckBoxKontrola
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chbDorucak = new System.Windows.Forms.CheckBox();
            this.chbRucak = new System.Windows.Forms.CheckBox();
            this.chbVecera = new System.Windows.Forms.CheckBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.chbSakrij = new System.Windows.Forms.CheckBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chbDorucak
            // 
            this.chbDorucak.AutoSize = true;
            this.chbDorucak.Location = new System.Drawing.Point(33, 30);
            this.chbDorucak.Name = "chbDorucak";
            this.chbDorucak.Size = new System.Drawing.Size(70, 19);
            this.chbDorucak.TabIndex = 0;
            this.chbDorucak.Text = "Dorucak";
            this.chbDorucak.UseVisualStyleBackColor = true;
            this.chbDorucak.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chbRucak
            // 
            this.chbRucak.AutoSize = true;
            this.chbRucak.Location = new System.Drawing.Point(33, 67);
            this.chbRucak.Name = "chbRucak";
            this.chbRucak.Size = new System.Drawing.Size(58, 19);
            this.chbRucak.TabIndex = 1;
            this.chbRucak.Text = "Rucak";
            this.chbRucak.UseVisualStyleBackColor = true;
            this.chbRucak.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chbVecera
            // 
            this.chbVecera.AutoSize = true;
            this.chbVecera.Location = new System.Drawing.Point(33, 105);
            this.chbVecera.Name = "chbVecera";
            this.chbVecera.Size = new System.Drawing.Size(60, 19);
            this.chbVecera.TabIndex = 2;
            this.chbVecera.Text = "Vecera";
            this.chbVecera.UseVisualStyleBackColor = true;
            this.chbVecera.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(33, 180);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(75, 23);
            this.btnPosalji.TabIndex = 3;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.button1_Click);
            // 
            // chbSakrij
            // 
            this.chbSakrij.AutoSize = true;
            this.chbSakrij.Location = new System.Drawing.Point(159, 183);
            this.chbSakrij.Name = "chbSakrij";
            this.chbSakrij.Size = new System.Drawing.Size(107, 19);
            this.chbSakrij.TabIndex = 4;
            this.chbSakrij.Text = "Sakrij narudžbu";
            this.chbSakrij.UseVisualStyleBackColor = true;
            this.chbSakrij.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(159, 30);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(136, 94);
            this.txtBox.TabIndex = 5;
            this.txtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 267);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.chbSakrij);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.chbVecera);
            this.Controls.Add(this.chbRucak);
            this.Controls.Add(this.chbDorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chbDorucak;
        private CheckBox chbRucak;
        private CheckBox chbVecera;
        private Button btnPosalji;
        private CheckBox chbSakrij;
        private TextBox txtBox;
    }
}