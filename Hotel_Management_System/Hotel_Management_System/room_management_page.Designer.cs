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
            this.hotelLabel = new System.Windows.Forms.Label();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.roomListLabel = new System.Windows.Forms.Label();
            this.roomNumberBox = new System.Windows.Forms.NumericUpDown();
            this.roomListBox = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.hotelBox = new System.Windows.Forms.ComboBox();
            this.roomTypeBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomListBox)).BeginInit();
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
            // hotelLabel
            // 
            this.hotelLabel.AutoSize = true;
            this.hotelLabel.Location = new System.Drawing.Point(92, 268);
            this.hotelLabel.Name = "hotelLabel";
            this.hotelLabel.Size = new System.Drawing.Size(32, 13);
            this.hotelLabel.TabIndex = 9;
            this.hotelLabel.Text = "Hotel";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Location = new System.Drawing.Point(62, 220);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(62, 13);
            this.roomTypeLabel.TabIndex = 10;
            this.roomTypeLabel.Text = "Room Type";
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(79, 174);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(45, 13);
            this.roomNumberLabel.TabIndex = 11;
            this.roomNumberLabel.Text = "Room #";
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
            this.roomNumberBox.Location = new System.Drawing.Point(130, 172);
            this.roomNumberBox.Name = "roomNumberBox";
            this.roomNumberBox.Size = new System.Drawing.Size(80, 20);
            this.roomNumberBox.TabIndex = 18;
            this.roomNumberBox.ValueChanged += new System.EventHandler(this.roomNumberBox_ValueChanged);
            // 
            // roomListBox
            // 
            this.roomListBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomListBox.Location = new System.Drawing.Point(352, 138);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(371, 207);
            this.roomListBox.TabIndex = 19;
            this.roomListBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomListBox_CellContentClick);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(649, 424);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 48);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Back to Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // hotelBox
            // 
            this.hotelBox.FormattingEnabled = true;
            this.hotelBox.Location = new System.Drawing.Point(130, 265);
            this.hotelBox.Name = "hotelBox";
            this.hotelBox.Size = new System.Drawing.Size(165, 21);
            this.hotelBox.TabIndex = 21;
            this.hotelBox.SelectedIndexChanged += new System.EventHandler(this.hotelBox_SelectedIndexChanged);
            // 
            // roomTypeBox
            // 
            this.roomTypeBox.FormattingEnabled = true;
            this.roomTypeBox.Location = new System.Drawing.Point(130, 217);
            this.roomTypeBox.Name = "roomTypeBox";
            this.roomTypeBox.Size = new System.Drawing.Size(121, 21);
            this.roomTypeBox.TabIndex = 22;
            this.roomTypeBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeBox_SelectedIndexChanged);
            // 
            // room_management_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 484);
            this.Controls.Add(this.roomTypeBox);
            this.Controls.Add(this.hotelBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.roomListBox);
            this.Controls.Add(this.roomNumberBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.hotelLabel);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.roomListLabel);
            this.Name = "room_management_page";
            this.Text = "room_management_page";
            ((System.ComponentModel.ISupportInitialize)(this.roomNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomListBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label hotelLabel;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Label roomListLabel;
        private System.Windows.Forms.NumericUpDown roomNumberBox;
        private System.Windows.Forms.DataGridView roomListBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox hotelBox;
        private System.Windows.Forms.ComboBox roomTypeBox;
    }
}