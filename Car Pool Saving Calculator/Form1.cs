using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Pool_Saving_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void parkingFeeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // getting user input
            decimal totalMilesDriven = Convert.ToDecimal(totalMilesDrivenTextBox.Text);
            decimal costPerGallon = Convert.ToDecimal(costPerGallonTextBox.Text) / 100;     // converting to dollars
            decimal averageMiles = Convert.ToDecimal(averageMilesTextBox.Text);
            decimal parkingFee = Convert.ToDecimal(parkingFeeTextBox.Text) / 100;
            decimal tolls = Convert.ToDecimal(tollsTextBox.Text) / 100;

            // calculation
            decimal costPerDay = ((totalMilesDriven / averageMiles) * costPerGallon) + parkingFee + tolls;

            // displaying result
            calculateLabel.Text = $"Your cost per day of driving to work is: ${costPerDay:0.00}";
        }
    }
}
