using System;
using System.Collections.Generic;
using System.Text;

namespace ForLoopCriticalThinking
{
    class example
    {
        public void WhileLoop_FunWithWhileLoops_UserInput()
        {
            int userInput = 42;
            Console.WriteLine("Please enter 42");
            userInput = Console.ReadLine();
            
            //bool cartComplete = false;
            //bool isValid = false;
            while (userInput != 42)
            {
                do
                {
                    Console.WriteLine("You must enter the Number 42");
                    //int userDecision = Console.ReadLine();
                    //switch (userDecision)
                    //{
                    //    case "toilet paper":
                    //        BuyToiletPaper();
                    //        isValid = true;
                    //        break;
                    //    case "sanitizer":
                    //        BuySanitizer();
                    //        isValid = true;
                    //        break;
                    //    case "face mask":
                    //        BuyFaceMask();
                    //        isValid = true;
                    //        break;
                    //    default:
                    //        Console.WriteLine("That isn't really essential is it?");
                    //        break;
                    //}
                    //} while (isValid == false);
                    //Console.WriteLine("Do you want to purchase more?");
                    //string input = Console.ReadLine();
                    //if (input == "no")
                    //{
                    //    cartComplete = true;
                }
            }
            //DisplayCart();
            Console.ReadLine();

        }
    }

}
