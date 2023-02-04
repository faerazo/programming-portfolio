using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment5ABC.ContactFiles;

namespace Assignment5ABC
{
    public class Address
    {
        #region------------------------------------------------------Fields------------------------------------------------------
        // instance variables for street, city, zipcode and country
        private string street;
        private string city;
        private string zipCode;
        private Countries country;
        #endregion

        #region ------------------------------------------------------Constructors------------------------------------------------------
        /// <summary>
        /// constructor #1: it considers 4 parameters that are part of address. we initialize the data of the address object with the values
        /// of the parameters passed to the constructor.
        /// </summary>
        /// <param name="street"/>The street parameter that will be assigned to the correlated field</param>
        /// <param name="city"/>The city parameter that will be assigned to the correlated field</param>
        /// <param name="zipCode"/>The zipcode parameter that will be assigned to the correlated field</param>
        /// <param name="country"/>The country parameter that will be assigned to the correlated field</param>
        public Address(string street, string city, string zipCode, Countries country)
        {
            //assign each field with the correlated parameters
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.country = country;
        }

        /// <summary>
        /// constructor #2: it takes 3 parameters and calls the first constructor to be reused and passes the values of street, city and zipcode, leaving country 
        /// with a default value.
        /// </summary>
        /// <param name="street"/>The street parameter that will be assigned to the correlated field</param>
        /// <param name="city"/>The city parameter that will be assigned to the correlated field</param>
        /// <param name="zipCode"/>The zipcode parameter that will be assigned to the correlated field</param>
        public Address(string street, string city, string zipCode) :
            this(street, city, zipCode, Countries.Sverige) // Sverige as default country
        { 
        }

        /// <summary>
        /// constructor #3: it considers no parameters and calls constructor #2 to pass empty strings for street, city and zipcode.
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty) 
        { 
        }


        #endregion







        #region ------------------------------------------------------Getters & Setters------------------------------------------------------

        /// <summary>
        /// The property to access or change the Country
        /// </summary>
        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }



        /// <summary>
        /// getter and setter for street
        /// </summary>
        public string Street
        {
            get { return street; }
            set 
            { 
                if (!string.IsNullOrEmpty(value))
                {
                    street = value;
                }
                
            }
        }

        /// <summary>
        /// getter and setter for city
        /// </summary>
        public string City
        {
            get { return city; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    city = value;
                }
            }
        }

        /// <summary>
        /// getter and setter for zipcode
        /// </summary>
        public string ZipCode
        {
            get { return zipCode; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    zipCode = value;
                }
            }
        }

        #endregion

        #region ------------------------------------------------------Methods------------------------------------------------------
        /// <summary>
        /// method for deleting the _ (underscore) from country names. 
        /// </summary>
        /// <returns>it returns the country name without the _ (underscore), and replace it with space</returns>
        public string GetCountryString()
        {
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }

        /// <summary>
        /// method for validating city is not empty.
        /// </summary>
        /// <returns>a bool variable confirming whether is it empty or not</returns>
        public bool Validate()
        {
            bool cityOK = !string.IsNullOrEmpty(city);
            return cityOK;
        }

        /// <summary>
        /// method for returning the string format of the address object, this will be called when the user wants to see
        /// the detail of the contact object
        /// </summary>
        /// <returns>a formatted string of the Address</returns>
        public string GetAddressLabel()
        {
            String strOut = "";
            strOut = strOut + Street + Environment.NewLine;
            strOut = strOut + ZipCode + " " + City + Environment.NewLine;
            strOut = strOut + GetCountryString() + Environment.NewLine;
            strOut = strOut + Environment.NewLine;
            return strOut;
        }

        /// <summary>
        /// method to override the ToString method, this will be called to preview the address in the listbox
        /// </summary>
        ///  <returns>a string format of the address</returns>
        public override string ToString()
        {
            string strOut = string.Format("{0, -25} {1, -8} {2, -10} {3}", street, city, zipCode, GetCountryString());
            return strOut;
        }


        #endregion
    }
}
