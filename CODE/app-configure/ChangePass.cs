using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using System.Text.RegularExpressions;

namespace AlarmSystem
{
    public partial class ChangePass : Form
    {
        LoginForm frm;
        private string encryptedCredentialsFile = "code.txt";
        private bool credentialsStored = false;
        private bool isValid = false;

        string storedEncryptedCredentials;



        public ChangePass(LoginForm lgfrm)
        {
            this.frm = lgfrm;
            InitializeComponent();

        }

        private void OK_Click(object sender, EventArgs e)
        {
            string username = userNameValue.Text;
            string pwd = oldPassValue.Text;
            string combinedData = username + pwd;
            string pattern = @"(?=(.*\d){5,})(?=.*[A-Z])(?=.*[a-z]{5})";



            if (File.Exists(encryptedCredentialsFile))
            {
                // Διαβάζουμε το κρυπτογραφημένο περιεχόμενο από το αρχείο
                storedEncryptedCredentials = File.ReadAllText(encryptedCredentialsFile);
            }
            else
            {
                // Δεν υπάρχει αρχείο 
                MessageBox.Show("ΤFile not found.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            isValid = Hashing.VerifyUsernameOrPassword(combinedData, storedEncryptedCredentials);

            if (isValid)
            {
                if (!Regex.IsMatch(newPassValue.Text, pattern))
                { //Lioste1234
                    MessageBox.Show("new paass is not currect form ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (newPassValue.Text != confPassValue.Text)
                {
                    MessageBox.Show("new paass is not conf succesful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newPassValue.Text = "";
                    confPassValue.Text = "";

                }
                else
                {
                    File.Delete(encryptedCredentialsFile);
                    if (File.Exists(encryptedCredentialsFile))
                    {
                        MessageBox.Show("den svistike!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Κρυπτογράφηση των συνδυασμένων δεδομένων

                    String newData = username + newPassValue.Text;
                    string encryptedData = Hashing.HashUsernameOrPassword(newData);

                    // Αποθήκευση των κρυπτογραφημένων δεδομένων στο αρχείο "encrypted_credentials.txt"
                    File.WriteAllText(encryptedCredentialsFile, encryptedData);
                    MessageBox.Show("Change was Succesful !", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frm.Show();
                    this.Close();


                }

            }
            else
            {
                MessageBox.Show("wrong username or pass. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userNameValue.Text = "";
                oldPassValue.Text = "";
                newPassValue.Text = "";
                confPassValue.Text = "";

            }



        }

        private void OK_MouseHover(object sender, EventArgs e)
        {
            OK.BackColor = Color.BurlyWood;
        }

        private void OK_MouseLeave(object sender, EventArgs e)
        {
            OK.BackColor = SystemColors.ActiveCaption;
        }

        private void ChangePass_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }
    }

}
