using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment5ABC
{
    public class Customer
    {
        #region------------------------------------------------------Fields------------------------------------------------------
        //private field of the customer
        private Contact contact;
        private int id;
        #endregion


        #region------------------------------------------------------Constructors------------------------------------------------------
        /// <summary>
        /// Default Constructor for the customer, this constructor will call the other constructor, with a new Contact object as parameter
        /// </summary>        }
        public Customer() : this(new Contact())
        {
        }

        /// <summary>
        /// Constructor for the customer, this function has 1 parameter which is the contact of the customer
        /// </summary>
        /// <param name="contact"/>The contact field of the customer</param>
        public Customer(Contact contact)
        {
            //assign the contact field with the parameter
            this.contact = contact;
        }
        #endregion





        #region------------------------------------------------------Getter & Setters------------------------------------------------------

        /// <summary>
        /// getter and setter for contact field
        /// </summary>
        public Contact ContactData
        {
            get { return contact; }
            set { contact = value; }
        }

        /// <summary>
        /// getter and setter for address field
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        #endregion




        #region------------------------------------------------------Methods------------------------------------------------------
        /// <summary>
        /// method for returning ID in a string format, this method will pad zero behind the ID, so each ID always has 3 characters.
        /// </summary>
        /// <returns>a formatted string with the ID</returns>
        private String getIDFormat()
        {
            String str = "0000"+id;
            return str.Substring(str.Length-3,3);
        }

        /// <summary>
        /// method for formatting the ID and contact to string
        /// </summary>
        /// <returns>a formatted string with the information</returns>
        public override string ToString()
        {
            //this function will be called to write the customer information in the listbox
            //the content of this function is ID in string format and contact in string format
            string strOut = string.Format("{0,-3}    {1}", getIDFormat(), contact.ToString());
            return strOut;
        }



        /// <summary>
        /// method for returning the address info of the customer
        /// </summary>
        /// <returns>a formatted string of the address</returns>
        public  string GetAddressInfo()
        {

            return contact.GetAddressInfo();
        }

        /// <summary>
        /// method for returning the phone info of the customer
        /// </summary>
        /// <returns>a formatted string of the phone</returns>
        public string GetPhonesInfo()
        {

            return contact.GetPhonesInfo();
        }

        /// <summary>
        /// method for returning the name info of the customer
        /// </summary>
        /// <returns>a formatted string of the name</returns>
        public String GetNameInfo()
        {
            return contact.GetNameInfo();
        }

        /// <summary>
        /// method for returning the email info of the customer
        /// </summary>
        /// <returns>a formatted string of the email</returns>
        public string GetEmailInfo()
        {

            return contact.GetEmailInfo();
        }
        #endregion
    }
}
