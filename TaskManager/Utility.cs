using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Utility
    {


       
        public static void NextMenu()
        {
            
            
            MainMenu();

            PrintColorMessage(ConsoleColor.Yellow, "\n\nControls: " +
               "\n1.Start Process" +
               "\n2.Kill a Process" +
               "\n3.List all Running Process" +
               "\n4.Start and Kill custom process"+
               "\n5.Custom Thread" +
               "\n6.Exit");

        }

        private static string _title = @"
            .__   __.      ___      .______     _______.___________. _______ .______      .______
            |  \ |  |     /   \     |   _  \   /       |           ||   ____||   _  \     |   _  \
            |   \|  |    /  ^  \    |  |_)  | |   (----`---|  |----`|  |__   |  |_)  |    |  |_)  |
            |  . `  |   /  /_\  \   |   ___/   \   \       |  |     |   __|  |      /     |      /
            |  |\   |  /  _____  \  |  |   .----)   |      |  |     |  |____ |  |\  \----.|  |\  \----.
            |__| \__| /__/     \__\ | _|   |_______/       |__|     |_______|| _| `._____|| _| `._____|  tm
                                 
                                        
                                            TASK MANAGER";



        public static void MainMenu()
        {

            PrintColorMessage(ConsoleColor.Cyan, _title);


        }

        public static int GetUserInput()
        {
            int input = int.Parse(Console.ReadLine());
            return input;

        }


        public static void AskUserNextAction()
        {
            Logger.Log("\npress 1 to return to main menu and 0 to exit");

            int inputAction = int.Parse(Console.ReadLine());

            switch (inputAction) {
                case 1:
                    Console.Clear();
                    ProcessThread.EvaluateUserTaskChoice();
                    break;
                 case 0:
                    Environment.Exit(0);
                    break;
                    
                    
            
            }

        }




        // print color message
        public static void PrintColorMessage(ConsoleColor color, string message)
        {

            Console.ForegroundColor = color;

            //tell user its not a number
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }
    }
}
