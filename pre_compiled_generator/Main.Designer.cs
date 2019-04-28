namespace pre_compiled_generator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.start_b = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.iURL_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iName_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fURL_text = new System.Windows.Forms.TextBox();
            this.cName_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sName_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::pre_compiled_generator.Properties.Resources.main_image;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 599);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // start_b
            // 
            this.start_b.Location = new System.Drawing.Point(531, 508);
            this.start_b.Name = "start_b";
            this.start_b.Size = new System.Drawing.Size(197, 53);
            this.start_b.TabIndex = 1;
            this.start_b.Text = "Generate";
            this.start_b.UseVisualStyleBackColor = true;
            this.start_b.Click += new System.EventHandler(this.Start_b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL to the information file:";
            // 
            // iURL_text
            // 
            this.iURL_text.Location = new System.Drawing.Point(408, 60);
            this.iURL_text.Multiline = true;
            this.iURL_text.Name = "iURL_text";
            this.iURL_text.Size = new System.Drawing.Size(420, 57);
            this.iURL_text.TabIndex = 3;
            this.iURL_text.Text = "http://127.0.0.1/verifier/Information.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Information File\'s Name:";
            // 
            // iName_text
            // 
            this.iName_text.Location = new System.Drawing.Point(408, 160);
            this.iName_text.Name = "iName_text";
            this.iName_text.Size = new System.Drawing.Size(420, 24);
            this.iName_text.TabIndex = 5;
            this.iName_text.Text = "Information.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "URL of the folder that have the files:";
            // 
            // fURL_text
            // 
            this.fURL_text.Location = new System.Drawing.Point(408, 224);
            this.fURL_text.Multiline = true;
            this.fURL_text.Name = "fURL_text";
            this.fURL_text.Size = new System.Drawing.Size(420, 57);
            this.fURL_text.TabIndex = 7;
            this.fURL_text.Text = "http://127.0.0.1/verifier/verify/";
            // 
            // cName_text
            // 
            this.cName_text.Location = new System.Drawing.Point(408, 321);
            this.cName_text.Name = "cName_text";
            this.cName_text.Size = new System.Drawing.Size(420, 24);
            this.cName_text.TabIndex = 9;
            this.cName_text.Text = "Ragnarok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Client EXE Name:";
            // 
            // sName_text
            // 
            this.sName_text.Location = new System.Drawing.Point(408, 384);
            this.sName_text.Name = "sName_text";
            this.sName_text.Size = new System.Drawing.Size(420, 24);
            this.sName_text.TabIndex = 11;
            this.sName_text.Text = "Ragnarok Online";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Server Name:";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(860, 611);
            this.Controls.Add(this.sName_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cName_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fURL_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iName_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iURL_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_b);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Sader File Verifier Pre-Compiled Generator";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button start_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iURL_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iName_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fURL_text;
        private System.Windows.Forms.TextBox cName_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sName_text;
        private System.Windows.Forms.Label label5;
    }
}

