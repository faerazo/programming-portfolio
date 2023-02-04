using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // title for the console
            Console.Title = "Phone Book App";

            // create object for the phone book app
            PhoneBook phonesObj = new PhoneBook();
            phonesObj.Start();
        }

    }
}
