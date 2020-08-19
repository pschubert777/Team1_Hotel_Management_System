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
            this.Maintenance_label = new System.Windows.Forms.Label();
            this.maintenance_combo_box = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maintenance_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxGuests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomListBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(200, 368);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(86, 368);
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
            this.roomListBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Room_number,
            this.roomType,
            this.hotelID,
            this.Maintenance_status,
            this.maxGuests});
            this.roomListBox.Location = new System.Drawing.Point(352, 138);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.ReadOnly = true;
            this.roomListBox.RowHeadersWidth = 82;
            this.roomListBox.Size = new System.Drawing.Size(371, 207);
            this.roomListBox.TabIndex = 19;
            this.roomListBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomListBox_CellContentClick);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 48);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Return to Menu";
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
            // Maintenance_label
            // 
            this.Maintenance_label.AutoSize = true;
            this.Maintenance_label.Location = new System.Drawing.Point(20, 316);
            this.Maintenance_label.Name = "Maintenance_label";
            this.Maintenance_label.Size = new System.Drawing.Size(102, 13);
            this.Maintenance_label.TabIndex = 23;
            this.Maintenance_label.Text = "Maintenance Status";
            // 
            // maintenance_combo_box
            // 
            this.maintenance_combo_box.FormattingEnabled = true;
            this.maintenance_combo_box.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.maintenance_combo_box.Location = new System.Drawing.Point(130, 311);
            this.maintenance_combo_box.Name = "maintenance_combo_box";
            this.maintenance_combo_box.Size = new System.Drawing.Size(165, 21);
            this.maintenance_combo_box.TabIndex = 24;
            this.maintenance_combo_box.SelectedIndexChanged += new System.EventHandler(this.maintenance_combo_box_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Room ID";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 200;
            // 
            // Room_number
            // 
            this.Room_number.DataPropertyName = "Room_number";
            this.Room_number.HeaderText = "Room Number";
            this.Room_number.MinimumWidth = 10;
            this.Room_number.Name = "Room_number";
            this.Room_number.ReadOnly = true;
            this.Room_number.Width = 200;
            // 
            // roomType
            // 
            this.roomType.DataPropertyName = "Room_type";
            this.roomType.HeaderText = "Room Type";
            this.roomType.MinimumWidth = 10;
            this.roomType.Name = "roomType";
            this.roomType.ReadOnly = true;
            this.roomType.Width = 200;
            // 
            // hotelID
            // 
            this.hotelID.DataPropertyName = "Hotel_id";
            this.hotelID.HeaderText = "Hotel ID";
            this.hotelID.MinimumWidth = 10;
            this.hotelID.Name = "hotelID";
            this.hotelID.ReadOnly = true;
            this.hotelID.Width = 200;
            // 
            // Maintenance_status
            // 
            this.Maintenance_status.DataPropertyName = "Maintenance_status";
            this.Maintenance_status.HeaderText = "Maintenance Status";
            this.Maintenance_status.MinimumWidth = 10;
            this.Maintenance_status.Name = "Maintenance_status";
            this.Maintenance_status.ReadOnly = true;
            this.Maintenance_status.Width = 200;
            // 
            // maxGuests
            // 
            this.maxGuests.DataPropertyName = "Num_guests_max";
            this.maxGuests.HeaderText = "Max Guests";
            this.maxGuests.MinimumWidth = 10;
            this.maxGuests.Name = "maxGuests";
            this.maxGuests.ReadOnly = true;
            this.maxGuests.Width = 200;
            // 
            // room_management_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(776, 484);
            this.Controls.Add(this.maintenance_combo_box);
            this.Controls.Add(this.Maintenance_label);
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
        private System.Windows.Forms.Label Maintenance_label;
        private System.Windows.Forms.ComboBox maintenance_combo_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maintenance_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxGuests;
    }
}