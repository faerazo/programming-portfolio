using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5ABC
{
    public class Contact
    {
        #region------------------------------------------------------Fields------------------------------------------------------
        // instance variables for first and last name 
        private string firstName = string.Empty;
        private string lastName = string.Empty;

        // aggregation with other classes
        private Phone phone;
        private Email email;
        private Address address;
        #endregion


        #region------------------------------------------------------Constructors------------------------------------------------------
        /// <summary>
        /// constructor #1: default constructor with no parameters. the object's phone, email and address are created and initialized
        /// with default values.
        /// </summary>
        public Contact() : this("","",new Phone(),new Email(),new Address())
        {
        }

        /// <summary>
        /// constructor #2: copy constructor, this constructor will call the other constructor with firstname, lastname, phone, email, address
        /// comes from the theOther parameter
        /// </summary>
        public Contact(Contact theOther):this(theOther.FirstName,theOther.LastName,theOther.PhoneData,theOther.EmailData,theOther.AddressData)
        {

        }
        /// <summary>
        /// constructor #3: it takes 5 parameters which are initialized with the values of the parameters passed to the constructor. It also checks whether 
        /// address is null, to avoid that, the contact object are constructed with a null address. 
        /// </summary>
        /// 
        public Contact(string firstName, string lastName, Phone phoneNumber, Email emailAddress, Address location)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            // ensuring phone is created
            if (phoneNumber != null)
            {
                phone = phoneNumber;
            }
            else
            {
                phone = new Phone();
            }

            // ensuring email is created
            if (emailAddress != null)
            {
                email = emailAddress;
            }
            else
            {
                email = new Email();
            }

            // ensuring the address is created
            if (location != null)
            {
                address = location;
            }
            else
            {
                address = new Address();
            }
        }
        #endregion


        #region------------------------------------------------------Getters & Setters------------------------------------------------------
        /// <summary>
        /// getter and setter for the first name
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>
        /// getter and setter for the last name
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /// <summary>
        /// getter and setter for the phone
        /// </summary>
        public Phone PhoneData
        {
            get { return phone; }
            set { phone = value; }
        }

        /// <summary>
        /// getter and setter for the email
        /// </summary>
        public Email EmailData
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// getter and setter for the address
        /// </summary>
        public Address AddressData
        {
            get { return address; }
            set { address = value; }
        }

        #endregion



        #region ------------------------------------------------------Methods------------------------------------------------------
        /// <summary>
        /// method for validating that first name, last name and address are not empty or null
        /// </summary>
        /// <returns>bool confirming if all values are empty or not</returns>
        public bool CheckData()
        {
            //check if the first and last name have values
            bool nameOK = (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName));
            
            //check if the address is valid by calling Validate function from the address object
            bool addressOK = address.Validate();

            //return both boolean combined with and operator
            return nameOK && addressOK;

        }

        /// <summary>
        /// method for formatting the first name, last name, the cell phone and email. This function will be used in the listbox
        /// </summary>
        /// <returns>a formatted string for the last, first, phone and email</returns>
        public override string ToString()
        {
            //return the string format of all the fields, we will set the lastname to upper case
            //and each field with padding, so each column will have the same alignment
            string strOut = string.Format("{0,-23} {1,-20} {2,-24}", LastName.ToUpper()+","+firstName, phone.CellPhone,email.Work); // what is full name
            return strOut;
        }

        /// <summary>
        /// method for formatting the address in string format, this will be used to 
        /// show detailed info in the labelContactResult when the user chooses one of the items
        /// </summary>
        /// <returns>a formatted string for the address</returns>
        public String GetAddressInfo()
        {
            return address.GetAddressLabel();
        }

        /// <summary>
        /// method for formatting the phone in string format, this will be used to 
        /// show detailed info in the labelContactResult when the user chooses one of the items
        /// </summary>
        /// <returns>a formatted string for the phone</returns>
        public String GetPhonesInfo()
        {
            return phone.ToString();
        }

        /// <summary>
        /// method for formatting the email in string format, this will be used to 
        /// show detailed info in the labelContactResult when the user chooses one of the items
        /// </summary>
        /// <returns>a formatted string for the email</returns>
        public String GetEmailInfo()
        {

            return email.ToString();
        }

        /// <summary>
        /// method for formatting the names in string format, this will be used to 
        /// show detailed info in the labelContactResult when the user chooses one of the items
        /// </summary>
        /// <returns>a formatted string for the names</returns>
        public String GetNameInfo()
        {
            string strOut = FirstName + " " + LastName + Environment.NewLine;       
            return strOut;
            
        }



        #endregion


    }

}
