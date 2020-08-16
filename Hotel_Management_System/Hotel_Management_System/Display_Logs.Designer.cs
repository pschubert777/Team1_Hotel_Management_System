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
            this.start_date_picker = new System.Windows.Forms.DateTimePicker();
            this.end_date_picker = new System.Windows.Forms.DateTimePicker();
            this.back_menu_button = new System.Windows.Forms.Button();
            this.Generate_Report_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_date_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userInfo = new System.Windows.Forms.Label();
            this.ActionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.logResults = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // start_date_picker
            // 
            this.start_date_picker.CustomFormat = "yyyy-MM-dd";
            this.start_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_date_picker.Location = new System.Drawing.Point(11, 116);
            this.start_date_picker.Margin = new System.Windows.Forms.Padding(2);
            this.start_date_picker.Name = "start_date_picker";
            this.start_date_picker.Size = new System.Drawing.Size(177, 20);
            this.start_date_picker.TabIndex = 18;
            // 
            // end_date_picker
            // 
            this.end_date_picker.CustomFormat = "yyyy-MM-dd";
            this.end_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date_picker.Location = new System.Drawing.Point(11, 160);
            this.end_date_picker.Margin = new System.Windows.Forms.Padding(2);
            this.end_date_picker.Name = "end_date_picker";
            this.end_date_picker.Size = new System.Drawing.Size(177, 20);
            this.end_date_picker.TabIndex = 17;
            // 
            // back_menu_button
            // 
            this.back_menu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_menu_button.Location = new System.Drawing.Point(11, 11);
            this.back_menu_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_menu_button.Name = "back_menu_button";
            this.back_menu_button.Size = new System.Drawing.Size(118, 55);
            this.back_menu_button.TabIndex = 16;
            this.back_menu_button.Text = "Back to Menu";
            this.back_menu_button.UseVisualStyleBackColor = true;
            this.back_menu_button.Click += new System.EventHandler(this.back_menu_button_Click);
            // 
            // Generate_Report_Button
            // 
            this.Generate_Report_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Generate_Report_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_Report_Button.Location = new System.Drawing.Point(647, 368);
            this.Generate_Report_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Generate_Report_Button.Name = "Generate_Report_Button";
            this.Generate_Report_Button.Size = new System.Drawing.Size(130, 65);
            this.Generate_Report_Button.TabIndex = 15;
            this.Generate_Report_Button.Text = "Generate Report";
            this.Generate_Report_Button.UseVisualStyleBackColor = false;
            this.Generate_Report_Button.Click += new System.EventHandler(this.Generate_Report_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "End Date";
            // 
            // Start_date_label
            // 
            this.Start_date_label.AutoSize = true;
            this.Start_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_date_label.Location = new System.Drawing.Point(11, 94);
            this.Start_date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Start_date_label.Name = "Start_date_label";
            this.Start_date_label.Size = new System.Drawing.Size(93, 20);
            this.Start_date_label.TabIndex = 13;
            this.Start_date_label.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Logs";
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfo.Location = new System.Drawing.Point(212, 9);
            this.userInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(76, 20);
            this.userInfo.TabIndex = 24;
            this.userInfo.Text = "userInfo";
            // 
            // ActionDate
            // 
            this.ActionDate.Text = "Action Date";
            this.ActionDate.Width = 136;
            // 
            // ActionType
            // 
            this.ActionType.Text = "Action Type";
            this.ActionType.Width = 424;
            // 
            // logResults
            // 
            this.logResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ActionDate,
            this.ActionType});
            this.logResults.HideSelection = false;
            this.logResults.Location = new System.Drawing.Point(216, 117);
            this.logResults.Name = "logResults";
            this.logResults.Size = new System.Drawing.Size(561, 246);
            this.logResults.TabIndex = 23;
            this.logResults.UseCompatibleStateImageBehavior = false;
            this.logResults.View = System.Windows.Forms.View.Details;
            // 
            // Display_Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.logResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start_date_picker);
            this.Controls.Add(this.end_date_picker);
            this.Controls.Add(this.back_menu_button);
            this.Controls.Add(this.Generate_Report_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start_date_label);
            this.Name = "Display_Logs";
            this.Text = "Display_Log";
            this.Load += new System.EventHandler(this.Display_Logs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker start_date_picker;
        private System.Windows.Forms.DateTimePicker end_date_picker;
        private System.Windows.Forms.Button back_menu_button;
        private System.Windows.Forms.Button Generate_Report_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Start_date_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userInfo;
        private System.Windows.Forms.ColumnHeader ActionDate;
        private System.Windows.Forms.ColumnHeader ActionType;
        private System.Windows.Forms.ListView logResults;
    }
}