using Assignment5ABC.ContactFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5ABC
{
    public partial class ContactForm : Form
    {
        #region------------------------------------------------------Fields------------------------------------------------------
        private Contact contact;
        #endregion


        #region ------------------------------------------------------Getters & Setters------------------------------------------------------
        /// <summary>
        /// The property to access or change the contact
        /// </summary>
        public Contact ContactData
        {
            get { return contact; }
            set { contact = value; }
        }
        #endregion


        #region ------------------------------------------------------Constructors------------------------------------------------------
        /// <summary>
        /// Constructor with 1 parameter, this will assign the contact variable with the parameter
        /// </summary>
        /// <param name="contact"/>The contact parameter that will be assigned to the field</param>
        public ContactForm(Contact contact)
        {
            
            InitializeComponent();

            //initialize all gui function
            InitializeGUI();


            //if contact is null, we create a new contact, this will happen when the contactForm called for an insert purpose
            if (contact == null)
            {
                //set the title of the form
                Text = "Add New Customer";
                this.contact = new Contact();
            }
            else
            {
                //set the title of the form
                Text = "Edit Customer";

                //if the contact is not null, assign the field with the parameter
                this.contact=contact;

                //update all the gui value
                UpdateGUI();
            }
        }

        /// <summary>
        /// Constructor with no parameter, this will assign the contact variable with null value
        /// </summary>
        public ContactForm() : this(null)
        {
 
        }
        #endregion


        #region ------------------------------------------------------Methods------------------------------------------------------
        /// <summary>
        /// a function that will be called when the buttonSave is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Read the address field from the inputs
            ReadAddress();

            //Read the emails field from the inputs
            ReadEmails();

            //Read the names field from the inputs
            ReadNames();

            //Read the phones field from the inputs
            ReadPhones();

            //validate all the data input
            if (contact.CheckData())
            {
                //if all the data is correct, close the dialog, set the result with ok
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //if not, show an error message
                MessageBox.Show("Save failed, You must at least provide first name,last name, city, or country");
            }
            
        }


        /// <summary>
        /// a function that will be called to initialize all the GUI value
        /// </summary>
        private void InitializeGUI()
        {
            //clear all the combobox item
            comboBoxCountry.Items.Clear();

            //add combobox with countries enum values
            comboBoxCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            
            for (int i = 0; i < comboBoxCountry.Items.Count; i++)
            {
                //replace all the values with the string representation of the country
                Countries country = (Countries)i;
                string strCountry = country.ToString();
                strCountry = strCountry.Replace("_", " ");
                comboBoxCountry.Items[i] = strCountry;
            }

            //set the default value to Sverige
            comboBoxCountry.SelectedIndex = (int)Countries.Sverige;
        }

        /// <summary>
        /// a function that will be called to read the address field
        /// </summary>
        private void ReadAddress()
        {
            //get all the data from user input
            String street = textBoxStreet.Text.Trim();
            String city = textBoxCity.Text.Trim();
            String zipcode = textBoxZipCode.Text.Trim();
            Countries country = (Countries)comboBoxCountry.SelectedIndex;
            
            //assign the address with the new value
            contact.AddressData= new Address(street, city, zipcode, country);
         
        }

        /// <summary>
        /// a function that will be called  to read the email field
        /// </summary>
        private void ReadEmails()
        {
            //get all the data from user input
            String workMail = textBoxEmailBiz.Text.Trim();
            String personalMail = textBoxEmailPriv.Text.Trim();

            //assign the email with the new value
            contact.EmailData = new Email();
            contact.EmailData.Work = workMail.Trim();
            contact.EmailData.Personal = personalMail.Trim();
        }

        /// <summary>
        /// a function that will be called  to read the names field
        /// </summary>
        private void ReadNames()
        {
            //assign the name with correlated input
            contact.FirstName = textBoxFirstName.Text.Trim();
            contact.LastName = textBoxLastName.Text.Trim();
        }

        /// <summary>
        /// a function that will be called , to read the phones field
        /// </summary>
        private void ReadPhones()
        {
            //get all the data from user input
            String homePhone = textBoxHomePhone.Text;
            String cellPhone = textBoxCellPhone.Text;

            //assign the phones with the new value
            contact.PhoneData = new Phone();
            contact.PhoneData.HomePhone = homePhone.Trim();
            contact.PhoneData.CellPhone = cellPhone.Trim();
        }

        /// <summary>
        /// a function that will be called , to update all the GUI value
        /// </summary>
        private void UpdateGUI()
        {
            //set all the correlated GUI components with the contact field
            textBoxFirstName.Text = contact.FirstName;
            textBoxLastName.Text = contact.LastName;
            textBoxHomePhone.Text = contact.PhoneData.HomePhone;
            textBoxCellPhone.Text = contact.PhoneData.CellPhone;

            textBoxEmailBiz.Text = contact.EmailData.Work;
            textBoxEmailPriv.Text = contact.EmailData.Personal;

            textBoxStreet.Text = contact.AddressData.Street;
            textBoxCity.Text = contact.AddressData.City;
            textBoxZipCode.Text = contact.AddressData.ZipCode;

            comboBoxCountry.SelectedIndex = (int)contact.AddressData.Country;
        }


        /// <summary>
        /// a function that will be called when the buttonCancel is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //call confirmation dialog
            var result = MessageBox.Show("Do you want to close this form?",
                                  "Think twice",
                                  MessageBoxButtons.OKCancel);

            //if the user chooses ok
            if (result == DialogResult.OK)
            {
                //close the dialog
                this.Close();
            }
            else
            {

            }
            
        }
        #endregion
    }
}
