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
    
        private void Login_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btnLog_Click_1(object sender, EventArgs e)
        { // groupBox1.Visible = true;

            if (txtUser.Text == "admin" && txtPassword.Text == "123")
            {
                Main log = new Main();
                log.Show();
                this.Hide();
            }

        }
    }
}
