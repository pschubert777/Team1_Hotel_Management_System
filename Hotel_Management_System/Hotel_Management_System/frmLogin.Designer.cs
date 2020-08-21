namespace AccountManagementInterface
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdiobtnCustomer = new System.Windows.Forms.RadioButton();
            this.rdiobtnEmployee = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(101, 195);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(18, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // tboxUsername
            // 
            this.tboxUsername.Location = new System.Drawing.Point(106, 23);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(100, 20);
            this.tboxUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(18, 78);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Don\'t have an account?";
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(106, 74);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '*';
            this.tboxPassword.Size = new System.Drawing.Size(100, 20);
            this.tboxPassword.TabIndex = 1;
            this.tboxPassword.UseSystemPasswordChar = true;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(256, 61);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(76, 47);
            this.btnNewUser.TabIndex = 6;
            this.btnNewUser.Text = "Create Account";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(238, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdiobtnCustomer
            // 
            this.rdiobtnCustomer.AutoSize = true;
            this.rdiobtnCustomer.Location = new System.Drawing.Point(101, 115);
            this.rdiobtnCustomer.Name = "rdiobtnCustomer";
            this.rdiobtnCustomer.Size = new System.Drawing.Size(69, 17);
            this.rdiobtnCustomer.TabIndex = 2;
            this.rdiobtnCustomer.TabStop = true;
            this.rdiobtnCustomer.Text = "Customer";
            this.rdiobtnCustomer.UseVisualStyleBackColor = true;
            // 
            // rdiobtnEmployee
            // 
            this.rdiobtnEmployee.AutoSize = true;
            this.rdiobtnEmployee.Location = new System.Drawing.Point(101, 138);
            this.rdiobtnEmployee.Name = "rdiobtnEmployee";
            this.rdiobtnEmployee.Size = new System.Drawing.Size(71, 17);
            this.rdiobtnEmployee.TabIndex = 3;
            this.rdiobtnEmployee.TabStop = true;
            this.rdiobtnEmployee.Text = "Employee";
            this.rdiobtnEmployee.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 260);
            this.Controls.Add(this.rdiobtnEmployee);
            this.Controls.Add(this.rdiobtnCustomer);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdiobtnCustomer;
        private System.Windows.Forms.RadioButton rdiobtnEmployee;
    }
}