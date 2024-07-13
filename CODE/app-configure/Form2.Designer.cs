namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label TITLE_USERS;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1 = new TabControl();
            USERS = new TabPage();
            groupBox3 = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            user6Label = new Label();
            user5Label = new Label();
            User6Value = new TextBox();
            User5Value = new TextBox();
            User4Value = new TextBox();
            user4Label = new Label();
            user3Check = new CheckBox();
            user2Check = new CheckBox();
            user1Check = new CheckBox();
            pictureBox1 = new PictureBox();
            User3Label = new Label();
            User2Label = new Label();
            User3Value = new TextBox();
            User2Value = new TextBox();
            User1Value = new TextBox();
            User1Lebel = new Label();
            ZONES = new TabPage();
            TITLE_ZONES = new Label();
            zone6Type = new ComboBox();
            zone5Type = new ComboBox();
            zone4Type = new ComboBox();
            zone3Type = new ComboBox();
            zone2Type = new ComboBox();
            zone1Type = new ComboBox();
            ZONE5 = new Label();
            ZONE6 = new Label();
            ZONE1 = new Label();
            ZONE2 = new Label();
            ZONE3 = new Label();
            ZONE4 = new Label();
            TIMERS = new TabPage();
            groupBox2 = new GroupBox();
            time_to_lock = new TextBox();
            wrong_pass = new TextBox();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            entryTime = new TextBox();
            exitTime = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            submit = new Button();
            TITLE_USERS = new Label();
            tabControl1.SuspendLayout();
            USERS.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ZONES.SuspendLayout();
            TIMERS.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TITLE_USERS
            // 
            TITLE_USERS.AutoSize = true;
            TITLE_USERS.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TITLE_USERS.ForeColor = Color.Black;
            TITLE_USERS.Location = new Point(178, 38);
            TITLE_USERS.Margin = new Padding(2, 0, 2, 0);
            TITLE_USERS.Name = "TITLE_USERS";
            TITLE_USERS.Size = new Size(265, 22);
            TITLE_USERS.TabIndex = 6;
            TITLE_USERS.Text = "TYPE 4 DIGIT FOR ANY USER";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(USERS);
            tabControl1.Controls.Add(ZONES);
            tabControl1.Controls.Add(TIMERS);
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(11, 11);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(845, 625);
            tabControl1.TabIndex = 2;
            // 
            // USERS
            // 
            USERS.AccessibleRole = AccessibleRole.None;
            USERS.BackColor = Color.DarkGray;
            USERS.Controls.Add(groupBox3);
            USERS.Controls.Add(user3Check);
            USERS.Controls.Add(user2Check);
            USERS.Controls.Add(user1Check);
            USERS.Controls.Add(pictureBox1);
            USERS.Controls.Add(User3Label);
            USERS.Controls.Add(User2Label);
            USERS.Controls.Add(TITLE_USERS);
            USERS.Controls.Add(User3Value);
            USERS.Controls.Add(User2Value);
            USERS.Controls.Add(User1Value);
            USERS.Controls.Add(User1Lebel);
            USERS.ForeColor = SystemColors.ActiveCaptionText;
            USERS.Location = new Point(4, 29);
            USERS.Margin = new Padding(2);
            USERS.Name = "USERS";
            USERS.Padding = new Padding(2);
            USERS.Size = new Size(837, 592);
            USERS.TabIndex = 0;
            USERS.Text = "USERS";
            USERS.Click += USERS_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox6);
            groupBox3.Controls.Add(checkBox5);
            groupBox3.Controls.Add(checkBox4);
            groupBox3.Controls.Add(user6Label);
            groupBox3.Controls.Add(user5Label);
            groupBox3.Controls.Add(User6Value);
            groupBox3.Controls.Add(User5Value);
            groupBox3.Controls.Add(User4Value);
            groupBox3.Controls.Add(user4Label);
            groupBox3.Location = new Point(31, 336);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(427, 240);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Avaliable shortly";
            // 
            // checkBox6
            // 
            checkBox6.AccessibleDescription = "user6Check";
            checkBox6.AutoCheck = false;
            checkBox6.AutoSize = true;
            checkBox6.Enabled = false;
            checkBox6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox6.Location = new Point(316, 183);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(97, 26);
            checkBox6.TabIndex = 21;
            checkBox6.Text = "ACTIVE";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AccessibleDescription = "user5heck";
            checkBox5.AutoCheck = false;
            checkBox5.AutoSize = true;
            checkBox5.Enabled = false;
            checkBox5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.Location = new Point(315, 118);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(97, 26);
            checkBox5.TabIndex = 20;
            checkBox5.Text = "ACTIVE";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AccessibleDescription = "user4Check";
            checkBox4.AutoCheck = false;
            checkBox4.AutoSize = true;
            checkBox4.Enabled = false;
            checkBox4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(316, 49);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(97, 26);
            checkBox4.TabIndex = 19;
            checkBox4.Text = "ACTIVE";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // user6Label
            // 
            user6Label.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            user6Label.ForeColor = SystemColors.ActiveCaptionText;
            user6Label.Location = new Point(9, 174);
            user6Label.Margin = new Padding(2, 0, 2, 0);
            user6Label.Name = "user6Label";
            user6Label.Size = new Size(129, 37);
            user6Label.TabIndex = 14;
            user6Label.Text = "USER 6 :";
            // 
            // user5Label
            // 
            user5Label.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            user5Label.ForeColor = SystemColors.ActiveCaptionText;
            user5Label.Location = new Point(9, 107);
            user5Label.Margin = new Padding(2, 0, 2, 0);
            user5Label.Name = "user5Label";
            user5Label.Size = new Size(137, 37);
            user5Label.TabIndex = 13;
            user5Label.Text = "USER 5 :";
            // 
            // User6Value
            // 
            User6Value.BackColor = SystemColors.GradientInactiveCaption;
            User6Value.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            User6Value.Location = new Point(168, 174);
            User6Value.Margin = new Padding(2);
            User6Value.Name = "User6Value";
            User6Value.ReadOnly = true;
            User6Value.Size = new Size(143, 28);
            User6Value.TabIndex = 12;
            User6Value.Text = "XXXX";
            // 
            // User5Value
            // 
            User5Value.BackColor = SystemColors.GradientInactiveCaption;
            User5Value.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            User5Value.Location = new Point(168, 107);
            User5Value.Margin = new Padding(2);
            User5Value.Name = "User5Value";
            User5Value.ReadOnly = true;
            User5Value.Size = new Size(143, 28);
            User5Value.TabIndex = 11;
            User5Value.Text = "XXXX";
            // 
            // User4Value
            // 
            User4Value.BackColor = SystemColors.GradientInactiveCaption;
            User4Value.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            User4Value.Location = new Point(168, 37);
            User4Value.Margin = new Padding(2);
            User4Value.Name = "User4Value";
            User4Value.ReadOnly = true;
            User4Value.Size = new Size(143, 28);
            User4Value.TabIndex = 10;
            User4Value.Text = "XXXX";
            // 
            // user4Label
            // 
            user4Label.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            user4Label.ForeColor = SystemColors.ActiveCaptionText;
            user4Label.Location = new Point(9, 38);
            user4Label.Margin = new Padding(2, 0, 2, 0);
            user4Label.Name = "user4Label";
            user4Label.Size = new Size(129, 37);
            user4Label.TabIndex = 9;
            user4Label.Text = "USER 4 :";
            // 
            // user3Check
            // 
            user3Check.AccessibleDescription = "";
            user3Check.AutoSize = true;
            user3Check.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            user3Check.Location = new Point(348, 280);
            user3Check.Name = "user3Check";
            user3Check.Size = new Size(97, 26);
            user3Check.TabIndex = 18;
            user3Check.Text = "ACTIVE";
            user3Check.UseVisualStyleBackColor = true;
            // 
            // user2Check
            // 
            user2Check.AccessibleDescription = "";
            user2Check.AutoSize = true;
            user2Check.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            user2Check.Location = new Point(348, 214);
            user2Check.Name = "user2Check";
            user2Check.Size = new Size(97, 26);
            user2Check.TabIndex = 17;
            user2Check.Text = "ACTIVE";
            user2Check.UseVisualStyleBackColor = true;
            // 
            // user1Check
            // 
            user1Check.AccessibleDescription = "";
            user1Check.AutoSize = true;
            user1Check.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            user1Check.Location = new Point(348, 154);
            user1Check.Name = "user1Check";
            user1Check.Size = new Size(97, 26);
            user1Check.TabIndex = 16;
            user1Check.Text = "ACTIVE";
            user1Check.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(488, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 310);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // User3Label
            // 
            User3Label.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            User3Label.ForeColor = SystemColors.ActiveCaptionText;
            User3Label.Location = new Point(41, 270);
            User3Label.Margin = new Padding(2, 0, 2, 0);
            User3Label.Name = "User3Label";
            User3Label.Size = new Size(137, 37);
            User3Label.TabIndex = 8;
            User3Label.Text = "USER 3 :";
            // 
            // User2Label
            // 
            User2Label.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            User2Label.ForeColor = SystemColors.ActiveCaptionText;
            User2Label.Location = new Point(41, 201);
            User2Label.Margin = new Padding(2, 0, 2, 0);
            User2Label.Name = "User2Label";
            User2Label.Size = new Size(137, 37);
            User2Label.TabIndex = 7;
            User2Label.Text = "USER 2 :";
            // 
            // User3Value
            // 
            User3Value.BackColor = SystemColors.GradientInactiveCaption;
            User3Value.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            User3Value.Location = new Point(200, 266);
            User3Value.Margin = new Padding(2);
            User3Value.Name = "User3Value";
            User3Value.Size = new Size(143, 28);
            User3Value.TabIndex = 5;
            User3Value.Text = "XXXX";
            // 
            // User2Value
            // 
            User2Value.BackColor = SystemColors.GradientInactiveCaption;
            User2Value.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            User2Value.Location = new Point(200, 201);
            User2Value.Margin = new Padding(2);
            User2Value.Name = "User2Value";
            User2Value.Size = new Size(143, 28);
            User2Value.TabIndex = 4;
            User2Value.Text = "XXXX";
            // 
            // User1Value
            // 
            User1Value.BackColor = SystemColors.GradientInactiveCaption;
            User1Value.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            User1Value.Location = new Point(200, 137);
            User1Value.Margin = new Padding(2);
            User1Value.Name = "User1Value";
            User1Value.Size = new Size(143, 28);
            User1Value.TabIndex = 3;
            User1Value.Text = "XXXX";
            // 
            // User1Lebel
            // 
            User1Lebel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            User1Lebel.ForeColor = SystemColors.ActiveCaptionText;
            User1Lebel.Location = new Point(41, 141);
            User1Lebel.Margin = new Padding(2, 0, 2, 0);
            User1Lebel.Name = "User1Lebel";
            User1Lebel.Size = new Size(129, 37);
            User1Lebel.TabIndex = 0;
            User1Lebel.Text = "USER 1 :";
            // 
            // ZONES
            // 
            ZONES.BackColor = Color.DarkGray;
            ZONES.Controls.Add(TITLE_ZONES);
            ZONES.Controls.Add(zone6Type);
            ZONES.Controls.Add(zone5Type);
            ZONES.Controls.Add(zone4Type);
            ZONES.Controls.Add(zone3Type);
            ZONES.Controls.Add(zone2Type);
            ZONES.Controls.Add(zone1Type);
            ZONES.Controls.Add(ZONE5);
            ZONES.Controls.Add(ZONE6);
            ZONES.Controls.Add(ZONE1);
            ZONES.Controls.Add(ZONE2);
            ZONES.Controls.Add(ZONE3);
            ZONES.Controls.Add(ZONE4);
            ZONES.Location = new Point(4, 29);
            ZONES.Margin = new Padding(2);
            ZONES.Name = "ZONES";
            ZONES.Padding = new Padding(2);
            ZONES.Size = new Size(837, 592);
            ZONES.TabIndex = 1;
            ZONES.Text = "ZONES";
            ZONES.Click += ZONES_Click;
            // 
            // TITLE_ZONES
            // 
            TITLE_ZONES.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            TITLE_ZONES.ForeColor = SystemColors.WindowText;
            TITLE_ZONES.Location = new Point(121, 22);
            TITLE_ZONES.Margin = new Padding(2, 0, 2, 0);
            TITLE_ZONES.Name = "TITLE_ZONES";
            TITLE_ZONES.Size = new Size(525, 80);
            TITLE_ZONES.TabIndex = 13;
            TITLE_ZONES.Text = "SELECT TYPE FOR THE ZONES";
            TITLE_ZONES.TextAlign = ContentAlignment.MiddleRight;
            TITLE_ZONES.Click += TITLE_ZONES_Click;
            // 
            // zone6Type
            // 
            zone6Type.AutoCompleteCustomSource.AddRange(new string[] { "TIME DELAY", "SILENS", "24", "BYPASS STAY (sequence)", "SEQUENCE", "DIRECT", "FIRE", "TABER", "BYPASS STAY (no sequence)" });
            zone6Type.BackColor = SystemColors.GradientActiveCaption;
            zone6Type.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zone6Type.FormattingEnabled = true;
            zone6Type.ItemHeight = 28;
            zone6Type.Items.AddRange(new object[] { "TIME DELAY", "SILENS", "TABER", "BYPASS STAY (sequence)", "SEQUENCE", "DIRECT", "FIRE", "BYPASS STAY (no sequence)" });
            zone6Type.Location = new Point(365, 509);
            zone6Type.Margin = new Padding(2);
            zone6Type.Name = "zone6Type";
            zone6Type.Size = new Size(281, 36);
            zone6Type.TabIndex = 12;
            zone6Type.Text = "DIRECT";
            // 
            // zone5Type
            // 
            zone5Type.AutoCompleteCustomSource.AddRange(new string[] { "TIME DELAY", "SILENS", "24", "BYPASS STAY (sequense)", "SEQUENS", "AMESH", "FIRE", "TABER", "BYPASS STAY (no sequense)" });
            zone5Type.BackColor = SystemColors.GradientActiveCaption;
            zone5Type.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zone5Type.FormattingEnabled = true;
            zone5Type.ItemHeight = 28;
            zone5Type.Items.AddRange(new object[] { "TIME DELAY", "SILENS", "TABER", "BYPASS STAY (sequence)", "SEQUENCE", "DIRECT", "FIRE", "BYPASS STAY (no sequence)" });
            zone5Type.Location = new Point(364, 434);
            zone5Type.Margin = new Padding(2);
            zone5Type.Name = "zone5Type";
            zone5Type.Size = new Size(282, 36);
            zone5Type.TabIndex = 11;
            zone5Type.Text = "DIRECT";
            // 
            // zone4Type
            // 
            zone4Type.AutoCompleteCustomSource.AddRange(new string[] { "TIME DELAY", "SILENS", "24", "BYPASS STAY (sequense)", "SEQUENS", "AMESH", "FIRE", "TABER", "BYPASS STAY (no sequense)" });
            zone4Type.BackColor = SystemColors.GradientActiveCaption;
            zone4Type.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zone4Type.FormattingEnabled = true;
            zone4Type.ItemHeight = 28;
            zone4Type.Items.AddRange(new object[] { "TIME DELAY", "SILENS", "TABER", "BYPASS STAY (sequence)", "SEQUENCE", "DIRECT", "FIRE", "BYPASS STAY (no sequence)" });
            zone4Type.Location = new Point(365, 355);
            zone4Type.Margin = new Padding(2);
            zone4Type.Name = "zone4Type";
            zone4Type.Size = new Size(281, 36);
            zone4Type.TabIndex = 10;
            zone4Type.Text = "DIRECT";
            // 
            // zone3Type
            // 
            zone3Type.AutoCompleteCustomSource.AddRange(new string[] { "TIME DELAY", "SILENS", "24", "BYPASS STAY (sequense)", "SEQUENS", "AMESH", "FIRE", "TABER", "BYPASS STAY (no sequense)" });
            zone3Type.BackColor = SystemColors.GradientActiveCaption;
            zone3Type.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zone3Type.FormattingEnabled = true;
            zone3Type.ItemHeight = 28;
            zone3Type.Items.AddRange(new object[] { "TIME DELAY", "SILENS", "TABER", "BYPASS STAY (sequence)", "SEQUENCE", "DIRECT", "FIRE", "24", "BYPASS STAY (no sequence)" });
            zone3Type.Location = new Point(364, 277);
            zone3Type.Margin = new Padding(2);
            zone3Type.Name = "zone3Type";
            zone3Type.Size = new Size(282, 36);
            zone3Type.TabIndex = 9;
            zone3Type.Text = "DIRECT";
            // 
            // zone2Type
            // 
            zone2Type.AutoCompleteSource = AutoCompleteSource.ListItems;
            zone2Type.BackColor = SystemColors.GradientActiveCaption;
            zone2Type.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zone2Type.FormattingEnabled = true;
            zone2Type.ItemHeight = 28;
            zone2Type.Items.AddRange(new object[] { "TIME DELAY", "SILENS", "TABER", "BYPASS STAY (sequence)", "SEQUENCE", "DIRECT", "FIRE", "BYPASS STAY (no sequence)" });
            zone2Type.Location = new Point(365, 207);
            zone2Type.Margin = new Padding(2);
            zone2Type.Name = "zone2Type";
            zone2Type.Size = new Size(281, 36);
            zone2Type.TabIndex = 8;
            zone2Type.Text = "DIRECT";
            // 
            // zone1Type
            // 
            zone1Type.AutoCompleteCustomSource.AddRange(new string[] { "TIME DELAY", "SILENS", "24", "BYPASS STAY (sequense)", "SEQUENS", "AMESH", "FIRE", "TABER", "BYPASS STAY (no sequense)" });
            zone1Type.BackColor = SystemColors.GradientActiveCaption;
            zone1Type.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zone1Type.FormattingEnabled = true;
            zone1Type.ItemHeight = 28;
            zone1Type.Items.AddRange(new object[] { "TIME DELAY", "SILENS", "TABER", "BYPASS STAY (sequence)", "SEQUENCE", "DIRECT", "FIRE", "BYPASS STAY (no sequence)" });
            zone1Type.Location = new Point(363, 136);
            zone1Type.Margin = new Padding(2);
            zone1Type.Name = "zone1Type";
            zone1Type.Size = new Size(283, 36);
            zone1Type.TabIndex = 7;
            zone1Type.Text = "DIRECT";
            zone1Type.SelectedIndexChanged += zone1Type_SelectedIndexChanged;
            // 
            // ZONE5
            // 
            ZONE5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ZONE5.ForeColor = SystemColors.ActiveCaptionText;
            ZONE5.Location = new Point(162, 435);
            ZONE5.Margin = new Padding(2, 0, 2, 0);
            ZONE5.Name = "ZONE5";
            ZONE5.Size = new Size(127, 37);
            ZONE5.TabIndex = 6;
            ZONE5.Text = "ZONE 5 :";
            // 
            // ZONE6
            // 
            ZONE6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ZONE6.ForeColor = SystemColors.ActiveCaptionText;
            ZONE6.Location = new Point(162, 509);
            ZONE6.Margin = new Padding(2, 0, 2, 0);
            ZONE6.Name = "ZONE6";
            ZONE6.Size = new Size(127, 37);
            ZONE6.TabIndex = 5;
            ZONE6.Text = "ZONE 6 :";
            // 
            // ZONE1
            // 
            ZONE1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ZONE1.ForeColor = SystemColors.ActiveCaptionText;
            ZONE1.Location = new Point(162, 136);
            ZONE1.Margin = new Padding(2, 0, 2, 0);
            ZONE1.Name = "ZONE1";
            ZONE1.Size = new Size(144, 37);
            ZONE1.TabIndex = 4;
            ZONE1.Text = "ZONE 1 :";
            // 
            // ZONE2
            // 
            ZONE2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ZONE2.ForeColor = SystemColors.ActiveCaptionText;
            ZONE2.Location = new Point(162, 213);
            ZONE2.Margin = new Padding(2, 0, 2, 0);
            ZONE2.Name = "ZONE2";
            ZONE2.Size = new Size(127, 37);
            ZONE2.TabIndex = 3;
            ZONE2.Text = "ZONE 2 :";
            // 
            // ZONE3
            // 
            ZONE3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ZONE3.ForeColor = SystemColors.ActiveCaptionText;
            ZONE3.Location = new Point(162, 278);
            ZONE3.Margin = new Padding(2, 0, 2, 0);
            ZONE3.Name = "ZONE3";
            ZONE3.Size = new Size(127, 37);
            ZONE3.TabIndex = 2;
            ZONE3.Text = "ZONE 3 :";
            // 
            // ZONE4
            // 
            ZONE4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ZONE4.ForeColor = SystemColors.ActiveCaptionText;
            ZONE4.Location = new Point(162, 355);
            ZONE4.Margin = new Padding(2, 0, 2, 0);
            ZONE4.Name = "ZONE4";
            ZONE4.Size = new Size(127, 37);
            ZONE4.TabIndex = 1;
            ZONE4.Text = "ZONE 4 :";
            // 
            // TIMERS
            // 
            TIMERS.BackColor = Color.DarkGray;
            TIMERS.Controls.Add(groupBox2);
            TIMERS.Controls.Add(groupBox1);
            TIMERS.Controls.Add(label3);
            TIMERS.Location = new Point(4, 29);
            TIMERS.Margin = new Padding(2);
            TIMERS.Name = "TIMERS";
            TIMERS.Size = new Size(837, 592);
            TIMERS.TabIndex = 2;
            TIMERS.Text = "TIMERS";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkGray;
            groupBox2.Controls.Add(time_to_lock);
            groupBox2.Controls.Add(wrong_pass);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(415, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(375, 366);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // time_to_lock
            // 
            time_to_lock.AccessibleRole = AccessibleRole.Caret;
            time_to_lock.BackColor = SystemColors.InactiveCaption;
            time_to_lock.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            time_to_lock.Location = new Point(276, 221);
            time_to_lock.Margin = new Padding(2);
            time_to_lock.Name = "time_to_lock";
            time_to_lock.Size = new Size(82, 52);
            time_to_lock.TabIndex = 5;
            time_to_lock.Text = "5";
            time_to_lock.TextAlign = HorizontalAlignment.Center;
            // 
            // wrong_pass
            // 
            wrong_pass.AccessibleRole = AccessibleRole.Caret;
            wrong_pass.BackColor = SystemColors.InactiveCaption;
            wrong_pass.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            wrong_pass.Location = new Point(276, 101);
            wrong_pass.Margin = new Padding(2);
            wrong_pass.Name = "wrong_pass";
            wrong_pass.Size = new Size(82, 52);
            wrong_pass.TabIndex = 4;
            wrong_pass.Text = "3";
            wrong_pass.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkGray;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(0, 79);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(268, 74);
            label8.TabIndex = 1;
            label8.Text = "TIMES FOR \r\nWRONG PASSWORD:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkGray;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(0, 203);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(273, 111);
            label9.TabIndex = 0;
            label9.Text = "TIME TO LOCK WHEN\r\n WRONG PASS(min):\r\n\r\n";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(entryTime);
            groupBox1.Controls.Add(exitTime);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 366);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(244, 242);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(82, 52);
            textBox2.TabIndex = 10;
            textBox2.Text = "max\r\n";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(244, 180);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(82, 52);
            textBox1.TabIndex = 9;
            textBox1.Text = "max";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkGray;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(27, 248);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(183, 46);
            label5.TabIndex = 8;
            label5.Text = "FIRE TIME :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGray;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(1, 186);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(209, 46);
            label4.TabIndex = 7;
            label4.Text = "SIREN TIME :";
            // 
            // entryTime
            // 
            entryTime.BackColor = SystemColors.InactiveCaption;
            entryTime.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            entryTime.Location = new Point(244, 52);
            entryTime.Margin = new Padding(2);
            entryTime.Name = "entryTime";
            entryTime.Size = new Size(82, 52);
            entryTime.TabIndex = 5;
            entryTime.Text = "10";
            entryTime.TextAlign = HorizontalAlignment.Center;
            // 
            // exitTime
            // 
            exitTime.BackColor = SystemColors.InactiveCaption;
            exitTime.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            exitTime.Location = new Point(244, 108);
            exitTime.Margin = new Padding(2);
            exitTime.Name = "exitTime";
            exitTime.Size = new Size(82, 52);
            exitTime.TabIndex = 4;
            exitTime.Text = "40";
            exitTime.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(35, 107);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 46);
            label2.TabIndex = 1;
            label2.Text = "EXIT TIME :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(1, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 46);
            label1.TabIndex = 0;
            label1.Text = "ENTRY TIME :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(268, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(260, 46);
            label3.TabIndex = 6;
            label3.Text = "SYSTEM TIMES";
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ActiveCaption;
            submit.FlatAppearance.BorderColor = Color.Black;
            submit.FlatStyle = FlatStyle.Popup;
            submit.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            submit.ForeColor = SystemColors.ActiveCaptionText;
            submit.Location = new Point(268, 658);
            submit.Margin = new Padding(2);
            submit.Name = "submit";
            submit.Size = new Size(331, 103);
            submit.TabIndex = 15;
            submit.Text = "SUBMIT FORM";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            submit.MouseLeave += submit_MouseLeave;
            submit.MouseHover += submit_MouseHover;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(867, 782);
            Controls.Add(submit);
            Controls.Add(tabControl1);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Main Menu";
            tabControl1.ResumeLayout(false);
            USERS.ResumeLayout(false);
            USERS.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ZONES.ResumeLayout(false);
            TIMERS.ResumeLayout(false);
            TIMERS.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TabControl tabControl1;
        private TabPage USERS;
        private TabPage ZONES;
        private TabPage TIMERS;
        private TextBox User3Value;
        private TextBox User2Value;
        private TextBox User1Value;
        private Label TITLE_USERS;
        private Label User1Lebel;
        private Label User3Label;
        private Label User2Label;
        private ComboBox zone1Type;
        private Label ZONE5;
        private Label ZONE6;
        private Label ZONE1;
        private Label ZONE2;
        private Label ZONE3;
        private Label ZONE4;
        private ComboBox zone6Type;
        private ComboBox zone5Type;
        private ComboBox zone4Type;
        private ComboBox zone3Type;
        private ComboBox zone2Type;
        private Label TITLE_ZONES;
        private Label user6Label;
        private Label user5Label;
        private TextBox User6Value;
        private TextBox User5Value;
        private TextBox User4Value;
        private Label user4Label;
        private TextBox entryTime;
        private TextBox exitTime;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button submit;
        private CheckBox checkBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox6;
        private CheckBox checkBox2;
        private CheckBox user1Check;
        private CheckBox user3Check;
        private CheckBox user2Check;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox wrong_pass;
        private Label label8;
        private Label label9;
        public GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox time_to_lock;
        private GroupBox groupBox3;
    }
}