using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyOrganizer
{
    public partial class MainForm : Form
    {
        // reference variable declared, object not created
        PartyManager partyManager;

        public MainForm()
        {
            InitializeComponent();
            // call method to prepare GUI
            InitializeGUI();
        }

        /// <summary>
        /// the code inside this method runs when the GUI initialized
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "Party Organizer by Francisco Erazo";

            // input controls for new party
            textBoxMaxGuests.Text = string.Empty; // textbox for max number guests is declared empty
            textBoxCostPerson.Text = string.Empty; // textbox for cost per person is declared empty
            textBoxFeePerson.Text = string.Empty; // textbox for fee per person is declared empty
            textBoxFirstName.Text = string.Empty; // textbox for first name is declared empty
            textBoxLastName.Text = string.Empty; // textbox for last name is declared empty

            // group boxes
            groupBoxParty.Enabled = true; // enable group box for new party
            groupBoxGuest.Enabled = false; // disable the groupbox for adding new guests

            // output results
            labelNumberGuestsResult.Text = "0.00"; // label for the number of guest result is declared empty
            labelTotalCostResult.Text = "0.00"; // label for total cost result is declared empty
            labelTotalFeesResult.Text = "0.00"; // label for total fees result is declared empty
            labelSurplusResult.Text = "0.00"; // label for surplus or deficit result is declared empty
            listBoxList.Items.Clear();
        }

        ////////////////////////////////////////////////////////////// Buttons and List Box  //////////////////////////////////////////////////////////////
        /// <summary>
        /// method connected with Click event of the button Create List, all code inside will run when
        /// user clicks this button
        /// </summary>
        private void buttonCreateList_Click(object sender, EventArgs e)
        {
            bool inputOK = ReadInputNewParty(); // calling method to validate max number of guests, cost and fee per person are correct

            if (inputOK)
            {
                // calling method for creating the partyManager object 
                CreateParty();

                // saving the cost and fee values in the partyManager object
                partyManager.CostPerPerson = double.Parse(textBoxCostPerson.Text);
                partyManager.FeePerPerson = double.Parse(textBoxFeePerson.Text);

                // group boxes
                groupBoxGuest.Enabled = true; // enable the groupbox for adding new guests

            }
        }

        /// <summary>
        /// method connected with Click event of the button Add, all code inside will run when
        /// users click this button
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool inputOK = ReadGuestName(); // calling method to validate first and last name are not empty

            if (inputOK)
            {
                // calling method to add new guest from party manager, if the guest is added correctly, ok is true, otherwise false
                bool ok = partyManager.AddNewGuest(textBoxFirstName.Text, textBoxLastName.Text); 
                
                // reset to empty the text boxes first and last name, so user can insert another name
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";

                if (ok) // if the new guest is added succesfully, the GUI is updated with the new values
                {
                    UpdateGUI(); // calling method for updating the GUI
                }

            }
        }

        /// <summary>
        /// method connected with selecting the list box of guests
        /// </summary>
        private void listBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxList.SelectedIndex; // saving the index of the selected guest from the lists

            if (index >= 0)
            {
                string name = partyManager.GetItemAt(index); // saving the name from the array using the index
                string[] names = name.Split(','); // split the name using the separator comma
                textBoxFirstName.Text = names[1].Trim(); // updating the text box for fist name with name of the selected guest
                textBoxLastName.Text = names[0].Trim(); // updating the text box for last name with the last name of the selected guest
            }
        }

        /// <summary>
        /// method connected with Click event for the button delete, all inside will run when users clicks this button
        /// </summary>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxList.SelectedIndex; // saving the index of the selected guest from the lists

            if (index >= 0)
            {
                partyManager.DeleteAt(index); // calling the method delete at which consider the index from the list box

                UpdateGUI(); // when a guest is deleted from the list, the GUI is updated

                // reset to empty the text boxes first and last name, so user can insert another name
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
            }

        }

        ////////////////////////////////////////////////////////////// Methods //////////////////////////////////////////////////////////////
        /// <summary>
        /// method for creating the object partyManager wich call the constructor for creating the array according to max number of guests
        /// </summary>
        private void CreateParty()
        {
            int maxGuests = int.Parse(textBoxMaxGuests.Text); // parsing the text from the text box max number of guests
            partyManager = new PartyManager(maxGuests); // calling method for constructing the array using the dimension of max number of guests
            MessageBox.Show($"Party list with space for {maxGuests} guests created!", "Success"); 
        }

        /// <summary>
        /// method for updating the GUI when a new guest is added or removed from the list 
        /// </summary>
        private void UpdateGUI()
        {
            listBoxList.Items.Clear(); // clearing the list box
            string[] guestList = partyManager.GetGuestList(); // calling method get guest list which returns an array with all guests

            if (guestList != null) // validate the array is not null
            {
                for (int i = 0; i < guestList.Length; i++) // for statement for going through every element of the array
                {
                    string str = $"{i + 1,4} {guestList[i],-20}"; // creating an independent string variable to store the guest with format
                    listBoxList.Items.Add(str); // update the list box with the previos string
                }
            }
            else
            {
                return;
            }

            // update the number of total guests
            int totalGuests = partyManager.NumberOfGuests();
            labelNumberGuestsResult.Text = totalGuests.ToString();

            // update the total cost according the number of guests
            double totalCost = partyManager.CalcTotalCost();
            labelTotalCostResult.Text = totalCost.ToString("0.00");

            // update the total fees according to the number of guests
            double totalFees = partyManager.CalcTotalFees();
            labelTotalFeesResult.Text = totalFees.ToString("0.00");

            // calculate the surplus or deficit 
            double surplus = totalFees - totalCost;
            labelSurplusResult.Text = surplus.ToString("0.00");

        }

        #region read methods for max number of guets, cost and fee per person
        /// <summary>
        /// method for consolidatiing the read methods for inputs in the new party group (max number of guests,
        /// cost and fee per person
        /// </summary>
        /// <returns>bool that will be equal to 1 if all inputs are correct</returns>
        private bool ReadInputNewParty()
        {
            bool maxNumberGuestsOK = ReadMaxNumberofGuests(); // read and validate max number of guests
            bool costPersonOK = ReadCostPerPerson(); // read and validate cost per person
            bool feepersonOK = ReadFeePerPerson(); // read and validate fee per person

            return maxNumberGuestsOK && costPersonOK && feepersonOK;
        }

        /// <summary>
        /// method for reading the max number of guests which is a string that is converted into a integer
        /// if the value is not an integer, a message error appears
        /// </summary>
        private bool ReadMaxNumberofGuests()
        {
            bool valueOk = false;
            int value = 0;
            string strValue = textBoxMaxGuests.Text.Trim(); //saving the string from text box without extra spaces

            valueOk = int.TryParse(strValue, out value); // validate whether the value is correct or not
            if (!valueOk) 
            {
                MessageBox.Show("Invalid input for maximum number of guests!", "Error");
            }
            else if(value <= 0) // the max number of guests must be greater than 0
            {
                MessageBox.Show("Invalid input for maximum number of guests!", "Error");
                return false;
            }
            return valueOk;
        }

        /// <summary>
        /// method for reading the cost per person which is a string that is converted into a double
        /// if the value is not an double, a message error appears
        /// </summary>
        private bool ReadCostPerPerson()
        {
            bool valueOk = false;
            double value = 0.0;
            string strValue = textBoxCostPerson.Text.Trim(); //saving the string from text box without extra spaces

            valueOk = double.TryParse(strValue, out value); //validate whether the value is correct or not
            if (!valueOk)
            {
                MessageBox.Show("Invalid input for cost per person!", "Error");
            }
            return valueOk;
        }

        /// <summary>
        /// method for reading the fee per person which is a string that is converted into a double
        /// if the value is not an double, a message error appears
        /// </summary>
        private bool ReadFeePerPerson()
        {
            bool valueOk = false;
            double value = 0.0;
            string strValue = textBoxFeePerson.Text.Trim(); //saving the string from text box without extra spaces

            valueOk = double.TryParse(strValue, out value); //validate whether the value is correct or not
            if (!valueOk)
            {
                MessageBox.Show("Invalid input for fee per person!", "Error");
            }
            return valueOk;
        }
        #endregion

        /// <summary>
        /// method to validate that first and last name are correct, it returns a bool that will allow to proceed with another functions
        /// </summary>
        private bool ReadGuestName()
        {
            bool firstNameOK = ValidateText(textBoxFirstName.Text, "First name cannot be empty!");
            bool lastNameOK = ValidateText(textBoxLastName.Text, "Last name cannot be empty!");

            return firstNameOK && lastNameOK;
        }

        /// <summary>
        /// method for validate whether a text is empty or not, when the latter is true, a error message appears
        /// </summary>
        private bool ValidateText (string text, string errorMessage)
        {
            text = text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show(errorMessage, "Error");
                return false;
            }
            return true;
        }
    }


}
