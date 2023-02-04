using System.CodeDom.Compiler;
using System.Drawing.Text;
using System.Reflection;
using System.Xml.Linq;

namespace Assignment3
{
    public partial class MainForm : Form
    {

        // declare and create an instance of BMICalculator
        private BMICalculator bmiCalc = new BMICalculator();

        // declare and create an instance of the SavingCalculator
        private SavingCalculator savCalc = new SavingCalculator();

        //declare and create and instance of the BMRCalculator
        private BMRCalculator bmrCalc = new BMRCalculator();


        public MainForm()
        {
            InitializeComponent();
            // call a method to prepare GUI
            InitializeGUI();
        }

        //
        // the code inside this method runs when the GUI initialized
        //
        private void InitializeGUI()
        {
            this.Text = "Super Calculator by Francisco Erazo";
            ///////////////// BMI Calculator /////////////////

            // input controls for BMI Calculator
            radioButtonMetric.Checked = true; // define metric type as default
            textHeight.Text = string.Empty; // textbox for height is declared empty
            textWeight.Text = string.Empty; // textbox for weight is declared empty

            // output controls for BMI Calculator
            labelBMIResult.Text = ""; // label for the bmi result is declared empty
            labelWeightCatResult.Text = ""; // label for the weight category result is declared empty
            labelNormalBMI.Text = ""; // label for normal bmi is declared empty
            labelNormalWeight.Text = ""; // label for normal weight range in kg or lbs is declared empty


            ///////////////// Saving Calculator /////////////////
        
            // input controls for Saving Calculator
            textMonthDep.Text = string.Empty; // textbox for monthly saving is declared empty
            textPeriod.Text = string.Empty; // textbox for period is declared empty
            textInterestRate.Text = string.Empty; // textbox for interest rate is declared empty
            textFees.Text = string.Empty; // textbox for fees rate is declared empty

            // output controls for Saving Calculator 
            labelAmtPaidResult.Text = ""; // amount paid result is empty
            labelAmtEarnedResult.Text = ""; // amout earned result is empty
            labelFBalanceResult.Text = ""; // final balance result is empty
            labelTotalFeesResult.Text = ""; //total fees result is empty


            ///////////////// Saving Calculator /////////////////

            // input controls for BMR Calculator
            textAge.Text = string.Empty; // textbox for height is declared empty
            radioButtonMale.Checked = true; // define male type as default
            radioButtonSedentary.Checked = true; // define sedentary type as default

            // output controls for BMR Calculator 
            listBoxBMRResults.Text = "Results:";
        }

        #region ***************//////////////////////////// BMI Calculator Section ////////////////////////////***************
        //
        // method connected with Click event of the button Calculate BMI all code inside will run when user clicks
        //
        private void buttonCalculateBMI_Click(object sender, EventArgs e)
        {
            bool inputOk = ReadInputBMI();

            if (inputOk)
            {
                DisplayResults();
            }
        }

        //
        // method for consolidating the methods for inputs in BMI (name, weight and height)
        //
        private bool ReadInputBMI()
        {
            ReadName();// first read and validate that name is correct
            bool heightOk = ReadHeight(); // second read and validate that height in cm or feet and inches is correct
            bool weightOk = ReadWeight(); // third read and validate that weight in kg or lbs is correct

            return heightOk && weightOk;
        }

        //
        // method for reading the name and validate whether is empty or not
        //
        private void ReadName()
        {
            string name; //declare variable for storing the results of text box Name

            name = textName.Text.Trim(); // remove spaces at the beginning and end of the string
            if (string.IsNullOrEmpty(name))
            {
                name = "Unknown"; // if name is not provided, tag as unknown
            } 
            groupResults.Text = "Results for " + name;
        }

        //
        // method for reading the height string and convert it into a double
        //
        private bool ReadHeight()
        {
            // these works for cm and feet
            bool okHeight = false; // variable to validate height value is ok
            double valueHeight = 0.0; // variable to store height if the value is valid
            string strHeight = textHeight.Text.Trim(); // variable to store the height string

            okHeight = double.TryParse(strHeight, out valueHeight); // validate if the input is correct and provide the value in cm or feet
            if (!okHeight)
            {
                    MessageBox.Show("Invalid input for height!", "Error");
            }

            // these are only for inches
            double valueHeight2 = 0.0; // to store inches values if the value is valid
            string strHeight2 = textHeight2.Text.Trim(); // variable to store the inches in string

            if (radioButtonImperial.Checked)
            {
                okHeight = okHeight && double.TryParse(strHeight2, out valueHeight2); // validate if the input for feetand inches is correct
                if (!okHeight)
                {
                    MessageBox.Show("Invalid input for height!", "Error");
                }
            }
            
            // cm needs to be m, and ft to inches
            if (bmiCalc.GetUnit() == UnitTypes.Metric)
                valueHeight = valueHeight / 100; // from cm to m
            else
                valueHeight = valueHeight * 12.0 + valueHeight2; // from feet to inches

            bmiCalc.SetHeight(valueHeight);

            return okHeight;
        }

        //
        // method for reading the weight string and convert it into a double 
        //
        private bool ReadWeight()
        {
            bool okWeight = false; // variable to validate weight value is ok
            double valueWeight = 0.0; // variable to store weight if the value is valid
            string strWeight = textWeight.Text.Trim(); // variable to store the weight string

            okWeight = double.TryParse(strWeight, out valueWeight); // validate if the input is correct and provide the value
            if (!okWeight)
            {
                MessageBox.Show("Invalid input for weight!", "Error");
            }
            bmiCalc.SetWeight(valueWeight);   
            return okWeight;
        }

        //
        // method for displaying results 
        //
        private void DisplayResults()
        {
            labelBMIResult.Text = bmiCalc.CalculateBMI().ToString("f2"); // bmi value
            labelWeightCatResult.Text = bmiCalc.BmiWeightCategory().ToString(); // weight category according to bmi
            labelNormalBMI.Text = "Normal BMI is between 18.5 and 24.9";
            labelNormalWeight.Text = bmiCalc.NormalWeight(); // normal weight range according the user height

        }

        //
        // method for radio button metric when checked has changed
        //
        private void radioButtonMetric_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeight();
        }

        //
        // method for radio button imperial when checked has changed
        //
        private void radioButtonImperial_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeight();
        }

        //
        // method to summarize the necessary changes when radio button for metric and imperial is checked
        //

        private void UpdateHeight()
        {
            if (radioButtonMetric.Checked)
            {
                labelHeight.Text = "Height (cm)"; // height will be measure in cm when unit is metric
                labelWeight.Text = "Weight (kg)"; // weight will be measure in kg when unit is metric
                textHeight2.Visible = false; // hide the text for inches
                bmiCalc.SetUnit(UnitTypes.Metric);


            }
            else // when radio button for metric is not checked
            {
                labelHeight.Text = "Height (ft and in)"; // height will be measure in feet and inches when unit is imperial
                labelWeight.Text = "Weight (lbs)"; // weight will be measure in lbs when unit is imperial
                textHeight2.Visible = true; // the text for inches becomes visible
                bmiCalc.SetUnit(UnitTypes.Imperial);
                textHeight2.Text = "0"; // textbox for inches is declared with zero

            }
            // the following applies for the two scenarios
            // input
            textHeight.Text = string.Empty; // texbox for height is declared empty
            textWeight.Text = string.Empty; // texbox for weight is declared empty

            // output
            groupResults.Text = "Results";
            labelBMIResult.Text = ""; // label for the bmi result is declared empty
            labelWeightCatResult.Text = ""; // label for the weight category result is declared empty
            labelNormalBMI.Text = ""; // label for normal bmi is declared empty
            labelNormalWeight.Text = ""; // label for normal weight range in kg or lbs is declared empty
        }

        #endregion



        #region ***************//////////////////////////// Saving Calculator Section ////////////////////////////***************

        private void buttonCalcSaving_Click(object sender, EventArgs e)
        {
            bool inputOk = ReadInputSaving();

            if (inputOk)
            {
                DisplayResultsSaving();
            }
        }


        //
        // method for consolidating the methods for inputs saving (deposit, period, interest rate, fees)
        //
        private bool ReadInputSaving()
        {
            bool depositOk = ReadDeposit(); // first read and validate that deposit is correct
            bool periodOk = ReadPeriod(); // second read and validate that period is correct
            bool interestOk = ReadInterest(); // third read and validate that interest is correct
            bool feesOk = ReadFees(); // fourth read and validate that fees is correct

            return depositOk && periodOk && interestOk && feesOk;
        }

        //
        // method for read the deposit value, if it is not correct return am error message
        //
        private bool ReadDeposit()
        {
            bool okDeposit = false; // variable to validate whether deposit value is ok
            double valueDeposit = 0.0; // variable to store deposit value
            string strDeposit = textMonthDep.Text.Trim(); // variable to store the deposit string

            okDeposit = double.TryParse(strDeposit, out valueDeposit); // validate if the input is correct and provide the value
            if (!okDeposit)
            {
                MessageBox.Show("Invalid input for deposit!", "Error");
            }
            savCalc.SetDeposit(valueDeposit);
            return okDeposit;
        }

        //
        // method for read the period, if it is not correct return an error message, otherwise calculates the product of period times 12
        //
        private bool ReadPeriod()
        {
            bool okPeriod = false; // variable to validate whether period value is ok
            int valuePeriod = 0; // variable to store period value
            string strPeriod = textPeriod.Text.Trim(); // variable to store the period string

            okPeriod = int.TryParse(strPeriod, out valuePeriod); // validate if the input is correct and provide the value
            if (!okPeriod)
            {
                MessageBox.Show("Invalid input for period!", "Error");
            }
            else
            {
                valuePeriod = valuePeriod * 12;
            }
            savCalc.SetPeriod(valuePeriod);
            return okPeriod;
        }


        //
        // method for read the interest, if it is not correct return an error message, otherwise calculates calculate monthly interest
        //
        private bool ReadInterest()
        {
            bool okInterest = false; // variable to validate whether interest is ok
            double valueInterest = 0.0; // variable to store period value
            string strInterest = textInterestRate.Text.Trim(); // variable to store the interest string

            okInterest = double.TryParse(strInterest, out valueInterest); // validate if the input is correct and provide the value
            if (!okInterest)
            {
                MessageBox.Show("Invalid input for interest!", "Error");
            }
            else
            {
                valueInterest = valueInterest / 12 / 100;
            }
            savCalc.SetInterest(valueInterest);
            return okInterest;
        }

        //
        // method for read the fees, if it is not correct return an error message, otherwise calculates calculate monthly fees
        //
        private bool ReadFees()
        {
            bool okFees = false; // variable to validate whether fees is ok
            double valueFees = 0.0; // variable to store fees value
            string strFees = textFees.Text.Trim(); // variable to store the fees string

            okFees = double.TryParse(strFees, out valueFees); // validate if the input is correct and provide the value
            if (!okFees)
            {
                MessageBox.Show("Invalid input for fees!", "Error");
            }
            else
            {
                valueFees = valueFees / 12 / 100;
            }
            savCalc.SetFees(valueFees);
            return okFees;
        }

        private void DisplayResultsSaving()
        {
            labelAmtPaidResult.Text = savCalc.CalculateAmountPaid().ToString("f2");
            labelAmtEarnedResult.Text = savCalc.CalculateAmountEarned().ToString("f2");
            labelFBalanceResult.Text = savCalc.CalculateFinalBalance().ToString("f2");
            labelTotalFeesResult.Text =savCalc.CalculateFees().ToString("f2");
        }



        #endregion



        #region ***************//////////////////////////// BMR Calculator Section ////////////////////////////***************

        //
        // method connected with Click event of the button Calculate BMR all code inside will run when user clicks
        //
        private void buttonCalcBMR_Click(object sender, EventArgs e)
        {
            bool inputOk = ReadInputBMR();

            if (inputOk)
            {
                DisplayResultsBMR();
            }
        }

        //
        // method for consolidating the methods for inputs in BMI (name, weight and height)
        //
        private bool ReadInputBMR()
        {
            bool heightOk = TransformToCM(); // read and validate that height in cm 
            bool weightOk = TransformToKG(); //read and validate that weight in kg 
            bool ageOk = ReadAge();
            return heightOk && weightOk && ageOk;
        }

        //
        // method for reading the height string and convert it into a double
        //
        private bool TransformToCM()
        {
            // these works for cm and feet
            bool okHeight = false; // variable to validate height value is ok
            double valueHeight = 0.0; // variable to store height if the value is valid
            string strHeight = textHeight.Text.Trim(); // variable to store the height string

            okHeight = double.TryParse(strHeight, out valueHeight); // validate if the input is correct and provide the value in cm or feet
            if (!okHeight)
            {
                MessageBox.Show("Invalid input for height!", "Error");
            }

            // these are only for inches
            double valueHeight2 = 0.0; // to store inches values if the value is valid
            string strHeight2 = textHeight2.Text.Trim(); // variable to store the inches in string

            if (radioButtonImperial.Checked)
            {
                okHeight = okHeight && double.TryParse(strHeight2, out valueHeight2); // validate if the input for feetand inches is correct
                if (!okHeight)
                {
                    MessageBox.Show("Invalid input for height!", "Error");
                }
            }

            // ft and inches need to be cm
            if (bmiCalc.GetUnit() == UnitTypes.Imperial)
                valueHeight = (valueHeight * 12.0 + valueHeight2) * 2.54; // from feet and inches to cm

            bmrCalc.SetHeightCm(valueHeight);

            return okHeight;
        }

        //
        // method for reading the weight string and convert it into a double 
        //
        private bool TransformToKG()
        {
            bool okWeight = false; // variable to validate weight value is ok
            double valueWeight = 0.0; // variable to store weight if the value is valid
            string strWeight = textWeight.Text.Trim(); // variable to store the weight string

            okWeight = double.TryParse(strWeight, out valueWeight); // validate if the input is correct and provide the value
            if (!okWeight)
            {
                MessageBox.Show("Invalid input for weight!", "Error");
            }
            
            // lbs need to be kg
            if (bmiCalc.GetUnit() == UnitTypes.Imperial)
                valueWeight = valueWeight * 0.453592; // from lbs to kg

            bmrCalc.SetWeightKg(valueWeight);
            return okWeight;
        }

        //
        // method for reading the age
        //
        private bool ReadAge()
        {
            bool okAge = false; // variable to validate weight age is ok
            int valueAge = 0; // variable to store weight if the value is valid
            string strAge = textAge.Text.Trim(); // variable to store the weight string

            okAge = int.TryParse(strAge, out valueAge); // validate if the input is correct and provide the value
            if (!okAge)
            {
                MessageBox.Show("Invalid input for age!", "Error");
            }
            bmrCalc.SetAge(valueAge);
            return okAge;
        }

        //
        // method for displaying results 
        //
        private void DisplayResultsBMR()
        {
            double bmr = bmrCalc.BMRActivity();
            listBoxBMRResults.Items.Clear();
            listBoxBMRResults.BeginUpdate();
            listBoxBMRResults.Items.Add("Results ");
            listBoxBMRResults.Items.Add("Your BMR calories/day = " + bmr);
            listBoxBMRResults.Items.Add("To lose 500gr (0.5kg) a week = " + (bmr-500));
            listBoxBMRResults.Items.Add("To lose 1000gr (1kg) a week = " + (bmr - 1000));
            listBoxBMRResults.Items.Add("To add 500gr (0.5kg) a week = " + (bmr + 500));
            listBoxBMRResults.Items.Add("To add 1000gr (1kg) a week = " + (bmr + 1000));
            listBoxBMRResults.EndUpdate();

        }

        //
        // method for radio button male checked has changed
        //
        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGender();
        }

        //
        // method for radio button female checked has changed
        //
        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGender();
        }

        //
        // method to summarize the necessary changes when radio button for metric and imperial is checked
        //
        private void UpdateGender()
        {
            if (radioButtonMale.Checked)
            {
                bmrCalc.SetGender(GenderTypes.Male);

            }
            else // when radio button for male is not checked
            {
                bmrCalc.SetGender(GenderTypes.Female);

            }
            // the following applies for the two scenarios
            // input
            textAge.Text = string.Empty; // texbox for age is declared empty

            // output
            listBoxBMRResults.Text = "Results:";
        }

        //
        // method for radio button sendentary checked has changed
        //
        private void radioButtonSedentary_CheckedChanged(object sender, EventArgs e)
        {
            UpdateActivity();
        }

        //
        // method for radio button lightly active checked has changed
        //
        private void radioButtonLightly_CheckedChanged(object sender, EventArgs e)
        {
            UpdateActivity();
        }

        //
        // method for radio button moderately active checked has changed
        //
        private void radioButtonModerately_CheckedChanged(object sender, EventArgs e)
        {
            UpdateActivity();
        }

        //
        // method for radio button very active checked has changed
        //
        private void radioButtonVery_CheckedChanged(object sender, EventArgs e)
        {
            UpdateActivity();
        }

        //
        // method for radio button extra active checked has changed
        //
        private void radioButtonExtra_CheckedChanged(object sender, EventArgs e)
        {
            UpdateActivity();
        }


        //
        // method to summarize the necessary changes for radio buttons about activity level
        //
        private void UpdateActivity()
        {
            if (radioButtonSedentary.Checked)
            {
                bmrCalc.SetActivity(ActivityTypes.Sedentary);

            }
            else if (radioButtonLightly.Checked)
            {
                bmrCalc.SetActivity(ActivityTypes.Lightly);

            }
            else if (radioButtonModerately.Checked)
            {
                bmrCalc.SetActivity(ActivityTypes.Moderately);

            }
            else if (radioButtonVery.Checked)
            {
                bmrCalc.SetActivity(ActivityTypes.Very);

            }
            else // if any of the other 4 activities level are checked so it's extra active
            {
                bmrCalc.SetActivity(ActivityTypes.Extra);
            }
        }



        #endregion


    }
}