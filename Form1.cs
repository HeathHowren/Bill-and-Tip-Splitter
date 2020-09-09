using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill_and_Tip_Splitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AmountOfPeople_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TipAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void TipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void TotalCost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (AmountOfPeople.Value != 0 && (TipAmount.Value != 0 || Cost.Value != 0))
            {
                decimal TotalCost = (Cost.Value + TipAmount.Value) / AmountOfPeople.Value;
                ResultTextLabel.Text = "Each person must pay: $" + TotalCost.ToString();
            }
            else
            {
                ResultTextLabel.Text = "0 is not a valid input";
            }
        }


    }
}
