namespace Odaberi_trougao_sa_liste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTemeC = new System.Windows.Forms.Label();
            this.lblTemeB = new System.Windows.Forms.Label();
            this.lblTemeA = new System.Windows.Forms.Label();
            this.lblStranicaC = new System.Windows.Forms.Label();
            this.lblStranicaB = new System.Windows.Forms.Label();
            this.lblStranicaA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(17, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 289);
            this.listBox1.TabIndex = 0;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(238, 19);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(595, 54);
            this.btnOdaberi.TabIndex = 1;
            this.btnOdaberi.Text = "Odaberi trougao iz ListBox-a";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(242, 104);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(246, 199);
            this.listBox2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTemeC
            // 
            this.lblTemeC.AutoSize = true;
            this.lblTemeC.Location = new System.Drawing.Point(548, 284);
            this.lblTemeC.Name = "lblTemeC";
            this.lblTemeC.Size = new System.Drawing.Size(15, 15);
            this.lblTemeC.TabIndex = 4;
            this.lblTemeC.Text = "C";
            // 
            // lblTemeB
            // 
            this.lblTemeB.AutoSize = true;
            this.lblTemeB.Location = new System.Drawing.Point(739, 284);
            this.lblTemeB.Name = "lblTemeB";
            this.lblTemeB.Size = new System.Drawing.Size(14, 15);
            this.lblTemeB.TabIndex = 5;
            this.lblTemeB.Text = "B";
            // 
            // lblTemeA
            // 
            this.lblTemeA.AutoSize = true;
            this.lblTemeA.Location = new System.Drawing.Point(549, 149);
            this.lblTemeA.Name = "lblTemeA";
            this.lblTemeA.Size = new System.Drawing.Size(15, 15);
            this.lblTemeA.TabIndex = 6;
            this.lblTemeA.Text = "A";
            // 
            // lblStranicaC
            // 
            this.lblStranicaC.AutoSize = true;
            this.lblStranicaC.Location = new System.Drawing.Point(690, 216);
            this.lblStranicaC.Name = "lblStranicaC";
            this.lblStranicaC.Size = new System.Drawing.Size(13, 15);
            this.lblStranicaC.TabIndex = 7;
            this.lblStranicaC.Text = "c";
            // 
            // lblStranicaB
            // 
            this.lblStranicaB.AutoSize = true;
            this.lblStranicaB.Location = new System.Drawing.Point(550, 225);
            this.lblStranicaB.Name = "lblStranicaB";
            this.lblStranicaB.Size = new System.Drawing.Size(14, 15);
            this.lblStranicaB.TabIndex = 8;
            this.lblStranicaB.Text = "b";
            // 
            // lblStranicaA
            // 
            this.lblStranicaA.AutoSize = true;
            this.lblStranicaA.Location = new System.Drawing.Point(634, 284);
            this.lblStranicaA.Name = "lblStranicaA";
            this.lblStranicaA.Size = new System.Drawing.Size(13, 15);
            this.lblStranicaA.TabIndex = 9;
            this.lblStranicaA.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 330);
            this.Controls.Add(this.lblStranicaA);
            this.Controls.Add(this.lblStranicaB);
            this.Controls.Add(this.lblStranicaC);
            this.Controls.Add(this.lblTemeA);
            this.Controls.Add(this.lblTemeB);
            this.Controls.Add(this.lblTemeC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Odaberi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button btnOdaberi;
        private ListBox listBox2;
        private PictureBox pictureBox1;
        private Label lblTemeC;
        private Label lblTemeB;
        private Label lblTemeA;
        private Label lblStranicaC;
        private Label lblStranicaB;
        private Label lblStranicaA;
    }
}