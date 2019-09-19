/*
 Author: Bethy Gomez
 Date: 9/18/2019
 Description: Deliverable 3 - Methods
 */

using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Please enter your name...");

            try
            {
                // This variable will collect the user input
                string UserName;
                UserName = Console.ReadLine();

                // This will display the user input
                Console.WriteLine("Hello " + UserName + "!");
                // Added an extra line to include the current date/time
                Console.WriteLine("It is currently: " + System.DateTime.Now); 
                Console.WriteLine();
             
                // To exit the program
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);

            } // end of try
            catch 
            {
                /*
                 I have a catch block set up but since the variable in the try block is a string, it will accept 
                 letters, numbers, or nothing at all so it doesn't have the chance to go to the catch block.
                 */
                Console.WriteLine("Please enter your name...");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            } // end of catch
        } // End of Main
    } // End of class
} // End of namespace
