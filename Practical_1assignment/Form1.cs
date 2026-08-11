using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Deliverable_1b
{
    public partial class Registerfrm : Form
    {
        private string filePath = "Users.txt";

        public Registerfrm()
        {
            InitializeComponent();
            
        }

        private void Registerfrm_Load(object sender, EventArgs e)
        {

        }
        
        
            

            private void InitializeFile()
            {
                try
                {
                    if (!File.Exists(filePath))
                    {
                        using (FileStream fs = File.Create(filePath)) { }
                    }
                }
                catch (Exception initializing)
                {
                    MessageBox.Show("There's an error initializing user file: \n" + initializing.Message);
                }
            }
            private bool DoesUserExist(string username)
            {
                InitializeFile();

                try
                {
                    using (StreamReader contentFile = new StreamReader(filePath))
                    {
                        string line;

                        while ((line = contentFile.ReadLine()) != null)
                        {
                            if (!string.IsNullOrEmpty(line))
                            {
                                string[] userCredentials = line.Split(',');

                                if (userCredentials.Length >= 1)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
                catch (Exception reading)
                {
                    MessageBox.Show("There has been an error reading from the user file "+ reading.Message);
                }
                return false;


            }
            private void SaveUser(string username, string password)
            {
                try
                {
                    using (StreamWriter userFile = new StreamWriter(filePath,true))
                    {
                        userFile.WriteLine(username + ","+password);
                    }
                }
                catch (Exception writing)
                {
                    MessageBox.Show(" There has been an error with writing to the user file"+ writing.Message);
                }
            }


        private void BackToLogin()
        {
            frmLOGIN loginform = new frmLOGIN();
            loginform.Show();
            this.Close();
        }




        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please make sure that all fields are filled in ");
                return;

                
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Please make sure passwords match");
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                return;
            }

            if (DoesUserExist(username))
            {
                MessageBox.Show("This username already exists. Try a different one");
                return;
            }
           SaveUser(username, password);

            MessageBox.Show("Your account has been created");

            BackToLogin();
        }

        private void btnBacktoLogin_Click(object sender, EventArgs e)
        {
            BackToLogin();
        }
    }
}