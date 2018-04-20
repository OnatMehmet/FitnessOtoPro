using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessOtoPro
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }


        private void txtName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtLastname.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text)|| string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("text box can not be blank");
            }
            else
            {
                // All the textboxes are filled in.
            
            if (!this.txtMail.Text.Contains('@') || !this.txtMail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
        }
    }
}
