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
            else
            {
                Logger.Log("Thread is not alive");

            }

            Utility.AskUserNextAction();

        }
        private static void checkBackground()
        {
            bool isBackground = Thread.CurrentThread.IsBackground;

            if (isBackground)
            {
                Logger.Log("This is a background thread");
            }
            else
            {
                Logger.Log("This is not a background thread");
            }

            Utility.AskUserNextAction();
            
        }


        public static void CheckThreadAliveAndBackground()
        {
            Console.Clear();

            start: Logger.Log("1. Check if thread is Alive\n2. Check for  Background");

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
                        goto start;
                        break;
                }
            }
            catch (FormatException ex)
            {
                Logger.ErrorLog($"An error occured. {ex.Message}");

                goto start;

            }catch(Exception ex)
            {
                Logger.ErrorLog(ex.Message);

                goto start;
            }


        }
    }
}
