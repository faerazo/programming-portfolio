namespace PartyOrganizer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxParty = new System.Windows.Forms.GroupBox();
            this.buttonCreateList = new System.Windows.Forms.Button();
            this.textBoxFeePerson = new System.Windows.Forms.TextBox();
            this.textBoxCostPerson = new System.Windows.Forms.TextBox();
            this.textBoxMaxGuests = new System.Windows.Forms.TextBox();
            this.labelFeePerson = new System.Windows.Forms.Label();
            this.labelCostPerson = new System.Windows.Forms.Label();
            this.labelMaxGuests = new System.Windows.Forms.Label();
            this.groupBoxGuest = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelNumberGuests = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelTotalFees = new System.Windows.Forms.Label();
            this.labelSurplus = new System.Windows.Forms.Label();
            this.labelNumberGuestsResult = new System.Windows.Forms.Label();
            this.labelTotalCostResult = new System.Windows.Forms.Label();
            this.labelTotalFeesResult = new System.Windows.Forms.Label();
            this.labelSurplusResult = new System.Windows.Forms.Label();
            this.labelGuestList = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxList = new System.Windows.Forms.ListBox();
            this.groupBoxParty.SuspendLayout();
            this.groupBoxGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParty
            // 
            this.groupBoxParty.Controls.Add(this.buttonCreateList);
            this.groupBoxParty.Controls.Add(this.textBoxFeePerson);
            this.groupBoxParty.Controls.Add(this.textBoxCostPerson);
            this.groupBoxParty.Controls.Add(this.textBoxMaxGuests);
            this.groupBoxParty.Controls.Add(this.labelFeePerson);
            this.groupBoxParty.Controls.Add(this.labelCostPerson);
            this.groupBoxParty.Controls.Add(this.labelMaxGuests);
            this.groupBoxParty.Location = new System.Drawing.Point(12, 12);
            this.groupBoxParty.Name = "groupBoxParty";
            this.groupBoxParty.Size = new System.Drawing.Size(244, 143);
            this.groupBoxParty.TabIndex = 0;
            this.groupBoxParty.TabStop = false;
            this.groupBoxParty.Text = "New Party";
            // 
            // buttonCreateList
            // 
            this.buttonCreateList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreateList.Location = new System.Drawing.Point(71, 107);
            this.buttonCreateList.Name = "buttonCreateList";
            this.buttonCreateList.Size = new System.Drawing.Size(88, 30);
            this.buttonCreateList.TabIndex = 6;
            this.buttonCreateList.Text = "Create List";
            this.buttonCreateList.UseVisualStyleBackColor = true;
            this.buttonCreateList.Click += new System.EventHandler(this.buttonCreateList_Click);
            // 
            // textBoxFeePerson
            // 
            this.textBoxFeePerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFeePerson.Location = new System.Drawing.Point(131, 69);
            this.textBoxFeePerson.Name = "textBoxFeePerson";
            this.textBoxFeePerson.Size = new System.Drawing.Size(97, 20);
            this.textBoxFeePerson.TabIndex = 5;
            this.textBoxFeePerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCostPerson
            // 
            this.textBoxCostPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCostPerson.Location = new System.Drawing.Point(131, 45);
            this.textBoxCostPerson.Name = "textBoxCostPerson";
            this.textBoxCostPerson.Size = new System.Drawing.Size(97, 20);
            this.textBoxCostPerson.TabIndex = 4;
            this.textBoxCostPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMaxGuests
            // 
            this.textBoxMaxGuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaxGuests.Location = new System.Drawing.Point(131, 21);
            this.textBoxMaxGuests.Name = "textBoxMaxGuests";
            this.textBoxMaxGuests.Size = new System.Drawing.Size(97, 20);
            this.textBoxMaxGuests.TabIndex = 3;
            this.textBoxMaxGuests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFeePerson
            // 
            this.labelFeePerson.AutoSize = true;
            this.labelFeePerson.Location = new System.Drawing.Point(6, 73);
            this.labelFeePerson.Name = "labelFeePerson";
            this.labelFeePerson.Size = new System.Drawing.Size(78, 13);
            this.labelFeePerson.TabIndex = 2;
            this.labelFeePerson.Text = "Fee per person";
            // 
            // labelCostPerson
            // 
            this.labelCostPerson.AutoSize = true;
            this.labelCostPerson.Location = new System.Drawing.Point(6, 49);
            this.labelCostPerson.Name = "labelCostPerson";
            this.labelCostPerson.Size = new System.Drawing.Size(81, 13);
            this.labelCostPerson.TabIndex = 1;
            this.labelCostPerson.Text = "Cost per person";
            // 
            // labelMaxGuests
            // 
            this.labelMaxGuests.AutoSize = true;
            this.labelMaxGuests.Location = new System.Drawing.Point(6, 25);
            this.labelMaxGuests.Name = "labelMaxGuests";
            this.labelMaxGuests.Size = new System.Drawing.Size(111, 13);
            this.labelMaxGuests.TabIndex = 0;
            this.labelMaxGuests.Text = "Max number of guests";
            // 
            // groupBoxGuest
            // 
            this.groupBoxGuest.Controls.Add(this.buttonAdd);
            this.groupBoxGuest.Controls.Add(this.textBoxLastName);
            this.groupBoxGuest.Controls.Add(this.textBoxFirstName);
            this.groupBoxGuest.Controls.Add(this.labelLastName);
            this.groupBoxGuest.Controls.Add(this.labelFirstName);
            this.groupBoxGuest.Location = new System.Drawing.Point(12, 192);
            this.groupBoxGuest.Name = "groupBoxGuest";
            this.groupBoxGuest.Size = new System.Drawing.Size(244, 123);
            this.groupBoxGuest.TabIndex = 1;
            this.groupBoxGuest.TabStop = false;
            this.groupBoxGuest.Text = "Invite Guest";
            // 
            // buttonAdd
            // 
            this.buttonAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonAdd.Location = new System.Drawing.Point(71, 87);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 30);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastName.Location = new System.Drawing.Point(131, 45);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(97, 20);
            this.textBoxLastName.TabIndex = 3;
            this.textBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.Location = new System.Drawing.Point(131, 21);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(97, 20);
            this.textBoxFirstName.TabIndex = 2;
            this.textBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(5, 49);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(6, 25);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // labelNumberGuests
            // 
            this.labelNumberGuests.AutoSize = true;
            this.labelNumberGuests.Location = new System.Drawing.Point(17, 336);
            this.labelNumberGuests.Name = "labelNumberGuests";
            this.labelNumberGuests.Size = new System.Drawing.Size(90, 13);
            this.labelNumberGuests.TabIndex = 2;
            this.labelNumberGuests.Text = "Number of guests";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(17, 359);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(54, 13);
            this.labelTotalCost.TabIndex = 3;
            this.labelTotalCost.Text = "Total cost";
            // 
            // labelTotalFees
            // 
            this.labelTotalFees.AutoSize = true;
            this.labelTotalFees.Location = new System.Drawing.Point(17, 382);
            this.labelTotalFees.Name = "labelTotalFees";
            this.labelTotalFees.Size = new System.Drawing.Size(54, 13);
            this.labelTotalFees.TabIndex = 4;
            this.labelTotalFees.Text = "Total fees";
            // 
            // labelSurplus
            // 
            this.labelSurplus.AutoSize = true;
            this.labelSurplus.Location = new System.Drawing.Point(17, 405);
            this.labelSurplus.Name = "labelSurplus";
            this.labelSurplus.Size = new System.Drawing.Size(75, 13);
            this.labelSurplus.TabIndex = 5;
            this.labelSurplus.Text = "Surplus/deficit";
            // 
            // labelNumberGuestsResult
            // 
            this.labelNumberGuestsResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelNumberGuestsResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNumberGuestsResult.Location = new System.Drawing.Point(141, 331);
            this.labelNumberGuestsResult.Name = "labelNumberGuestsResult";
            this.labelNumberGuestsResult.Size = new System.Drawing.Size(100, 23);
            this.labelNumberGuestsResult.TabIndex = 6;
            this.labelNumberGuestsResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalCostResult
            // 
            this.labelTotalCostResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelTotalCostResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalCostResult.Location = new System.Drawing.Point(141, 354);
            this.labelTotalCostResult.Name = "labelTotalCostResult";
            this.labelTotalCostResult.Size = new System.Drawing.Size(100, 23);
            this.labelTotalCostResult.TabIndex = 7;
            this.labelTotalCostResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalFeesResult
            // 
            this.labelTotalFeesResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelTotalFeesResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalFeesResult.Location = new System.Drawing.Point(141, 377);
            this.labelTotalFeesResult.Name = "labelTotalFeesResult";
            this.labelTotalFeesResult.Size = new System.Drawing.Size(100, 23);
            this.labelTotalFeesResult.TabIndex = 8;
            this.labelTotalFeesResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSurplusResult
            // 
            this.labelSurplusResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelSurplusResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSurplusResult.Location = new System.Drawing.Point(141, 400);
            this.labelSurplusResult.Name = "labelSurplusResult";
            this.labelSurplusResult.Size = new System.Drawing.Size(100, 23);
            this.labelSurplusResult.TabIndex = 9;
            this.labelSurplusResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGuestList
            // 
            this.labelGuestList.AutoSize = true;
            this.labelGuestList.Location = new System.Drawing.Point(423, 12);
            this.labelGuestList.Name = "labelGuestList";
            this.labelGuestList.Size = new System.Drawing.Size(54, 13);
            this.labelGuestList.TabIndex = 10;
            this.labelGuestList.Text = "Guest List";
            // 
            // buttonDelete
            // 
            this.buttonDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Location = new System.Drawing.Point(405, 377);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 30);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxList
            // 
            this.listBoxList.FormattingEnabled = true;
            this.listBoxList.Location = new System.Drawing.Point(305, 38);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.Size = new System.Drawing.Size(297, 316);
            this.listBoxList.TabIndex = 12;
            this.listBoxList.SelectedIndexChanged += new System.EventHandler(this.listBoxList_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.listBoxList);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelGuestList);
            this.Controls.Add(this.labelSurplusResult);
            this.Controls.Add(this.labelTotalFeesResult);
            this.Controls.Add(this.labelTotalCostResult);
            this.Controls.Add(this.labelNumberGuestsResult);
            this.Controls.Add(this.labelSurplus);
            this.Controls.Add(this.labelTotalFees);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelNumberGuests);
            this.Controls.Add(this.groupBoxGuest);
            this.Controls.Add(this.groupBoxParty);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party Organizer";
            this.groupBoxParty.ResumeLayout(false);
            this.groupBoxParty.PerformLayout();
            this.groupBoxGuest.ResumeLayout(false);
            this.groupBoxGuest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParty;
        private System.Windows.Forms.GroupBox groupBoxGuest;
        private System.Windows.Forms.Label labelFeePerson;
        private System.Windows.Forms.Label labelCostPerson;
        private System.Windows.Forms.Label labelMaxGuests;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelNumberGuests;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label labelTotalFees;
        private System.Windows.Forms.Label labelSurplus;
        private System.Windows.Forms.Label labelNumberGuestsResult;
        private System.Windows.Forms.Label labelTotalCostResult;
        private System.Windows.Forms.Label labelTotalFeesResult;
        private System.Windows.Forms.Label labelSurplusResult;
        private System.Windows.Forms.Label labelGuestList;
        private System.Windows.Forms.TextBox textBoxFeePerson;
        private System.Windows.Forms.TextBox textBoxCostPerson;
        private System.Windows.Forms.TextBox textBoxMaxGuests;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonCreateList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxList;
    }
}

