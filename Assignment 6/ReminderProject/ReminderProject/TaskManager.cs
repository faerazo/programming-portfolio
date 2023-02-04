using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderProject
{
    /// <summary>
    /// A class to manage the task in the application
    /// </summary>
    class TaskManager
    {
        /*
        * The taskList field
        */
        List<Task> taskList;

        /// <summary>
        /// Constructor without parameter, this constructor will initialize the taskList
        /// </summary>
        public TaskManager()
        {
            //initialize the taskList object
            taskList = new List<Task>();
        }


        /// <summary>
        /// a function to add a new task to the taskList
        /// </summary>
        /// <param name="newTask"/>The task parameter that will be added to the taskList</param>
        /// <returns>This function will return true if the process of adding newTask is successful</returns>
        public bool AddNewTask(Task newTask)
        {
            //a boolean variable that will be returned at the end of the function
            bool ok = true;

            //if the parameter is not null, add the task to the taskList
            if (newTask != null)
            {
                taskList.Add(newTask);
            }
            else
            {
                //set ok to false if the newTask is null
                ok = false;
            }

            //return the ok variable
            return ok;
        }

        /// <summary>
        /// a function to return taskList in string array format
        /// </summary>
        /// <returns>This function will return string array</returns>
        public string[] GetInfoStringList()
        {
            //initialize the string array, with the size of taskList
            string[] infoStrings = new string[taskList.Count];

            //loop through the taskList 
            for (int i = 0; i < taskList.Count; i++)
            {
                //assign each infoStrings[i] with taskList[i].toString
                infoStrings[i] = taskList[i].ToString();
            }
            
            //return the infoStrings 
            return infoStrings;
        }

        /// <summary>
        /// a function to save the taskManager object to a file
        /// </summary>
        /// <param name="filename"/>The filename parameter that will used to save the taskList</param>
        /// <returns>This function will return true if the saving process is successful</returns>
        public bool WriteDataToFile(String filename)
        {
            /*
             * Create a fileManager object and call the SaveTaskListToFile function, with taskList and fileName as parameter
             */
            FileManager fileManager = new FileManager();
            return fileManager.SaveTaskListToFile(taskList, filename);
        }

        /// <summary>
        /// a function to load the taskManager object from a file
        /// </summary>
        /// <param name="filename"/>The filename parameter that will used to load the taskList</param>
        /// <returns>This function will return true if the reading process is successful</returns>
        public bool ReadDataFromFile(String filename)
        {
            /*
             * Create a fileManager object and call the ReadTaskListFromFile function, with taskList and fileName as parameter
             */
            FileManager fileManager = new FileManager();
            return fileManager.ReadTaskListFromFile(taskList, filename);
        }

        // <summary>
        /// a function to check if the index parameter is valid
        /// </summary>
        /// <param name="index"/>The index parameter that will checked</param>
        /// <returns>This function will return true if the index is valid</returns>
        private bool CheckIndex(int index)
        {
            //initialize the ok variable with false
            bool ok = false;

            //check if the index is greater than 0 and less than taskList count
            if ((index >= 0) && index < taskList.Count)
            {
                //set the ok variable with true
                ok = true;
            }

            //return the ok variable
            return ok;
        }

        // <summary>
        /// a function to get the task at the index parameter
        /// </summary>
        /// <param name="index"/>The index of the task that will be returned</param>
        /// <returns>This function will return the task object at the index parameter</returns>
        public Task GetTask(int index)
        {
            //check if the index is valid
            if (CheckIndex(index))
            {
                //return the taskList at the index
                return taskList[index];
            }
            else
            {
                //return null if the index is invalid
                return null;
            }
        }

        // <summary>
        /// a function to delete the task at the index parameter
        /// </summary>
        /// <param name="index"/>The index of the task that will be deleted</param>
        /// <returns>This function will return false if the delete process is successful</returns>
        public bool DeleteTaskAt(int index)
        {
            //check if the index is valid
            if (CheckIndex(index))
            {
                //remove the tasklist at the index
                //and return true
                taskList.RemoveAt(index);
                return true;
            }
            else
            {
                //return false if the index is invalid
                return false;
            }
        }

        // <summary>
        /// a function to change the task at the index parameter
        /// </summary>
        /// <param name="index"/>The index of the task that will be changed</param>
        /// <returns>This function will return false if the change process is successful</returns>
        public bool ChangeTaskAt(Task task,int index)
        {
            //check if the index is valid
            if (CheckIndex(index))
            {
                //change the tasklist at the index
                //and return true
                taskList[index] = task;
                return true;
            }
            else
            {
                //return false if the index is invalid
                return false;
            }
        }

    }


}
