namespace GUI.AppForm
{
    partial class FormSignUp
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
            panel1 = new Panel();
            btnSignIn = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnSignUp = new Button();
            tbLogin = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tbPassword = new TextBox();
            label5 = new Label();
            tbAddress = new TextBox();
            label6 = new Label();
            tbPhoneNumber = new TextBox();
            label7 = new Label();
            tbEmail = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tbUsername = new TextBox();
            cbRole = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 450);
            panel1.TabIndex = 1;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.Highlight;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(57, 402);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(203, 36);
            btnSignIn.TabIndex = 8;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 356);
            label1.Name = "label1";
            label1.Size = new Size(213, 28);
            label1.TabIndex = 3;
            label1.Text = "Welcome to Testchovui";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 251);
            label2.Name = "label2";
            label2.Size = new Size(213, 28);
            label2.TabIndex = 2;
            label2.Text = "Welcome to Testchovui";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_laptop_100;
            pictureBox1.Location = new Point(92, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 113);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.Highlight;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(408, 383);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 36);
            btnSignUp.TabIndex = 11;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(513, 82);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(209, 27);
            tbLogin.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(408, 82);
            label4.Name = "label4";
            label4.Size = new Size(61, 28);
            label4.TabIndex = 9;
            label4.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(408, 31);
            label3.Name = "label3";
            label3.Size = new Size(247, 31);
            label3.TabIndex = 8;
            label3.Text = "Register your account";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(513, 124);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(209, 27);
            tbPassword.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(408, 124);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 12;
            label5.Text = "Password";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(513, 210);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(209, 27);
            tbAddress.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(408, 210);
            label6.Name = "label6";
            label6.Size = new Size(82, 28);
            label6.TabIndex = 14;
            label6.Text = "Address";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(513, 251);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(207, 27);
            tbPhoneNumber.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(406, 250);
            label7.Name = "label7";
            label7.Size = new Size(67, 28);
            label7.TabIndex = 16;
            label7.Text = "Phone";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(513, 292);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(209, 27);
            tbEmail.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(408, 292);
            label8.Name = "label8";
            label8.Size = new Size(59, 28);
            label8.TabIndex = 18;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(771, 8);
            label9.Name = "label9";
            label9.Size = new Size(21, 19);
            label9.TabIndex = 20;
            label9.Text = "X";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(406, 332);
            label10.Name = "label10";
            label10.Size = new Size(50, 28);
            label10.TabIndex = 21;
            label10.Text = "Role";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(408, 167);
            label11.Name = "label11";
            label11.Size = new Size(99, 28);
            label11.TabIndex = 21;
            label11.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(513, 167);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(209, 27);
            tbUsername.TabIndex = 22;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Seller", "Client" });
            cbRole.Location = new Point(513, 332);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(209, 28);
            cbRole.TabIndex = 23;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbRole);
            Controls.Add(tbUsername);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(tbEmail);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(tbPhoneNumber);
            Controls.Add(label7);
            Controls.Add(tbAddress);
            Controls.Add(label6);
            Controls.Add(tbPassword);
            Controls.Add(label5);
            Controls.Add(btnSignUp);
            Controls.Add(tbLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSignIn;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnSignUp;
        private TextBox tbLogin;
        private Label label4;
        private Label label3;
        private TextBox tbPassword;
        private Label label5;
        private TextBox tbAddress;
        private Label label6;
        private TextBox tbPhoneNumber;
        private Label label7;
        private TextBox tbEmail;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tbUsername;
        private ComboBox cbRole;
    }
}