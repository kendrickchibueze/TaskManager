using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal partial class ProcessThread
    {


        
        public static void CustomThread()
        {
            Console.Clear();
            
            Logger.Log("Do you want  [1] or [2 ]threads?");

            string ThreadCount = Console.ReadLine();

            Test(ThreadCount);

            static void Test(String input)
            {
                if (input == "1")
                {
                    PrintNumbers();
                }
                else
                {
                    //2.Create a new ThreadStart delegate , passing the address of the method defined  in step 1 to the constructor.
                    ThreadStart threadstart = new ThreadStart(PrintNumbers);

                    //3. Create a thread object passing the parameterized threadstart/ threadstart delegate as a constructor argument
                    Thread BackgroundThread = new Thread(threadstart);

                    //Establish any initial thread start characteristics (name priority etc)
                    BackgroundThread.Name = "Secondary Thread";

                    //5. Call the Thread.Start() method . This starts the Thread at the method referenced by the delegate creted in step 2
                    BackgroundThread.Start();
                }

                //create a method to be the entry point of the new thread
                static void PrintNumbers()
                {
                    //display thread Info
                    Logger.Log($"--> {Thread.CurrentThread.Name} is executing PrintNumbers()");

                    //print out numbers
                    Logger.Log("Your numbers : ");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write("{0} ", i);

                        Thread.Sleep(2000);
                    }
                    
                    Utility.AskUserNextAction();
                }
            }

            //Utility.AskUserNextAction();
        }
    }
}
