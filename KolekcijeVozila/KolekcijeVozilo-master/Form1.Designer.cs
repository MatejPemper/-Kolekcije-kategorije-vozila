namespace KolekcijeVozilo
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
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnispis = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.txtboxModel = new System.Windows.Forms.TextBox();
            this.txtboxGodProizvodnje = new System.Windows.Forms.TextBox();
            this.txtboxBrojKotaca = new System.Windows.Forms.TextBox();
            this.txtboxIspisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnObradi
            // 
            this.btnObradi.BackColor = System.Drawing.Color.GhostWhite;
            this.btnObradi.Location = new System.Drawing.Point(282, 45);
            this.btnObradi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(209, 94);
            this.btnObradi.TabIndex = 0;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = false;
            this.btnObradi.Click += new System.EventHandler(this.btnObradi_Click);
            // 
            // btnispis
            // 
            this.btnispis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnispis.Location = new System.Drawing.Point(817, 50);
            this.btnispis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnispis.Name = "btnispis";
            this.btnispis.Size = new System.Drawing.Size(191, 85);
            this.btnispis.TabIndex = 1;
            this.btnispis.Text = "Ispiši";
            this.btnispis.UseVisualStyleBackColor = false;
            this.btnispis.Click += new System.EventHandler(this.btnispis_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.GhostWhite;
            this.btnUnesi.ForeColor = System.Drawing.Color.Gray;
            this.btnUnesi.Location = new System.Drawing.Point(41, 346);
            this.btnUnesi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(164, 89);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtboxModel
            // 
            this.txtboxModel.Location = new System.Drawing.Point(44, 81);
            this.txtboxModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxModel.Name = "txtboxModel";
            this.txtboxModel.Size = new System.Drawing.Size(132, 22);
            this.txtboxModel.TabIndex = 3;
            // 
            // txtboxGodProizvodnje
            // 
            this.txtboxGodProizvodnje.Location = new System.Drawing.Point(41, 174);
            this.txtboxGodProizvodnje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxGodProizvodnje.Name = "txtboxGodProizvodnje";
            this.txtboxGodProizvodnje.Size = new System.Drawing.Size(132, 22);
            this.txtboxGodProizvodnje.TabIndex = 4;
            // 
            // txtboxBrojKotaca
            // 
            this.txtboxBrojKotaca.Location = new System.Drawing.Point(44, 265);
            this.txtboxBrojKotaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxBrojKotaca.Name = "txtboxBrojKotaca";
            this.txtboxBrojKotaca.Size = new System.Drawing.Size(132, 22);
            this.txtboxBrojKotaca.TabIndex = 5;
            // 
            // txtboxIspisi
            // 
            this.txtboxIspisi.Location = new System.Drawing.Point(269, 174);
            this.txtboxIspisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxIspisi.Multiline = true;
            this.txtboxIspisi.Name = "txtboxIspisi";
            this.txtboxIspisi.Size = new System.Drawing.Size(739, 342);
            this.txtboxIspisi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Model vozila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Godina proizvodnje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Broj kotaca:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxIspisi);
            this.Controls.Add(this.txtboxBrojKotaca);
            this.Controls.Add(this.txtboxGodProizvodnje);
            this.Controls.Add(this.txtboxModel);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnispis);
            this.Controls.Add(this.btnObradi);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "ListaVozila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnispis;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.TextBox txtboxModel;
        private System.Windows.Forms.TextBox txtboxGodProizvodnje;
        private System.Windows.Forms.TextBox txtboxBrojKotaca;
        private System.Windows.Forms.TextBox txtboxIspisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

