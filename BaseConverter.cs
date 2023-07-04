using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaseConverter
{
    public partial class BaseConverter : Form
    {

        // Variable to hold number, fromBase, toBase value
        private string input;
        private int fromBase;
        private int toBase;

        // Constructor initialise combo box value
        public BaseConverter()
        {
            InitializeComponent();
            // Set initial combobox selected index
            cbFromBase.SelectedIndex = 0;
            cbToBase.SelectedIndex = 0;
        }

        // Event for convert
        private void btnConvert_Click(object sender, EventArgs e)
        {
            // input, store string from textbox
            string input = txtNumber.Text;

            // Check if input textbox is empty?
            if (string.IsNullOrEmpty(input))
            {
                // if empty show error
                MessageBox.Show("Enter Input in the Enter Number Textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // if not empty call convertbase function, and send value from textbox
                fromBase = int.Parse(cbFromBase.SelectedItem.ToString());
                toBase = int.Parse(cbToBase.SelectedItem.ToString());

                txtResult.Text = ConvertBase(input, fromBase, toBase);
            }
        }

        // Function to convert base
        public static string ConvertBase(string input, int fromBase, int toBase)
        {

            // Convert to base 10 first
            // Variable to hold decimal value after conversion
            int decimalValue = 0;

            // Iterates through each character in the input string at the index of "i"
            for (int i = 0; i < input.Length; i++)
            {
                // Variable to the numerical value of digit
                int digitValue;
                // Checks if the current character is a digit (0-9) using the char.IsDigit() method. 
                if (char.IsDigit(input[i]))
                    // To converts the current character to its corresponding integer value
                    digitValue = input[i] - '0';
                // If the current character is not a digit, it checks if the character is lowercase using the char.IsLower() method.
                else if (char.IsLower(input[i]))
                    // To converts the current character to its corresponding integer value.
                    digitValue = input[i] - 'a' + 10;
                else
                    //If the character is not lowercase, it assumes it is an uppercase letter
                    // To converts the current character to its corresponding integer value.
                    digitValue = input[i] - 'A' + 10;

                // Multiplies the current decimal value by the base and adds the digit value to get the new decimal value.
                decimalValue = decimalValue * fromBase + digitValue;
            }

            // Converting (base 10) number to a any number of any base in range of (2-36)

            // string output which will be used to store the converted number.
            string output = "";

            // while loop runs as long as the decimalValue is greater than 0
            while (decimalValue > 0)
            {
                // This part of codes mainly to calculates the remainder of the decimalValue when divided by the target base.
                // int digitValue will store the remainder 
                int digitValue = decimalValue % toBase;
                char digit;

                // if the digit value is less than 10.
                if (digitValue < 10)
                    // converts the digit value to its corresponding character representation by adding the ASCII value of the character '0' to the digit value.
                    digit = (char)('0' + digitValue);
                else
                    // Digit value is not less than 10, it assumes it is a letter, between 10 and 15 (a-f),
                    // Converts the digit value to its corresponding character representation
                    digit = (char)('A' + digitValue - 10);

                // adds the digit to the output string
                output = digit + output;
                // divides the decimal value by the target base using the /= operator, updating the value of decimalValue for the next iteration.
                decimalValue /= toBase;
            }
            // The output string is returned.
            return output;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            txtResult.Clear();
            cbFromBase.SelectedIndex = 0;
            cbToBase.SelectedIndex = 0;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string temp;
            string fromBase, toBase;

            fromBase = cbFromBase.Text;
            toBase = cbToBase.Text;

            temp = cbFromBase.Text;
            fromBase = cbToBase.Text;
            toBase = temp;

            cbFromBase.Text = fromBase;
            cbToBase.Text = toBase;
        }
    }
}
