using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class frmLOGIN : Form
    {
        public frmLOGIN()
        {
            InitializeComponent();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (txtPassword.Text == "" || txtUsername.Text == "")
                {
                    MessageBox.Show("Please enter both your username and password");
                    return;
                }

                StreamReader contentFile;
                contentFile = new StreamReader("Users.txt");
                string lines = contentFile.ReadLine();
                bool loginSuccessful = false;

                while (lines != null)
                {
                    string[] userDetails = lines.Split(',');
                    string savedusername = userDetails[0];
                    string savedpassword = userDetails[1];
                }
                lines = contentFile.ReadLine();

                if (loginSuccessful)
                {
                    frmHomePage homepage = new frmHomePage(username);
                    
                    homepage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your details do not exist. Please try again or register a new account");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
    

