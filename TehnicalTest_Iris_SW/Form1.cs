namespace TehnicalTest_Iris_SW
{
    public partial class Form1 : Form
    {
        CheckRuleNumberColumnName checkClass;

        public Form1()
        {
            checkClass = new CheckRuleNumberColumnName();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showReturnedLabel.Visible = false;
            valueReturnedLabel.Visible = false;
            inputTextBox.Enabled = false;
            returnBtn.Enabled = false;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            int errorLevel = 0;
            bool errorTriggered = false;
            try
            {
                string correspondingValue = "";
                if(checkForCNcheckBox.Checked)
                {
                    int valueInput = Convert.ToInt32(inputTextBox.Text);
                    correspondingValue = checkClass.GetExcelColumnName(valueInput);
                    checkClass.ShowResults(showReturnedLabel, valueReturnedLabel,correspondingValue);
                }
                else
                {
                    string valueInput = inputTextBox.Text;
                    correspondingValue = checkClass.GetNumberOfExcelColumnName(valueInput);
                    if (correspondingValue.Equals("false"))
                    {
                        checkClass.DisplayWarningMessages(2);
                    }
                    else
                    {
                        checkClass.ShowResults(showReturnedLabel, valueReturnedLabel, correspondingValue);
                    }
                }
            }
            catch
            {
                checkClass.DisplayWarningMessages(1);
            }
        }

        private void checkForCNcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkClass.RestorAfterCheckingBoxes(checkForNrcheckBox, checkForCNcheckBox, inputTextBox, returnBtn, showReturnedLabel, valueReturnedLabel, 1);
        }

        private void checkForNrcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkClass.RestorAfterCheckingBoxes(checkForNrcheckBox, checkForCNcheckBox, inputTextBox, returnBtn, showReturnedLabel, valueReturnedLabel, 2);
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputTextBox.Text))
            {
                returnBtn.Enabled = false;
                showReturnedLabel.Visible = false;
                valueReturnedLabel.Visible = false;
            }
            else
            {
                returnBtn.Enabled = true;
            }
        }
    }
}