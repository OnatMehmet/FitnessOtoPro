namespace FitnessOtoPro
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbBugunGelenler = new System.Windows.Forms.TabPage();
            this.tbSuresiDolacaklar = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbTumUyler = new System.Windows.Forms.TabPage();
            this.tbAnasayfa = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbTumUyler.SuspendLayout();
            this.tbAnasayfa.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 472);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barkod Okuyucu Durum Bilgisi";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(494, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tbBugunGelenler
            // 
            this.tbBugunGelenler.Location = new System.Drawing.Point(4, 22);
            this.tbBugunGelenler.Name = "tbBugunGelenler";
            this.tbBugunGelenler.Padding = new System.Windows.Forms.Padding(3);
            this.tbBugunGelenler.Size = new System.Drawing.Size(737, 395);
            this.tbBugunGelenler.TabIndex = 2;
            this.tbBugunGelenler.Text = "Bugün Gelenler";
            this.tbBugunGelenler.UseVisualStyleBackColor = true;
            // 
            // tbSuresiDolacaklar
            // 
            this.tbSuresiDolacaklar.Location = new System.Drawing.Point(4, 22);
            this.tbSuresiDolacaklar.Name = "tbSuresiDolacaklar";
            this.tbSuresiDolacaklar.Padding = new System.Windows.Forms.Padding(3);
            this.tbSuresiDolacaklar.Size = new System.Drawing.Size(737, 395);
            this.tbSuresiDolacaklar.TabIndex = 3;
            this.tbSuresiDolacaklar.Text = "Süresi Dolacak Olanlar";
            this.tbSuresiDolacaklar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.Firstname,
            this.Lastname,
            this.Phone,
            this.DOB,
            this.EntryDate,
            this.FinishDate,
            this.Address});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // tbTumUyler
            // 
            this.tbTumUyler.Controls.Add(this.dataGridView1);
            this.tbTumUyler.Location = new System.Drawing.Point(4, 22);
            this.tbTumUyler.Name = "tbTumUyler";
            this.tbTumUyler.Padding = new System.Windows.Forms.Padding(3);
            this.tbTumUyler.Size = new System.Drawing.Size(737, 395);
            this.tbTumUyler.TabIndex = 1;
            this.tbTumUyler.Text = "Tüm Üyeler";
            this.tbTumUyler.UseVisualStyleBackColor = true;
            // 
            // tbAnasayfa
            // 
            this.tbAnasayfa.Controls.Add(this.pictureBox1);
            this.tbAnasayfa.Controls.Add(this.button1);
            this.tbAnasayfa.Controls.Add(this.monthCalendar1);
            this.tbAnasayfa.Location = new System.Drawing.Point(4, 22);
            this.tbAnasayfa.Name = "tbAnasayfa";
            this.tbAnasayfa.Padding = new System.Windows.Forms.Padding(3);
            this.tbAnasayfa.Size = new System.Drawing.Size(737, 395);
            this.tbAnasayfa.TabIndex = 0;
            this.tbAnasayfa.Text = "Anasayfa";
            this.tbAnasayfa.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(599, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 32);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbAnasayfa);
            this.tabControl1.Controls.Add(this.tbTumUyler);
            this.tabControl1.Controls.Add(this.tbBugunGelenler);
            this.tabControl1.Controls.Add(this.tbSuresiDolacaklar);
            this.tabControl1.Location = new System.Drawing.Point(13, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 421);
            this.tabControl1.TabIndex = 4;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "ID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.Name = "Firstname";
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Date Of Born";
            this.DOB.Name = "DOB";
            // 
            // EntryDate
            // 
            this.EntryDate.HeaderText = "EntryDate";
            this.EntryDate.Name = "EntryDate";
            // 
            // FinishDate
            // 
            this.FinishDate.HeaderText = "FinishDate";
            this.FinishDate.Name = "FinishDate";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 17);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(745, 34);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 100;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "ÜYE BİLGİLERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(494, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 201);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(782, 479);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbTumUyler.ResumeLayout(false);
            this.tbAnasayfa.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbAnasayfa;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage tbTumUyler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tbBugunGelenler;
        private System.Windows.Forms.TabPage tbSuresiDolacaklar;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}