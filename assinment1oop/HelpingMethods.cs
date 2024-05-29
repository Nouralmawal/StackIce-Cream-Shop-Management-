using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Ink;
using System.Xml.Linq;

namespace assinment1oop
{
     public class HelpingMethods
    {//First character of name and surname will be converted
     //to upper case automatically after typing first character of name and last name.
        public string CapitalizeFirstLetter(string input)
        {
            if (!string.IsNullOrWhiteSpace(input) && input.Length >= 1)
            {
                // Convert the first character to uppercase and keep the rest of the text as is.
                return char.ToUpper(input[0]) + input.Substring(1);
            }

            return input;
        }

        public static void EnableTypeOfMilk(GroupBox typeOfMilkGroupBox, TextBox nameTextBox, TextBox addressTextBox)
        {
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text) && !string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                typeOfMilkGroupBox.IsEnabled = true;
            }
        }


        public static void EnableTypeOfMilkByPessEnter(GroupBox typeOfMilkGroupBox, TextBox nameTextBox, TextBox addressTextBox)
        {
            // Check if both name and address text boxes are not empty
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text) && !string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                // Enable the "Type of Milk" group box
                typeOfMilkGroupBox.IsEnabled = true;
            }
        }
        public static void EnableControlsAfterTypeOfMilkSelection(
        GroupBox typeOfMilkGroupBox,
        GroupBox additionsGroupBox,
        GroupBox extraGroupBox,
        GroupBox pricesGroupBox,
        GroupBox invoiceGroupBox,
        GroupBox additionsPictursGroupBox,
        Button insertOrderButton,
       // Button newOrderButton,
        RadioButton dietRadioButton,
        RadioButton lowFatRadioButton,
        RadioButton fatRadioButton)
        {
            // Check which radio button is checked
            if (dietRadioButton.IsChecked == true || lowFatRadioButton.IsChecked == true || fatRadioButton.IsChecked == true)
            {
                // Enable all other fields and buttons
                typeOfMilkGroupBox.IsEnabled = true;

                // Enable other group boxes, buttons, and controls
                additionsGroupBox.IsEnabled = true;
                extraGroupBox.IsEnabled = true;
                pricesGroupBox.IsEnabled = true;
                invoiceGroupBox.IsEnabled = true;
                additionsPictursGroupBox.IsEnabled = true;

                insertOrderButton.IsEnabled = true;
                //newOrderButton.IsEnabled = true;
               
            }
        }
        
       


    }
}
