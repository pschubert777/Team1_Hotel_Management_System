namespace Hotel_Management_System
{
    partial class Metrics_Page
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
            this.Start_date_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Generate_Report_Button = new System.Windows.Forms.Button();
            this.Rewards_summary_button = new System.Windows.Forms.RadioButton();
            this.Customer_Report_button = new System.Windows.Forms.RadioButton();
            this.Occupancy_Summary_button = new System.Windows.Forms.RadioButton();
            this.back_menu_button = new System.Windows.Forms.Button();
            this.end_date_picker = new System.Windows.Forms.DateTimePicker();
            this.start_date_picker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Start_date_label
            // 
            this.Start_date_label.AutoSize = true;
            this.Start_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_date_label.Location = new System.Drawing.Point(326, 144);
            this.Start_date_label.Name = "Start_date_label";
            this.Start_date_label.Size = new System.Drawing.Size(171, 37);
            this.Start_date_label.TabIndex = 2;
            this.Start_date_label.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(761, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "End Date";
            // 
            // Generate_Report_Button
            // 
            this.Generate_Report_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Generate_Report_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_Report_Button.Location = new System.Drawing.Point(1261, 686);
            this.Generate_Report_Button.Name = "Generate_Report_Button";
            this.Generate_Report_Button.Size = new System.Drawing.Size(259, 125);
            this.Generate_Report_Button.TabIndex = 4;
            this.Generate_Report_Button.Text = "Generate Report";
            this.Generate_Report_Button.UseVisualStyleBackColor = false;
            this.Generate_Report_Button.Click += new System.EventHandler(this.Generate_Report_Button_Click);
            // 
            // Rewards_summary_button
            // 
            this.Rewards_summary_button.AutoSize = true;
            this.Rewards_summary_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rewards_summary_button.Location = new System.Drawing.Point(1106, 292);
            this.Rewards_summary_button.Name = "Rewards_summary_button";
            this.Rewards_summary_button.Size = new System.Drawing.Size(334, 41);
            this.Rewards_summary_button.TabIndex = 5;
            this.Rewards_summary_button.TabStop = true;
            this.Rewards_summary_button.Text = "Rewards Summary";
            this.Rewards_summary_button.UseVisualStyleBackColor = true;
            // 
            // Customer_Report_button
            // 
            this.Customer_Report_button.AutoSize = true;
            this.Customer_Report_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Report_button.Location = new System.Drawing.Point(1106, 466);
            this.Customer_Report_button.Name = "Customer_Report_button";
            this.Customer_Report_button.Size = new System.Drawing.Size(306, 41);
            this.Customer_Report_button.TabIndex = 6;
            this.Customer_Report_button.TabStop = true;
            this.Customer_Report_button.Text = "Customer Report";
            this.Customer_Report_button.UseVisualStyleBackColor = true;
            // 
            // Occupancy_Summary_button
            // 
            this.Occupancy_Summary_button.AutoSize = true;
            this.Occupancy_Summary_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Occupancy_Summary_button.Location = new System.Drawing.Point(1106, 384);
            this.Occupancy_Summary_button.Name = "Occupancy_Summary_button";
            this.Occupancy_Summary_button.Size = new System.Drawing.Size(371, 41);
            this.Occupancy_Summary_button.TabIndex = 7;
            this.Occupancy_Summary_button.TabStop = true;
            this.Occupancy_Summary_button.Text = "Occupancy Summary";
            this.Occupancy_Summary_button.UseVisualStyleBackColor = true;
            // 
            // back_menu_button
            // 
            this.back_menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_menu_button.Location = new System.Drawing.Point(12, 12);
            this.back_menu_button.Name = "back_menu_button";
            this.back_menu_button.Size = new System.Drawing.Size(235, 105);
            this.back_menu_button.TabIndex = 10;
            this.back_menu_button.Text = "Back to Menu";
            this.back_menu_button.UseVisualStyleBackColor = true;
            // 
            // end_date_picker
            // 
            this.end_date_picker.CustomFormat = "MM-dd-yyyy";
            this.end_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date_picker.Location = new System.Drawing.Point(665, 230);
            this.end_date_picker.Name = "end_date_picker";
            this.end_date_picker.Size = new System.Drawing.Size(350, 31);
            this.end_date_picker.TabIndex = 11;
            // 
            // start_date_picker
            // 
            this.start_date_picker.CustomFormat = "MM-dd-yyyy";
            this.start_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_date_picker.Location = new System.Drawing.Point(241, 230);
            this.start_date_picker.Name = "start_date_picker";
            this.start_date_picker.Size = new System.Drawing.Size(350, 31);
            this.start_date_picker.TabIndex = 12;
            // 
            // Metrics_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1552, 930);
            this.Controls.Add(this.start_date_picker);
            this.Controls.Add(this.end_date_picker);
            this.Controls.Add(this.back_menu_button);
            this.Controls.Add(this.Occupancy_Summary_button);
            this.Controls.Add(this.Customer_Report_button);
            this.Controls.Add(this.Rewards_summary_button);
            this.Controls.Add(this.Generate_Report_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start_date_label);
            this.Name = "Metrics_Page";
            this.Text = "Metrics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Start_date_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Generate_Report_Button;
        private System.Windows.Forms.RadioButton Rewards_summary_button;
        private System.Windows.Forms.RadioButton Customer_Report_button;
        private System.Windows.Forms.RadioButton Occupancy_Summary_button;
        private System.Windows.Forms.Button back_menu_button;
        private System.Windows.Forms.DateTimePicker end_date_picker;
        private System.Windows.Forms.DateTimePicker start_date_picker;
    }
}

