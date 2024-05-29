using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace assinment1oop
{
  public  class NumericUpDown

    {
        private TextBox textBox;
        private Button plusButton;
        private Button minusButton;
        private MainWindow mainWindow;
        public NumericUpDown(TextBox textBox, Button plusButton, Button minusButton , MainWindow mainWindow)
        {
            this.textBox = textBox;
            this.plusButton = plusButton;
            this.minusButton = minusButton;
            this.mainWindow = mainWindow;

            plusButton.Click += PlusButton_Click;
            minusButton.Click += MinusButton_Click;
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateValue(1);
           

        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        { 
            UpdateValue(-1);
        }

        private void UpdateValue(int increment)
        {
            if (int.TryParse(textBox.Text, out int currentValue))
            {
                // Ensure the new value is not less than 0 and not greater than 100
                int newValue = currentValue + increment;
                if (newValue >= 0 && newValue <= 100)
                {
                    currentValue = newValue;
                    textBox.Text = currentValue.ToString();
                    mainWindow.UpdateUIElements();
                }
            }
        }





    }
}
