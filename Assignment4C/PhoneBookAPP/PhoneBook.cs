using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAPP
{
    internal class PhoneBook
    {
        // arrays for names and phones to be used in this app
        private string[] names = { "Jose", "Fernando", "Roberto", "Maria", "Gabriela", "Andrea" };
        private string[] phones = { "040-6394", "040-6241", "050-9812", "050-1535", "070-6743", "080-2395" };
        
        // two dimensional array
        private string[,] phoneList;

        /// <summary>
        /// method for starting the app, all the code include in this section will run
        /// </summary>
        public void Start()
        {
            int length = names.Length; // variable to store the number of elements on the list
            Console.WriteLine("Hello! There are " + length + " records in the Phone Book App:");

            // call display list method
            DisplayList();
            Console.WriteLine(); //  blank space

            // call sort by name method
            SortByName();
            Console.WriteLine("Sorted List By Name:");

            // call again display list method
            DisplayList();
            Console.WriteLine(); //  blank space

            // call method for filling 2D array
            int rows = names.Length; // getting the total number of rows for the 2D array
            int cols = 2; // defining the total number of columns for the 2D array
            phoneList = new string[rows, cols]; // defining the structure of the 2D array that will be used in FillTable()
            FillTable();
            
            // call method for displaying the matrix result
            Console.WriteLine("Using a 2D array instead of two 1D arrays:");
            DisplayTable();
            Console.WriteLine(); //  blank space
        }

        /// <summary>
        /// method for displaying the lists names and phones in the console
        /// </summary>
        public void DisplayList()
        {
            int length = names.Length; // variable to store the number of elements on the list
            Console.WriteLine(); // blank space

            // considering that for loop starts at 0, it is important that the limit is lower than the total number of elements
            // if we use lower equal than, it will be out the range
            for (int i = 0; i < length; i++) 
            {
                string strOut = string.Format("{0,-15} {1,-15}", names[i], phones[i]);
                Console.WriteLine(strOut);
            }
        }

        /// <summary>
        /// method for sorting the lists according to alphabetical order of the names
        /// </summary>
        public void SortByName()
        {
            int i, j; // variables used in the for loops
            int length = names.Length; // variable to store the number of elements on the list

            for (i = 0; i < length - 1; i++)
            { 
                for (j = 0; j < length - i - 1; j++)
                {
                    // compare whether the current instance is greater, equal or less than another instance
                    int result = names[j].CompareTo(names[j + 1]); 

                    if (result == 1) // when result is greater than 0 means that names[j] is greater than names[j + 1]
                    {
                        SwapValues(j); // so we swap to sort this values alphabetically
                    }
                }
            }
        }

        /// <summary>
        /// method for swap the values and put them in the right order A->Z. This methods only runs in SortByName() when the 
        /// curren instance is greater the the next instance
        /// </summary>
        /// <param name="i"> the location of instance</param>
        private void SwapValues (int i)
        {
            // swap tha names, we are moving the instance from the current position to the next position
            string temp = names[i];
            names[i] = names[i + 1];
            names[i + 1] = temp;

            // swap the corresponding phones
            temp = phones[i];
            phones[i] = phones[i + 1];
            phones[i + 1] = temp;
        }

        /// <summary>
        /// method for creating a 2D array with n rows and 2 columns
        /// </summary>
        private void FillTable()
        {
            int rows = names.Length; // total number of rows

            for(int row = 0; row < rows; row++)
            {
                phoneList[row, 0] = names[row]; // names are included in column 1, in this case the index is 0
                phoneList[row, 1] = phones[row]; // phones are included in column 2, in this case the index is 1
            }
        }

        /// <summary>
        /// method for displaying the 2D array 
        /// </summary>
        private void DisplayTable()
        {
            int rows = phoneList.GetLength(0);
            int cols = phoneList.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                Console.Write(string.Format("{0,-8}", "Row " + row.ToString()));

                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0, -15}", phoneList[row, col]));
                }
                Console.WriteLine(); // blank space
            }
        }
    }
}
