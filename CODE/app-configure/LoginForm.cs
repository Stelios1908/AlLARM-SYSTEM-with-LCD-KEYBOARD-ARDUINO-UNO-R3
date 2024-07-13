using AlarmSystem;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private string encryptedCredentialsFile = "code.txt";
        private bool credentialsStored = false;
        private bool isValid = false;

        public LoginForm()
        {
            InitializeComponent();

            if (File.Exists(encryptedCredentialsFile))
            {
                credentialsStored = true;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string username = "stelios";// usernameValue.Text;  //
            string pwd = "Lioste12345";//passwordValue.Text; //
            string combinedData = username + pwd;

            if (!credentialsStored)
            {

                // Κρυπτογράφηση των συνδυασμένων δεδομένων
                string encryptedData = Hashing.HashUsernameOrPassword(combinedData);

                // Αποθήκευση των κρυπτογραφημένων δεδομένων στο αρχείο "encrypted_credentials.txt"
                File.WriteAllText(encryptedCredentialsFile, encryptedData);

                credentialsStored = true;
            }


            if (credentialsStored)
            {
                // Διαβάζουμε το κρυπτογραφημένο περιεχόμενο από το αρχείο
                string storedEncryptedCredentials = File.ReadAllText(encryptedCredentialsFile);
                isValid = Hashing.VerifyUsernameOrPassword(combinedData, storedEncryptedCredentials);




            }


            else
            {
                // Δεν υπάρχουν αποθηκευμένα διαπιστευτήρια
                MessageBox.Show("Τα διαπιστευτήρια δεν βρέθηκαν.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (isValid)
            {
                MessageBox.Show("Connection is Succesful !", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("wrong username or pass. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameValue.Text = "";
                passwordValue.Text = "";
            }


            //progressBar1.Value += 10; 
            // MessageBox.Show($"hi  {textBox1.Text}  {textBox2.Text}");
            // textBox3.Text = $"{ textBox1.Text} ${ textBox2.Text}";


        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.BurlyWood;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = SystemColors.ActiveCaption;
        }

        private void changePass_MouseHover(object sender, EventArgs e)
        {
            changePass.BackColor = Color.BurlyWood;
        }
        private void changePass_MouseLeave(object sender, EventArgs e)
        {
            changePass.BackColor = Color.IndianRed;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // progressBar1.Value += 10;
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            ChangePass pass_frm = new ChangePass(this);
            pass_frm.Show();
            this.Hide();

        }
    }
}