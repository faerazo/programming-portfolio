using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderProject
{
    class FileManager
    {
        //the token and file version to identify the text file used
        private const string fileVersionToken = "ToDoRe_21";
        private const double fileVersionNr = 1.0;


        /// <summary>
        /// a function to save the tasklist to the file
        /// </summary>
        /// <param name="taskList"/>The tasklist that will be saved to the file</param>
        /// <param name="fileName"/>The fileName that will be used to save the file</param>
        /// <returns>This function will return true if the saving process is successful</returns>
        public bool SaveTaskListToFile(List<Task> taskList,String fileName)
        {
            //a boolean, that will be returned at the end of the function
            bool ok = true;

            //a StreamWriter object used to write the taskList in the file
            StreamWriter writer = null;
            try
            {
                //create the writer object, with the fileName as the parameter
                writer = new StreamWriter(fileName);

                //write fileVersionToken,and number
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);

                //write the tota item in taskList
                writer.WriteLine(taskList.Count);

                //write each field of the tasklist member
                for (int i = 0; i < taskList.Count; i++)
                {
                    writer.WriteLine(taskList[i].Description);
                    writer.WriteLine(taskList[i].Priority.ToString());
                    writer.WriteLine(taskList[i].TaskDate.Year);
                    writer.WriteLine(taskList[i].TaskDate.Month);
                    writer.WriteLine(taskList[i].TaskDate.Day);
                    writer.WriteLine(taskList[i].TaskDate.Hour);
                    writer.WriteLine(taskList[i].TaskDate.Minute);
                    writer.WriteLine(taskList[i].TaskDate.Second);
                }
            }
            catch
            {
                //if we enter acatch block, set the value of ok to false
                ok = false;
            }
            finally
            {
                //close the writer object at finally block
                if (writer != null)
                {
                    writer.Close();
                }
            }
            //return the ok variable
            return ok;
        }

        /// <summary>
        /// a function to read the tasklist from the file
        /// </summary>
        /// <param name="taskList"/>The tasklist that will be loaded from the file</param>
        /// <param name="fileName"/>The fileName that will be used to read the file</param>
        /// <returns>This function will return true if the reading process is successful </returns>
        public bool ReadTaskListFromFile(List<Task> taskList, String fileName)
        {
            //a boolean, that will be returned at the end of the function
            bool ok = true;

            //a StreamReader object used to read the taskList from the file
            StreamReader reader = null;

            try
            {
                //if the tasklist is not null, we will clear all the member
                //if the tasklist is null, we create a new taskList
                if (taskList != null)
                {
                    taskList.Clear();
                }
                else
                {
                    taskList = new List<Task>();
                }

                //create a reader object
                reader = new StreamReader(fileName);
                
                //read the versionTest and versionNumber
                String versionTest = reader.ReadLine();
                double version = double.Parse(reader.ReadLine());

                //compare the versionTest and versionNumber
                if ((versionTest == fileVersionToken) && (version == fileVersionNr))
                {
                    //read the total tasklist in the file
                    int count = int.Parse(reader.ReadLine());

                    //loop from 0 to count
                    for (int i = 0; i < count; i++)
                    {
                        //create a task object
                        Task task = new Task();

                        //assign each field with the line in the file
                        task.Description = reader.ReadLine();
                        task.Priority = (PriorityType)Enum.Parse(typeof(PriorityType), reader.ReadLine());
                        int year = 0,month=0,day=0,hour=0,minute=0,second=0;

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine());
                        day = int.Parse(reader.ReadLine());
                        hour = int.Parse(reader.ReadLine());
                        minute = int.Parse(reader.ReadLine());
                        second = int.Parse(reader.ReadLine());
                    
                        task.TaskDate=new DateTime(year,month,day,hour,minute,second);

                        //add the task to the taskList
                        taskList.Add(task);
                    }
                }
                else
                {
                    //if the version is wrong set ok to false
                    ok = false;
                }
            }
            catch
            {
                //if we enter catch block, set the value of ok to false
                ok = false;
            }
            finally
            {
                //close the reader object at finally block
                if (reader != null)
                {
                    reader.Close();
                }
            }
            //return the ok variable
            return ok;
        }
    }
}
