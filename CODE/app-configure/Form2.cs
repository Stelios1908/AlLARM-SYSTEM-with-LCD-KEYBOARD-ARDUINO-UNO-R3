using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        private List<KeyValuePair<string, int>> items = new List<KeyValuePair<string, int>>();


        public Form2()
        {
            InitializeComponent();

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string folderPath_keyboard = "C:\\Users\\30698\\Desktop\\KEYPAD\\";
            string folderPath_cu = "C:\\Users\\30698\\Desktop\\UNIT\\";
            string fileName_keyboard = "keypad.ino";
            string fileName_cu = "unit.ino";

            string filePath_keyboard = Path.Combine(folderPath_keyboard, fileName_keyboard);
            string filePath_cu = Path.Combine(folderPath_cu, fileName_cu);

            items.Add(new KeyValuePair<string, int>("TIME DELAY", 1));
            items.Add(new KeyValuePair<string, int>("SILENS", 2));
            items.Add(new KeyValuePair<string, int>("TABER", 3));
            items.Add(new KeyValuePair<string, int>("BYPASS STAY (sequence)", 4));
            items.Add(new KeyValuePair<string, int>("SEQUENCE", 5));
            items.Add(new KeyValuePair<string, int>("DIRECT", 6));
            items.Add(new KeyValuePair<string, int>("FIRE", 7));
            items.Add(new KeyValuePair<string, int>("BYPASS STAY (no sequense)", 9));


            //collect data from form  users
            string user1A = user1Check.Checked ? String.Concat(User1Value.Text, "A") : "XXXXA";
            string user1D = user1Check.Checked ? String.Concat(User1Value.Text, "D") : "XXXXD";
            string bypassUser1 = user1Check.Checked ? String.Concat(User1Value.Text, "B") : "XXXXB";

            string user2A = user2Check.Checked ? String.Concat(User2Value.Text, "A") : "XXXXA";
            string user2D = user2Check.Checked ? String.Concat(User2Value.Text, "D") : "XXXXD";
            string bypassUser2 = user1Check.Checked ? String.Concat(User2Value.Text, "B") : "XXXXB";

            string user3A = user3Check.Checked ? String.Concat(User3Value.Text, "A") : "XXXXA";
            string user3D = user3Check.Checked ? String.Concat(User3Value.Text, "D") : "XXXXD";
            string bypassUser3 = user3Check.Checked ? String.Concat(User3Value.Text, "B") : "XXXXB";

            //check valid values
            bool valid = true;
            valid = (valid && user1A.Length == 5 && user1A.Substring(0, 4).All(char.IsDigit)) || (valid && !user1Check.Checked);
            valid = (valid && user2A.Length == 5 && user2A.Substring(0, 4).All(char.IsDigit)) || (valid && !user2Check.Checked);
            valid = (valid && user3A.Length == 5 && user3A.Substring(0, 4).All(char.IsDigit)) || (valid && !user3Check.Checked);


            if (!valid)
                MessageBox.Show("INVALID VALUES USERS CODES", "PLEASE CHECK", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!(user1Check.Checked || user2Check.Checked || user3Check.Checked))
            {
                MessageBox.Show("NO USER WITH PASSWORD", "PLEASE CHECK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            System.Diagnostics.Debug.WriteLine(valid);
            //collect data from form zones

            string zone1 = items.FirstOrDefault(item => item.Key == zone1Type.Text).Value.ToString();
            string zone2 = items.FirstOrDefault(item => item.Key == zone2Type.Text).Value.ToString();
            string zone3 = items.FirstOrDefault(item => item.Key == zone3Type.Text).Value.ToString();
            string zone4 = items.FirstOrDefault(item => item.Key == zone4Type.Text).Value.ToString();
            string zone5 = items.FirstOrDefault(item => item.Key == zone5Type.Text).Value.ToString();
            string zone6 = items.FirstOrDefault(item => item.Key == zone6Type.Text).Value.ToString();

            //collect data from form timers
            string entry_time = entryTime.Text;
            string exit_time = exitTime.Text;
            string swrong_pass = wrong_pass.Text;
            string times_to_lock = time_to_lock.Text;


            // To keimeno poy tha graftei sto arxeio gia to pliktrologio
            string contex_keyboard = $@"#define EXIT_TIME {exit_time}
#define ENTRY_TIME {entry_time}

#define USER1A ""{user1A}""
#define USER1D ""{user1D}""
#define USER2A ""{user2A}""
#define USER2D ""{user2D}""
#define USER3A ""{user3A}""
#define USER3D ""{user3D}""

#define BYPASSCODE_1 ""{bypassUser1}""
#define BYPASSCODE_2 ""{bypassUser2}""
#define BYPASSCODE_3 ""{bypassUser3}""

#define TZ1 {zone1}
#define TZ2 {zone2}
#define TZ3 {zone3}
#define TZ4 {zone4}
#define TZ5 {zone5}
#define TZ6 {zone6}

#define TRIES {swrong_pass}
#define TIME_TO_LOCK {times_to_lock}";


            // To keimeno poy tha graftei gia too arxeio tis kentrikis monadas
            string contex_cu = $@"#define TZ1 {zone1}
#define TZ2 {zone2}
#define TZ3 {zone3}
#define TZ4 {zone4}
#define TZ5 {zone5}
#define TZ6 {zone6}";


            if (valid)
            {
                // Elegxos kai dimiourgia tou fakelou an den uparxei
                if (!File.Exists(filePath_keyboard))
                {
                    MessageBox.Show("the file not exist", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GrafeArxeio(filePath_keyboard, contex_keyboard, 36, 58);
                    System.Diagnostics.Debug.WriteLine("THE FILE HAS BEEN MODIFIED");
                    MessageBox.Show("SUCCESS MODIFY", "THANK YOY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Elegxos kai dimiourgia tou fakelou an den uparxei
                if (!File.Exists(filePath_cu))
                {
                    MessageBox.Show("the file not exist", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GrafeArxeio(filePath_cu, contex_cu, 38, 43);
                    System.Diagnostics.Debug.WriteLine("THE FILE HAS BEEN MODIFIED");
                    MessageBox.Show("SUCCESS MODIFY", "THANK YOY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }






        }


        // Sinartisi gia na grapseis ena keimeno se ena arxeio
        static void GrafeArxeio(string path, string text, int lineStart, int lineEnd)
        {
            string[] existingLinesK = File.ReadAllLines(path);
            //string[] existingLinesC   = File.ReadAllLines(path);


            // Xrisimopoisis tou StreamWriter gia na anoixeis to arxeio gia grapsimo
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < existingLinesK.Length; i++)
                {
                    if (i < lineStart - 1 || i > lineEnd - 1)
                    {
                        sw.WriteLine(existingLinesK[i]);
                    }
                    else
                    {
                        sw.WriteLine(text);
                        i = lineEnd - 1; // Μετακίνηση δείκτη στην τελευταία γραμμή που αντικαταστάθηκε
                    }
                }
            }
            /*
            using (StreamWriter sw2 = new StreamWriter(path))
            {
                for (int i = 0; i < existingLinesC.Length; i++) {

                    if (i < lineStart || i > lineEnd)
                    {
                        sw2.WriteLine(existingLinesK[i]);
                    }
                    else {
                        sw2.WriteLine(text);
                        i = lineEnd - 1;
                    }
                }  
            }
            */
        }

        private void submit_MouseHover(object sender, EventArgs e)
        {
            submit.BackColor = Color.BurlyWood;

            // System.Diagnostics.Debug.WriteLine("323");
        }

        private void submit_MouseLeave(object sender, EventArgs e)
        {
            submit.BackColor = SystemColors.ActiveCaption;
        }

        private void TITLE_ZONES_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void zone1Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ZONES_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void USERS_Click(object sender, EventArgs e)
        {

        }
    }
}
