namespace Hotel_Management_System
{
    partial class room_management_page
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.hotelBox = new System.Windows.Forms.TextBox();
            this.roomTypeBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.hotelLabel = new System.Windows.Forms.Label();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.roomListLabel = new System.Windows.Forms.Label();
            this.roomNumberBox = new System.Windows.Forms.NumericUpDown();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(199, 322);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(88, 322);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(98, 23);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit / Update";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(174, 278);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(100, 20);
            this.statusBox.TabIndex = 12;
            this.statusBox.TextChanged += new System.EventHandler(this.statusBox_TextChanged);
            // 
            // hotelBox
            // 
            this.hotelBox.Location = new System.Drawing.Point(174, 229);
            this.hotelBox.Name = "hotelBox";
            this.hotelBox.Size = new System.Drawing.Size(100, 20);
            this.hotelBox.TabIndex = 13;
            this.hotelBox.TextChanged += new System.EventHandler(this.hotelBox_TextChanged);
            // 
            // roomTypeBox
            // 
            this.roomTypeBox.Location = new System.Drawing.Point(174, 181);
            this.roomTypeBox.Name = "roomTypeBox";
            this.roomTypeBox.Size = new System.Drawing.Size(100, 20);
            this.roomTypeBox.TabIndex = 14;
            this.roomTypeBox.TextChanged += new System.EventHandler(this.roomTypeBox_TextChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(94, 281);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(74, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Current Status";
            // 
            // hotelLabel
            // 
            this.hotelLabel.AutoSize = true;
            this.hotelLabel.Location = new System.Drawing.Point(136, 232);
            this.hotelLabel.Name = "hotelLabel";
            this.hotelLabel.Size = new System.Drawing.Size(32, 13);
            this.hotelLabel.TabIndex = 9;
            this.hotelLabel.Text = "Hotel";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Location = new System.Drawing.Point(106, 184);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(62, 13);
            this.roomTypeLabel.TabIndex = 10;
            this.roomTypeLabel.Text = "Room Type";
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(123, 138);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(45, 13);
            this.roomNumberLabel.TabIndex = 11;
            this.roomNumberLabel.Text = "Room #";
            // 
            // roomListBox
            // 
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.Location = new System.Drawing.Point(384, 133);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(307, 212);
            this.roomListBox.TabIndex = 7;
            this.roomListBox.SelectedIndexChanged += new System.EventHandler(this.roomListBox_SelectedIndexChanged);
            // 
            // roomListLabel
            // 
            this.roomListLabel.AutoSize = true;
            this.roomListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomListLabel.Location = new System.Drawing.Point(484, 108);
            this.roomListLabel.Name = "roomListLabel";
            this.roomListLabel.Size = new System.Drawing.Size(99, 22);
            this.roomListLabel.TabIndex = 6;
            this.roomListLabel.Text = "Room List";
            // 
            // roomNumberBox
            // 
            this.roomNumberBox.Location = new System.Drawing.Point(174, 136);
            this.roomNumberBox.Name = "roomNumberBox";
            this.roomNumberBox.Size = new System.Drawing.Size(100, 20);
            this.roomNumberBox.TabIndex = 18;
            this.roomNumberBox.ValueChanged += new System.EventHandler(this.roomNumberBox_ValueChanged);
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(78, 46);
            this.btnReturnMenu.TabIndex = 19;
            this.btnReturnMenu.Text = "Return to Menu";
            this.btnReturnMenu.UseVisualStyleBackColor = true;
            this.btnReturnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // room_management_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 484);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.roomNumberBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.hotelBox);
            this.Controls.Add(this.roomTypeBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.hotelLabel);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.roomListBox);
            this.Controls.Add(this.roomListLabel);
            this.Name = "room_management_page";
            this.Text = "room_management_page";
            ((System.ComponentModel.ISupportInitialize)(this.roomNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.TextBox hotelBox;
        private System.Windows.Forms.TextBox roomTypeBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label hotelLabel;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.Label roomListLabel;
        private System.Windows.Forms.NumericUpDown roomNumberBox;
        private System.Windows.Forms.Button btnReturnMenu;
    }
}