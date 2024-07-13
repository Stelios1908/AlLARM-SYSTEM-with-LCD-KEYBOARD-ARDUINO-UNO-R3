namespace WinFormsApp1
{
    partial class LoginForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            notifyIcon1 = new NotifyIcon(components);
            usernameValue = new TextBox();
            passwordValue = new TextBox();
            loginButton = new Button();
            usernameLabel = new Label();
            passwordLebel = new Label();
            label3 = new Label();
            changePass = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // usernameValue
            // 
            usernameValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usernameValue.Location = new Point(365, 171);
            usernameValue.Margin = new Padding(2);
            usernameValue.Name = "usernameValue";
            usernameValue.Size = new Size(182, 41);
            usernameValue.TabIndex = 8;
            // 
            // passwordValue
            // 
            passwordValue.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordValue.Location = new Point(365, 248);
            passwordValue.Margin = new Padding(2);
            passwordValue.Name = "passwordValue";
            passwordValue.PasswordChar = '*';
            passwordValue.Size = new Size(180, 41);
            passwordValue.TabIndex = 9;
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ActiveCaption;
            loginButton.Location = new Point(326, 318);
            loginButton.Margin = new Padding(2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(251, 87);
            loginButton.TabIndex = 13;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click;
            loginButton.MouseLeave += button1_MouseLeave;
            loginButton.MouseHover += button1_MouseHover;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(186, 174);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(148, 35);
            usernameLabel.TabIndex = 14;
            usernameLabel.Text = "USERNAME:";
            // 
            // passwordLebel
            // 
            passwordLebel.AutoSize = true;
            passwordLebel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLebel.Location = new Point(186, 251);
            passwordLebel.Margin = new Padding(2, 0, 2, 0);
            passwordLebel.Name = "passwordLebel";
            passwordLebel.Size = new Size(149, 35);
            passwordLebel.TabIndex = 15;
            passwordLebel.Text = "PASSWORD:";
            // 
            // label3
            // 
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(139, 48);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(661, 80);
            label3.TabIndex = 16;
            label3.Text = "CEID  SECURITY DEPARTMENT";
            // 
            // changePass
            // 
            changePass.BackColor = Color.IndianRed;
            changePass.Location = new Point(326, 422);
            changePass.Name = "changePass";
            changePass.Size = new Size(251, 56);
            changePass.TabIndex = 17;
            changePass.Text = "Change Password";
            changePass.UseVisualStyleBackColor = false;
            changePass.Click += changePass_Click;
            changePass.MouseLeave += changePass_MouseLeave;
            changePass.MouseHover += changePass_MouseHover;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 488);
            Controls.Add(changePass);
            Controls.Add(label3);
            Controls.Add(passwordLebel);
            Controls.Add(usernameLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordValue);
            Controls.Add(usernameValue);
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private NotifyIcon notifyIcon1;
        private TextBox usernameValue;
        private TextBox passwordValue;
        private Button loginButton;
        private Label usernameLabel;
        private Label passwordLebel;
        private Label label3;
        private Button changePass;
    }
}