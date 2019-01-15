using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        //private static int num;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Hello there, what's your name? ");
            Console.ForegroundColor = ConsoleColor.Red;
            string userName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nice you meet you, " + userName);

            bool isValid = true;
            while (isValid == true)
            {
                Console.Write("Please select an integer between 1 and 100: ");
                int num;
                bool num2 = true;
                num2 = int.TryParse(Console.ReadLine(), out num);

                if ((num % 2 == 1) && (num >= 1) && (num <= 100))
                {
                    Console.WriteLine(userName + " your number is: "+ num + " and Odd");
                    isValid = false;
                }
                else if ((num % 2 == 0) && (num <= 25) && (num >= 2))
                {
                    Console.WriteLine(userName + " your number is: " + "Even and Less Than 25");
                    isValid = false;                    

                }
                else if ((num % 2 == 0) && (num >= 26) && (num <= 60))
                {
                    Console.WriteLine(userName + " your number is: " + "Even");
                    isValid = false;                    
                }
                else if ((num % 2 == 0) && (num > 60) && (num <= 100))
                {
                    Console.WriteLine(userName + " your number is: " + num + " Even");
                    isValid = false;                    
                }
                else
                {
                    Console.WriteLine("Error: Please Input Correct Value: ");
                    isValid = true;                    
                }
                    if (isValid == false)
                    {
                        bool cont = true;
                        while (cont == true)
                        {
                            Console.Write("Would you like to select another integer " + userName + " (y/n)? ");
                            string repeat = Console.ReadLine().ToLower();
                            if (repeat == "y")
                            {
                                cont = false;
                                Console.Clear();
                                isValid = true;
                            }
                            else if (repeat == "n")
                            {
                                cont = false;
                                isValid = false;
                            }
                            else
                            {
                                cont = true;
                            }
                        }
                    }
            }
            Console.WriteLine("Thanks for your sweet inputs today " + userName + "\nHave a great day!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }            
    }
}

