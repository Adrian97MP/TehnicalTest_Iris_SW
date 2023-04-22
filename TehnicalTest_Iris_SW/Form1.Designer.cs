namespace TehnicalTest_Iris_SW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkForCNcheckBox = new System.Windows.Forms.CheckBox();
            this.checkForNrcheckBox = new System.Windows.Forms.CheckBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.showReturnedLabel = new System.Windows.Forms.Label();
            this.valueReturnedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkForCNcheckBox
            // 
            this.checkForCNcheckBox.AutoSize = true;
            this.checkForCNcheckBox.Location = new System.Drawing.Point(12, 40);
            this.checkForCNcheckBox.Name = "checkForCNcheckBox";
            this.checkForCNcheckBox.Size = new System.Drawing.Size(422, 24);
            this.checkForCNcheckBox.TabIndex = 0;
            this.checkForCNcheckBox.Text = "Corresponding column name of a given number from Excel";
            this.checkForCNcheckBox.UseVisualStyleBackColor = true;
            this.checkForCNcheckBox.CheckedChanged += new System.EventHandler(this.checkForCNcheckBox_CheckedChanged);
            // 
            // checkForNrcheckBox
            // 
            this.checkForNrcheckBox.AutoSize = true;
            this.checkForNrcheckBox.Location = new System.Drawing.Point(12, 81);
            this.checkForNrcheckBox.Name = "checkForNrcheckBox";
            this.checkForNrcheckBox.Size = new System.Drawing.Size(422, 24);
            this.checkForNrcheckBox.TabIndex = 1;
            this.checkForNrcheckBox.Text = "Corresponding number of a given column name from Excel";
            this.checkForNrcheckBox.UseVisualStyleBackColor = true;
            this.checkForNrcheckBox.CheckedChanged += new System.EventHandler(this.checkForNrcheckBox_CheckedChanged);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 125);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(125, 27);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(143, 125);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(123, 27);
            this.returnBtn.TabIndex = 3;
            this.returnBtn.Text = "Return Value";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // showReturnedLabel
            // 
            this.showReturnedLabel.AutoSize = true;
            this.showReturnedLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showReturnedLabel.Location = new System.Drawing.Point(12, 176);
            this.showReturnedLabel.Name = "showReturnedLabel";
            this.showReturnedLabel.Size = new System.Drawing.Size(70, 30);
            this.showReturnedLabel.TabIndex = 4;
            this.showReturnedLabel.Text = "Value:";
            // 
            // valueReturnedLabel
            // 
            this.valueReturnedLabel.AutoSize = true;
            this.valueReturnedLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueReturnedLabel.Location = new System.Drawing.Point(82, 176);
            this.valueReturnedLabel.Name = "valueReturnedLabel";
            this.valueReturnedLabel.Size = new System.Drawing.Size(71, 30);
            this.valueReturnedLabel.TabIndex = 5;
            this.valueReturnedLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 232);
            this.Controls.Add(this.valueReturnedLabel);
            this.Controls.Add(this.showReturnedLabel);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.checkForNrcheckBox);
            this.Controls.Add(this.checkForCNcheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TehnicalTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkForCNcheckBox;
        private CheckBox checkForNrcheckBox;
        private TextBox inputTextBox;
        private Button returnBtn;
        private Label showReturnedLabel;
        private Label valueReturnedLabel;
    }
}