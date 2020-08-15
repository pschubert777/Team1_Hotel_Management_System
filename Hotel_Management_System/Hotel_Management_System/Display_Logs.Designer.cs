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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // start_date_picker
            // 
            this.start_date_picker.CustomFormat = "yyyy-MM-dd";
            this.start_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_date_picker.Location = new System.Drawing.Point(11, 119);
            this.start_date_picker.Margin = new System.Windows.Forms.Padding(2);
            this.start_date_picker.Name = "start_date_picker";
            this.start_date_picker.Size = new System.Drawing.Size(177, 20);
            this.start_date_picker.TabIndex = 18;
            // 
            // end_date_picker
            // 
            this.end_date_picker.CustomFormat = "yyyy-MM-dd";
            this.end_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date_picker.Location = new System.Drawing.Point(11, 172);
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
            this.label1.Location = new System.Drawing.Point(11, 150);
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
            this.Start_date_label.Location = new System.Drawing.Point(11, 97);
            this.Start_date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Start_date_label.Name = "Start_date_label";
            this.Start_date_label.Size = new System.Drawing.Size(93, 20);
            this.Start_date_label.TabIndex = 13;
            this.Start_date_label.Text = "Start Date";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(474, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 238);
            this.listBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Reservation Logs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Account Logs";
            // 
            // logResults
            // 
            this.logResults.FormattingEnabled = true;
            this.logResults.Location = new System.Drawing.Point(216, 97);
            this.logResults.Name = "logResults";
            this.logResults.Size = new System.Drawing.Size(238, 238);
            this.logResults.TabIndex = 21;
            this.logResults.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Display_Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.start_date_picker);
            this.Controls.Add(this.end_date_picker);
            this.Controls.Add(this.back_menu_button);
            this.Controls.Add(this.Generate_Report_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start_date_label);
            this.Name = "Display_Logs";
            this.Text = "Display_Log";
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox logResults;
    }
}