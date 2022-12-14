using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal partial class ProcessThread
    {
        private static int _Input;

      

        private static void checkAlive()
        {
            bool isAlive = Thread.CurrentThread.IsAlive;
            if (isAlive)
            {
                Logger.Log("Thread is alive");
            }
            Logger.Log("Thread is not alive");
        }
        private static void checkBackground()
        {
            bool isBackground = Thread.CurrentThread.IsBackground;
            Console.WriteLine(isBackground ? "This is a background thread" : "This is not a background thread");
        }


        public static void CheckThreadAliveAndBackground()
        {

            Logger.Log("1. Check if thread is Alive\n2. Check for  Background");

            try
            {
                _Input = int.Parse(Console.ReadLine());

                switch (_Input)
                {
                    case 1:
                        checkAlive();
                        break;
                    case 2:
                        checkBackground();
                        break;    
                    default:
                        Logger.Log("please choose the right options");
                        break;
                }
            }
            catch (FormatException ex)
            {
                Logger.ErrorLog($"An error occured. {ex.Message}");
            }


        }
    }
}
