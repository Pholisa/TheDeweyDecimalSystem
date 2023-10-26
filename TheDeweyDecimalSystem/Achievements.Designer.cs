namespace TheDeweyDecimalSystem
{
    partial class Achievements
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
            this.components = new System.ComponentModel.Container();
            this.lblAchievements = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGetBadge = new System.Windows.Forms.Button();
            this.theTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAchievements
            // 
            this.lblAchievements.AutoSize = true;
            this.lblAchievements.Font = new System.Drawing.Font("Perpetua Titling MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchievements.Location = new System.Drawing.Point(13, 13);
            this.lblAchievements.Name = "lblAchievements";
            this.lblAchievements.Size = new System.Drawing.Size(380, 52);
            this.lblAchievements.TabIndex = 1;
            this.lblAchievements.Text = "Archievements";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Perpetua Titling MT", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(24, 481);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(501, 16);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Congratulations for completing your first book replacing!!!";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(456, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGetBadge
            // 
            this.btnGetBadge.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBadge.Location = new System.Drawing.Point(201, 392);
            this.btnGetBadge.Name = "btnGetBadge";
            this.btnGetBadge.Size = new System.Drawing.Size(128, 39);
            this.btnGetBadge.TabIndex = 10;
            this.btnGetBadge.Text = "GET BADGE!";
            this.btnGetBadge.UseVisualStyleBackColor = true;
            this.btnGetBadge.Click += new System.EventHandler(this.btnGetBadge_Click_1);
            // 
            // theTimer
            // 
            this.theTimer.Interval = 1;
            this.theTimer.Tick += new System.EventHandler(this.theTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Keep up the good work, to receive more badgets in the future!";
            // 
            // Achievements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.btnGetBadge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblAchievements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(550, 550);
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "Achievements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Achievements";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAchievements;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGetBadge;
        private System.Windows.Forms.Timer theTimer;
        private System.Windows.Forms.Label label1;
    }
}