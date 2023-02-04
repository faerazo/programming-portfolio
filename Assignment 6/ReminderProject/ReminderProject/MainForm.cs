using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderProject
{
    public partial class MainForm : Form
    {
        //the taskManager for managing all the task 
        //the fileName is the path of the file that will be used to save or load the taskManager
        TaskManager taskManager;
        string fileName = Application.StartupPath + "\\Tasks.txt";


        /// <summary>
        /// a constructor for the MainForm object, this will call initializeComponent to initialize all the GUI component
        /// and InitializeGui, to initialize all the values in the GUI
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InializeGUI();
        }

        /// <summary>
        /// a function to initialize all the GUI values, including the dtPicker format, the tooltip, the timer, etc
        /// </summary>
        private void InializeGUI()
        {
            //call the SetTime function
            SetTime();

            //set the format of datetimepicker
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "yyyy-MM-dd HH:mm";

            //start the timer
            clockTimer.Start();

            //set the title of the form
            this.Text = "Todo Reminder by Francisco Erazo";
            
            //set the tooltips for each component
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(dtPicker,"Click to open calendar, write in time here");
            toolTip1.SetToolTip(cmbPriority,"Select the priority level");

            String tips = "TO CHANGE:Select an item first!"+Environment.NewLine;
            tips = tips + "Make you changes in input controls"+Environment.NewLine;
            tips = tips + "Click the change button"+Environment.NewLine;

            toolTip1.SetToolTip(lstTask,tips);
            toolTip1.SetToolTip(btnChange, tips);

            String delTips = "Select an item first and then click this button!";
            toolTip1.SetToolTip(btnDelete, delTips);

            String desTips = "Write your sins here!";
            toolTip1.SetToolTip(tbToDo, desTips);

            String okTips = "Write your reminder and then click this button";
            toolTip1.SetToolTip(btnOk, okTips);

            //initialize the taskManager
            taskManager = new TaskManager();

            //update the GUI
            UpdateGUI();

            //set the item selections for the cmbPriority
            cmbPriority.Items.Clear();
            cmbPriority.Items.AddRange(Enum.GetNames(typeof(PriorityType)));
            cmbPriority.SelectedIndex = (int)PriorityType.Normal;
            ClearInput();
        }

        /// <summary>
        /// a function to clear all the input in the form
        /// </summary>
        void ClearInput()
        {
            //set the textbox to empty string
            tbToDo.Text = "";

            //set the cmbPriority selected index to normal
            cmbPriority.SelectedIndex = (int)PriorityType.Normal;

            //set the datePicker value to now
            dtPicker.Value = DateTime.Now;
        }


        /// <summary>
        /// a function to set the lblClock text with the value of time
        /// </summary>
        private void SetTime()
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// a function that will be called on each tick of the timer
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            //call the SetTime function on each tick
            SetTime();
        }

       

        /// <summary>
        /// a function that will read all the input and return the task object
        /// </summary>
        /// <returns>This function will return the task object from the user input</returns>
        public Task ReadInput()
        {
            //check if the tbToDo is empty
            if (string.IsNullOrEmpty(tbToDo.Text))
            {
                //show error message
                MessageBox.Show("No subject? write something please!","Hello...");
                
                //return the null object
                return null;
            }
            else
            {
                //create a new task
                Task task = new Task();

                //assign each property with the input value
                task.TaskDate = dtPicker.Value;
                task.Description = tbToDo.Text;
                task.Priority = (PriorityType)cmbPriority.SelectedIndex;
                
                //return the task object
                return task;
            }
            
        }

        /// <summary>
        /// a function to update the lstTask, with the taskManager member
        /// </summary>
        void UpdateGUI()
        {
            //clear all the items in the lstTask
            lstTask.Items.Clear();
            
            //get the infoStrings from taskManager.getInfoStringList()
            string[] infoStrings = taskManager.GetInfoStringList();
            if (infoStrings != null)
            {
                //insert all the infoStrings to the lstTask
                lstTask.Items.AddRange(infoStrings);
            }

            //call the checkSelectedIndex function
            checkSelectedIndex();
        }

        /// <summary>
        /// a function that will be called when the btnOk is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            //get the taskObject from the ReadInput function
            Task task = ReadInput();

            //call the taskManager AddNewTask function with the task as a parameter
            if (taskManager.AddNewTask(task))
            {
                //if the adding process is successful, update the list
                //and clear all the input
                UpdateGUI();
                ClearInput();
            }
        }


        /// <summary>
        /// a function that checks the lstTask selectedIndex
        /// </summary>
        void checkSelectedIndex()
        {
            //if the lstTaskSelectedIndex is bigger than 0, we enable the btnChange and btnDelete
            //if not we disabled the btnChange and the btnDelete
            if (lstTask.SelectedIndex >= 0)
            {
                //enable the buttons
                btnChange.Enabled = true;
                btnDelete.Enabled = true;

                //get the task at the selected index
                Task task = taskManager.GetTask(lstTask.SelectedIndex);
                if (task != null)
                {
                    //assign the input value with the task properties
                    tbToDo.Text = task.Description;
                    dtPicker.Value = task.TaskDate;
                    cmbPriority.SelectedIndex = (int)task.Priority;

                }
            }
            else
            {
                //disabled the buttons
                btnChange.Enabled = false;
                btnDelete.Enabled = false;
            }
        }


        /// <summary>
        /// a function that will be called each time the selected index in the lstTask is changed
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void lstTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            //call the checkSelectedIndex function
            checkSelectedIndex();
        }

        /// <summary>
        /// a function that will be called when the btnChange is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            //check if the selected index is greater or equal to 0
            if (lstTask.SelectedIndex >= 0)
            {
                //get the task from user input
                Task task = ReadInput();

                //call the function ChangeTaskAt from the taskManager with the task and selectedIndex as the parameter
                if (taskManager.ChangeTaskAt(task,lstTask.SelectedIndex))
                {
                    //if the process of changing is successful, update the list and clear all the input
                    UpdateGUI();
                    ClearInput();
                }
            }
            else
            {
                //show the error message
                MessageBox.Show("Select an element to change");
            }
        }

        /// <summary>
        /// a function that will be called when the btnDelete is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //check if the selected index is greater or equal to 0
            if (lstTask.SelectedIndex >= 0)
            {
                //ask the user for confirmation
                var result = MessageBox.Show("Sure to delete an item?",
                                    "Think twice",
                                    MessageBoxButtons.OKCancel);
                
                //if the user chooses ok
                if (result == DialogResult.OK)
                {
                    //call the function DeleteTaskAt from the taskManager with the selectedIndex as the parameter
                    if (taskManager.DeleteTaskAt(lstTask.SelectedIndex))
                    {
                        //if the process of deleting is successful, update the list and clear all the input
                        UpdateGUI();
                        ClearInput();
                    }
                }
                else
                {
                }

            }
            else
            {
                //show the error message
                MessageBox.Show("Select an element to delete");
            }
        }


        /// <summary>
        /// a function that will be called on when the menuFileSave is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            //initialize error message
            string errMessage = "Something wrong while saving data to file";

            //call the taskManager WriteDataToFile, with the fileName variable as the parameter
            bool ok = taskManager.WriteDataToFile(fileName);
            if (!ok)
            {
                //if the saving process is failed, show the error message
                MessageBox.Show(errMessage);
            }
            else
            {
                //if the saving process is successful, show the success message
                MessageBox.Show("Data saved to file : " + Environment.NewLine + fileName);
            }
        }

        /// <summary>
        /// a function that will be called on when the menuFileOpen is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            //initialize error message
            string errMessage = "Something went wrong when opening the file";

            //call the taskManager ReadDataFromFile, with the fileName variable as the parameter
            bool ok = taskManager.ReadDataFromFile(fileName);
            if (!ok)
            {
                //if the loading process is failed, show the error message
                MessageBox.Show(errMessage);
            }
            else
            {
                //if the loading process is successful, show the success message
                MessageBox.Show("Data load from file : " + Environment.NewLine + fileName);
                UpdateGUI();
            }
        }


        /// <summary>
        /// a function that will be called on when the menuFileExit is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            //ask the user for confirmation
            var result = MessageBox.Show("Sure to exit program?",
                                     "Think twice",
                                     MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //close the application if the user chooses ok
                Application.Exit();
            }
        }


        /// <summary>
        /// a function that will be called on when the menuFileNew is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            //call the InitializeGui function
            InializeGUI();
        }

        /// <summary>
        /// a function that will be called on when the menuFileAbout is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void menuFileAbout_Click(object sender, EventArgs e)
        {
            //Crete the aboutBox1 object
            AboutBox1 about = new AboutBox1();

            //show the aboutbox1
            about.ShowDialog();
        }

        /// <summary>
        /// a function that will be called on when the menuFilePrint is clicked
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void menuFilePrint_Click(object sender, EventArgs e)
        {
            //show the print dialog
            //and if the user chooses ok
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                //call the print function from the printDocument object
                printDocument.Print();
            }
        }

        /// <summary>
        /// a function that will be called on when the printDocument is printed
        /// </summary>
        /// <param name="sender"/>The object that called this function</param>
        /// <param name="e"/>The argument of the event</param>
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //get all the list from the taskManager
            String[] list = taskManager.GetInfoStringList();


            //create the doc string
            String doc = "";
             for (int i = 0; i < list.Length; i++)
            {
                doc = doc + list[i] + Environment.NewLine;
            }



            //print the doc
            //taken from : https://learn.microsoft.com/en-us/dotnet/api/system.drawing.printing.printdocument.printpage?view=windowsdesktop-7.0
            int charactersOnPage = 0;
            int linesPerPage = 0;

            //use courier new, so each letter has the same size
            FontFamily fontFamily = new FontFamily("Courier New");
            Font font = new Font(
               fontFamily,
               16,
               FontStyle.Regular,
               GraphicsUnit.Pixel);

            e.Graphics.MeasureString(doc, font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);
            e.Graphics.DrawString(doc, font, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);
            doc = doc.Substring(charactersOnPage);
            e.HasMorePages = (doc.Length > 0);
        }
    }
}
