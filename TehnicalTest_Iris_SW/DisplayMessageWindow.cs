using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TehnicalTest_Iris_SW
{
    public partial class DisplayMessageWindow : Form
    {
        int numberMessage = 0;
        string message1 = "Wrong input format, the input must be an integer number and grader then 0.";
        string message2 = "Wrong input format, the input must be a capital letter or letters.";

        public DisplayMessageWindow(int messageReceivedNumberCheckFor)
        {
            InitializeComponent();
            numberMessage = messageReceivedNumberCheckFor;
        }

        private void DisplayMessageWindow_Load(object sender, EventArgs e)
        {
            if(numberMessage == 1)
            {
                messageReceivedTextBox.Text = message1;
            }
            else
            {
                messageReceivedTextBox.Text = message2;
            }
        }
    }
}
