namespace AccountManagementInterface
{
    partial class frmCreateAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.rdiobtnCustomer = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.tboxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdiobtnEmployee = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tboxLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // tboxUsername
            // 
            this.tboxUsername.Location = new System.Drawing.Point(181, 27);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(127, 20);
            this.tboxUsername.TabIndex = 1;
            // 
            // rdiobtnCustomer
            // 
            this.rdiobtnCustomer.AutoSize = true;
            this.rdiobtnCustomer.Location = new System.Drawing.Point(365, 27);
            this.rdiobtnCustomer.Name = "rdiobtnCustomer";
            this.rdiobtnCustomer.Size = new System.Drawing.Size(69, 17);
            this.rdiobtnCustomer.TabIndex = 2;
            this.rdiobtnCustomer.TabStop = true;
            this.rdiobtnCustomer.Text = "Customer";
            this.rdiobtnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(54, 191);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(181, 62);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(127, 20);
            this.tboxPassword.TabIndex = 1;
            // 
            // tboxConfirmPassword
            // 
            this.tboxConfirmPassword.Location = new System.Drawing.Point(181, 98);
            this.tboxConfirmPassword.Name = "tboxConfirmPassword";
            this.tboxConfirmPassword.Size = new System.Drawing.Size(127, 20);
            this.tboxConfirmPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Confirm Password";
            // 
            // rdiobtnEmployee
            // 
            this.rdiobtnEmployee.AutoSize = true;
            this.rdiobtnEmployee.Location = new System.Drawing.Point(365, 55);
            this.rdiobtnEmployee.Name = "rdiobtnEmployee";
            this.rdiobtnEmployee.Size = new System.Drawing.Size(71, 17);
            this.rdiobtnEmployee.TabIndex = 2;
            this.rdiobtnEmployee.TabStop = true;
            this.rdiobtnEmployee.Text = "Employee";
            this.rdiobtnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tboxLocation
            // 
            this.tboxLocation.Location = new System.Drawing.Point(181, 134);
            this.tboxLocation.Name = "tboxLocation";
            this.tboxLocation.Size = new System.Drawing.Size(127, 20);
            this.tboxLocation.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Set Location";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 254);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rdiobtnEmployee);
            this.Controls.Add(this.rdiobtnCustomer);
            this.Controls.Add(this.tboxLocation);
            this.Controls.Add(this.tboxConfirmPassword);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateAccount";
            this.Text = "frmCreateAccount";
            this.Load += new System.EventHandler(this.frmCreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.RadioButton rdiobtnCustomer;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.TextBox tboxConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdiobtnEmployee;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tboxLocation;
        private System.Windows.Forms.Label label4;
    }
}