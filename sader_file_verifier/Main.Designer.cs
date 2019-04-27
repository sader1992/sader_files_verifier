namespace sader_file_verifier
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
            this.main_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new sader_file_verifier.RoundButton2();
            this.main_button = new sader_file_verifier.RoundButton1();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // main_label
            // 
            this.main_label.BackColor = System.Drawing.Color.Transparent;
            this.main_label.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.Location = new System.Drawing.Point(25, 446);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(331, 34);
            this.main_label.TabIndex = 2;
            this.main_label.Text = "Found Some Broken Files";
            this.main_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "By sader1992";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(140, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "BETA Test";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(331, 335);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(25, 25);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.TabStop = false;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // main_button
            // 
            this.main_button.BackColor = System.Drawing.Color.Transparent;
            this.main_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_button.BackgroundImage")));
            this.main_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_button.FlatAppearance.BorderSize = 0;
            this.main_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_button.ForeColor = System.Drawing.Color.Black;
            this.main_button.Location = new System.Drawing.Point(109, 504);
            this.main_button.Margin = new System.Windows.Forms.Padding(0);
            this.main_button.Name = "main_button";
            this.main_button.Size = new System.Drawing.Size(150, 60);
            this.main_button.TabIndex = 4;
            this.main_button.TabStop = false;
            this.main_button.Text = "Start";
            this.main_button.UseVisualStyleBackColor = true;
            this.main_button.Click += new System.EventHandler(this.Main_button_Click);
            this.main_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_button_MouseDown);
            this.main_button.MouseLeave += new System.EventHandler(this.Main_button_MouseLeave);
            this.main_button.MouseHover += new System.EventHandler(this.Main_button_MouseHover);
            this.main_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_button_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(130, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sader Files Verifier";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.main_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sader\'s files verifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.Label label1;
        private RoundButton1 main_button;
        private RoundButton2 ExitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

