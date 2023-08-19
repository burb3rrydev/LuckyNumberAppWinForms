using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LuckyNumberApp
{
    public partial class Form1 : Form
    {
        private int luckyNumberCount = 0; // To store the count of lucky numbers
        private int luckyNumber = 0; // To store the lucky number

        public Form1()
        {
            InitializeComponent();

            // Add items to the ComboBox to select calculation methods
            comboBoxMethods.Items.Add("Random");
            comboBoxMethods.Items.Add("Custom Algorithm 1");
            comboBoxMethods.Items.Add("Custom Algorithm 2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMethods.SelectedIndex = 0; // Set default selection to "Random"
            lblCalculation.Text = "";
        }

        private void ShowRandomLuckyNumber(int minRange, int maxRange)
        {
            Random random = new Random();
            luckyNumber = random.Next(minRange, maxRange + 1); // Generate a random number within the specified range
            luckyNumberCount = 1; // Indicate that a lucky number has been generated
        }

        private void ShowCustomlLuckyNumber1(int minRange, int maxRange)
        {
            Random random = new Random();
            int num = random.Next(minRange, maxRange + 1); // Generate a random number within the specified range
            luckyNumber = (int)(num / 2 * 0.8); // Apply a custom calculation to the generated number
            luckyNumberCount = 1;
        }

        private void ShowCustomLuckyNumber2(int minRange, int maxRange)
        {
            Random random = new Random();
            int num = random.Next(minRange, maxRange + 1); // Generate a random number within the specified range
            luckyNumber = (int)(num * 2 / 0.8); // Apply another custom calculation to the generated number
            luckyNumberCount = 1;
        }

        private void btnShowLuckyNumber_Click(object sender, EventArgs e)
        {
            int minRange = int.Parse(textBoxMinRange.Text); // Get the minimum range value from the user input
            int maxRange = int.Parse(textBoxMaxRange.Text); // Get the maximum range value from the user input

            if (comboBoxMethods.SelectedItem.ToString() == "Random")
            {
                ShowRandomLuckyNumber(minRange, maxRange);
                lblCalculation.Text = "Random number will be selected from the given range.";
            }
            else if (comboBoxMethods.SelectedItem.ToString() == "Custom Algorithm 1")
            {
                ShowCustomlLuckyNumber1(minRange, maxRange);
                lblCalculation.Text = "Random number will be selected from the given range and applied to this calculation (int)(num / 2 * 0.8).";
            }
            else if (comboBoxMethods.SelectedItem.ToString() == "Custom Algorithm 2")
            {
                ShowCustomLuckyNumber2(minRange, maxRange);
                lblCalculation.Text = "Random number will be selected from the given range and applied to this calculation (int)(num * 2 / 0.8).";
            }

            // Open the second form to display the lucky number and its count
            var resultForm = new Form2();
            resultForm.LuckyNumber = luckyNumber;
            resultForm.LuckyNumberCount = luckyNumberCount;
            resultForm.ShowDialog();
        }
    }
}





