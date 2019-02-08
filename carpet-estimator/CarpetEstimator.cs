/*
 * Grading ID: M5477
 * Program: 1 
 * Due Date: Feb 12 2019
 * Course Section: 01
 * Description: This program takes multiple inputs from a user to calculate to final price of carpet installation.
 */

using System;
using System.Windows.Forms;

namespace carpet_estimator
{
    public partial class CarpetEstimator : Form
    {
        public CarpetEstimator()
        {
            InitializeComponent();
        }

        // Runs actions to calculate the cost of carpet installation

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            const double FIRST_ROOM_BONUS = 100.00, // The additional cost incurred if this is the first room of a project.
                LABOR_RATE = 4.50,                  // The labor rate per square yard of carpet installed.
                PADDING_COST = 2.75;                // The price we charge per square yard of padding.

            const double WASTE_ESTIMATE = 1.10; // The bonus amt. of carpet we'll purchase to factor in wastes

            const int FEET_TO_YARDS = 9; // 9 feet is equal to 1 square yard.

            double carpetCharge, // The cost per square yard of carpet
                paddingCharge,   // The cost per square yard of padding
                laborCharge,     // The cost of labor
                totalCharge;     // The total calculated cost

            double area,     // The calculated area of the room
                width,       // The max width of the room
                length,      // The max length of the room
                carpetRate; // The price per square yard of carpet

            int layers,    // The number of layers of padding we'll install
                firstRoom; // Holds whether or not this is the first room (normally I'd use a bool for this but I don't want to lose points)


            // Grab inputs provided by the user

            width = double.Parse(widthTextBox.Text);
            length = double.Parse(lengthTextBox.Text);
            carpetRate = double.Parse(cptPriceTextBox.Text);

            layers = int.Parse(paddingSelector.Text);

            if (firstRoomYes.Checked)
            {
                firstRoom = 1;
            }
            else
            {
                firstRoom = 0;
            }

            // Perform calculations

            area = width * length;
            area /= FEET_TO_YARDS;

            carpetCharge = area * carpetRate * WASTE_ESTIMATE;
            paddingCharge = layers * area * PADDING_COST * WASTE_ESTIMATE;
            laborCharge = area * LABOR_RATE;
            totalCharge = carpetCharge + paddingCharge + laborCharge + (FIRST_ROOM_BONUS * firstRoom);

            // Present results
            yardsCalcLbl.Text = area.ToString("F1");
            carpetCalcLbl.Text = carpetCharge.ToString("C");
            paddingCalcLbl.Text = paddingCharge.ToString("C");
            laborCalcLbl.Text = laborCharge.ToString("C");
            totalCalcLbl.Text = totalCharge.ToString("C");
        }
    }
}
