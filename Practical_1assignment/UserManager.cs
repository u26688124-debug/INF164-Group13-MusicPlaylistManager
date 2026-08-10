using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliverable_1b
{
    internal class UserManager
    {
    }
    private static class UserManager
    {
        private static readonly string filePath = "users.txt";

        public static void InitializeFile()
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
                MessageBox.Show("There's an error initializing user file");
            }
        }
        public static bool DoesUserExist(string username)
        {
            InitializeFile();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line == "")
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
                MessageBox.Show("There has been an error reading from the user file ");
            }
            return false;


        }
        public static void SaveUser(string username, string password)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{username},{password}");
                }
            }
            catch (Exception writing)
            {
                MessageBox.Show(" There has been an error with writing to the user file");
            }
        }
    }
}
