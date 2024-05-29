using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assinment1oop;


namespace assinment1oop
{
    public static class IceCreamHelper

    {

        public static float[] dietPrice = { 0.25f, 0.55f, 0.75f, 0.80f };
        public static int[] dietCalories = { 115, 175, 135, 235 };


        public static float[] lowFatPrice = { 0.35f, 0.65f, 0.85f, 0.90f };
        public static int[] lowFatCalories = { 125, 325, 225, 340 };


        public static float[] FatPrice = { 0.40f, 0.80f, 0.85f, 1.0f };
        public static int[] FatCalories= { 175, 365 , 280 , 400};


        public static int PeaNutCalories = 30;
        public static int HazelNutCaloris = 45;
        public static int AntepNutCaloris = 75;


        public static float totalLemonPrice = 0.0f;
        public static float totalBananaPrice = 0.0f;
        public static float totalStrowPrice = 0.0f;
        public static float totalChocolatePrice = 0.0f;


        public static int totalLemonCalories = 0;
        public static int totalBananaCalories = 0;
        public static int totalStrowCalories = 0;
        public static int totalChocolateCalories = 0;


        


        public static int lemonQuantity = 0;
        public static int bananaQuantity = 0;
        public static int strowQuantity = 0;
        public static int chocolateQuantity = 0;


        public static float TotalPrices = 0.0f;
        public static int TotalCaloris = 0;

        public static float lemonPrice = 0.0f;
        public static float bananaPrice = 0.0f;
        public static float strowPrice = 0.0f;
        public static float chocolatePrice = 0.0f;


        public static int lemonCalories = 0;
        public static int bananaCalories = 0;
        public static int strowCalories = 0;
        public static int chocolateCalories = 0;


        public static void UpdateTotalPriceAndCalories(string selectedMilkType)
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
                //PriceTest.Text = lemonPrice.ToString();
                //CaloriTest.Text = lemonCalories.ToString();
                //QuantatyTest.Text = lemonQuantity.ToString();
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

            }
            

        }


    }
}
