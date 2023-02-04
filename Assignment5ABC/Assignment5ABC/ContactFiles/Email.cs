using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5ABC
{
    public class Email
    {
        #region------------------------------------------------------Fields------------------------------------------------------
        // instance variables
        private string workMail;
        private string personalMail;
        #endregion


        #region ------------------------------------------------------Constructors------------------------------------------------------
        /// <summary>
        /// constructor #1: default constructor 
        /// </summary>
        public Email()
        {

        }
        #endregion



        #region ------------------------------------------------------Getters & Setters------------------------------------------------------
        /// <summary>
        /// getter and setter for work mail
        /// </summary>
        public string Work
        {
            get { return workMail; }
            set { workMail = value; }
        }

        /// <summary>
        /// getter and setter for personal mail
        /// </summary>
        public string Personal
        {
            get { return personalMail; }
            set { personalMail = value; }
        }

        #endregion

        #region ------------------------------------------------------Methods------------------------------------------------------


        /// <summary>
        /// method for returning the string format of the email object, this will be called when the user wants to see
        /// the detail of the contact object
        /// </summary>
        /// <returns>a formatted string of the Email</returns>
        public override string ToString()
        {
            string strOut = Environment.NewLine + "Emails" + Environment.NewLine;
            strOut += string.Format(" {0,-10} {1, -10}"+Environment.NewLine, "Private", personalMail);
            strOut += string.Format(" {0,-10} {1, -10}"+Environment.NewLine+Environment.NewLine, "Office", workMail);

            return strOut;
        }

        #endregion




       

    }
}
