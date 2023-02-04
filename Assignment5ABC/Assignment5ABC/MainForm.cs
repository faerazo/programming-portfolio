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
using static System.ActivationContext;

namespace Assignment5ABC
{
    public partial class MainForm : Form
    {
        #region------------------------------------------------------Fields------------------------------------------------------
        //private field for customer manager
        CustomerManager customerManager;
        #endregion

        #region------------------------------------------------------Constructors------------------------------------------------------
        /// <summary>
        /// Default Constructor for the main form, we initialize the components, customer manager, and update the view
        /// </summary>   
        public MainForm()
        {
            InitializeComponent();

            customerManager = new CustomerManager();
                   
            UpdateCustomerList();
   
        }
        #endregion


        #region------------------------------------------------------Methods------------------------------------------------------
        /// <summary>
        /// a function to update the customer listbox
        /// </summary>   
        private void UpdateCustomerList()
        {
            //clear all the items in the listbox
            listBoxCustomers.Items.Clear();

            //get the infoStrings from taskManager.getInfoStringList()
            string[] infoStrings = customerManager.GetCustomerInfoStrings();
            
            //if the info is not null
            if (infoStrings != null)
            {
                //insert all the infoStrings to the listBoxCustomers
                listBoxCustomers.Items.AddRange(infoStrings);
            }

            //check the customer details
            checkCustomerDetail();
        }

        /// <summary>
        /// a function that will be called when the buttonAdd is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Create new ContactForm Object
            ContactForm contactForm = new ContactForm();

            //if the user choose ok 
            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                //add the new contact to the customer list
                customerManager.AddCustomer(new Customer(contactForm.ContactData));
                
                //update the listbox
                UpdateCustomerList();
            }
        }


        /// <summary>
        /// a function that will be called when the listbox selected index is changted
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check the customer detail
            checkCustomerDetail();
        }

        /// <summary>
        /// a method to display all the customer's detail in labelContactResults
        /// </summary>
        private void checkCustomerDetail()
        {
            //set the labelContatResults text with the detail of the customer selected from the listbox
            labelContactResults.Text = customerManager.GetInfo(listBoxCustomers.SelectedIndex);

        }

        /// <summary>
        /// a function that will be called when the buttonEdit is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //if the selected index is greater or equal to zero
            if (listBoxCustomers.SelectedIndex >= 0)
            {
                //get the customer at selected index
                Customer customer = customerManager.GetCustomer(listBoxCustomers.SelectedIndex);
                
                //create a new contatForm with the customer ContactData as the paramter
                ContactForm contactForm = new ContactForm(customer.ContactData);

                //check if user choose ok
                if (contactForm.ShowDialog() == DialogResult.OK)
                {
                    //update customer at the selected index
                    customerManager.ChangeCustomer(contactForm.ContactData, listBoxCustomers.SelectedIndex);

                    //update the listbox
                    UpdateCustomerList();
                }
            }
            else
            {
                //show error message if user choose the wrong index
                MessageBox.Show("Please choose a customer first");
            }
        }


        /// <summary>
        /// a function that will be called when the buttonDelete is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //if the selected index is greater or equal to zero
            if (listBoxCustomers.SelectedIndex >= 0)
            {
                //ask the user for confirmation
                var result = MessageBox.Show("Sure to delete a customer?",
                                    "Think twice",
                                    MessageBoxButtons.OKCancel);

                //if the user chooses ok
                if (result == DialogResult.OK)
                {
                    //remove customer at index
                    if (customerManager.RemoveCustomer(listBoxCustomers.SelectedIndex))
                    {
                        //update the listbox
                        UpdateCustomerList();
                    }
                }
                    
            }
            else
            {
                //show error message if user choose the wrong index
                MessageBox.Show("Please choose a customer first");
            }
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
