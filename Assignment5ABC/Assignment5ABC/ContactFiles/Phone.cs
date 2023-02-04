using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment5ABC.ContactFiles;

namespace Assignment5ABC
{
    public class Phone
    {
        #region------------------------------------------------------Fields------------------------------------------------------
        // instances variable for home and private phone
        private string homePhone;
        private string cellPhone;
        #endregion


        #region ------------------------------------------------------Constructors------------------------------------------------------

        /// <summary>
        /// default constructor calling another constructor in this class
        /// </summary>
        public Phone() 
        {
        }
        #endregion



        #region ------------------------------------------------------Getters & Setters------------------------------------------------------
        /// <summary>
        /// The property to access or change the homePhone
        /// </summary>
        public String HomePhone
        {
            get { return homePhone; }
            set { homePhone = value; }
        }


        /// <summary>
        /// The property to access or change the cellPhone
        /// </summary>
        public String CellPhone
        {
            get { return cellPhone; }
            set { cellPhone = value; }
        }
        #endregion



        #region ------------------------------------------------------Methods------------------------------------------------------


        /// <summary>
        /// method for returning the string format of the phone object, this will be called when the user wants to see
        /// the detail of the contact object
        /// </summary>
        /// <returns>a formatted string of the Phone</returns>
        public override string ToString()
        {
            String strOut = "";
            strOut = strOut + Environment.NewLine + Environment.NewLine;
            strOut = strOut + "Phone Numbers" + Environment.NewLine;
            strOut = strOut + " Private    " + HomePhone + Environment.NewLine;
            strOut = strOut + " Office     " + CellPhone + Environment.NewLine;
            return strOut;
        }

        #endregion


    }


}
