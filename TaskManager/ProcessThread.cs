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
      

        public static void EnumeratingProcess()
        {
            Console.Clear();
            var runningProcesses = from proc in Process.GetProcesses()
                                   orderby proc.Id
                                   select proc;


            foreach (var p in runningProcesses)
            {
                string info = $"->PID:{p.Id}\tName:{p.ProcessName}";
                Logger.Log(info);
            }

            Logger.Log("**************************************************************");
        }



        public static void EvaluateUserTaskChoice()
        {
            Utility.NextMenu();

            Logger.Log("\nEnter your choice : ");

            switch (Utility.GetUserInput())
            {
                case 1:
                    StartProcess();
                    break;
                case 2:
                    KillProcess();
                    break;
                case 3:
                    EnumeratingProcess();
                    break;
                case 4:
                    StartingAndStoppingCustomProcess();
                    break ;
                case 5:
                    CustomThread();
                    break;
            }


        }







    }


}