namespace Hotel_Management_System
{
    partial class rewards_page
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
            this.rewardsListLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rewardNameLabel = new System.Windows.Forms.Label();
            this.rewardTypeLabel = new System.Windows.Forms.Label();
            this.rewardDetailsLabel = new System.Windows.Forms.Label();
            this.pointAmountLabel = new System.Windows.Forms.Label();
            this.rewardNameBox = new System.Windows.Forms.TextBox();
            this.rewardTypeBox = new System.Windows.Forms.TextBox();
            this.rewardDetailsBox = new System.Windows.Forms.TextBox();
            this.pointAmountBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rewardsListLabel
            // 
            this.rewardsListLabel.AutoSize = true;
            this.rewardsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewardsListLabel.Location = new System.Drawing.Point(473, 94);
            this.rewardsListLabel.Name = "rewardsListLabel";
            this.rewardsListLabel.Size = new System.Drawing.Size(126, 22);
            this.rewardsListLabel.TabIndex = 0;
            this.rewardsListLabel.Text = "Rewards List";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(392, 129);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 212);
            this.listBox1.TabIndex = 1;
            // 
            // rewardNameLabel
            // 
            this.rewardNameLabel.AutoSize = true;
            this.rewardNameLabel.Location = new System.Drawing.Point(89, 134);
            this.rewardNameLabel.Name = "rewardNameLabel";
            this.rewardNameLabel.Size = new System.Drawing.Size(87, 13);
            this.rewardNameLabel.TabIndex = 2;
            this.rewardNameLabel.Text = "Name of Reward";
            // 
            // rewardTypeLabel
            // 
            this.rewardTypeLabel.AutoSize = true;
            this.rewardTypeLabel.Location = new System.Drawing.Point(93, 180);
            this.rewardTypeLabel.Name = "rewardTypeLabel";
            this.rewardTypeLabel.Size = new System.Drawing.Size(83, 13);
            this.rewardTypeLabel.TabIndex = 2;
            this.rewardTypeLabel.Text = "Type of Reward";
            // 
            // rewardDetailsLabel
            // 
            this.rewardDetailsLabel.AutoSize = true;
            this.rewardDetailsLabel.Location = new System.Drawing.Point(97, 228);
            this.rewardDetailsLabel.Name = "rewardDetailsLabel";
            this.rewardDetailsLabel.Size = new System.Drawing.Size(79, 13);
            this.rewardDetailsLabel.TabIndex = 2;
            this.rewardDetailsLabel.Text = "Reward Details";
            // 
            // pointAmountLabel
            // 
            this.pointAmountLabel.AutoSize = true;
            this.pointAmountLabel.Location = new System.Drawing.Point(89, 277);
            this.pointAmountLabel.Name = "pointAmountLabel";
            this.pointAmountLabel.Size = new System.Drawing.Size(87, 13);
            this.pointAmountLabel.TabIndex = 2;
            this.pointAmountLabel.Text = "Amount of Points";
            // 
            // rewardNameBox
            // 
            this.rewardNameBox.Location = new System.Drawing.Point(182, 131);
            this.rewardNameBox.Name = "rewardNameBox";
            this.rewardNameBox.Size = new System.Drawing.Size(100, 20);
            this.rewardNameBox.TabIndex = 3;
            // 
            // rewardTypeBox
            // 
            this.rewardTypeBox.Location = new System.Drawing.Point(182, 177);
            this.rewardTypeBox.Name = "rewardTypeBox";
            this.rewardTypeBox.Size = new System.Drawing.Size(100, 20);
            this.rewardTypeBox.TabIndex = 3;
            // 
            // rewardDetailsBox
            // 
            this.rewardDetailsBox.Location = new System.Drawing.Point(182, 225);
            this.rewardDetailsBox.Name = "rewardDetailsBox";
            this.rewardDetailsBox.Size = new System.Drawing.Size(100, 20);
            this.rewardDetailsBox.TabIndex = 3;
            // 
            // pointAmountBox
            // 
            this.pointAmountBox.Location = new System.Drawing.Point(182, 274);
            this.pointAmountBox.Name = "pointAmountBox";
            this.pointAmountBox.Size = new System.Drawing.Size(100, 20);
            this.pointAmountBox.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(96, 318);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(98, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit / Update";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(207, 318);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // rewards_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 484);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.pointAmountBox);
            this.Controls.Add(this.rewardDetailsBox);
            this.Controls.Add(this.rewardTypeBox);
            this.Controls.Add(this.rewardNameBox);
            this.Controls.Add(this.pointAmountLabel);
            this.Controls.Add(this.rewardDetailsLabel);
            this.Controls.Add(this.rewardTypeLabel);
            this.Controls.Add(this.rewardNameLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rewardsListLabel);
            this.Name = "rewards_page";
            this.Text = "rewards_page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rewardsListLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label rewardNameLabel;
        private System.Windows.Forms.Label rewardTypeLabel;
        private System.Windows.Forms.Label rewardDetailsLabel;
        private System.Windows.Forms.Label pointAmountLabel;
        private System.Windows.Forms.TextBox rewardNameBox;
        private System.Windows.Forms.TextBox rewardTypeBox;
        private System.Windows.Forms.TextBox rewardDetailsBox;
        private System.Windows.Forms.TextBox pointAmountBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
    }
}