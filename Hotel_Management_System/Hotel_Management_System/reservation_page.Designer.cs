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
            this.ReservationDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGuestsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelLocationBox
            // 
            this.hotelLocationBox.FormattingEnabled = true;
            this.hotelLocationBox.Items.AddRange(new object[] {
            "testItem",
            "testItem_2"});
            this.hotelLocationBox.Location = new System.Drawing.Point(300, 350);
            this.hotelLocationBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hotelLocationBox.Name = "hotelLocationBox";
            this.hotelLocationBox.Size = new System.Drawing.Size(320, 33);
            this.hotelLocationBox.TabIndex = 3;
            this.hotelLocationBox.SelectedIndexChanged += new System.EventHandler(this.hotelLocationBox_SelectedIndexChanged);
            // 
            // roomTypeBox
            // 
            this.roomTypeBox.FormattingEnabled = true;
            this.roomTypeBox.Items.AddRange(new object[] {
            "testItem",
            "testItem2"});
            this.roomTypeBox.Location = new System.Drawing.Point(300, 413);
            this.roomTypeBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.roomTypeBox.Name = "roomTypeBox";
            this.roomTypeBox.Size = new System.Drawing.Size(280, 33);
            this.roomTypeBox.TabIndex = 4;
            this.roomTypeBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeBox_SelectedIndexChanged);
            // 
            // creditCardNumberBox
            // 
            this.creditCardNumberBox.Location = new System.Drawing.Point(300, 546);
            this.creditCardNumberBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.creditCardNumberBox.Name = "creditCardNumberBox";
            this.creditCardNumberBox.Size = new System.Drawing.Size(354, 31);
            this.creditCardNumberBox.TabIndex = 6;
            this.creditCardNumberBox.TextChanged += new System.EventHandler(this.creditCardNumberBox_TextChanged);
            // 
            // currentReservationsLabel
            // 
            this.currentReservationsLabel.AutoSize = true;
            this.currentReservationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentReservationsLabel.Location = new System.Drawing.Point(972, 79);
            this.currentReservationsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentReservationsLabel.Name = "currentReservationsLabel";
            this.currentReservationsLabel.Size = new System.Drawing.Size(366, 39);
            this.currentReservationsLabel.TabIndex = 4;
            this.currentReservationsLabel.Text = "Current Reservations";
            // 
            // reservationSearchLabel
            // 
            this.reservationSearchLabel.AutoSize = true;
            this.reservationSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationSearchLabel.Location = new System.Drawing.Point(948, 575);
            this.reservationSearchLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.reservationSearchLabel.Name = "reservationSearchLabel";
            this.reservationSearchLabel.Size = new System.Drawing.Size(413, 39);
            this.reservationSearchLabel.TabIndex = 4;
            this.reservationSearchLabel.Text = "Search for Reservations";
            // 
            // reservationIdLabel
            // 
            this.reservationIdLabel.AutoSize = true;
            this.reservationIdLabel.Location = new System.Drawing.Point(870, 671);
            this.reservationIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.reservationIdLabel.Name = "reservationIdLabel";
            this.reservationIdLabel.Size = new System.Drawing.Size(153, 25);
            this.reservationIdLabel.TabIndex = 7;
            this.reservationIdLabel.Text = "Reservation ID";
            // 
            // reservationIdBox
            // 
            this.reservationIdBox.Location = new System.Drawing.Point(1038, 665);
            this.reservationIdBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.reservationIdBox.Name = "reservationIdBox";
            this.reservationIdBox.Size = new System.Drawing.Size(358, 31);
            this.reservationIdBox.TabIndex = 10;
            this.reservationIdBox.TextChanged += new System.EventHandler(this.reservationIdBox_TextChanged);
            // 
            // submitUpdateButton
            // 
            this.submitUpdateButton.Location = new System.Drawing.Point(270, 617);
            this.submitUpdateButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.submitUpdateButton.Name = "submitUpdateButton";
            this.submitUpdateButton.Size = new System.Drawing.Size(206, 44);
            this.submitUpdateButton.TabIndex = 7;
            this.submitUpdateButton.Text = "Submit / Update";
            this.submitUpdateButton.UseVisualStyleBackColor = true;
            this.submitUpdateButton.Click += new System.EventHandler(this.submitUpdateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(508, 617);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 44);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // reservationSearchButton
            // 
            this.reservationSearchButton.Location = new System.Drawing.Point(1134, 731);
            this.reservationSearchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.reservationSearchButton.Name = "reservationSearchButton";
            this.reservationSearchButton.Size = new System.Drawing.Size(150, 44);
            this.reservationSearchButton.TabIndex = 11;
            this.reservationSearchButton.Text = "Search";
            this.reservationSearchButton.UseVisualStyleBackColor = true;
            this.reservationSearchButton.Click += new System.EventHandler(this.reservationSearchButton_Click);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(178, 223);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(108, 25);
            this.startDateLabel.TabIndex = 9;
            this.startDateLabel.Text = "Start Date";
            // 
            // hotelLocationLabel
            // 
            this.hotelLocationLabel.AutoSize = true;
            this.hotelLocationLabel.Location = new System.Drawing.Point(136, 356);
            this.hotelLocationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.hotelLocationLabel.Name = "hotelLocationLabel";
            this.hotelLocationLabel.Size = new System.Drawing.Size(150, 25);
            this.hotelLocationLabel.TabIndex = 9;
            this.hotelLocationLabel.Text = "Hotel Location";
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Location = new System.Drawing.Point(164, 419);
            this.roomTypeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(122, 25);
            this.roomTypeLabel.TabIndex = 9;
            this.roomTypeLabel.Text = "Room Type";
            // 
            // numberOfGuestsLabel
            // 
            this.numberOfGuestsLabel.AutoSize = true;
            this.numberOfGuestsLabel.Location = new System.Drawing.Point(104, 487);
            this.numberOfGuestsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numberOfGuestsLabel.Name = "numberOfGuestsLabel";
            this.numberOfGuestsLabel.Size = new System.Drawing.Size(185, 25);
            this.numberOfGuestsLabel.TabIndex = 9;
            this.numberOfGuestsLabel.Text = "Number of Guests";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(150, 552);
            this.cardNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(139, 25);
            this.cardNumberLabel.TabIndex = 9;
            this.cardNumberLabel.Text = "Credit Card #";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(184, 290);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(101, 25);
            this.endDateLabel.TabIndex = 9;
            this.endDateLabel.Text = "End Date";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(300, 283);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(388, 31);
            this.endDatePicker.TabIndex = 2;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(300, 215);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(388, 31);
            this.startDatePicker.TabIndex = 1;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // numberOfGuestsBox
            // 
            this.numberOfGuestsBox.Location = new System.Drawing.Point(300, 483);
            this.numberOfGuestsBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numberOfGuestsBox.Name = "numberOfGuestsBox";
            this.numberOfGuestsBox.Size = new System.Drawing.Size(64, 31);
            this.numberOfGuestsBox.TabIndex = 5;
            this.numberOfGuestsBox.ValueChanged += new System.EventHandler(this.numberOfGuestsBox_ValueChanged);
            // 
            // ReservationDataGridView
            // 
            this.ReservationDataGridView.AllowUserToAddRows = false;
            this.ReservationDataGridView.AllowUserToDeleteRows = false;
            this.ReservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationDataGridView.Location = new System.Drawing.Point(827, 145);
            this.ReservationDataGridView.Name = "ReservationDataGridView";
            this.ReservationDataGridView.ReadOnly = true;
            this.ReservationDataGridView.RowHeadersWidth = 82;
            this.ReservationDataGridView.RowTemplate.Height = 33;
            this.ReservationDataGridView.Size = new System.Drawing.Size(657, 395);
            this.ReservationDataGridView.TabIndex = 12;
            // 
            // reservation_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 931);
            this.Controls.Add(this.ReservationDataGridView);
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
            this.Controls.Add(this.reservationSearchLabel);
            this.Controls.Add(this.currentReservationsLabel);
            this.Controls.Add(this.roomTypeBox);
            this.Controls.Add(this.hotelLocationBox);
            this.Controls.Add(this.creditCardNumberBox);
            this.Controls.Add(this.reservationIdBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "reservation_page";
            this.Text = "reservation_page";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGuestsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox hotelLocationBox;
        private System.Windows.Forms.ComboBox roomTypeBox;
        private System.Windows.Forms.TextBox creditCardNumberBox;
        private System.Windows.Forms.Label currentReservationsLabel;
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
        private System.Windows.Forms.DataGridView ReservationDataGridView;
    }
}