/*
 * Grading ID: M5477
 * Program: 1 
 * Due Date: Feb 12 2019
 * Course Section: 01
 * Description: This program takes multiple inputs from a user to calculate to final price of carpet installation.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            const decimal FIRST_ROOM_BONUS = 100.00M, // The additional cost incurred if this is the first room of a project.
                LABOR_COST = 4.50M,                   // The labor rate per square yard of carpet installed.
                PADDING_COST = 2.75M;                 // The price we charge per square yard of padding.

            const double WASTE_ESTIMATE = 0.10; // The bonus amt. of carpet we'll purchase to factor in wastes

            double width, // The max width of the room
                length,   // The max length of the room
                price;    // The price per square yard of carpet

            int layers; // The number of layers of padding we'll install
        }
    }
}
