namespace Hotel_Management_System
{
    partial class Display_Logs
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
            this.Generate_Report_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_date_label = new System.Windows.Forms.Label();
            this.back_menu_button = new System.Windows.Forms.Button();
            this.start_date_picker = new System.Windows.Forms.DateTimePicker();
            this.end_date_picker = new System.Windows.Forms.DateTimePicker();
            this.accountLogs = new System.Windows.Forms.ListBox();
            this.reservationsLogs = new System.Windows.Forms.ListBox();
            this.reservationLogLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metricsLogs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Generate_Report_Button
            // 
            this.Generate_Report_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Generate_Report_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_Report_Button.Location = new System.Drawing.Point(628, 393);
            this.Generate_Report_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Generate_Report_Button.Name = "Generate_Report_Button";
            this.Generate_Report_Button.Size = new System.Drawing.Size(130, 65);
            this.Generate_Report_Button.TabIndex = 7;
            this.Generate_Report_Button.Text = "Generate Report";
            this.Generate_Report_Button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "End Date";
            // 
            // Start_date_label
            // 
            this.Start_date_label.AutoSize = true;
            this.Start_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_date_label.Location = new System.Drawing.Point(11, 111);
            this.Start_date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Start_date_label.Name = "Start_date_label";
            this.Start_date_label.Size = new System.Drawing.Size(93, 20);
            this.Start_date_label.TabIndex = 5;
            this.Start_date_label.Text = "Start Date";
            // 
            // back_menu_button
            // 
            this.back_menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_menu_button.Location = new System.Drawing.Point(11, 11);
            this.back_menu_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_menu_button.Name = "back_menu_button";
            this.back_menu_button.Size = new System.Drawing.Size(118, 55);
            this.back_menu_button.TabIndex = 11;
            this.back_menu_button.Text = "Back to Menu";
            this.back_menu_button.UseVisualStyleBackColor = true;
            // 
            // start_date_picker
            // 
            this.start_date_picker.CustomFormat = "MM-dd-yyyy";
            this.start_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_date_picker.Location = new System.Drawing.Point(11, 133);
            this.start_date_picker.Margin = new System.Windows.Forms.Padding(2);
            this.start_date_picker.Name = "start_date_picker";
            this.start_date_picker.Size = new System.Drawing.Size(118, 20);
            this.start_date_picker.TabIndex = 14;
            // 
            // end_date_picker
            // 
            this.end_date_picker.CustomFormat = "MM-dd-yyyy";
            this.end_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date_picker.Location = new System.Drawing.Point(11, 191);
            this.end_date_picker.Margin = new System.Windows.Forms.Padding(2);
            this.end_date_picker.Name = "end_date_picker";
            this.end_date_picker.Size = new System.Drawing.Size(118, 20);
            this.end_date_picker.TabIndex = 13;
            // 
            // accountLogs
            // 
            this.accountLogs.FormattingEnabled = true;
            this.accountLogs.Location = new System.Drawing.Point(151, 111);
            this.accountLogs.Name = "accountLogs";
            this.accountLogs.Size = new System.Drawing.Size(190, 199);
            this.accountLogs.TabIndex = 15;
            // 
            // reservationsLogs
            // 
            this.reservationsLogs.FormattingEnabled = true;
            this.reservationsLogs.Location = new System.Drawing.Point(359, 111);
            this.reservationsLogs.Name = "reservationsLogs";
            this.reservationsLogs.Size = new System.Drawing.Size(190, 199);
            this.reservationsLogs.TabIndex = 16;
            this.reservationsLogs.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // reservationLogLabel
            // 
            this.reservationLogLabel.AutoSize = true;
            this.reservationLogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationLogLabel.Location = new System.Drawing.Point(147, 88);
            this.reservationLogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reservationLogLabel.Name = "reservationLogLabel";
            this.reservationLogLabel.Size = new System.Drawing.Size(75, 20);
            this.reservationLogLabel.TabIndex = 17;
            this.reservationLogLabel.Text = "Account";
            this.reservationLogLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Reservations";
            // 
            // metricsLogs
            // 
            this.metricsLogs.FormattingEnabled = true;
            this.metricsLogs.Location = new System.Drawing.Point(568, 111);
            this.metricsLogs.Name = "metricsLogs";
            this.metricsLogs.Size = new System.Drawing.Size(190, 199);
            this.metricsLogs.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Metrics";
            // 
            // Display_Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metricsLogs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reservationLogLabel);
            this.Controls.Add(this.reservationsLogs);
            this.Controls.Add(this.accountLogs);
            this.Controls.Add(this.start_date_picker);
            this.Controls.Add(this.end_date_picker);
            this.Controls.Add(this.back_menu_button);
            this.Controls.Add(this.Generate_Report_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start_date_label);
            this.Name = "Display_Logs";
            this.Text = "Display_Logs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate_Report_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Start_date_label;
        private System.Windows.Forms.Button back_menu_button;
        private System.Windows.Forms.DateTimePicker start_date_picker;
        private System.Windows.Forms.DateTimePicker end_date_picker;
        private System.Windows.Forms.ListBox accountLogs;
        private System.Windows.Forms.ListBox reservationsLogs;
        private System.Windows.Forms.Label reservationLogLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox metricsLogs;
        private System.Windows.Forms.Label label2;
    }
}