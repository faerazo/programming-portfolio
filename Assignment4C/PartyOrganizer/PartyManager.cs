using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace PartyOrganizer
{
    internal class PartyManager
    {
        // instance variables
        private double costPerPerson;
        private double feePerPerson;
        
        // array for the guest
        private string[] guestList = { };

        /// <summary>
        /// constructor for the array, it uses the max number of guests to determine the size of the array
        /// </summary>
        /// <param name="maxGuests"> the maximum number of guests</param>
        public PartyManager (int maxGuests)
        {
            guestList = new string[maxGuests]; //constructed array
        }

        #region setters and getters
        // setter and getter for cost per person
        public double CostPerPerson
        {
            set
            {
                if (value >= 0.0)
                    costPerPerson = value;
            }
            get
            {
                return costPerPerson;
            }
        }


        // stter and getter for fee per person
        public double FeePerPerson
        {
            set
            {
                if (value >= 0.0)
                    feePerPerson = value;
            }
            get
            {
                return feePerPerson;
            }
        }

        #endregion

        ////////////////////////////////////////////////////////////// Add New Guests Methods //////////////////////////////////////////////////////////////  
        /// <summary>
        /// method for adding a new guest on the array, first it validates if there are any 
        /// available space using the FindVacantPosition() method and then add the name of the guest to the list
        /// </summary>
        public bool AddNewGuest(string firstName, string lastName)
        {
            bool ok = true;
            int vacantPosition = FindVacantPosition(); // caling another method

            if (vacantPosition != -1) // if there is a vacant position, guest name is included in the array
            {
                guestList[vacantPosition] = FullName(firstName, lastName); // calling method for formating the name correctly 
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// method for finding the first available position in the array, if the array is full
        /// it returns a -1 when there is not an available position
        /// </summary>
        private int FindVacantPosition()
        {
            int vacantPosition = -1; // no position available

            for (int index = 0; index < guestList.Length; index++) // for statement to go trough all elements of the array
            {
                if (string.IsNullOrEmpty(guestList[index])) // if one space is empty in some index, that index is vacant
                {
                    vacantPosition = index;
                    break;
                }
            }
            return vacantPosition;
        }

        /// <summary>
        /// method for concatenating the last name in upper and the first name of the guest
        /// </summary>
        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + ", " + firstName;
        }


        ////////////////////////////////////////////////////////////// Delete Guests Methods //////////////////////////////////////////////////////////////  
        /// <summary>
        /// method for deleting user in an specific index
        /// </summary>
        public bool DeleteAt(int index)
        {
            bool ok = false;
            if (CheckIndex(index)) // calling another method for checking the index is between the range of the dimension array
            {
                guestList[index] = string.Empty; // the guest name is removed
                MoveElementsOneStepToLeft(index); // calling method for not leaving blank spaces between guests names
                ok = true;
            }
            return ok;
        }

        /// <summary>
        /// method for checking whether the index is between the dimension of max number of guests, return a boolean which is true the index is between range
        /// </summary>
        public bool CheckIndex(int index)
        {
            bool ok = (index >= 0) && (index < guestList.Length);
            return ok;
        }

        /// <summary>
        /// method for not leaving empty spaces between guests
        /// </summary>
        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index + 1; i < guestList.Length; i++)
            {
                guestList[i - 1] = guestList[i]; // move 1 step to left
                guestList[i] = string.Empty; // empty its place
            }
        }

        /// <summary>
        /// method for getting the name of the guest in an specific index
        /// </summary>
        public string GetItemAt (int index)
        {
            return guestList[index];
        }


        ////////////////////////////////////////////////////////////// Get List, Total Cost, Fees Methods//////////////////////////////////////////////////////////////  
        /// <summary>
        /// method for getting the array of guests, return the array with all available elements.
        /// </summary>
        public string[] GetGuestList()
        {
            // array with the same size as the current number of
            // guests stored in the guestList
            int size = NumOfGuests();

            if (size <= 0) // if there is not element, return null
            {
                return null;
            }

            string[] guests = new string[size]; // creating new array with dimension according the the current number of element
            for (int i = 0, j = 0; i < guestList.Length; i++) // for statement to go through the elements of the array
            { 
                if (!string.IsNullOrEmpty(guestList[i])) // if one element is not empty becomes part of the new array
                {
                    guests[j++] = guestList[i];
                }
            }
            return guests;
        }

        /// <summary>
        /// method for calculating the total cost
        /// </summary>
        public double CalcTotalCost()
        {
            int size = NumOfGuests();

            double totalCost = size * costPerPerson;

            return totalCost;
        }

        /// <summary>
        /// method for calculating the total fees
        /// </summary>
        public double CalcTotalFees()
        {
            int size = NumOfGuests();

            double totalFees = size * feePerPerson;

            return totalFees;
        }
        
        /// <summary>
        /// method for calculating the total number of guests
        /// </summary>
        public int NumberOfGuests()
        {
            int size = NumOfGuests();

            int totalGuests = size * 1;

            return totalGuests;
        }

        /// <summary>
        /// method for counting the number of guests saved in the array
        /// </summary>
        private int NumOfGuests()
        {
            int numGuests = 0;

            for (int i = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    numGuests++;
                }
            }
            return numGuests;
        }
    }


}
