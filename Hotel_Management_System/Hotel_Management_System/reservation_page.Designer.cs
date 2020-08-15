namespace Hotel_Management_System
{
    partial class reservation_page
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
            this.hotelLocationBox = new System.Windows.Forms.ComboBox();
            this.roomTypeBox = new System.Windows.Forms.ComboBox();
            this.creditCardNumberBox = new System.Windows.Forms.TextBox();
            this.currentReservationsLabel = new System.Windows.Forms.Label();
            this.reservationListBox = new System.Windows.Forms.ListBox();
            this.reservationSearchLabel = new System.Windows.Forms.Label();
            this.reservationIdLabel = new System.Windows.Forms.Label();
            this.reservationIdBox = new System.Windows.Forms.TextBox();
            this.submitUpdateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.reservationSearchButton = new System.Windows.Forms.Button();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.hotelLocationLabel = new System.Windows.Forms.Label();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.numberOfGuestsLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.numberOfGuestsBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGuestsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelLocationBox
            // 
            this.hotelLocationBox.FormattingEnabled = true;
            this.hotelLocationBox.Items.AddRange(new object[] {
            "testItem",
            "testItem_2"});
            this.hotelLocationBox.Location = new System.Drawing.Point(145, 203);
            this.hotelLocationBox.Name = "hotelLocationBox";
            this.hotelLocationBox.Size = new System.Drawing.Size(162, 21);
            this.hotelLocationBox.TabIndex = 3;
            this.hotelLocationBox.SelectedIndexChanged += new System.EventHandler(this.hotelLocationBox_SelectedIndexChanged);
            // 
            // roomTypeBox
            // 
            this.roomTypeBox.FormattingEnabled = true;
            this.roomTypeBox.Items.AddRange(new object[] {
            "testItem",
            "testItem2"});
            this.roomTypeBox.Location = new System.Drawing.Point(145, 236);
            this.roomTypeBox.Name = "roomTypeBox";
            this.roomTypeBox.Size = new System.Drawing.Size(142, 21);
            this.roomTypeBox.TabIndex = 4;
            this.roomTypeBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeBox_SelectedIndexChanged);
            // 
            // creditCardNumberBox
            // 
            this.creditCardNumberBox.Location = new System.Drawing.Point(145, 305);
            this.creditCardNumberBox.Name = "creditCardNumberBox";
            this.creditCardNumberBox.Size = new System.Drawing.Size(179, 20);
            this.creditCardNumberBox.TabIndex = 6;
            this.creditCardNumberBox.TextChanged += new System.EventHandler(this.creditCardNumberBox_TextChanged);
            // 
            // currentReservationsLabel
            // 
            this.currentReservationsLabel.AutoSize = true;
            this.currentReservationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentReservationsLabel.Location = new System.Drawing.Point(486, 41);
            this.currentReservationsLabel.Name = "currentReservationsLabel";
            this.currentReservationsLabel.Size = new System.Drawing.Size(200, 22);
            this.currentReservationsLabel.TabIndex = 4;
            this.currentReservationsLabel.Text = "Current Reservations";
            // 
            // reservationListBox
            // 
            this.reservationListBox.FormattingEnabled = true;
            this.reservationListBox.Location = new System.Drawing.Point(416, 66);
            this.reservationListBox.Name = "reservationListBox";
            this.reservationListBox.Size = new System.Drawing.Size(336, 199);
            this.reservationListBox.TabIndex = 9;
            // 
            // reservationSearchLabel
            // 
            this.reservationSearchLabel.AutoSize = true;
            this.reservationSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationSearchLabel.Location = new System.Drawing.Point(474, 299);
            this.reservationSearchLabel.Name = "reservationSearchLabel";
            this.reservationSearchLabel.Size = new System.Drawing.Size(226, 22);
            this.reservationSearchLabel.TabIndex = 4;
            this.reservationSearchLabel.Text = "Search for Reservations";
            // 
            // reservationIdLabel
            // 
            this.reservationIdLabel.AutoSize = true;
            this.reservationIdLabel.Location = new System.Drawing.Point(435, 349);
            this.reservationIdLabel.Name = "reservationIdLabel";
            this.reservationIdLabel.Size = new System.Drawing.Size(78, 13);
            this.reservationIdLabel.TabIndex = 7;
            this.reservationIdLabel.Text = "Reservation ID";
            // 
            // reservationIdBox
            // 
            this.reservationIdBox.Location = new System.Drawing.Point(519, 346);
            this.reservationIdBox.Name = "reservationIdBox";
            this.reservationIdBox.Size = new System.Drawing.Size(181, 20);
            this.reservationIdBox.TabIndex = 10;
            this.reservationIdBox.TextChanged += new System.EventHandler(this.reservationIdBox_TextChanged);
            // 
            // submitUpdateButton
            // 
            this.submitUpdateButton.Location = new System.Drawing.Point(130, 342);
            this.submitUpdateButton.Name = "submitUpdateButton";
            this.submitUpdateButton.Size = new System.Drawing.Size(103, 23);
            this.submitUpdateButton.TabIndex = 7;
            this.submitUpdateButton.Text = "Submit / Update";
            this.submitUpdateButton.UseVisualStyleBackColor = true;
            this.submitUpdateButton.Click += new System.EventHandler(this.submitUpdateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(249, 342);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // reservationSearchButton
            // 
            this.reservationSearchButton.Location = new System.Drawing.Point(567, 380);
            this.reservationSearchButton.Name = "reservationSearchButton";
            this.reservationSearchButton.Size = new System.Drawing.Size(75, 23);
            this.reservationSearchButton.TabIndex = 11;
            this.reservationSearchButton.Text = "Search";
            this.reservationSearchButton.UseVisualStyleBackColor = true;
            this.reservationSearchButton.Click += new System.EventHandler(this.reservationSearchButton_Click);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(84, 137);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateLabel.TabIndex = 9;
            this.startDateLabel.Text = "Start Date";
            // 
            // hotelLocationLabel
            // 
            this.hotelLocationLabel.AutoSize = true;
            this.hotelLocationLabel.Location = new System.Drawing.Point(63, 206);
            this.hotelLocationLabel.Name = "hotelLocationLabel";
            this.hotelLocationLabel.Size = new System.Drawing.Size(76, 13);
            this.hotelLocationLabel.TabIndex = 9;
            this.hotelLocationLabel.Text = "Hotel Location";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Location = new System.Drawing.Point(77, 239);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(62, 13);
            this.roomTypeLabel.TabIndex = 9;
            this.roomTypeLabel.Text = "Room Type";
            // 
            // numberOfGuestsLabel
            // 
            this.numberOfGuestsLabel.AutoSize = true;
            this.numberOfGuestsLabel.Location = new System.Drawing.Point(47, 274);
            this.numberOfGuestsLabel.Name = "numberOfGuestsLabel";
            this.numberOfGuestsLabel.Size = new System.Drawing.Size(92, 13);
            this.numberOfGuestsLabel.TabIndex = 9;
            this.numberOfGuestsLabel.Text = "Number of Guests";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(70, 308);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(69, 13);
            this.cardNumberLabel.TabIndex = 9;
            this.cardNumberLabel.Text = "Credit Card #";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(87, 172);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 9;
            this.endDateLabel.Text = "End Date";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(145, 168);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(196, 20);
            this.endDatePicker.TabIndex = 2;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(145, 133);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(196, 20);
            this.startDatePicker.TabIndex = 1;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // numberOfGuestsBox
            // 
            this.numberOfGuestsBox.Location = new System.Drawing.Point(145, 272);
            this.numberOfGuestsBox.Name = "numberOfGuestsBox";
            this.numberOfGuestsBox.Size = new System.Drawing.Size(32, 20);
            this.numberOfGuestsBox.TabIndex = 5;
            // 
            // reservation_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 484);
            this.Controls.Add(this.numberOfGuestsBox);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.numberOfGuestsLabel);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.hotelLocationLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.reservationSearchButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitUpdateButton);
            this.Controls.Add(this.reservationIdLabel);
            this.Controls.Add(this.reservationListBox);
            this.Controls.Add(this.reservationSearchLabel);
            this.Controls.Add(this.currentReservationsLabel);
            this.Controls.Add(this.roomTypeBox);
            this.Controls.Add(this.hotelLocationBox);
            this.Controls.Add(this.creditCardNumberBox);
            this.Controls.Add(this.reservationIdBox);
            this.Name = "reservation_page";
            this.Text = "reservation_page";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGuestsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox hotelLocationBox;
        private System.Windows.Forms.ComboBox roomTypeBox;
        private System.Windows.Forms.TextBox creditCardNumberBox;
        private System.Windows.Forms.Label currentReservationsLabel;
        private System.Windows.Forms.ListBox reservationListBox;
        private System.Windows.Forms.Label reservationSearchLabel;
        private System.Windows.Forms.Label reservationIdLabel;
        private System.Windows.Forms.TextBox reservationIdBox;
        private System.Windows.Forms.Button submitUpdateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button reservationSearchButton;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label hotelLocationLabel;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Label numberOfGuestsLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.NumericUpDown numberOfGuestsBox;
    }
}