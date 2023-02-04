using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class SavingCalculator
    {
        // declare variable for collecting necessary inputs
        private double monthlyDeposit = 0.0;
        private int period = 0;
        private double interestRate = 0.0;
        private double fees = 0.0;


        #region setter and getters
        // setter and getter for monthly deposit
        public void SetDeposit(double value)
        {
            if (value > 0.0)
                monthlyDeposit = value;
        }
        public double GetDeposit()
        {
            return monthlyDeposit;
        }

        // setter and getter for period
        public void SetPeriod(int value)
        {
            if (value > 0.0)
                period = value;
        }
        public double GetPeriod()
        {
            return period;
        }

        // setter and getter for interest rate
        public void SetInterest(double value)
        {
            if (value > 0.0)
                interestRate = value;
        }
        public double GetInterest()
        {
            return interestRate;
        }

        // setter and getter for fees
        public void SetFees(double value)
        {
            if (value >= 0.0)
                fees = value;
        }
        public double GetFees()
        {
            return fees;
        }

        #endregion

        //
        // method for calculating the final balance
        //
        public double CalculateFinalBalance()
        {
            double finalBalance = 0.0; // variable to store the future value (capital + amount earned)

            for (int i = 1; i <= period; i++)
            {
                double interestEarned = interestRate * finalBalance; // interest earned in each month
                double feesPaid = fees * finalBalance; // fees paid in each month
                finalBalance += interestEarned - feesPaid + monthlyDeposit; // final value
            }
            return finalBalance;

        }

        //
        // method for calculating the amount earned
        //
        public double CalculateAmountEarned()
        {
            double amountEarned = 0.0; // variable to store the amount earned
            double finalBalance = 0.0; // variable to store the future value (capital + amount earned)

            for (int i = 1; i <= period; i++)
            {
                double interestEarned = interestRate * finalBalance; // interest earned in each month
                double feesPaid = fees * finalBalance; // fees paid in each month
                finalBalance += interestEarned - feesPaid + monthlyDeposit;// final value
                amountEarned += interestEarned; // cummulative of interest earned each month
            }
            return amountEarned;
        }

        //
        // method for calculating the fees
        //
        public double CalculateFees()
        {
            double finalBalance = 0.0; // variable to store the future value (capital + amount earned)
            double totalFees = 0.0; // variable to store the total fees

            for (int i = 1; i <= period; i++)
            {
                double interestEarned = interestRate * finalBalance; // interest earned in each month
                double feesPaid = fees * finalBalance; // fees paid in each month
                finalBalance += interestEarned - feesPaid + monthlyDeposit; // final value
                totalFees += feesPaid;// cummulative of fees paid each month

            }
            return totalFees;

        }

        //
        // mehthod for calculating the capital paid
        //
        public double CalculateAmountPaid()
        {
            double amountPaid = monthlyDeposit * period; // it corresponds to the monthly deposit times the period in months

            return amountPaid;
        }


    }
}
