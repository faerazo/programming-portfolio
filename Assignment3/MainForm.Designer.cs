namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.groupInputs = new System.Windows.Forms.GroupBox();
            this.textHeight2 = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupUnit = new System.Windows.Forms.GroupBox();
            this.radioButtonImperial = new System.Windows.Forms.RadioButton();
            this.radioButtonMetric = new System.Windows.Forms.RadioButton();
            this.buttonCalculateBMI = new System.Windows.Forms.Button();
            this.groupResults = new System.Windows.Forms.GroupBox();
            this.labelNormalWeight = new System.Windows.Forms.Label();
            this.labelNormalBMI = new System.Windows.Forms.Label();
            this.labelWeightCatResult = new System.Windows.Forms.Label();
            this.labelBMIResult = new System.Windows.Forms.Label();
            this.labelWeightCat = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.groupSavingPlan = new System.Windows.Forms.GroupBox();
            this.textFees = new System.Windows.Forms.TextBox();
            this.textInterestRate = new System.Windows.Forms.TextBox();
            this.labelFees = new System.Windows.Forms.Label();
            this.labelInterest = new System.Windows.Forms.Label();
            this.labelStartBalance = new System.Windows.Forms.Label();
            this.textPeriod = new System.Windows.Forms.TextBox();
            this.textMonthDep = new System.Windows.Forms.TextBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelMonthDep = new System.Windows.Forms.Label();
            this.buttonCalcSaving = new System.Windows.Forms.Button();
            this.groupFV = new System.Windows.Forms.GroupBox();
            this.labelAmtEarnedResult = new System.Windows.Forms.Label();
            this.labelTotalFeesResult = new System.Windows.Forms.Label();
            this.labelTotalFees = new System.Windows.Forms.Label();
            this.labelAmountEarned = new System.Windows.Forms.Label();
            this.labelFBalanceResult = new System.Windows.Forms.Label();
            this.labelAmtPaidResult = new System.Windows.Forms.Label();
            this.labelFBalance = new System.Windows.Forms.Label();
            this.labelAmoundPaid = new System.Windows.Forms.Label();
            this.groupBMR = new System.Windows.Forms.GroupBox();
            this.listBoxBMRResults = new System.Windows.Forms.ListBox();
            this.buttonCalcBMR = new System.Windows.Forms.Button();
            this.groupActivity = new System.Windows.Forms.GroupBox();
            this.radioButtonExtra = new System.Windows.Forms.RadioButton();
            this.radioButtonVery = new System.Windows.Forms.RadioButton();
            this.radioButtonModerately = new System.Windows.Forms.RadioButton();
            this.radioButtonLightly = new System.Windows.Forms.RadioButton();
            this.radioButtonSedentary = new System.Windows.Forms.RadioButton();
            this.textAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.groupInputs.SuspendLayout();
            this.groupUnit.SuspendLayout();
            this.groupResults.SuspendLayout();
            this.groupSavingPlan.SuspendLayout();
            this.groupFV.SuspendLayout();
            this.groupBMR.SuspendLayout();
            this.groupActivity.SuspendLayout();
            this.groupGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // groupInputs
            // 
            this.groupInputs.Controls.Add(this.textHeight2);
            this.groupInputs.Controls.Add(this.labelWeight);
            this.groupInputs.Controls.Add(this.labelHeight);
            this.groupInputs.Controls.Add(this.textWeight);
            this.groupInputs.Controls.Add(this.textHeight);
            this.groupInputs.Controls.Add(this.textName);
            this.groupInputs.Controls.Add(this.labelName);
            this.groupInputs.Location = new System.Drawing.Point(15, 14);
            this.groupInputs.Name = "groupInputs";
            this.groupInputs.Size = new System.Drawing.Size(320, 140);
            this.groupInputs.TabIndex = 1;
            this.groupInputs.TabStop = false;
            this.groupInputs.Text = "BMI Calculator";
            // 
            // textHeight2
            // 
            this.textHeight2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHeight2.Location = new System.Drawing.Point(214, 61);
            this.textHeight2.Name = "textHeight2";
            this.textHeight2.Size = new System.Drawing.Size(98, 23);
            this.textHeight2.TabIndex = 6;
            this.textHeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(9, 108);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(45, 15);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Weight";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(9, 63);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(43, 15);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "Height";
            // 
            // textWeight
            // 
            this.textWeight.BackColor = System.Drawing.SystemColors.Window;
            this.textWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textWeight.Location = new System.Drawing.Point(111, 106);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(98, 23);
            this.textWeight.TabIndex = 3;
            this.textWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textHeight
            // 
            this.textHeight.BackColor = System.Drawing.SystemColors.Window;
            this.textHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHeight.Location = new System.Drawing.Point(111, 61);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(98, 23);
            this.textHeight.TabIndex = 2;
            this.textHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.SystemColors.Window;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Location = new System.Drawing.Point(111, 16);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(201, 23);
            this.textName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // groupUnit
            // 
            this.groupUnit.Controls.Add(this.radioButtonImperial);
            this.groupUnit.Controls.Add(this.radioButtonMetric);
            this.groupUnit.Location = new System.Drawing.Point(363, 14);
            this.groupUnit.Name = "groupUnit";
            this.groupUnit.Size = new System.Drawing.Size(122, 84);
            this.groupUnit.TabIndex = 3;
            this.groupUnit.TabStop = false;
            this.groupUnit.Text = "Unit";
            // 
            // radioButtonImperial
            // 
            this.radioButtonImperial.AutoSize = true;
            this.radioButtonImperial.Location = new System.Drawing.Point(6, 47);
            this.radioButtonImperial.Name = "radioButtonImperial";
            this.radioButtonImperial.Size = new System.Drawing.Size(108, 19);
            this.radioButtonImperial.TabIndex = 1;
            this.radioButtonImperial.TabStop = true;
            this.radioButtonImperial.Text = "Imperial (ft, lbs)";
            this.radioButtonImperial.UseVisualStyleBackColor = true;
            this.radioButtonImperial.CheckedChanged += new System.EventHandler(this.radioButtonImperial_CheckedChanged);
            // 
            // radioButtonMetric
            // 
            this.radioButtonMetric.AutoSize = true;
            this.radioButtonMetric.Location = new System.Drawing.Point(6, 22);
            this.radioButtonMetric.Name = "radioButtonMetric";
            this.radioButtonMetric.Size = new System.Drawing.Size(106, 19);
            this.radioButtonMetric.TabIndex = 0;
            this.radioButtonMetric.TabStop = true;
            this.radioButtonMetric.Text = "Metric (cm, kg)";
            this.radioButtonMetric.UseVisualStyleBackColor = true;
            this.radioButtonMetric.CheckedChanged += new System.EventHandler(this.radioButtonMetric_CheckedChanged);
            // 
            // buttonCalculateBMI
            // 
            this.buttonCalculateBMI.Location = new System.Drawing.Point(81, 181);
            this.buttonCalculateBMI.Name = "buttonCalculateBMI";
            this.buttonCalculateBMI.Size = new System.Drawing.Size(176, 46);
            this.buttonCalculateBMI.TabIndex = 4;
            this.buttonCalculateBMI.Text = "Calculate BMI";
            this.buttonCalculateBMI.UseVisualStyleBackColor = true;
            this.buttonCalculateBMI.Click += new System.EventHandler(this.buttonCalculateBMI_Click);
            // 
            // groupResults
            // 
            this.groupResults.Controls.Add(this.labelNormalWeight);
            this.groupResults.Controls.Add(this.labelNormalBMI);
            this.groupResults.Controls.Add(this.labelWeightCatResult);
            this.groupResults.Controls.Add(this.labelBMIResult);
            this.groupResults.Controls.Add(this.labelWeightCat);
            this.groupResults.Controls.Add(this.labelBMI);
            this.groupResults.Location = new System.Drawing.Point(15, 254);
            this.groupResults.Name = "groupResults";
            this.groupResults.Size = new System.Drawing.Size(470, 142);
            this.groupResults.TabIndex = 5;
            this.groupResults.TabStop = false;
            this.groupResults.Text = "Results";
            // 
            // labelNormalWeight
            // 
            this.labelNormalWeight.Location = new System.Drawing.Point(7, 120);
            this.labelNormalWeight.Name = "labelNormalWeight";
            this.labelNormalWeight.Size = new System.Drawing.Size(424, 19);
            this.labelNormalWeight.TabIndex = 5;
            this.labelNormalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNormalBMI
            // 
            this.labelNormalBMI.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelNormalBMI.Location = new System.Drawing.Point(104, 85);
            this.labelNormalBMI.Name = "labelNormalBMI";
            this.labelNormalBMI.Size = new System.Drawing.Size(230, 17);
            this.labelNormalBMI.TabIndex = 4;
            this.labelNormalBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWeightCatResult
            // 
            this.labelWeightCatResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelWeightCatResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWeightCatResult.Location = new System.Drawing.Point(230, 52);
            this.labelWeightCatResult.Name = "labelWeightCatResult";
            this.labelWeightCatResult.Size = new System.Drawing.Size(230, 17);
            this.labelWeightCatResult.TabIndex = 3;
            this.labelWeightCatResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBMIResult
            // 
            this.labelBMIResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelBMIResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBMIResult.Location = new System.Drawing.Point(230, 19);
            this.labelBMIResult.Name = "labelBMIResult";
            this.labelBMIResult.Size = new System.Drawing.Size(106, 17);
            this.labelBMIResult.TabIndex = 2;
            this.labelBMIResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWeightCat
            // 
            this.labelWeightCat.AutoSize = true;
            this.labelWeightCat.Location = new System.Drawing.Point(6, 54);
            this.labelWeightCat.Name = "labelWeightCat";
            this.labelWeightCat.Size = new System.Drawing.Size(96, 15);
            this.labelWeightCat.TabIndex = 1;
            this.labelWeightCat.Text = "Weight Category";
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Location = new System.Drawing.Point(6, 21);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(28, 15);
            this.labelBMI.TabIndex = 0;
            this.labelBMI.Text = "BMI";
            // 
            // groupSavingPlan
            // 
            this.groupSavingPlan.Controls.Add(this.textFees);
            this.groupSavingPlan.Controls.Add(this.textInterestRate);
            this.groupSavingPlan.Controls.Add(this.labelFees);
            this.groupSavingPlan.Controls.Add(this.labelInterest);
            this.groupSavingPlan.Controls.Add(this.labelStartBalance);
            this.groupSavingPlan.Controls.Add(this.textPeriod);
            this.groupSavingPlan.Controls.Add(this.textMonthDep);
            this.groupSavingPlan.Controls.Add(this.labelPeriod);
            this.groupSavingPlan.Controls.Add(this.labelMonthDep);
            this.groupSavingPlan.Location = new System.Drawing.Point(536, 14);
            this.groupSavingPlan.Name = "groupSavingPlan";
            this.groupSavingPlan.Size = new System.Drawing.Size(332, 140);
            this.groupSavingPlan.TabIndex = 6;
            this.groupSavingPlan.TabStop = false;
            this.groupSavingPlan.Text = "Saving Plan";
            // 
            // textFees
            // 
            this.textFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFees.Location = new System.Drawing.Point(131, 106);
            this.textFees.Name = "textFees";
            this.textFees.Size = new System.Drawing.Size(147, 23);
            this.textFees.TabIndex = 9;
            this.textFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textInterestRate
            // 
            this.textInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textInterestRate.Location = new System.Drawing.Point(131, 76);
            this.textInterestRate.Name = "textInterestRate";
            this.textInterestRate.Size = new System.Drawing.Size(147, 23);
            this.textInterestRate.TabIndex = 8;
            this.textInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFees
            // 
            this.labelFees.AutoSize = true;
            this.labelFees.Location = new System.Drawing.Point(6, 109);
            this.labelFees.Name = "labelFees";
            this.labelFees.Size = new System.Drawing.Size(51, 15);
            this.labelFees.TabIndex = 6;
            this.labelFees.Text = "Fees (%)";
            // 
            // labelInterest
            // 
            this.labelInterest.AutoSize = true;
            this.labelInterest.Location = new System.Drawing.Point(6, 79);
            this.labelInterest.Name = "labelInterest";
            this.labelInterest.Size = new System.Drawing.Size(93, 15);
            this.labelInterest.TabIndex = 5;
            this.labelInterest.Text = "Interest Rate (%)";
            // 
            // labelStartBalance
            // 
            this.labelStartBalance.AutoSize = true;
            this.labelStartBalance.Location = new System.Drawing.Point(6, 19);
            this.labelStartBalance.Name = "labelStartBalance";
            this.labelStartBalance.Size = new System.Drawing.Size(0, 15);
            this.labelStartBalance.TabIndex = 4;
            // 
            // textPeriod
            // 
            this.textPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPeriod.Location = new System.Drawing.Point(131, 45);
            this.textPeriod.Name = "textPeriod";
            this.textPeriod.Size = new System.Drawing.Size(147, 23);
            this.textPeriod.TabIndex = 3;
            this.textPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMonthDep
            // 
            this.textMonthDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMonthDep.Location = new System.Drawing.Point(131, 15);
            this.textMonthDep.Name = "textMonthDep";
            this.textMonthDep.Size = new System.Drawing.Size(147, 23);
            this.textMonthDep.TabIndex = 2;
            this.textMonthDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(6, 49);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(79, 15);
            this.labelPeriod.TabIndex = 1;
            this.labelPeriod.Text = "Period (Years)";
            // 
            // labelMonthDep
            // 
            this.labelMonthDep.AutoSize = true;
            this.labelMonthDep.Location = new System.Drawing.Point(6, 19);
            this.labelMonthDep.Name = "labelMonthDep";
            this.labelMonthDep.Size = new System.Drawing.Size(95, 15);
            this.labelMonthDep.TabIndex = 0;
            this.labelMonthDep.Text = "Monthly Deposit";
            // 
            // buttonCalcSaving
            // 
            this.buttonCalcSaving.Location = new System.Drawing.Point(614, 181);
            this.buttonCalcSaving.Name = "buttonCalcSaving";
            this.buttonCalcSaving.Size = new System.Drawing.Size(176, 46);
            this.buttonCalcSaving.TabIndex = 7;
            this.buttonCalcSaving.Text = "Calculate Saving";
            this.buttonCalcSaving.UseVisualStyleBackColor = true;
            this.buttonCalcSaving.Click += new System.EventHandler(this.buttonCalcSaving_Click);
            // 
            // groupFV
            // 
            this.groupFV.Controls.Add(this.labelAmtEarnedResult);
            this.groupFV.Controls.Add(this.labelTotalFeesResult);
            this.groupFV.Controls.Add(this.labelTotalFees);
            this.groupFV.Controls.Add(this.labelAmountEarned);
            this.groupFV.Controls.Add(this.labelFBalanceResult);
            this.groupFV.Controls.Add(this.labelAmtPaidResult);
            this.groupFV.Controls.Add(this.labelFBalance);
            this.groupFV.Controls.Add(this.labelAmoundPaid);
            this.groupFV.Location = new System.Drawing.Point(536, 254);
            this.groupFV.Name = "groupFV";
            this.groupFV.Size = new System.Drawing.Size(332, 139);
            this.groupFV.TabIndex = 8;
            this.groupFV.TabStop = false;
            this.groupFV.Text = "Future Value";
            // 
            // labelAmtEarnedResult
            // 
            this.labelAmtEarnedResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelAmtEarnedResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAmtEarnedResult.Location = new System.Drawing.Point(159, 48);
            this.labelAmtEarnedResult.Name = "labelAmtEarnedResult";
            this.labelAmtEarnedResult.Size = new System.Drawing.Size(119, 15);
            this.labelAmtEarnedResult.TabIndex = 7;
            this.labelAmtEarnedResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalFeesResult
            // 
            this.labelTotalFeesResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelTotalFeesResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalFeesResult.Location = new System.Drawing.Point(159, 101);
            this.labelTotalFeesResult.Name = "labelTotalFeesResult";
            this.labelTotalFeesResult.Size = new System.Drawing.Size(119, 15);
            this.labelTotalFeesResult.TabIndex = 6;
            this.labelTotalFeesResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalFees
            // 
            this.labelTotalFees.AutoSize = true;
            this.labelTotalFees.Location = new System.Drawing.Point(6, 102);
            this.labelTotalFees.Name = "labelTotalFees";
            this.labelTotalFees.Size = new System.Drawing.Size(58, 15);
            this.labelTotalFees.TabIndex = 5;
            this.labelTotalFees.Text = "Total Fees";
            // 
            // labelAmountEarned
            // 
            this.labelAmountEarned.AutoSize = true;
            this.labelAmountEarned.Location = new System.Drawing.Point(6, 48);
            this.labelAmountEarned.Name = "labelAmountEarned";
            this.labelAmountEarned.Size = new System.Drawing.Size(90, 15);
            this.labelAmountEarned.TabIndex = 4;
            this.labelAmountEarned.Text = "Amount Earned";
            // 
            // labelFBalanceResult
            // 
            this.labelFBalanceResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelFBalanceResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFBalanceResult.Location = new System.Drawing.Point(159, 74);
            this.labelFBalanceResult.Name = "labelFBalanceResult";
            this.labelFBalanceResult.Size = new System.Drawing.Size(119, 15);
            this.labelFBalanceResult.TabIndex = 3;
            this.labelFBalanceResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAmtPaidResult
            // 
            this.labelAmtPaidResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelAmtPaidResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAmtPaidResult.Location = new System.Drawing.Point(159, 20);
            this.labelAmtPaidResult.Name = "labelAmtPaidResult";
            this.labelAmtPaidResult.Size = new System.Drawing.Size(119, 15);
            this.labelAmtPaidResult.TabIndex = 2;
            this.labelAmtPaidResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFBalance
            // 
            this.labelFBalance.AutoSize = true;
            this.labelFBalance.Location = new System.Drawing.Point(6, 75);
            this.labelFBalance.Name = "labelFBalance";
            this.labelFBalance.Size = new System.Drawing.Size(76, 15);
            this.labelFBalance.TabIndex = 1;
            this.labelFBalance.Text = "Final Balance";
            // 
            // labelAmoundPaid
            // 
            this.labelAmoundPaid.AutoSize = true;
            this.labelAmoundPaid.Location = new System.Drawing.Point(6, 21);
            this.labelAmoundPaid.Name = "labelAmoundPaid";
            this.labelAmoundPaid.Size = new System.Drawing.Size(77, 15);
            this.labelAmoundPaid.TabIndex = 0;
            this.labelAmoundPaid.Text = "Amount Paid";
            // 
            // groupBMR
            // 
            this.groupBMR.Controls.Add(this.listBoxBMRResults);
            this.groupBMR.Controls.Add(this.buttonCalcBMR);
            this.groupBMR.Controls.Add(this.groupActivity);
            this.groupBMR.Controls.Add(this.textAge);
            this.groupBMR.Controls.Add(this.labelAge);
            this.groupBMR.Controls.Add(this.groupGender);
            this.groupBMR.Location = new System.Drawing.Point(14, 401);
            this.groupBMR.Name = "groupBMR";
            this.groupBMR.Size = new System.Drawing.Size(853, 224);
            this.groupBMR.TabIndex = 9;
            this.groupBMR.TabStop = false;
            this.groupBMR.Text = "BMR Calculator";
            // 
            // listBoxBMRResults
            // 
            this.listBoxBMRResults.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBoxBMRResults.FormattingEnabled = true;
            this.listBoxBMRResults.ItemHeight = 15;
            this.listBoxBMRResults.Location = new System.Drawing.Point(399, 21);
            this.listBoxBMRResults.Name = "listBoxBMRResults";
            this.listBoxBMRResults.Size = new System.Drawing.Size(439, 184);
            this.listBoxBMRResults.TabIndex = 5;
            // 
            // buttonCalcBMR
            // 
            this.buttonCalcBMR.Location = new System.Drawing.Point(76, 175);
            this.buttonCalcBMR.Name = "buttonCalcBMR";
            this.buttonCalcBMR.Size = new System.Drawing.Size(176, 46);
            this.buttonCalcBMR.TabIndex = 4;
            this.buttonCalcBMR.Text = "Calculate BMR";
            this.buttonCalcBMR.UseVisualStyleBackColor = true;
            this.buttonCalcBMR.Click += new System.EventHandler(this.buttonCalcBMR_Click);
            // 
            // groupActivity
            // 
            this.groupActivity.Controls.Add(this.radioButtonExtra);
            this.groupActivity.Controls.Add(this.radioButtonVery);
            this.groupActivity.Controls.Add(this.radioButtonModerately);
            this.groupActivity.Controls.Add(this.radioButtonLightly);
            this.groupActivity.Controls.Add(this.radioButtonSedentary);
            this.groupActivity.Location = new System.Drawing.Point(152, 22);
            this.groupActivity.Name = "groupActivity";
            this.groupActivity.Size = new System.Drawing.Size(241, 150);
            this.groupActivity.TabIndex = 3;
            this.groupActivity.TabStop = false;
            this.groupActivity.Text = "Weekly Activity Level";
            // 
            // radioButtonExtra
            // 
            this.radioButtonExtra.AutoSize = true;
            this.radioButtonExtra.Location = new System.Drawing.Point(6, 123);
            this.radioButtonExtra.Name = "radioButtonExtra";
            this.radioButtonExtra.Size = new System.Drawing.Size(167, 19);
            this.radioButtonExtra.TabIndex = 4;
            this.radioButtonExtra.TabStop = true;
            this.radioButtonExtra.Text = "Extra Active (hard exercise)";
            this.radioButtonExtra.UseVisualStyleBackColor = true;
            this.radioButtonExtra.CheckedChanged += new System.EventHandler(this.radioButtonExtra_CheckedChanged);
            // 
            // radioButtonVery
            // 
            this.radioButtonVery.AutoSize = true;
            this.radioButtonVery.Location = new System.Drawing.Point(6, 98);
            this.radioButtonVery.Name = "radioButtonVery";
            this.radioButtonVery.Size = new System.Drawing.Size(155, 19);
            this.radioButtonVery.TabIndex = 3;
            this.radioButtonVery.TabStop = true;
            this.radioButtonVery.Text = "Very Active (6 to 7 times)";
            this.radioButtonVery.UseVisualStyleBackColor = true;
            this.radioButtonVery.CheckedChanged += new System.EventHandler(this.radioButtonVery_CheckedChanged);
            // 
            // radioButtonModerately
            // 
            this.radioButtonModerately.AutoSize = true;
            this.radioButtonModerately.Location = new System.Drawing.Point(6, 73);
            this.radioButtonModerately.Name = "radioButtonModerately";
            this.radioButtonModerately.Size = new System.Drawing.Size(193, 19);
            this.radioButtonModerately.TabIndex = 2;
            this.radioButtonModerately.TabStop = true;
            this.radioButtonModerately.Text = "Moderately Active (3 to 5 times)";
            this.radioButtonModerately.UseVisualStyleBackColor = true;
            this.radioButtonModerately.CheckedChanged += new System.EventHandler(this.radioButtonModerately_CheckedChanged);
            // 
            // radioButtonLightly
            // 
            this.radioButtonLightly.AutoSize = true;
            this.radioButtonLightly.Location = new System.Drawing.Point(6, 48);
            this.radioButtonLightly.Name = "radioButtonLightly";
            this.radioButtonLightly.Size = new System.Drawing.Size(169, 19);
            this.radioButtonLightly.TabIndex = 1;
            this.radioButtonLightly.TabStop = true;
            this.radioButtonLightly.Text = "Lightly Active (1 to 3 times)";
            this.radioButtonLightly.UseVisualStyleBackColor = true;
            this.radioButtonLightly.CheckedChanged += new System.EventHandler(this.radioButtonLightly_CheckedChanged);
            // 
            // radioButtonSedentary
            // 
            this.radioButtonSedentary.AutoSize = true;
            this.radioButtonSedentary.Location = new System.Drawing.Point(6, 22);
            this.radioButtonSedentary.Name = "radioButtonSedentary";
            this.radioButtonSedentary.Size = new System.Drawing.Size(193, 19);
            this.radioButtonSedentary.TabIndex = 0;
            this.radioButtonSedentary.TabStop = true;
            this.radioButtonSedentary.Text = "Sedentary (little or no excercise)";
            this.radioButtonSedentary.UseVisualStyleBackColor = true;
            this.radioButtonSedentary.CheckedChanged += new System.EventHandler(this.radioButtonSedentary_CheckedChanged);
            // 
            // textAge
            // 
            this.textAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAge.Location = new System.Drawing.Point(58, 123);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(58, 23);
            this.textAge.TabIndex = 2;
            this.textAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(21, 127);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(28, 15);
            this.labelAge.TabIndex = 1;
            this.labelAge.Text = "Age";
            // 
            // groupGender
            // 
            this.groupGender.Controls.Add(this.radioButtonFemale);
            this.groupGender.Controls.Add(this.radioButtonMale);
            this.groupGender.Location = new System.Drawing.Point(13, 23);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(125, 83);
            this.groupGender.TabIndex = 0;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Gender";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(6, 47);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(63, 19);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(6, 22);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(51, 19);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 625);
            this.Controls.Add(this.groupBMR);
            this.Controls.Add(this.groupFV);
            this.Controls.Add(this.buttonCalcSaving);
            this.Controls.Add(this.groupSavingPlan);
            this.Controls.Add(this.groupResults);
            this.Controls.Add(this.buttonCalculateBMI);
            this.Controls.Add(this.groupUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupInputs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.groupInputs.ResumeLayout(false);
            this.groupInputs.PerformLayout();
            this.groupUnit.ResumeLayout(false);
            this.groupUnit.PerformLayout();
            this.groupResults.ResumeLayout(false);
            this.groupResults.PerformLayout();
            this.groupSavingPlan.ResumeLayout(false);
            this.groupSavingPlan.PerformLayout();
            this.groupFV.ResumeLayout(false);
            this.groupFV.PerformLayout();
            this.groupBMR.ResumeLayout(false);
            this.groupBMR.PerformLayout();
            this.groupActivity.ResumeLayout(false);
            this.groupActivity.PerformLayout();
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelName;
        private GroupBox groupInputs;
        private TextBox textWeight;
        private TextBox textHeight;
        private TextBox textName;
        private Label label2;
        private GroupBox groupUnit;
        private RadioButton radioButtonImperial;
        private RadioButton radioButtonMetric;
        private Button buttonCalculateBMI;
        private GroupBox groupResults;
        private Label labelWeightCat;
        private Label labelBMI;
        private Label labelWeightCatResult;
        private Label labelBMIResult;
        private Label labelHeight;
        private Label labelWeight;
        private TextBox textHeight2;
        private Label labelNormalWeight;
        private Label labelNormalBMI;
        private GroupBox groupSavingPlan;
        private TextBox textPeriod;
        private TextBox textMonthDep;
        private Label labelPeriod;
        private Label labelMonthDep;
        private Button buttonCalcSaving;
        private GroupBox groupFV;
        private Label labelFBalanceResult;
        private Label labelAmtPaidResult;
        private Label labelFBalance;
        private Label labelAmoundPaid;
        private TextBox textFees;
        private TextBox textInterestRate;
        private Label labelFees;
        private Label labelInterest;
        private Label labelStartBalance;
        private Label labelAmtEarnedResult;
        private Label labelTotalFeesResult;
        private Label labelTotalFees;
        private Label labelAmountEarned;
        private GroupBox groupBMR;
        private TextBox textAge;
        private Label labelAge;
        private GroupBox groupGender;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private ListBox listBoxBMRResults;
        private Button buttonCalcBMR;
        private GroupBox groupActivity;
        private RadioButton radioButtonExtra;
        private RadioButton radioButtonVery;
        private RadioButton radioButtonModerately;
        private RadioButton radioButtonLightly;
        private RadioButton radioButtonSedentary;
    }
}