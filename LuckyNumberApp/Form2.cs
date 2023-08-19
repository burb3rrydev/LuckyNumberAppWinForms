using System;
using System.Windows.Forms;

namespace LuckyNumberApp
{
    public partial class Form2 : Form
    {
        public int LuckyNumber { get; set; } // Property to store the lucky number
        public int LuckyNumberCount { get; set; } // Property to store the lucky number count

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Update the label to display the lucky number by converting it to a string and concatenating it with the text
            labelLuckyNumber.Text = "Lucky Number: " + LuckyNumber.ToString();

        }
    }
}

