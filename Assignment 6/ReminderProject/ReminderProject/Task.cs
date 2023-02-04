using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderProject
{
    /// <summary>
    /// A class to store, the task object with all the encapsulated functions and fields.
    /// </summary>
    public class Task
    {
        /*
         * All the private fields for the task object.
         */
        private DateTime date;
        private String description;
        private PriorityType priority;

        /// <summary>
        /// Constructor without parameter, this constructor will call the 
        /// another constructor with three parameters, with three default value
        /// </summary>
        public Task() : this(DateTime.Now, String.Empty, PriorityType.Normal)
        {
        }

        /// <summary>
        /// Constructor with one parameter
        /// Call the constructor with 3parameters, Send the one parameter that comes from the caller (taskDate), and two default value
        /// The other constructor is called using the keyword this
        /// </summary>
        /// <param name="taskDate"/>Input coming as date parameter from the caller</param>
        public Task(DateTime taskDate) : this(taskDate, String.Empty, PriorityType.Normal)
        {
        }

        /// <summary>
        /// Constructor with three parameters, this constructor will assign each field with correlated parameters
        /// </summary>
        /// <param name="date"/>Input coming as date parameter from the caller</param>
        /// <param name="description"/>Input coming as description parameter from the caller</param>
        /// <param name="priority"/>Input coming as priority parameter from the caller</param>
        public Task(DateTime date, string description, PriorityType priority) 
        {
            /*
             * Change all the field according to the parameter
             */
            this.description = description;
            this.priority = priority;
            this.date = date;
        }

        /// <summary>
        /// The priority type in string format
        /// </summary>
        /// <returns>This function will return priority type in string format</returns>
        private String GetPriorityString()
        {
            /*
             * Check each priority, and return the string accordingly. For example
             * if the priority is Very_Important this function will return 'Very important'
             * if the priority is Less_Important this function will return 'Less important'
             * This function will be called in the Task toString function
             */
            if (priority == PriorityType.Very_important)
            {
                return "Very important";
            }
            else if (priority == PriorityType.Important)
            {
                return "Important";
            }
            else if (priority == PriorityType.Normal)
            {
                return "Normal";
            }
            else if (priority == PriorityType.Less_important)
            {
                return "Less important";
            }
            else
            {
                return "Not important";
            }
        }

        /// <summary>
        /// A function to return the date in the hour and minute format
        /// </summary>
        /// <returns>This function will return the date in hh:mm format</returns>
        private String GetTimeString()
        {
            //return the date in hh:mm format using toString function
            return date.ToString("HH:mm");
        }

        /// <summary>
        /// A function to return the task object in string format
        /// </summary>
        /// <returns>This function will return the string that contain all the fields information</returns>
        public override string ToString()
        {

            /*
             * Return all the fields in string format, we need to add space, so all the field will have the same alignment.
             * For example the {0,-30} will pad the date string format with extra spaces, if the length is less than 30
             */
            String textout = String.Format("{0, -30} {1, 10}    {2, -25} {3,-30}", date.ToLongDateString(), GetTimeString(), GetPriorityString(), Description);
            return textout;
        }




        /// <summary>
        /// The property to access or change the description field
        /// </summary>
        public String Description 
        {
            get { return description; }
            set { 
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        }

        /// <summary>
        /// The property to access or change the priority field
        /// </summary>
        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value;}
        }

        /// <summary>
        /// The property to access or change the task date field
        /// </summary>
        public DateTime TaskDate
        {
            get { return date; }
            set { date = value; }
        }


       

       
    }
}
