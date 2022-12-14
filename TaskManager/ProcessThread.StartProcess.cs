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



        public static void StartProcess()
        {
            Console.Clear();

            Process proc = null;

            //test examples
            // C:\Program Files (x86)\Windows Media Player\wmplayer
            //C:\Program Files\Git\git-bash
            //C:\Program Files (x86)\Google\Chrome\Application\chrome"

            try
            {
                int i = 0;
                ProcessStartInfo startInfo = new ProcessStartInfo(Logger.Path());

                foreach (var verb in startInfo.Verbs)
                {
                    Console.WriteLine($"{i++}.{verb}");
                }

                startInfo.WindowStyle = ProcessWindowStyle.Normal;

                startInfo.Verb = "Open";

                startInfo.UseShellExecute = true;

                proc = Process.Start(startInfo);
            }
            catch (InvalidOperationException ex)
            {
                Logger.ErrorLog(ex.Message);
            }


            Utility.AskUserNextAction();




        }
    }
}

