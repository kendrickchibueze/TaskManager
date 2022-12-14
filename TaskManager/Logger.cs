using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public  class Logger
    {

        public static void Log(string message)
        {
            Utility.PrintColorMessage(ConsoleColor.Cyan, message);
        }


        public static void ErrorLog(string message)
        {
            Utility.PrintColorMessage(ConsoleColor.Red, message);
        }

        public static string Path()
        {
            
            Utility.PrintColorMessage(ConsoleColor.Cyan, "Enter a valid file path of the process to start  and hit enter: ");
            string message = Console.ReadLine().Trim();
            return message + ".exe";
        }


        public static string WhereToGo()
        {
            Utility.PrintColorMessage(ConsoleColor.Cyan, "Enter the name of the website you want to visit and hit enter : ");
            string websiteName = Console.ReadLine().Trim();
            return websiteName;
        }
    }
}
