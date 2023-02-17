
namespace nationalEconomics
{
    partial class USA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USA));
            this.UStext = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.USpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UStext
            // 
            this.UStext.Location = new System.Drawing.Point(454, 12);
            this.UStext.Name = "UStext";
            this.UStext.Size = new System.Drawing.Size(430, 152);
            this.UStext.TabIndex = 1;
            this.UStext.Text = "США БЛИН";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // USpictureBox
            // 
            this.USpictureBox.Location = new System.Drawing.Point(454, 172);
            this.USpictureBox.Name = "USpictureBox";
            this.USpictureBox.Size = new System.Drawing.Size(429, 334);
            this.USpictureBox.TabIndex = 3;
            this.USpictureBox.TabStop = false;
            // 
            // USA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(894, 519);
            this.Controls.Add(this.USpictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UStext);
            this.Name = "USA";
            this.Text = "USA";
            this.Load += new System.EventHandler(this.USA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox UStext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox USpictureBox;
    }
}