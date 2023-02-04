using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class BMRCalculator
    {
        // declare variable for collecting weight, height age, gender, and activity level
        private double userWeightKg;
        private double userHeightCm;
        private int userAge;
        private GenderTypes gender;
        private ActivityTypes activity;

        #region setters and getters
        // setter and getter for weight
        public void SetWeightKg(double value)
        {
            if (value > 0.0)
                userWeightKg = value;
        }
        public double GetWeightKg()
        {
            return userWeightKg;
        }

        // setter and getter for weight
        public void SetHeightCm(double value)
        {
            if (value > 0.0)
                userHeightCm = value;
        }
        public double GetHeightCm()
        {
            return userHeightCm;
        }


        // setter and getter for age
        public void SetAge(int value)
        {
            if (value > 0.0)
                userAge = value;
        }
        public double GetAge()
        {
            return userAge;
        }


        //setter and getter for gender type
        public void SetGender(GenderTypes type)
        {
            gender = type;
        }
        public GenderTypes GetGender()
        {
            return gender;
        }


        //setter and getter for activity level
        public void SetActivity(ActivityTypes type)
        {
            activity = type;
        }
        public ActivityTypes GetActivity()
        {
            return activity;
        }

        #endregion


        //
        // method for the calculation of BMR according to gender
        //
        public double CalculateBMR()
        {
            double bmr = 0.0;
            if (gender == GenderTypes.Male) // calculate bmr for male
            {
                bmr = 10 * userWeightKg + 6.25 * userHeightCm - 5 * userAge + 5;
            }
            else // calculation when gender is not male, i.e. female
            {
                bmr = 10 * userWeightKg + 6.25 * userHeightCm - 5 * userAge - 161;
            }
            return bmr;
        }

        //
        // method for the calculation of BMR according to activity level
        //
        public double BMRActivity()
        {
            double bmr = CalculateBMR();
            double bmrActivity = 0.0;
            if (activity == ActivityTypes.Sedentary) // sedentary (little or no exercise)
            {
                bmrActivity = bmr * 1.2;
            } 
            else if (activity == ActivityTypes.Lightly) // lighly active (exercise 1 to 3 times per week)
            {
                bmrActivity = bmr * 1.375;
            }
            else if (activity == ActivityTypes.Moderately) // moderately active (exercise 4 to 5 times per week)
            {
                bmrActivity = bmr * 1.550;
            }
            else if (activity == ActivityTypes.Very) // very active (exercise 6 to 7 times per week)
            {
                bmrActivity = bmr * 1.725;
            }
            else // when activity level is extra active (hard exercise)
            {
                bmrActivity = bmr * 1.9;
            }
            return bmrActivity;
        }

    }
}
