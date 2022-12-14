using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal partial class ProcessThread
    {

        public static void KillProcess()
        {
            Console.Clear();

            Logger.Log("Enter the name of process to kill and hit enter...");

            string processName = Console.ReadLine().Trim();

            Process[] process = Process.GetProcessesByName(processName);

            foreach (Process p in process)
            {
                p.Kill();
            }

            Utility.AskUserNextAction();

        }


       
    }
}
