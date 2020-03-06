using System;

namespace TASKS
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            var choice = menu.DisplayMenu();                                   

            Console.WriteLine($"you chose: {choice}");
            
        }
    }
}
