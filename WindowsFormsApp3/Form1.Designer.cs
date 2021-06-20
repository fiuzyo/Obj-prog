namespace WindowsFormsApp3
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
            this.brojprocesaTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brojDretviTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.memorijaTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.procMemTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nazivTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.argumentiTB = new System.Windows.Forms.TextBox();
            this.pokreniBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.zaustaviBTN = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statusTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // brojprocesaTB
            // 
            this.brojprocesaTB.Location = new System.Drawing.Point(144, 32);
            this.brojprocesaTB.Name = "brojprocesaTB";
            this.brojprocesaTB.Size = new System.Drawing.Size(100, 20);
            this.brojprocesaTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ukupan broj procesa";
            // 
            // brojDretviTB
            // 
            this.brojDretviTB.Location = new System.Drawing.Point(128, 80);
            this.brojDretviTB.Name = "brojDretviTB";
            this.brojDretviTB.Size = new System.Drawing.Size(100, 20);
            this.brojDretviTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ukupan broj dretvi";
            // 
            // memorijaTB
            // 
            this.memorijaTB.Location = new System.Drawing.Point(168, 128);
            this.memorijaTB.Name = "memorijaTB";
            this.memorijaTB.Size = new System.Drawing.Size(100, 20);
            this.memorijaTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ukupna potrošnja memorije";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proces koji trosi najvise memorije";
            // 
            // procMemTB
            // 
            this.procMemTB.Location = new System.Drawing.Point(200, 176);
            this.procMemTB.Name = "procMemTB";
            this.procMemTB.Size = new System.Drawing.Size(100, 20);
            this.procMemTB.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Naziv";
            // 
            // nazivTB
            // 
            this.nazivTB.Location = new System.Drawing.Point(56, 24);
            this.nazivTB.Name = "nazivTB";
            this.nazivTB.Size = new System.Drawing.Size(100, 20);
            this.nazivTB.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Argumenti";
            // 
            // argumentiTB
            // 
            this.argumentiTB.Location = new System.Drawing.Point(72, 88);
            this.argumentiTB.Name = "argumentiTB";
            this.argumentiTB.Size = new System.Drawing.Size(100, 20);
            this.argumentiTB.TabIndex = 12;
            // 
            // pokreniBTN
            // 
            this.pokreniBTN.Location = new System.Drawing.Point(48, 128);
            this.pokreniBTN.Name = "pokreniBTN";
            this.pokreniBTN.Size = new System.Drawing.Size(75, 23);
            this.pokreniBTN.TabIndex = 13;
            this.pokreniBTN.Text = "Pokreni";
            this.pokreniBTN.UseVisualStyleBackColor = true;
            this.pokreniBTN.Click += new System.EventHandler(this.pokreniBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID";
            // 
            // zaustaviBTN
            // 
            this.zaustaviBTN.Location = new System.Drawing.Point(16, 72);
            this.zaustaviBTN.Name = "zaustaviBTN";
            this.zaustaviBTN.Size = new System.Drawing.Size(75, 23);
            this.zaustaviBTN.TabIndex = 17;
            this.zaustaviBTN.Text = "Zaustavi";
            this.zaustaviBTN.UseVisualStyleBackColor = true;
            this.zaustaviBTN.Click += new System.EventHandler(this.zaustaviBTN_Click);
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(48, 32);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Status";
            // 
            // statusTB
            // 
            this.statusTB.Location = new System.Drawing.Point(24, 264);
            this.statusTB.Multiline = true;
            this.statusTB.Name = "statusTB";
            this.statusTB.Size = new System.Drawing.Size(352, 160);
            this.statusTB.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nazivTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.argumentiTB);
            this.groupBox1.Controls.Add(this.pokreniBTN);
            this.groupBox1.Location = new System.Drawing.Point(392, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pokretanje procesa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.idTB);
            this.groupBox2.Controls.Add(this.zaustaviBTN);
            this.groupBox2.Location = new System.Drawing.Point(392, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 160);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Z austavi proces po ID-u";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.procMemTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.memorijaTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brojDretviTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brojprocesaTB);
            this.Name = "Form1";
            this.Text = "Procesi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox brojprocesaTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox brojDretviTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox memorijaTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox procMemTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nazivTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox argumentiTB;
        private System.Windows.Forms.Button pokreniBTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button zaustaviBTN;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox statusTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

