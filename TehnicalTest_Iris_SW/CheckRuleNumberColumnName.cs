using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TehnicalTest_Iris_SW
{
    internal class CheckRuleNumberColumnName
    {

        /// Generate ColumnName based on a given number//
        /// </Check if the number is > 0 >
        /// <param name="columnNumber"></param>
        /// <returns></returns>
        public string GetExcelColumnName(int columnNumber)
        {
            string columnName = "";
            try
            {
                while (columnNumber > 0)
                {
                    int modulo = (columnNumber - 1) % 26;
                    columnName = Convert.ToChar('A' + modulo) + columnName;
                    columnNumber = (columnNumber - modulo) / 26;
                }

                return columnName;
            }
            catch
            {
                return columnName;
            }
            
        }
        /// Generate number based on column name/ <summary>
        /// Generate number based on column name/
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>Index(string columnName)
        public string GetNumberOfExcelColumnName(string columnName)
        {
            int number = 0;
            int pow = 1;

            for (int i = columnName.Length - 1; i >= 0; i--)
            {
                if(Char.IsLetter(columnName[i]) && Char.IsUpper(columnName[i]))
                {
                    number += (columnName[i] - 'A' + 1) * pow;
                    pow *= 26;
                }
                else
                {
                    return "false";
                }
                
            }

            return Convert.ToString(number);
        }

        public void RestorAfterCheckingBoxes(CheckBox checkBoxNR, CheckBox checkBoxCN, TextBox inputTextBox, Button returnValueButton, Label showLabel, Label valueLabel, int whatIsChecked)
        {
            returnValueButton.Enabled = false;
            showLabel.Visible = false;
            valueLabel.Visible = false;
            inputTextBox.Enabled = true;
            inputTextBox.Text = "";

            if (whatIsChecked == 1)
            {   
                checkBoxNR.Checked = !checkBoxCN.Checked;
            }
            else
            {
                checkBoxCN.Checked = !checkBoxNR.Checked;
            }
        }

        public void DisplayWarningMessages(int whatToShow)
        {
            DisplayMessageWindow displayMessageWindow;
            if (whatToShow == 1)
            {
                displayMessageWindow = new DisplayMessageWindow(1);
                displayMessageWindow.Show();
            }
            else
            {
                displayMessageWindow = new DisplayMessageWindow(2);
                displayMessageWindow.Show();
            }
        }

        public void ShowResults(Label showReturn, Label valueReturn,string value)
        {
            showReturn.Visible = true;
            valueReturn.Visible = true;
            valueReturn.Text = value;
        }
    }
}
