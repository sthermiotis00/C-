namespace ergasia
{
    partial class Help
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
            this.Back_button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back_button1
            // 
            this.Back_button1.Location = new System.Drawing.Point(713, 3);
            this.Back_button1.Name = "Back_button1";
            this.Back_button1.Size = new System.Drawing.Size(75, 23);
            this.Back_button1.TabIndex = 0;
            this.Back_button1.Text = "Back";
            this.Back_button1.UseVisualStyleBackColor = true;
            this.Back_button1.Click += new System.EventHandler(this.Back_button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 405);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Level 1: 60 seconds ,Level 2: 30 Seconds, Level 3: 15 seconds";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Back_button1);
            this.Name = "Text";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}