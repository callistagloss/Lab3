using System;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)

        {
            int firstNumber;
            string userName;

            Console.WriteLine("Hello. What is your name?");
            userName = ((Console.ReadLine()));


            Console.Write("Hi " + userName);
            Console.Write("! Enter a number between 1 and 100: ");
            firstNumber = int.Parse((Console.ReadLine()));
            if (firstNumber < 100 && firstNumber % 2 != 0)
            {
                Console.WriteLine("Odd");
            }
            else if (firstNumber >= 2 && firstNumber <= 25 && firstNumber % 2 == 0)
                Console.WriteLine("Even and less than 25.");
            else if (firstNumber >= 26 && firstNumber <= 60 && firstNumber % 2 == 0)
                Console.WriteLine("Even.");
            else if (firstNumber > 60 && firstNumber <= 100 & firstNumber % 2 == 0)
                Console.WriteLine("Even.");
            else if (firstNumber > 60 && firstNumber < 100 && firstNumber % 2 != 0)
                Console.WriteLine("Odd.");
            else if (firstNumber > 100 || firstNumber < 1)
                Console.WriteLine("Please enter a positive number between 1 and 100.");
        }
            }
        }
    
        
            

            

            
   
