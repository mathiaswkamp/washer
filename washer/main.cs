using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Washer
{
    class main
    {
        static WasherProgram Washer = new WasherProgram();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your washing machine ");                          // prints a text
            Console.WriteLine("press 1 to choose cotton program ");                         // prints option 1 
            Console.WriteLine("press 2 to choose woll program ");                           // prints option 2
            Console.WriteLine("press 3 to choose boiling program");                         // prints option 3
            int InputFromUser = int.Parse(Console.ReadLine());                              // reads input from user


            switch (InputFromUser)                                                          // switch statement to switch on users input
            {
                case 1:                                                                     // checks if user input = 1
                    Console.Clear();
                    Console.WriteLine("You have chosen cotton program ");
                    Washer.setProgram(1);                                           // calls the method setprogram and gives the method a 1
                    break;

                case 2:                                                                     // checks if user input = 2
                    Console.Clear();
                    Console.WriteLine("You have chosen woll program ");
                    Washer.setProgram(2);                                           // calls the method setprogram and gives the method a 2
                    break;

                case 3:                                                                     // checks if user input = 3
                    Console.Clear();
                    Console.WriteLine("You have chosen boiling program ");
                    Washer.setProgram(3);                                           // calls the method setprogram and gives the method a 3
                    break;


                default:                                                                    // checks if user didn´t incert 1 2 or 3
                    Console.Clear();
                    Console.WriteLine("you haven´t chosen any programs yet ");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
            }
           
            Thread.Sleep(2000);                                               // waits 2 secounds to start the program   
            Console.WriteLine("The washing program is running......");                       // starts the program
            Thread.Sleep(5000);                                               // program runs for 5 secounds
            Console.WriteLine("Press enter to finish your wash ");                           // prints a line that the program is finish
            Console.ReadKey();                                                               // waits for user to press any key to finish



        }
    }
}