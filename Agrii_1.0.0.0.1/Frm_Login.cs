using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrii_A
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get text from textboxes
            string struserID = txtID.Text.Trim();
            string strpassword = txtPassword.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(struserID) || string.IsNullOrEmpty(strpassword))
            {
                // Display error message if any field is empty
                MessageBox.Show("Both User ID and Password are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (struserID=="Admin" && strpassword=="123")
                {
                    this.Hide();
                    Frm_HomePage objPage = new Frm_HomePage();  
                    objPage.Show();

                    MessageBox.Show("User authenticated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (struserID == "Jadhav" && strpassword == "123")
                {

                    this.Hide();
                    Frm_HomePage objPage = new Frm_HomePage();
                    objPage.Show();

                    MessageBox.Show("User authenticated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Invalid User ID or Password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
        }
      

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
