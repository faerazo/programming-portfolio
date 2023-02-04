using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // this class handles with the neccesary calculations for BMI
    internal class BMICalculator 
    {
        // declare variables for collecting user name, height, weight and type of measurement
        private string userName = " ";
        private double userHeight = 0; // cm, feet and inches
        private double userWeight = 0; // kgs, lbs
        private UnitTypes unit;

        #region setters and getters
        // setter and getter for name
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                userName = name;
        }
        public string GetName()
        {
            return userName;
        }


        // setter and getter for height
        public void SetHeight(double value)
        {
            if(value > 0.0)
                userHeight = value;
        }
        public double GetHeight()
        {
            return userHeight;
        }


        // setter and getter for weight
        public void SetWeight(double value)
        {
            if(value > 0.0)
                userWeight = value;
        }
        public double GetWeight()
        {
            return userWeight;
        }


        //setter and getter for unit type
        public void SetUnit(UnitTypes type)
        {
            unit = type;
        }
        public UnitTypes GetUnit()
        {
            return unit;
        }

        #endregion
        
        //
        // method for the calculation of the bmi according to the unit type (metric or imperial)
        //
        public double CalculateBMI()
        {
            double bmi = 0.0;
            if (unit == UnitTypes.Metric) // calculation when the unit is metric, userWeight is in kg and userHeight in m
            {
                bmi = userWeight / (userHeight * userHeight);
            }
            else // calculation when the unit is imperial, userWeight is in lbs and userHeight in inches
            {
                bmi = (703.0 * userWeight) / (userHeight * userHeight);
            }
            return bmi;
        }

        //
        // method for getting the category of weight according to bmi
        //
        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI(); //save the bmi result in a variable to be used in the if-statement
            string categoryWeight = string.Empty;
            if (bmi > 40)
                categoryWeight = "Overweight (Obesity Class III)";
            else if ((bmi >= 35) && (bmi <= 39.9))
                categoryWeight = "Overweight (Obesity Class II)";
            else if ((bmi >= 30) && (bmi <= 34.9))
                categoryWeight = "Overweight (Obesity Class I)";
            else if ((bmi >= 25) && (bmi <= 29.9))
                categoryWeight = "Overweight (Pre-Obesity)";
            else if ((bmi >= 18.5) && (bmi <= 24.9))
                categoryWeight = "Normal Weight";
            else // for cases when bmi is lower to 18.5
                categoryWeight = "Underweight";
            return categoryWeight;

        }

        //
        // method for calculating the normal weight range according to the height of the user
        //
        public string NormalWeight()
        {
            // setting local variable to be used in the calculation
            double heightSquare = userHeight * userHeight; 
            double maxWeight;
            double minWeight;
            string normalWeight = string.Empty; // this will record the total string specifying the normal weight range


            if (unit == UnitTypes.Metric) // calculation when the unit is metric, userWeight is in kg and userHeight in m
            {
                minWeight = heightSquare * 18.5;
                maxWeight = heightSquare * 24.9;
                normalWeight = "Normal weight should be between " + String.Format("{0:0.#}",minWeight) + 
                    " and " + String.Format("{0:0.#}",maxWeight) + " kg";

            }
            else // calculation when the unit is imperial, userWeight is in lbs and userHeight in inches
            { 
                minWeight = heightSquare/703 * 18.5;
                maxWeight = heightSquare/703 * 24.9;
                normalWeight = "Normal weight should be between " + String.Format("{0:0.#}", minWeight) +
                    " and " + String.Format("{0:0.#}", maxWeight) + " lbs";
            }
            return normalWeight;
        }
    }
}
