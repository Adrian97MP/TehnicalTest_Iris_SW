namespace TehnicalTest_Iris_SW
{
    partial class DisplayMessageWindow
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
            this.warningPictureBox = new System.Windows.Forms.PictureBox();
            this.messageReceivedTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.warningPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // warningPictureBox
            // 
            this.warningPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.warningPictureBox.Image = global::TehnicalTest_Iris_SW.Properties.Resources.Warning;
            this.warningPictureBox.Location = new System.Drawing.Point(28, 44);
            this.warningPictureBox.Name = "warningPictureBox";
            this.warningPictureBox.Size = new System.Drawing.Size(53, 52);
            this.warningPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.warningPictureBox.TabIndex = 0;
            this.warningPictureBox.TabStop = false;
            // 
            // messageReceivedTextBox
            // 
            this.messageReceivedTextBox.BackColor = System.Drawing.Color.White;
            this.messageReceivedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageReceivedTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageReceivedTextBox.Location = new System.Drawing.Point(105, 28);
            this.messageReceivedTextBox.Multiline = true;
            this.messageReceivedTextBox.Name = "messageReceivedTextBox";
            this.messageReceivedTextBox.ReadOnly = true;
            this.messageReceivedTextBox.Size = new System.Drawing.Size(256, 101);
            this.messageReceivedTextBox.TabIndex = 0;
            this.messageReceivedTextBox.TabStop = false;
            this.messageReceivedTextBox.Text = "Wrong input format, the input should be an integer number and grader then 0.";
            // 
            // DisplayMessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 170);
            this.Controls.Add(this.messageReceivedTextBox);
            this.Controls.Add(this.warningPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DisplayMessageWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warning";
            this.Load += new System.EventHandler(this.DisplayMessageWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warningPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox warningPictureBox;
        private TextBox messageReceivedTextBox;
    }
}