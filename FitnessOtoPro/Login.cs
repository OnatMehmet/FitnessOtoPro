using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessOtoPro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            MainForm log = new MainForm();
            log.Show();
            this.Hide();
        }

     

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

        }
    }
}
