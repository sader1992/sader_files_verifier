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
            this.main_button = new System.Windows.Forms.Button();
            this.main_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // main_button
            // 
            this.main_button.Location = new System.Drawing.Point(94, 112);
            this.main_button.Name = "main_button";
            this.main_button.Size = new System.Drawing.Size(153, 64);
            this.main_button.TabIndex = 1;
            this.main_button.Text = "Start";
            this.main_button.UseVisualStyleBackColor = true;
            this.main_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.Location = new System.Drawing.Point(12, 40);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(331, 34);
            this.main_label.TabIndex = 2;
            this.main_label.Text = "Found Some Broken Files";
            this.main_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "design me please";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.main_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "sader\'s files verifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button main_button;
        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.Label label1;
    }
}

