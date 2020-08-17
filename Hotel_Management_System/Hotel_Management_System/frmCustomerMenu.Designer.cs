namespace AccountManagementInterface
{
    partial class frmCustomerMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnManageReservations = new System.Windows.Forms.Button();
            this.btnAccountInfo = new System.Windows.Forms.Button();
            this.btnActivityLog = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservations and Rewards";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menu";
            // 
            // btnManageReservations
            // 
            this.btnManageReservations.Location = new System.Drawing.Point(59, 114);
            this.btnManageReservations.Name = "btnManageReservations";
            this.btnManageReservations.Size = new System.Drawing.Size(94, 49);
            this.btnManageReservations.TabIndex = 3;
            this.btnManageReservations.Text = "Manage Reservations";
            this.btnManageReservations.UseVisualStyleBackColor = true;
            this.btnManageReservations.Click += new System.EventHandler(this.btnManageReservations_Click);
            // 
            // btnAccountInfo
            // 
            this.btnAccountInfo.Location = new System.Drawing.Point(311, 114);
            this.btnAccountInfo.Name = "btnAccountInfo";
            this.btnAccountInfo.Size = new System.Drawing.Size(90, 49);
            this.btnAccountInfo.TabIndex = 5;
            this.btnAccountInfo.Text = "Account Information";
            this.btnAccountInfo.UseVisualStyleBackColor = true;
            this.btnAccountInfo.Click += new System.EventHandler(this.btnAccountInfo_Click);
            // 
            // btnActivityLog
            // 
            this.btnActivityLog.Location = new System.Drawing.Point(311, 169);
            this.btnActivityLog.Name = "btnActivityLog";
            this.btnActivityLog.Size = new System.Drawing.Size(90, 49);
            this.btnActivityLog.TabIndex = 6;
            this.btnActivityLog.Text = "View Activity Log";
            this.btnActivityLog.UseVisualStyleBackColor = true;
            this.btnActivityLog.Click += new System.EventHandler(this.btnActivityLog_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(193, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Logout";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 286);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnActivityLog);
            this.Controls.Add(this.btnAccountInfo);
            this.Controls.Add(this.btnManageReservations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomerMenu";
            this.Text = "Customer Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnManageReservations;
        private System.Windows.Forms.Button btnAccountInfo;
        private System.Windows.Forms.Button btnActivityLog;
        private System.Windows.Forms.Button btnCancel;
    }
}