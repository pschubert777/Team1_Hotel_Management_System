namespace Hotel_Management_System
{
    partial class check_in_out_page
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
            this.searchReservationLabel = new System.Windows.Forms.Label();
            this.checkInOutLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.reservationIdLabel = new System.Windows.Forms.Label();
            this.reservationIdBox = new System.Windows.Forms.TextBox();
            this.checkInOutStatusBox = new System.Windows.Forms.ComboBox();
            this.statusSubmitButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.DataGridView();
            this.reservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checked_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checked_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchReservationLabel
            // 
            this.searchReservationLabel.AutoSize = true;
            this.searchReservationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchReservationLabel.Location = new System.Drawing.Point(1356, 597);
            this.searchReservationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.searchReservationLabel.Name = "searchReservationLabel";
            this.searchReservationLabel.Size = new System.Drawing.Size(394, 39);
            this.searchReservationLabel.TabIndex = 0;
            this.searchReservationLabel.Text = "Search for Reservation";
            // 
            // checkInOutLabel
            // 
            this.checkInOutLabel.AutoSize = true;
            this.checkInOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInOutLabel.Location = new System.Drawing.Point(174, 288);
            this.checkInOutLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.checkInOutLabel.Name = "checkInOutLabel";
            this.checkInOutLabel.Size = new System.Drawing.Size(365, 39);
            this.checkInOutLabel.TabIndex = 0;
            this.checkInOutLabel.Text = "Check In / Check Out";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(974, 150);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(248, 39);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "Search Result";
            // 
            // reservationIdLabel
            // 
            this.reservationIdLabel.AutoSize = true;
            this.reservationIdLabel.Location = new System.Drawing.Point(1228, 672);
            this.reservationIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.reservationIdLabel.Name = "reservationIdLabel";
            this.reservationIdLabel.Size = new System.Drawing.Size(150, 25);
            this.reservationIdLabel.TabIndex = 1;
            this.reservationIdLabel.Text = "Reservation Id";
            // 
            // reservationIdBox
            // 
            this.reservationIdBox.Location = new System.Drawing.Point(1426, 666);
            this.reservationIdBox.Margin = new System.Windows.Forms.Padding(6);
            this.reservationIdBox.Name = "reservationIdBox";
            this.reservationIdBox.Size = new System.Drawing.Size(324, 31);
            this.reservationIdBox.TabIndex = 2;
            this.reservationIdBox.TextChanged += new System.EventHandler(this.reservationIdBox_TextChanged);
            // 
            // checkInOutStatusBox
            // 
            this.checkInOutStatusBox.FormattingEnabled = true;
            this.checkInOutStatusBox.Items.AddRange(new object[] {
            "Check In",
            "Check Out"});
            this.checkInOutStatusBox.Location = new System.Drawing.Point(250, 371);
            this.checkInOutStatusBox.Margin = new System.Windows.Forms.Padding(6);
            this.checkInOutStatusBox.Name = "checkInOutStatusBox";
            this.checkInOutStatusBox.Size = new System.Drawing.Size(238, 33);
            this.checkInOutStatusBox.TabIndex = 3;
            this.checkInOutStatusBox.SelectedIndexChanged += new System.EventHandler(this.checkInOutStatusBox_SelectedIndexChanged);
            // 
            // statusSubmitButton
            // 
            this.statusSubmitButton.Location = new System.Drawing.Point(298, 423);
            this.statusSubmitButton.Margin = new System.Windows.Forms.Padding(6);
            this.statusSubmitButton.Name = "statusSubmitButton";
            this.statusSubmitButton.Size = new System.Drawing.Size(150, 44);
            this.statusSubmitButton.TabIndex = 5;
            this.statusSubmitButton.Text = "Submit";
            this.statusSubmitButton.UseVisualStyleBackColor = true;
            this.statusSubmitButton.Click += new System.EventHandler(this.statusSubmitButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(24, 23);
            this.returnButton.Margin = new System.Windows.Forms.Padding(6);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(220, 92);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return to Menu";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationID,
            this.startDate,
            this.endDate,
            this.checked_in,
            this.checked_out});
            this.resultsBox.Location = new System.Drawing.Point(732, 198);
            this.resultsBox.Margin = new System.Windows.Forms.Padding(6);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.RowHeadersWidth = 82;
            this.resultsBox.Size = new System.Drawing.Size(1018, 340);
            this.resultsBox.TabIndex = 6;
            this.resultsBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsBox_CellContentClick);
            // 
            // reservationID
            // 
            this.reservationID.DataPropertyName = "Id";
            this.reservationID.HeaderText = "Reservation ID";
            this.reservationID.MinimumWidth = 10;
            this.reservationID.Name = "reservationID";
            this.reservationID.Width = 200;
            // 
            // startDate
            // 
            this.startDate.DataPropertyName = "Start_date";
            this.startDate.HeaderText = "Start Date";
            this.startDate.MinimumWidth = 10;
            this.startDate.Name = "startDate";
            this.startDate.Width = 200;
            // 
            // endDate
            // 
            this.endDate.DataPropertyName = "End_date";
            this.endDate.HeaderText = "End Date";
            this.endDate.MinimumWidth = 10;
            this.endDate.Name = "endDate";
            this.endDate.Width = 200;
            // 
            // checked_in
            // 
            this.checked_in.DataPropertyName = "Check_in";
            this.checked_in.HeaderText = "Checked In";
            this.checked_in.MinimumWidth = 10;
            this.checked_in.Name = "checked_in";
            this.checked_in.Width = 200;
            // 
            // checked_out
            // 
            this.checked_out.DataPropertyName = "Check_out";
            this.checked_out.HeaderText = "Checked Out";
            this.checked_out.MinimumWidth = 10;
            this.checked_out.Name = "checked_out";
            this.checked_out.Width = 200;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1516, 731);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 44);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // check_in_out_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1830, 969);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.statusSubmitButton);
            this.Controls.Add(this.checkInOutStatusBox);
            this.Controls.Add(this.reservationIdBox);
            this.Controls.Add(this.reservationIdLabel);
            this.Controls.Add(this.checkInOutLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.searchReservationLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "check_in_out_page";
            this.Text = "check_in_out_page";
            ((System.ComponentModel.ISupportInitialize)(this.resultsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchReservationLabel;
        private System.Windows.Forms.Label checkInOutLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label reservationIdLabel;
        private System.Windows.Forms.TextBox reservationIdBox;
        private System.Windows.Forms.ComboBox checkInOutStatusBox;
        private System.Windows.Forms.Button statusSubmitButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.DataGridView resultsBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn checked_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn checked_out;
    }
}