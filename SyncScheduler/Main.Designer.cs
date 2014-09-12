namespace SyncScheduler
{
    partial class Main
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
            this.mMins = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.mStatus = new System.Windows.Forms.Label();
            this.mTotal = new System.Windows.Forms.Label();
            this.mComplete = new System.Windows.Forms.Label();
            this.mFail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mMins
            // 
            this.mMins.Location = new System.Drawing.Point(138, 4);
            this.mMins.Name = "mMins";
            this.mMins.Size = new System.Drawing.Size(76, 20);
            this.mMins.TabIndex = 0;
            this.mMins.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Run thread per __ mins :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(138, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstStatus
            // 
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.Location = new System.Drawing.Point(12, 113);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(202, 186);
            this.lstStatus.TabIndex = 3;
            // 
            // mStatus
            // 
            this.mStatus.Location = new System.Drawing.Point(9, 58);
            this.mStatus.Name = "mStatus";
            this.mStatus.Size = new System.Drawing.Size(205, 13);
            this.mStatus.TabIndex = 4;
            this.mStatus.Text = "Status : N/A";
            // 
            // mTotal
            // 
            this.mTotal.Location = new System.Drawing.Point(9, 71);
            this.mTotal.Name = "mTotal";
            this.mTotal.Size = new System.Drawing.Size(205, 13);
            this.mTotal.TabIndex = 5;
            this.mTotal.Text = "Total need to be synced : 0 file";
            // 
            // mComplete
            // 
            this.mComplete.Location = new System.Drawing.Point(9, 84);
            this.mComplete.Name = "mComplete";
            this.mComplete.Size = new System.Drawing.Size(205, 13);
            this.mComplete.TabIndex = 6;
            this.mComplete.Text = "Total completed synced : 0 file";
            // 
            // mFail
            // 
            this.mFail.Location = new System.Drawing.Point(9, 97);
            this.mFail.Name = "mFail";
            this.mFail.Size = new System.Drawing.Size(205, 13);
            this.mFail.TabIndex = 7;
            this.mFail.Text = "Total failed to synced : 0 file";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 305);
            this.Controls.Add(this.mFail);
            this.Controls.Add(this.mComplete);
            this.Controls.Add(this.mTotal);
            this.Controls.Add(this.mStatus);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mMins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SyncScheduler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox mMins;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.ListBox lstStatus;
        public System.Windows.Forms.Label mStatus;
        public System.Windows.Forms.Label mTotal;
        public System.Windows.Forms.Label mComplete;
        public System.Windows.Forms.Label mFail;
    }
}

