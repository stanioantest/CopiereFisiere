namespace CopiereFisiere
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sursafisiere = new System.Windows.Forms.TextBox();
            this.txt_destinatiefisiere = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_salvare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sursa Fisiere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destinatie Fisiere";
            // 
            // txt_sursafisiere
            // 
            this.txt_sursafisiere.Location = new System.Drawing.Point(153, 33);
            this.txt_sursafisiere.Name = "txt_sursafisiere";
            this.txt_sursafisiere.Size = new System.Drawing.Size(387, 22);
            this.txt_sursafisiere.TabIndex = 3;
            this.txt_sursafisiere.TabStop = false;
            // 
            // txt_destinatiefisiere
            // 
            this.txt_destinatiefisiere.Location = new System.Drawing.Point(153, 62);
            this.txt_destinatiefisiere.Name = "txt_destinatiefisiere";
            this.txt_destinatiefisiere.Size = new System.Drawing.Size(387, 22);
            this.txt_destinatiefisiere.TabIndex = 4;
            this.txt_destinatiefisiere.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_salvare
            // 
            this.btn_salvare.Location = new System.Drawing.Point(432, 101);
            this.btn_salvare.Name = "btn_salvare";
            this.btn_salvare.Size = new System.Drawing.Size(108, 30);
            this.btn_salvare.TabIndex = 3;
            this.btn_salvare.Text = "Salvare";
            this.btn_salvare.UseVisualStyleBackColor = true;
            this.btn_salvare.Click += new System.EventHandler(this.btn_salvare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "20 s.";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Urmatoarea scanare:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 151);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_salvare);
            this.Controls.Add(this.txt_destinatiefisiere);
            this.Controls.Add(this.txt_sursafisiere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mutare Fisiere";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sursafisiere;
        private System.Windows.Forms.TextBox txt_destinatiefisiere;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_salvare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
    }
}

