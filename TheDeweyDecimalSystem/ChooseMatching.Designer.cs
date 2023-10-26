namespace TheDeweyDecimalSystem
{
    partial class ChooseMatching
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFirstDesc = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFirstNum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheDeweyDecimalSystem.Properties.Resources.scroll;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(80, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 302);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnFirstDesc
            // 
            this.btnFirstDesc.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstDesc.Location = new System.Drawing.Point(108, 195);
            this.btnFirstDesc.Name = "btnFirstDesc";
            this.btnFirstDesc.Size = new System.Drawing.Size(141, 74);
            this.btnFirstDesc.TabIndex = 2;
            this.btnFirstDesc.Text = "Descriptions to Call Numbers";
            this.btnFirstDesc.UseVisualStyleBackColor = true;
            this.btnFirstDesc.Click += new System.EventHandler(this.btnFirstDesc_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TheDeweyDecimalSystem.Properties.Resources.scroll;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(405, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 302);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnFirstNum
            // 
            this.btnFirstNum.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstNum.Location = new System.Drawing.Point(435, 195);
            this.btnFirstNum.Name = "btnFirstNum";
            this.btnFirstNum.Size = new System.Drawing.Size(141, 74);
            this.btnFirstNum.TabIndex = 4;
            this.btnFirstNum.Text = "Call Numbers to Descriptions";
            this.btnFirstNum.UseVisualStyleBackColor = true;
            this.btnFirstNum.Click += new System.EventHandler(this.btnFirstNum_Click);
            // 
            // ChooseMatching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheDeweyDecimalSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 494);
            this.Controls.Add(this.btnFirstNum);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnFirstDesc);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(750, 550);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "ChooseMatching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseMatching";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFirstDesc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFirstNum;
    }
}