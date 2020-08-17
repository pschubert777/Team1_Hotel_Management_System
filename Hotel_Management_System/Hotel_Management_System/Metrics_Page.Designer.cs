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
            this.Start_date_label.Location = new System.Drawing.Point(163, 75);
            this.Start_date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Start_date_label.Name = "Start_date_label";
            this.Start_date_label.Size = new System.Drawing.Size(93, 20);
            this.Start_date_label.TabIndex = 2;
            this.Start_date_label.Text = "Start Date";
            this.Start_date_label.Click += new System.EventHandler(this.Start_date_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "End Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Generate_Report_Button
            // 
            this.Generate_Report_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Generate_Report_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_Report_Button.Location = new System.Drawing.Point(630, 357);
            this.Generate_Report_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Generate_Report_Button.Name = "Generate_Report_Button";
            this.Generate_Report_Button.Size = new System.Drawing.Size(130, 65);
            this.Generate_Report_Button.TabIndex = 4;
            this.Generate_Report_Button.Text = "Generate Report";
            this.Generate_Report_Button.UseVisualStyleBackColor = false;
            this.Generate_Report_Button.Click += new System.EventHandler(this.Generate_Report_Button_Click);
            // 
            // Rewards_summary_button
            // 
            this.Rewards_summary_button.AutoSize = true;
            this.Rewards_summary_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rewards_summary_button.Location = new System.Drawing.Point(553, 152);
            this.Rewards_summary_button.Margin = new System.Windows.Forms.Padding(2);
            this.Rewards_summary_button.Name = "Rewards_summary_button";
            this.Rewards_summary_button.Size = new System.Drawing.Size(176, 24);
            this.Rewards_summary_button.TabIndex = 5;
            this.Rewards_summary_button.TabStop = true;
            this.Rewards_summary_button.Text = "Rewards Summary";
            this.Rewards_summary_button.UseVisualStyleBackColor = true;
            // 
            // Customer_Report_button
            // 
            this.Customer_Report_button.AutoSize = true;
            this.Customer_Report_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Report_button.Location = new System.Drawing.Point(553, 242);
            this.Customer_Report_button.Margin = new System.Windows.Forms.Padding(2);
            this.Customer_Report_button.Name = "Customer_Report_button";
            this.Customer_Report_button.Size = new System.Drawing.Size(164, 24);
            this.Customer_Report_button.TabIndex = 6;
            this.Customer_Report_button.TabStop = true;
            this.Customer_Report_button.Text = "Customer Report";
            this.Customer_Report_button.UseVisualStyleBackColor = true;
            // 
            // Occupancy_Summary_button
            // 
            this.Occupancy_Summary_button.AutoSize = true;
            this.Occupancy_Summary_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Occupancy_Summary_button.Location = new System.Drawing.Point(553, 200);
            this.Occupancy_Summary_button.Margin = new System.Windows.Forms.Padding(2);
            this.Occupancy_Summary_button.Name = "Occupancy_Summary_button";
            this.Occupancy_Summary_button.Size = new System.Drawing.Size(194, 24);
            this.Occupancy_Summary_button.TabIndex = 7;
            this.Occupancy_Summary_button.TabStop = true;
            this.Occupancy_Summary_button.Text = "Occupancy Summary";
            this.Occupancy_Summary_button.UseVisualStyleBackColor = true;
            // 
            // back_menu_button
            // 
            this.back_menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_menu_button.Location = new System.Drawing.Point(6, 6);
            this.back_menu_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_menu_button.Name = "back_menu_button";
            this.back_menu_button.Size = new System.Drawing.Size(118, 55);
            this.back_menu_button.TabIndex = 10;
            this.back_menu_button.Text = "Back to Menu";
            this.back_menu_button.UseVisualStyleBackColor = true;
            this.back_menu_button.Click += new System.EventHandler(this.back_menu_button_Click);
            // 
            // end_date_picker
            // 
            this.end_date_picker.CustomFormat = "yyyy-MM-dd";
            this.end_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date_picker.Location = new System.Drawing.Point(332, 120);
            this.end_date_picker.Margin = new System.Windows.Forms.Padding(2);
            this.end_date_picker.Name = "end_date_picker";
            this.end_date_picker.Size = new System.Drawing.Size(177, 20);
            this.end_date_picker.TabIndex = 11;
            this.end_date_picker.ValueChanged += new System.EventHandler(this.end_date_picker_ValueChanged);
            // 
            // start_date_picker
            // 
            this.start_date_picker.CustomFormat = "yyyy-MM-dd";
            this.start_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_date_picker.Location = new System.Drawing.Point(120, 120);
            this.start_date_picker.Margin = new System.Windows.Forms.Padding(2);
            this.start_date_picker.Name = "start_date_picker";
            this.start_date_picker.Size = new System.Drawing.Size(177, 20);
            this.start_date_picker.TabIndex = 12;
            this.start_date_picker.ValueChanged += new System.EventHandler(this.start_date_picker_ValueChanged);
            // 
            // Metrics_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(776, 484);
            this.Controls.Add(this.start_date_picker);
            this.Controls.Add(this.end_date_picker);
            this.Controls.Add(this.back_menu_button);
            this.Controls.Add(this.Occupancy_Summary_button);
            this.Controls.Add(this.Customer_Report_button);
            this.Controls.Add(this.Rewards_summary_button);
            this.Controls.Add(this.Generate_Report_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start_date_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Metrics_Page";
            this.Text = "B";
            this.Load += new System.EventHandler(this.Metrics_Page_Load);
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

