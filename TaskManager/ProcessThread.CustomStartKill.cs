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
       

        private static int _choice;

        private static Process proc = null;






        public static void StartingAndStoppingCustomProcess()
        {
            Console.Clear();

            Logger.Log("choose the type of process\n" +
                "[1] shell process\n" +
                "[2] browser process");

            try
            {
                _choice = int.Parse(Console.ReadLine());

                switch (_choice)
                {
                    case 1:
                        ShellProcess();
                        break;
                    case 2:
                        BrowserProcess();
                        break;
                        
                }
            }
            catch(Exception ex)
            {
                Logger.ErrorLog(ex.Message);
            }

            Utility.AskUserNextAction();



        }




        public static void BrowserProcess()
        {
            

            //start a process
            try
            {

                proc = Process.Start(Logger.Path(), Logger.WhereToGo());
                Logger.Log(proc?.ProcessName);
            }
            catch (InvalidOperationException ex)
            {
                Logger.ErrorLog(ex.Message);
            }

            //kill a process
            Logger.Log("--->Hit enter to kill a process...." +  proc.ProcessName);

            Console.ReadLine();

            //kill all of browser processes

            try
            {
                foreach (var p in Process.GetProcessesByName(proc?.ProcessName))
                {
                    p.Kill(true);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);

            }



        }


        public static void ShellProcess()
        {
           

            //start a process
            try
            {

               

                proc = Process.Start( new ProcessStartInfo { FileName = Logger.Path(), UseShellExecute = true } );

                Logger.Log(proc?.ProcessName);

            }
            catch (InvalidOperationException ex)
            {
                Logger.ErrorLog(ex.Message);
            }

            //kill a process
            Logger.Log("--->Hit enter to kill a process...." + proc.ProcessName);

            Console.ReadLine();

            //kill all of browser processes

            try
            {
                foreach (var p in Process.GetProcessesByName(proc?.ProcessName))
                {
                    p.Kill(true);
                }
            }
            catch (InvalidOperationException ex)
            {
                Logger.Log(ex.Message);

            }




        }






      
    }
}
