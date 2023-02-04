using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5ABC
{
    internal class CustomerManager
    {
        #region------------------------------------------------------Fields------------------------------------------------------
        // list of customers 
        private List<Customer> customers;
        #endregion


        #region------------------------------------------------------Constructors------------------------------------------------------
        /// <summary>
        /// default constructor, initialize the customers list variable
        /// </summary>
        public CustomerManager() 
        { 
            customers = new List<Customer>();
        }

        #endregion


        #region------------------------------------------------------Methods------------------------------------------------------
        /// <summary>
        /// a function for getting a customer at the index parameter
        /// </summary>
        /// 
        /// <param name="index"/>The index of the list that will be returned</param>
        /// <returns>Customer at index</returns>
        public Customer GetCustomer (int index)
        {
            //check the index parameter
            if (CheckIndex(index))
            {
                //return customer at index
                return customers[index];
            }
            //return null if there's no item at index
            return null;
        }


        /// <summary>
        /// a function for checking the index parameter
        /// </summary>
        /// 
        /// <param name="index"/>The index of the list that will be checked</param>
        /// <returns>return false if the index is wrong, and true otherwise</returns>
        private bool CheckIndex(int index)
        {
            //check if index is equal or greater to zero and less than customer list size
            return (index>=0) && (index<customers.Count);
        }

        /// <summary>
        /// method for adding a customer
        /// </summary>
        /// 
        /// <param name="customer"/>The customer that will be added</param>
        public void AddCustomer(Customer c)
        {
            //initialize id
            int id = 1;

            //loop through the customers list
            for (int i = 0; i < customers.Count; i++)
            {
                //if we find the same id, increase the value of id by 1
                if (customers[i].ID == id)
                {
                    id++;
                }
            }

            //assign the customer's ID property with id parameter
            c.ID = id;

            //add customer to the list
            customers.Add(c);
        }


        /// <summary>
        /// a function to get the detail customer at the index parameter
        /// </summary>
        /// 
        /// <param name="index"/>The index of the list that will be shown</param>
        /// <returns>return the customer's info in string format</returns>
        public String GetInfo(int index)
        {
            //check the index parameter
            if (CheckIndex(index))
            {
                //return all the customer info's in string format
                return GetNameInfo(index) + "" + GetAndAddressInfo(index) + "" + GetEmailInfo(index) + "" + GetPhonesInfo(index);
            }
            else
            {
                //return empty if index is wrong
                return "";
            }
        }

        /// <summary>
        /// a function  to get the customer's  name at the index parameter
        /// </summary>
        /// 
        /// <param name="index"/>The index of the list that will be shown</param>
        /// <returns>return the customer's name in string format</returns>
        private String GetNameInfo(int index)
        {
            //check the index parameter
            if (CheckIndex(index))
            {
                //return the name of the customer in string format
                return customers[index].GetNameInfo();
            }
            else
            {
                //return empty if index is wrong
                return "";
            }
        }

        /// <summary>
        /// a function  to get the customer's address info at the index parameter
        /// </summary>
        /// 
        /// <param name="index"/>The index of the list that will be shown</param>
        /// <returns>return the customer's address in string format</returns>
        private String GetAndAddressInfo(int index)
        {
            //check the index parameter
            if (CheckIndex(index))
            {
                //return the address info of the customer in string format
                return customers[index].GetAddressInfo();
            }
            else
            {
                //return empty if index is wrong
                return "";
            }
        }

        /// <summary>
        /// a function  to get the customer's email info at the index parameter
        /// </summary>
        /// 
        /// <param name="index"/>The index of the list that will be shown</param>
        /// <returns>return the customer's email in string format</returns>
        private String GetEmailInfo(int index)
        {
            //check the index parameter
            if (CheckIndex(index))
            {
                //return the email info of the customer in string format
                return customers[index].GetEmailInfo();
            }
            else
            {
                //return empty if index is wrong
                return "";
            }
        }


        /// <summary>
        /// a function to get the customer's phones info at the index parameter
        /// </summary>
        /// 
        /// <param name="index"/>The index of the list that will be shown</param>
        /// <returns>return the customer's phones in string format</returns>
        private String GetPhonesInfo(int index)
        {
            //check the index parameter
            if (CheckIndex(index))
            {
                //return the phones info of the customer in string format
                return customers[index].GetPhonesInfo();
            }
            else
            {
                //return empty if index is wrong
                return "";
            }
        }

        /// <summary>
        /// a method to change customer at index parameter
        /// </summary>
        /// 
        /// <param name="customer"/>The new customer value</param>
        /// <param name="index"/>The index of the list that will be changed</param>
        public bool ChangeCustomer(Contact customer,int index)
        {
            if (CheckIndex(index))
            {
                customers[index].ContactData = customer;
                return true;
            }
            else
            {
                return false;
            }
             
        }

     
        /// <summary>
        /// a method to delete a customer at the index parameter
        /// </summary>
        /// 
        /// <param name="index"/>The index of the list that will be removed</param>
        /// <returns>return true if the index is correct and false otherwise</returns>
        public bool RemoveCustomer(int index)
        {
            //check the index parameter
            if (CheckIndex(index))
            {
                //remote the customer if the index is correct
                customers.RemoveAt(index);

                //return true
                return true;
            }
            else
            {
                //return false is the index is wrong
                return false;
            }
        }


        /// <summary>
        /// a function to get an array of string that represents the customer's info
        /// </summary>
        /// 
        /// <returns>return array of strings contains all the customer's info</returns>
        public string[] GetCustomerInfoStrings()
        {
            //create a new array
            String[] info = new string[customers.Count];
            
            //loop through the customer member
            for (int i = 0; i < customers.Count; i++)
            {
                //assign each array with the customer's info
                info[i] = customers[i].ToString();
            }

            //return the array
            return info;
        }
        #endregion

    }
}
