using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using assinment1oop;
using System.Reflection.Metadata;

namespace assinment1oop
{   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        private HelpingMethods helpingMethods = new HelpingMethods();
        private ObservableCollection<OrderItem> orderItems = new ObservableCollection<OrderItem>();
        public NumericUpDown lemonHandler;
        public NumericUpDown bananaHandler;
        public NumericUpDown strowhandler;
        public NumericUpDown chocolateHandler;
        public NumericUpDown amontHanler;
        public float totalLemonPrice = 0.0f;
        public float totalBananaPrice = 0.0f;
        public float totalStrowPrice = 0.0f;
        public float totalChocolatePrice = 0.0f;
        public int totalLemonCalories = 0;
        public int totalBananaCalories = 0;
        public int totalStrowCalories = 0;
        public int totalChocolateCalories = 0;
        public string? selectedMilkType;
        public static int lemonQuantity = 0;
        public int bananaQuantity = 0;
        public int strowQuantity = 0;
        public int chocolateQuantity = 0;
        public float TotalPrices = 0.0f;
        public int TotalCaloris = 0;

        public float lemonPrice = 0.0f;
        public float bananaPrice = 0.0f;
        public float strowPrice = 0.0f;
        public float chocolatePrice = 0.0f;
        public int lemonCalories = 0;
        public int bananaCalories = 0;
        public int strowCalories = 0;
        public int chocolateCalories = 0;


        public int PeaNutCalories = 0;
        public int HazelNutCaloris = 0;
        public int AntepNutCaloris = 0;

        public bool IsLemonChecked = false;
        public bool IsBananaChecked = false;
        public bool IsStrowChecked = false;
        public bool IsChocolateChecked = false;

        public float Amont = 0.0f;

        public string ExtraChecked = "";
        List<string> selectedFlavors = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            lemonHandler = new NumericUpDown(lemon, lemonPlus, lemonMinus, this);//here we are passing the valus to the NumericUpDown
            bananaHandler = new NumericUpDown(banana, bananaPlus, bananaMinus, this);
            strowhandler = new NumericUpDown(strow, strowPlus, strowMinus, this);
            chocolateHandler = new NumericUpDown(chocolate, chocolatePlus, chocolateMinus, this);
            amontHanler = new NumericUpDown(amont, amontPlus, amontMinus, this);

        }

      

        private void TextBox_KeyUp(object sender, KeyEventArgs e) //if the name and adderss is not empty the TypeOfMilk will be enabled
        {
            // HelpingMethods.EnableTypeOfMilk(typeOfMilkGroupBox, name, address);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                // Capitalize the first letter of the name
                string capitalizedName = helpingMethods.CapitalizeFirstLetter(name.Text);
                name.Text = capitalizedName;

                // Move focus to the address TextBox
                address.IsEnabled = true;
                address.Focus();

                // Enable TypeOfMilk
                HelpingMethods.EnableTypeOfMilk(typeOfMilkGroupBox, name, address);
            }
        }


        private void TypeOfMilkRadioButton_Checked(object sender, RoutedEventArgs e)//now all the boxws are enabled
        {
            HelpingMethods.EnableControlsAfterTypeOfMilkSelection(
                 typeOfMilkGroupBox, additionsGroupBox, extraGroupBox, pricesGroupBox, invoiceGroupBox, additionsPictursGroupBox,
          insertOrderButton, dietRadioButton,// newOrderButton,
          lowFatRadioButton, fatRadioButton);

            if (dietRadioButton.IsChecked == true) { selectedMilkType = "Diet"; }
            if (lowFatRadioButton.IsChecked == true) { selectedMilkType = "LowFat"; }
            if (fatRadioButton.IsChecked == true) { selectedMilkType = "Fat"; }

        }

        private void lemonQuantity_textChange(object sender, TextChangedEventArgs e)
        {
            if (IsLemonChecked == true)
            {
                lemonQuantity = int.Parse(lemon.Text);
                totalLemonPrice = lemonQuantity * lemonPrice;
                totalLemonCalories = lemonQuantity * lemonCalories;

            }
        }


        private void bananaQuantity_textChange(object sender, TextChangedEventArgs e)
        {
            if (IsBananaChecked == true)
            {
                bananaQuantity = int.Parse(banana.Text);
                totalBananaPrice = bananaQuantity * bananaPrice;
                totalBananaCalories = bananaQuantity * bananaCalories;
            }
        }


        private void strowQuantity_textChange(object sender, TextChangedEventArgs e)
        {
            if (IsStrowChecked == true)
            { strowQuantity = int.Parse(strow.Text);
                totalStrowPrice = strowQuantity * strowPrice;
                totalStrowCalories = strowCalories * strowQuantity;
            }

        }
        private void chocolateQuantity_textChange(object sender, TextChangedEventArgs e)
        {
            if (IsChocolateChecked == true)
            {
                chocolateQuantity = int.Parse(chocolate.Text);
                totalChocolatePrice = chocolateQuantity * chocolatePrice;
                totalChocolateCalories = chocolateQuantity * chocolateCalories;
            }
        }


        private void FlavorCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            

            if (selectedMilkType == "Diet")
            {
                lemonPrice = IceCreamHelper.dietPrice[0];
                bananaPrice = IceCreamHelper.dietPrice[1];
                strowPrice = IceCreamHelper.dietPrice[2];
                chocolatePrice = IceCreamHelper.dietPrice[3];

                lemonCalories = IceCreamHelper.dietCalories[0];
                bananaCalories = IceCreamHelper.dietCalories[1];
                strowCalories = IceCreamHelper.dietCalories[2];
                chocolateCalories = IceCreamHelper.dietCalories[3];
                UpdateUIElements();
            }

            if (selectedMilkType == "LowFat")
            {
                lemonPrice = IceCreamHelper.lowFatPrice[0];
                bananaPrice = IceCreamHelper.lowFatPrice[1];
                strowPrice = IceCreamHelper.lowFatPrice[2];
                chocolatePrice = IceCreamHelper.lowFatPrice[3];

                lemonCalories = IceCreamHelper.lowFatCalories[0];
                bananaCalories = IceCreamHelper.lowFatCalories[1];
                strowCalories = IceCreamHelper.lowFatCalories[2];
                chocolateCalories = IceCreamHelper.lowFatCalories[3];
                UpdateUIElements();
            }

            if (selectedMilkType == "Fat")
            {
                lemonPrice = IceCreamHelper.FatPrice[0];
                bananaPrice = IceCreamHelper.FatPrice[1];
                strowPrice = IceCreamHelper.FatPrice[2];
                chocolatePrice = IceCreamHelper.FatPrice[3];
                lemonCalories = IceCreamHelper.FatCalories[0];
                bananaCalories = IceCreamHelper.FatCalories[1];
                strowCalories = IceCreamHelper.FatCalories[2];
                chocolateCalories = IceCreamHelper.FatCalories[3];
                UpdateUIElements();

            }

            if (lemonFlavor.IsChecked == true) { lemonImg.Visibility = Visibility.Visible; selectedFlavors.Add("lem"); IsLemonChecked = true;  UpdateUIElements(); }

            if (bananaFlavor.IsChecked == true) { bananaImg.Visibility = Visibility.Visible; selectedFlavors.Add("ban"); IsBananaChecked = true;  UpdateUIElements(); }

            if (strowFlavor.IsChecked == true) { strowImg.Visibility = Visibility.Visible; selectedFlavors.Add("strow"); IsStrowChecked = true;  UpdateUIElements(); }

            if (chocolateFlavor.IsChecked == true) { chocoimg.Visibility = Visibility.Visible; selectedFlavors.Add("choco"); IsChocolateChecked = true;  UpdateUIElements(); }

            TotalPrices = totalBananaPrice + totalChocolatePrice + totalLemonPrice + totalStrowPrice;
            TotalCaloris = totalLemonCalories + totalStrowCalories + totalBananaCalories + totalChocolateCalories + PeaNutCalories + HazelNutCaloris + AntepNutCaloris;

        }
        private void ExtraCheckBox_checked(object sender, RoutedEventArgs e)
        {
            if (PeaNut.IsChecked == true) { PeaNutCalories= 30; ExtraChecked = "PeaNut"; UpdateUIElements(); }
            if(HazeNut.IsChecked==true)   {HazelNutCaloris = 45; ExtraChecked = "HazeNut"; UpdateUIElements(); }
            if(AntepNut.IsChecked==true) { AntepNutCaloris = 75; ExtraChecked = "AntepNut"; UpdateUIElements(); }
        }



        
        public void UpdateUIElements()
        {
            TotalPrices = totalBananaPrice + totalChocolatePrice + totalLemonPrice + totalStrowPrice;
            TotalCaloris = totalLemonCalories + totalStrowCalories + totalBananaCalories + totalChocolateCalories + PeaNutCalories + HazelNutCaloris + AntepNutCaloris;


            unitPrice.Text = TotalPrices.ToString();
            unitCalori.Text = TotalCaloris.ToString();
           Amont=  float.Parse(unitPrice.Text)*float.Parse(amont.Text);
            totalAmontPrice.Text = Amont.ToString();
        }

        private void InsertOrderButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedFlavorsText = string.Join(" ", selectedFlavors);

            OrderItem newItem = new OrderItem
            {
                Property1 = selectedFlavorsText,
                Property2 = name.Text,
                Property3 = address.Text,
                Property4 = ExtraChecked,
                Property5 = unitPrice.Text,
                Property6 = unitCalori.Text,
                Property7 = totalAmontPrice.Text
            };
            int grand = listView.Items.Count;
            grandtotal.Text=(grand+1).ToString();
           listView.Items.Add(newItem);
            newOrderButton.IsEnabled = true;
            selectedFlavors.Clear();
            selectedFlavorsText = string.Empty;
        }

       
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (listView.Items.Count > 0)
               { listView.Items.RemoveAt(listView.Items.Count - 1);}//delet the last row 
        }

        public void ClearMethod()
        {
            selectedFlavors.Clear();
            ExtraChecked = "none";
            dietRadioButton.IsChecked = false;
            lowFatRadioButton.IsChecked = false;
            fatRadioButton.IsChecked = false;
            lemonFlavor.IsChecked = false;
            bananaFlavor.IsChecked = false;
            strowFlavor.IsChecked = false;
            chocolateFlavor.IsChecked = false;
            PeaNut.IsChecked = false;
            HazeNut.IsChecked = false;
            AntepNut.IsChecked = false;
            lemon.Text = "0";
            banana.Text = "0";
            strow.Text = "0";
            chocolate.Text = "0";
            unitPrice.Text = "0";
            unitCalori.Text = "0";
            amont.Text = "0";
            totalAmontPrice.Text = "0";
        }
        private void NewOrderButton_Click(Object sender, RoutedEventArgs e)
        {
            ClearMethod();

        }
        private void NewCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            ClearMethod();
            name.Text = string.Empty;
            address.Text = string.Empty;

        }
        private void ExitButton_Click( object sender, RoutedEventArgs e )
        {
            this.Close();
        }





    }
}
