using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace BigBikes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("**Welcome to Ride City!**");
            Console.ReadLine();
            Console.WriteLine("Check out our bikes!");
            Class1 bikeList = new Class1();
            bikeList.listOfBikes();
            Console.WriteLine("*****************");
            Console.WriteLine("Please put the number of the chosen bike.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //call
            switch (userInput)
            {
                case 1:
                    Class1 Class1 = new Class1();
                    Class1.caseOne();
                    break;

                case 2:
                    Class1 Class2 = new Class1();
                    Class2.caseTwo();
                    break;

                case 3:
                    Class1 Class3 = new Class1();   
                    Class3.caseThree();
                    break;

                case 4:
                    Class1 Class4 = new Class1();
                    Class4.caseFour();
                    break;

                case 5:
                    Class1 Class5 = new Class1();
                    Class5.caseFive();
                    break;
            }

            Console.WriteLine("Do you want to book for test ride? ");
            Console.WriteLine("A. Yes");
            Console.WriteLine("B. No, thanks");

            string userInputOne = Console.ReadLine();

            if (userInputOne == "A")
            {
                Console.WriteLine("Please write your number.");
                Console.ReadLine();
                Console.WriteLine("Enter the date for your test ride(DD-MM-YYYY):");
                Console.ReadLine();
                Console.WriteLine("We appreciate it, our staff will reach you within 24 hours.");

            }

            if (userInputOne == "B")
            {
                Console.WriteLine();
                Console.WriteLine("Alright!");
            }
        }

        
        
        
        
        
        

   
    }
}