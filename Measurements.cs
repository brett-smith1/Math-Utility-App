using System;

namespace Math_Utility_App
{
    class Measurements
    {


    }
    class Temperature
    {

        public static double Conversion(string input, string output, double temp)
        {
            double temp_In_F;

            if (input == "Fahrenheit")
            {
                temp_In_F = temp;
            }
            else if (input == "Celcius")
            {
                temp_In_F = temp * 1.8 + 32;
            }
            else
            {
                temp_In_F = temp * 1.8 - 459.67;
            }

            if (output == "Fahrenheit")
            {
                return temp_In_F;
            }
            else if (output == "Celcius")
            {
                return (temp_In_F - 32) / 1.8;
            }
            else
            {
                return (temp_In_F - 32) / 1.8 + 273.15;
            }
        }
    }

    class Distance
    {
               
        public static double Conversion(string input, string output, double dist)
        {
            double dist_in_m;

            // Takes input distance and distance type and converts input to a common unit (meters)
            if (input == "Miles")
            {
                dist_in_m = dist * 1609.344;
            }
            else if (input == "Yards")
            {
                dist_in_m = dist * 0.9144;
            }
            else if (input == "Feet")
            {
                dist_in_m = dist * 0.3048;
            }
            else if (input == "Inches")
            {
                dist_in_m = dist * 0.0254;
            }
            else if (input == "Kilometers")
            {
                dist_in_m = dist * 1000;
            }
            else if (input == "Centimeters")
            {
                dist_in_m = dist * 0.01;
            }
            else if (input == "Millimeters")
            {
                dist_in_m = dist * 0.001;
            }
            else //input must == "Meters"
            {
                dist_in_m = dist;
            }


           //Takes common unit (meters) and converts to output unit type
            if (output == "Miles")
            {
                return dist_in_m  / 1609.344;
            }
            else if (output == "Yards")
            {
                return dist_in_m * 0.9144;
            }
            else if (output == "Feet")
            {
                return dist_in_m * 0.3048;
            }
            else if (output == "Inches")
            {
                return dist_in_m * 39.3700787;
            }
            else if (output == "Kilometers")
            {
                return dist_in_m / 1000;
            }
            else if (output == "Centimeters")
            {
                return dist_in_m * 100;
            }
            else if (output == "Millimeters")
            {
                return dist_in_m * 1000;
            }
            else //output must == "Meters"
            {
                return dist_in_m;
            }
        }
    }

    class Volume
    {
      
        public static double Conversion(string input, string output, double vol)
        {
            //"Gallon", "Quart", "Pint", "Cup", "Ounce", "Liter", "Milliliter"
            double vol_in_oz;

            if (input == "Gallon")
            {
                vol_in_oz = vol * 128;
            }
            else if (input == "Quart")
            {
                vol_in_oz = vol * 32;
            }
            else if (input == "Pint")
            {
                vol_in_oz = vol * 16;
            }
            else if (input == "Cup")
            {
                vol_in_oz = vol * 8;
            }
            else if (input == "Liter")
            {
                vol_in_oz = vol * 33.814;
            }
            else if (input == "Milliliter")
            {
                vol_in_oz = vol / 29.5735;
            }
            else //input must == "Ounce"
            {
                vol_in_oz = vol;
            }

            if(output == "Gallon")
            {
                return vol_in_oz / 128;
            }
            else if (output == "Quart")
            {
                return vol_in_oz / 32;
            }
            else if (output == "Pint")
            {
                return vol_in_oz / 16;
            }
            else if (output == "Cup")
            {
                return vol_in_oz / 8;
            }
            else if (output == "Liter")
            {
                return vol_in_oz / 33.814;
            }
            else if (output == "Milliliter")
            {
                return vol_in_oz * 29.5735;
            }
            else //input must == "Ounce"
            {
                return vol_in_oz;
            }
        }
    }

    class Weight
    {

        public static double Conversion(string input, string output, double weight)
        {
           // "Tons", "Pounds", "Ounces", "Kilograms", "Grams", "Stones"
            double weight_in_lbs;

            if (input == "Tons")
            {
                weight_in_lbs = weight * 2240;
            }
            else if (input == "Ounces")
            {
                weight_in_lbs = weight / 16;
            }
            else if (input == "Kilograms")
            {
                weight_in_lbs = weight * 2.2046;
            }
            else if (input == "Grams")
            {
                weight_in_lbs = weight / 453.59327;
            }
            else if (input == "Stones")
            {
                weight_in_lbs = weight * 14;
            }
            else //input must == "Pounds"
            {
                weight_in_lbs = weight;
            }

            if (output == "Tons")
            {
                return weight_in_lbs / 2240;
            }
            else if (output == "Ounces")
            {
                return weight_in_lbs * 16;
            }
            else if (output == "Kilograms")
            {
                return weight_in_lbs / 2.2046;
            }
            else if (output == "Grams")
            {
                return weight_in_lbs * 453.59237;
            }
            else if (output == "Stones")
            {
                return weight_in_lbs / 14;
            }
            else //input must == "Pounds"
            {
                return weight_in_lbs;
            }
        }
    }

}
