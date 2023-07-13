using System;


namespace Task_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello; You are welocme to GPA Calculator");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------------");
            DisplayUI displayUI = new DisplayUI();

            Console.WriteLine("Type help to show options");
            Console.Write(">");
            string inputLine = Console.ReadLine().Trim();
            
            while (!inputLine.Equals("") && !inputLine.Equals("exit"))
            {
                if (inputLine.ToLower().Equals("add"))
                {
                    displayUI.StartUpDisplay();
                }
                else if (inputLine.ToLower().Equals("print"))
                {
                    displayUI.DisplayResult();
                }
                else if (inputLine.ToLower().Equals("help")) 
                {
                    displayUI.Help();
                }

                else
                {
                    // If the user type something that is not recognised by the program
                    Console.WriteLine("Command not recognised, type help to see all options");
                }

                // Write a command line terminal symbol
                Console.Write(">");

                // Read new input
                inputLine = Console.ReadLine();

                Console.Clear();
            }       
                




        }

       

        

        
    }
}
