namespace FitnessOtoPro
{
    partial class Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(29, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Login to your Account";
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Blue;
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLog.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLog.ForeColor = System.Drawing.Color.Ivory;
            this.btnLog.Location = new System.Drawing.Point(33, 177);
            this.btnLog.Name = "btnLog";
            this.btnLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLog.Size = new System.Drawing.Size(222, 38);
            this.btnLog.TabIndex = 16;
            this.btnLog.Text = "Log In";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Location = new System.Drawing.Point(133, 96);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(122, 20);
            this.txtUser.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(30, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "User      :";
            this.label1.UseWaitCursor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Location = new System.Drawing.Point(133, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(122, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(30, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password  :";
            this.label2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::FitnessOtoPro.Properties.Resources.login__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(282, 256);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FITNESS LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}