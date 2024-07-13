namespace AlarmSystem
{
    partial class ChangePass
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
            usernameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            oldPassValue = new TextBox();
            newPassValue = new TextBox();
            confPassValue = new TextBox();
            OK = new Button();
            label4 = new Label();
            userNameValue = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(118, 183);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(205, 35);
            usernameLabel.TabIndex = 15;
            usernameLabel.Text = "OLD PASSWORD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(112, 245);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 35);
            label1.TabIndex = 16;
            label1.Text = "NEW PASSWORD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(100, 309);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(213, 35);
            label2.TabIndex = 17;
            label2.Text = "CONF.PASSWORD";
            // 
            // label3
            // 
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(167, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(462, 80);
            label3.TabIndex = 18;
            label3.Text = "CHANGE PASSWORD";
            // 
            // oldPassValue
            // 
            oldPassValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            oldPassValue.Location = new Point(356, 183);
            oldPassValue.Margin = new Padding(2);
            oldPassValue.Name = "oldPassValue";
            oldPassValue.PasswordChar = '*';
            oldPassValue.Size = new Size(253, 41);
            oldPassValue.TabIndex = 19;
            // 
            // newPassValue
            // 
            newPassValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            newPassValue.Location = new Point(356, 245);
            newPassValue.Margin = new Padding(2);
            newPassValue.Name = "newPassValue";
            newPassValue.PasswordChar = '*';
            newPassValue.Size = new Size(253, 41);
            newPassValue.TabIndex = 20;
            // 
            // confPassValue
            // 
            confPassValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            confPassValue.Location = new Point(356, 309);
            confPassValue.Margin = new Padding(2);
            confPassValue.Name = "confPassValue";
            confPassValue.PasswordChar = '*';
            confPassValue.Size = new Size(253, 41);
            confPassValue.TabIndex = 21;
            // 
            // OK
            // 
            OK.BackColor = SystemColors.ActiveCaption;
            OK.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            OK.Location = new Point(356, 378);
            OK.Margin = new Padding(2);
            OK.Name = "OK";
            OK.Size = new Size(251, 61);
            OK.TabIndex = 22;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = false;
            OK.Click += OK_Click;
            OK.MouseLeave += OK_MouseLeave;
            OK.MouseHover += OK_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(168, 129);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(155, 35);
            label4.TabIndex = 23;
            label4.Text = "USER NAME:";
            // 
            // userNameValue
            // 
            userNameValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            userNameValue.Location = new Point(356, 123);
            userNameValue.Margin = new Padding(2);
            userNameValue.Name = "userNameValue";
            userNameValue.Size = new Size(253, 41);
            userNameValue.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(614, 246);
            label5.Name = "label5";
            label5.Size = new Size(164, 40);
            label5.TabIndex = 25;
            label5.Text = "a capital letter, \r\n5 letters and 5 numbers";
            label5.Click += label5_Click;
            // 
            // ChangePass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(userNameValue);
            Controls.Add(label4);
            Controls.Add(OK);
            Controls.Add(confPassValue);
            Controls.Add(newPassValue);
            Controls.Add(oldPassValue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameLabel);
            Name = "ChangePass";
            Text = "Change Password";
            FormClosed += ChangePass_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox oldPassValue;
        private TextBox newPassValue;
        private TextBox confPassValue;
        private Button OK;
        private Label label4;
        private TextBox userNameValue;
        private Label label5;
    }
}