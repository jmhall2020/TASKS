using System;
using System.Collections.Generic;
using System.Text;

namespace TASKS
{
    public class Menu                                                            
    {
        public int DisplayMenu()                                             //need public for access to this method outside of the class?                                             
        {
            Console.WriteLine("Welcome to the Task Manager Menu. Please choose from the following options: (enter a number) ");
            Console.WriteLine("1. Enter a new task");
            Console.WriteLine("2. Display entered tasks");

            string input = Console.ReadLine();

            if (input.Length < 1)
            {
                Console.WriteLine("You didn't enter anything. Please try again.");
                DisplayMenu();
            }

            //what if a non-number is entered?

            int result = Int32.Parse(input);

            return result;
        }


    }
}
