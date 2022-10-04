namespace ergasia
{
    partial class Home
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
            this.login_button1 = new System.Windows.Forms.Button();
            this.Exitbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button1
            // 
            this.login_button1.Location = new System.Drawing.Point(286, 252);
            this.login_button1.Name = "login_button1";
            this.login_button1.Size = new System.Drawing.Size(85, 35);
            this.login_button1.TabIndex = 0;
            this.login_button1.Text = "Log in";
            this.login_button1.UseVisualStyleBackColor = true;
            this.login_button1.Click += new System.EventHandler(this.login_button1_Click);
            // 
            // Exitbutton2
            // 
            this.Exitbutton2.Location = new System.Drawing.Point(445, 252);
            this.Exitbutton2.Name = "Exitbutton2";
            this.Exitbutton2.Size = new System.Drawing.Size(85, 35);
            this.Exitbutton2.TabIndex = 1;
            this.Exitbutton2.Text = "Exit";
            this.Exitbutton2.UseVisualStyleBackColor = true;
            this.Exitbutton2.Click += new System.EventHandler(this.Exitbutton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(286, 199);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(244, 20);
            this.txtuser.TabIndex = 3;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ergasia.Properties.Resources.Log_in;
            this.pictureBox1.Location = new System.Drawing.Point(103, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exitbutton2);
            this.Controls.Add(this.login_button1);
            this.Name = "Home";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button1;
        private System.Windows.Forms.Button Exitbutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

